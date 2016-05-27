"use strict";
angular.module("app").directive("categoriesFinalDetails", function () {
    var controller = [
        "$scope", function($scope) {
            //console.log($scope.selectedProfile);
            function setSubsPercentage(categories) {
                categories.forEach(function (category) {
                    category.targetsTotalPercentage = 0;
                    category.subs.forEach(function(subCategory) {
                        subCategory.percentage = Math.floor(100 / category.subs.length);
                        category.targetsTotalPercentage += subCategory.percentage;
                    }, this);
                    if (category.subs.length > 0) {
                        var diffValue = 100 - category.targetsTotalPercentage;
                        category.subs[category.subs.length - 1].percentage += diffValue;
                        category.targetsTotalPercentage += diffValue;
                    }
                }, this);
            };
            setSubsPercentage($scope.selectedProfile);

        }
    ];


    return {
        restrict: "E",
        templateUrl: "templates/categoriesFinalDetails.html",
        scope: {
            selectedProfile: "="
        },
        controller: controller
    }
});