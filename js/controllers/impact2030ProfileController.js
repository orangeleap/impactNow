"use strict";
angular.module('app').controller("impact2030ProfileController", [
    "$scope", "$state",
        function ($scope, $state) {
            $scope.currentStepPosition = {
                currentStep: 0
            };

            function init() {
                var continueToGettingStarted = function (href) {
                    $state.go(href);
                };

                var continueToDonationsAndHours = function (href) {
                    $state.go(href);
                };

                var continueToImpactGoals = function (href) {
                    $state.go(href);
                };

                var continueToImpactAllocation = function (href) {
                    $state.go(href);
                };

                var continueToFinalDetails = function (href) {
                    $state.go(href);
                };

                var continueToConfirmation = function (href) {
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
