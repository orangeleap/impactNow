"use strict";
angular.module("app").factory("sustainabilityDevelopmentGoalService", ["$http", "$q", function ($http, $q) {
    return {
        getSDGs: function () {
            var result = $q.defer();
            $http({
                method: 'GET',
                url: "/api/category"
            })
                .success(function (response) {
                    result.resolve(response);
                })
                .error(function (response, status, headers, config) {
                    
                    result.reject(response);
                });
            return result.promise;
        },
        getSponsors: function () {
            var result = $q.defer();
            $http({
                method: 'GET',
                url: "/api/sponsors"
            })
                .success(function (response) {
                    result.resolve(response);
                })
                .error(function (response, status, headers, config) {
                    
                    result.reject(response);
                });
            return result.promise;
        }
    };
}]);