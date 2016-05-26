"use strict";
angular.module("app").directive("categoriesFinalDetails", function () {
    var controller = [
        "$scope", function ($scope) {
            $scope.sliderOptions = {
                value: 0,
                options: {
                    floor: 0,
                    ceil: 100,
                    maxLimit: 50,
                    onStart: function (id, newValue) {
                        console.info('start', id, newValue);
                    },
                    onChange: function (id, newValue) {
                        console.info('change', id, newValue);
                    },
                    onEnd: function (id, newValue) {
                        console.info('end', id, newValue);
                    }
                }
            }
        }
    ];

    return {
        templateUrl: "/templates/categoriesFinalDetails.html",
        scope: {
            selectedProfile: "="
        },
        controller: controller
    }
});