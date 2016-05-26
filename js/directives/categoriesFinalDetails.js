"use strict";
angular.module("app").directive("categoriesFinalDetails", function () {
    var controller = [
        "$scope", function ($scope) {
            console.log($scope.selectedProfile);
        }
    ];

    return {
        restrict: "E",
        templateUrl: "templates/categoriesFinalDetails.html",
        scope: {
            selectedProfile:"="
        },
        controller: controller
    }
});