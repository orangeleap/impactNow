"use strict";
angular.module('app').controller("impact2030ProfileController", [
    "$scope", "$state",
        function ($scope, $state) {
            $scope.currentStepPosition = {
                currentStep: 0
            };

            $scope.profile = {
                receivesDonations: false,
                receivesVolunteerHours: false
            };
            

            function init() {
                function continueToGettingStarted(href) {
                    $state.go(href);
                };

                function continueToDonationsAndHours(href) {
                    $state.go(href);
                };

                function continueToImpactGoals(href) {
                    console.log($scope.profile.receivesDonations);
                    console.log($scope.profile.receivesVolunteerHours);
                    $state.go(href);
                };

                function continueToImpactAllocation(href) {
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
                        onContinue: continueToGettingStarted
                    },
                    {
                        name: ' Donations & Hours',
                        href: 'impact2030.donationsandhours',
                        onContinue: continueToDonationsAndHours
                    },
                    {
                        name: ' Impact Goals',
                        href: 'impact2030.impactgoals',
                        onContinue: continueToImpactGoals
                    },
                    {
                        name: ' Impact Allocation',
                        href: 'impact2030.impactallocation',
                        onContinue: continueToImpactAllocation
                    },
                    {
                        name: ' Final Details',
                        href: 'impact2030.finaldetails',
                        onContinue: continueToFinalDetails
                    },
                    {
                        name: ' Confirmation',
                        href: 'impact2030.confirmation',
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
