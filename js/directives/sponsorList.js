"use strict";
angular.module("app").directive("sponsorList", function () {
    var controller = [
        "$scope",
        function ($scope) {
            //wire up an interval, and change the filter range appropriately
            
        }
    ];

    return {
        restring: "E",
        controller: controller,
        link: function (scope, element, attrs) {
            scope.useAlt = attrs.useAlt;
            scope.sponsors = attrs.sponsors;
        },
        scope: { sponsors: "="},
        templateUrl: "templates/sponsors.html"
    };
});
