"use strict";
angular.module('app').controller("impact2030ProfileController", [
    "$scope", "$state", "sustainabilityDevelopmentGoalService", "$uibModal",
        function ($scope, $state, sustainabilityDevelopmentGoalService, $uibModal) {

            $scope.currentStepPosition = {
                currentStep: 0
            };

            $scope.profile = {
                percentageComplete: 0,
                receivesDonations: false,
                givePercentage: 0,
                receivesVolunteerHours: false,
                volunteerPercentage: 0,
                selectedSDGs: [],
                selectedSDGsWithOutSelected: []
            };


            function getCategories() {
                sustainabilityDevelopmentGoalService.getSDGs().
                    then(function (response) {
                        $scope.sdgs = response;
                    });
            };

            function getSponsors() {
                sustainabilityDevelopmentGoalService.getSponsors().
                    then(function (response) {
                        $scope.sponsorList = response;
                    });
            };

            function postProfile(data) {
                sustainabilityDevelopmentGoalService.postProfile(data).
                    then(function (response) {
                        //anything to do with the response?

                    });
            }
            
            getCategories();
            getSponsors();

            function init() {
                function continueToGettingStarted(href) {
                    $state.go(href);
                };

                function continueToDonationsAndHours(href) {
                    $state.go(href);
                };

                function filterOutNoSelected(collection) {
                    var result = new Array();

                    for(var j = 0; j < collection.length; j++)
                    {
                        if(collection[j].selected)
                        {
                            result.push(collection[j]);
                        }
                    }

                    return result;
                };

                function copy(o) {
                    var output, v, key;
                    output = Array.isArray(o) ? [] : {};
                    for (key in o) {
                        v = o[key];
                        output[key] = (typeof v === "object") ? copy(v) : v;
                    }
                    return output;
                }


                function continueToImpactGoals(href) {

                    $scope.open = function (sdg) {
                        var modalInstance = $uibModal.open({
                            animation: true,
                            templateUrl: 'templates/sdgModal.html',
                            controller: function ($scope, $uibModalInstance, displayedSdg) {

                                $scope.formattedName = "#" + displayedSdg.num + " " + displayedSdg.name;
                                $scope.displayedSdg = displayedSdg;

                                $scope.ok = function () {
                                    $uibModalInstance.close($scope.displayedSdg);
                                };

                                $scope.cancel = function () {
                                    $uibModalInstance.dismiss('cancel');
                                };
                            },
                            size: 'lg',
                            resolve: {
                                displayedSdg: function () {
                                    return sdg;
                                }
                            }
                        });

                        modalInstance.result.then(function (selectedItem) {
                            var idx = $scope.profile.selectedSDGs.findIndex(function (s) {
                                return s.num === selectedItem.num;
                            });

                            //var selItem = selectedItem;
                            //selItem.subs = filterOutNoSelected(selectedItem.subs);

                            if (idx > -1) {
                                $scope.profile.selectedSDGs.splice(idx, 1, selectedItem);
                            } else {
                                $scope.profile.selectedSDGs.push(selectedItem);
                            }
                        }, function () {
                        });
                    };

                    $scope.formatSDG = function (sdg) {
                        return "#" + sdg.num + " " + sdg.name;
                    };

                    $scope.removeSelectedSDG = function (sdg) {
                        var idx = $scope.profile.selectedSDGs.findIndex(function (s) {
                            return s.num === sdg.num;
                        });
                        $scope.profile.selectedSDGs.splice(idx, 1);
                        if ($scope.profile.selectedSDGsWithOutSelected.length > 0) {
                            $scope.profile.selectedSDGsWithOutSelected.splice(idx, 1);
                        };
                        var foundSdg = $scope.sdgs.find(function(s) {
                            return s.num === sdg.num;
                        });

                        if (foundSdg) {
                            foundSdg.subs.forEach(function(sub, i) {
                                sub['selected'] = false;
                            });
                        }

                    };

                    $scope.selectSDG = function (sdg) {

                        $scope.open(sdg);
                    };
                    $state.go(href);
                };

                function continueToImpactAllocation(href) {
                    var selectedWithOut = copy($scope.profile.selectedSDGs);
                    for (var i = 0; i < selectedWithOut.length; i++) {

                        var selItem = selectedWithOut[i];
                        selItem.subs = filterOutNoSelected(selItem.subs);

                        $scope.profile.selectedSDGsWithOutSelected.push(selItem);
                    };
                    if ($scope.profile.selectedSDGsWithOutSelected) {
                        if ($scope.profile.selectedSDGsWithOutSelected.length == 1) {

                            if ($scope.profile.receivesDonations) {
                                $scope.profile.givePercentage = 100;
                                $scope.profile.selectedSDGsWithOutSelected[0].givePercentage = 100;
                            };
                            if ($scope.profile.receivesVolunteerHours) {
                                $scope.profile.volunteerPercentage = 100;
                                $scope.profile.selectedSDGsWithOutSelected[0].volunteerPercentage = 100;
                            };
                        };
                    };

                    $state.go(href);
                };

                function continueToFinalDetails(href) {
                    
                    $scope.validateFinalDetails = function () {
                        var isInValid = false;
                        $scope.profile.selectedSDGsWithOutSelected.forEach(function (sdg, i) {
                            if (sdg.targetsTotalPercentage < 100) {
                                isInValid = true;
                            }
                        });

                        return isInValid;
                    };

                    $state.go(href);
                };

                function continueToConfirmation(href) {
                    postProfile($scope.profile);
                    $state.go(href);
                };

                $scope.stepDefinitions = [
                    {
                        name: ' Getting Started',
                        href: 'impact2030.gettingstarted',
                        percent: 0,
                        onContinue: continueToGettingStarted
                    },
                    {
                        name: ' Donations & Hours',
                        href: 'impact2030.donationsandhours',
                        percent: 20,
                        onContinue: continueToDonationsAndHours
                    },
                    {
                        name: ' Impact Goals',
                        href: 'impact2030.impactgoals',
                        percent: 20,
                        onContinue: continueToImpactGoals
                    },
                    {
                        name: ' Impact Allocation',
                        href: 'impact2030.impactallocation',
                        percent: 20,
                        onContinue: continueToImpactAllocation
                    },
                    {
                        name: ' Final Details',
                        href: 'impact2030.finaldetails',
                        percent: 20,
                        onContinue: continueToFinalDetails
                    },
                    {
                        name: ' Confirmation',
                        href: 'impact2030.confirmation',
                        percent: 20,
                        onContinue: continueToConfirmation
                    }
                ];

                $scope.moveToNextStep = function () {
                    $scope.currentStepPosition.currentStep++;
                };

            };
            


            init();
        }
]);
