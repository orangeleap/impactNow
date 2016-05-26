angular.module('app', ['ui.router', 'ui.bootstrap'])

// configuring our routes 
// =============================================================================
.config(function ($stateProvider, $urlRouterProvider) {

    $stateProvider
        .state('impact2030', {
            url: '/impact2030',
            templateUrl: '/templates/profile.html',
            controller: 'impact2030ProfileController'
        })
        .state('impact2030.gettingstarted', {
            url: '/gettingstarted',
            templateUrl: '/templates/gettingstarted.html'
        })
        .state('impact2030.donationsandhours', {
            url: '/donationsandhours',
            templateUrl: '/templates/donationsandhours.html'
        })
        .state('impact2030.impactgoals', {
            url: '/impactgoals',
            templateUrl: '/templates/impactgoals.html'
        })
        .state('impact2030.impactallocation', {
            url: '/impactallocation',
            templateUrl: '/templates/impactallocation.html'
        })
        .state('impact2030.finaldetails', {
            url: '/finaldetails',
            templateUrl: '/templates/finaldetails.html'
        })
        .state('impact2030.confirmation', {
            url: '/confirmation',
            templateUrl: '/templates/confirmation.html'
        });

    // catch all route
    // send users to the form page 
    $urlRouterProvider.otherwise('/impact2030/gettingstarted');
})

// our controller for the form
// =============================================================================
.controller('mainController', function ($scope) {

    // we will store all of our form data in this object
    $scope.formData = {};

    // function to process the form
    $scope.processForm = function () {
        alert('awesome!');
    };

});