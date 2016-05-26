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
                selectedSDGs: []
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
                        $scope.sponsors = response;
                    });
            };

            
            getCategories();
            getSponsors();

            $scope.selectedProfile = {
                hasVolunteering: true,
                hasGiving: true,
                category:
                [
                    {
                        name : "Quality Education",
                        num : 4,
                        imageUrl : "images/QualityEducation.png",
                        volunteerPercentage: 50,
                        givePercentage: 75,
                        subCategory: [
                            { num: 1, text: "Ensure Quality Education", percentage: 25,maxLimit:40 },
                            { num: 2, text: "Improve Quality of Early Childhood Development", percentage: 25, maxLimit: 100 },
                            { num: 3, text: "Foster Equal Access to Education", percentage: 25, maxLimit: 100 },
                            { num: 4, text: "Develop Employment Skills", percentage: 25, maxLimit: 100 }
                        ]
                    },
                    {
                        name: "Reduce Inequality",
                        num: 10,
                        imageUrl: "images/ReducedInequalities.png",
                        volunteeringpercentage: 50,
                        givePercentage: 25,
                        subCategory: [
                            { num: 1, text: "Sustain Income Growth", percentage: 25, maxLimit: 100 },
                            { num: 2, text: "Empower Equality", percentage: 25, maxLimit: 100 },
                            { num: 3, text: "Ensure Equal Opportunity", percentage: 25, maxLimit: 100 },
                            { num: 4, text: "Promote Equality Policies", percentage: 25,maxLimit:100 }
                        ]
                    }
                ]
            };

            function init() {
                function continueToGettingStarted(href) {
                    $state.go(href);
                };

                function continueToDonationsAndHours(href) {
                    $state.go(href);
                };

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
                    $scope.min = 0;
                    $scope.givingMax = 100;
                    $scope.volunteerMax = 100;
                    $scope.updateTotalGivePercentage = function ($event, value) {
                        $scope.profile.givePercentage += value;
                        //$scope.givingMax -= $scope.profile.givePercentage;
                    };
                    $scope.updateTotalVolunteerPercentage = function ($event, value) {
                        $scope.profile.volunteerPercentage += value;
                        //$scope.volunteerMax -= $scope.profile.givePercentage;
                    };
                    $state.go(href);
                };

                function continueToFinalDetails(href) {
                    $state.go(href);
                };

                function continueToConfirmation(href) {
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
