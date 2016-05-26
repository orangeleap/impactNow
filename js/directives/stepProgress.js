"use strict";
angular.module("app").directive("stepProgress", function () {
    var controller = [
        "$scope", function ($scope) {
            if ($scope.stepDefinitions.length > 0) {
                var step = $scope.stepDefinitions[0];
                step.first = true;
                step.isActive = true;
            }

            $scope.navigateToStep = function (step, index) {
                if (step.isActive) {
                    $scope.currentStepPosition.currentStep = index;                   
                }
            }

            $scope.$watch("currentStepPosition.currentStep", function (newVal) {
                if ($scope.stepDefinitions.length >= newVal) {
                    var step = $scope.stepDefinitions[newVal];
                    if (!step.isActive)
                        $scope.percentageComplete += step.percent;

                    step.isActive = true;
                    step.onContinue(step.href);
                }
            });
        }
    ];

    return {
        templateUrl: "templates/steps.html",
        scope: {
            stepDefinitions: "=",
            currentStepPosition: "=",
            percentageComplete: "="
        },
        controller: controller
    }
});