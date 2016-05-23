angular.module('formApp', [ 'ui.router'])

// configuring our routes 
// =============================================================================
.config(function ($stateProvider, $urlRouterProvider) {

    $stateProvider
        .state('Impact2030', {
            templateUrl: 'main.html',
            controller: 'mainController'
        })
        .state('Impact2030.page1', {
            url: '/page1',
            templateUrl: 'page1.html'
        })
        .state('Impact2030.page2', {
            url: '/page2',
            templateUrl: 'page2.html'
        })
        .state('Impact2030.page3', {
            url: '/page3',
            templateUrl: 'page3.html'
        })
        .state('Impact2030.page4', {
            url: '/page4',
            templateUrl: 'page4.html'
        })
        .state('Impact2030.page5', {
            url: '/page5',
            templateUrl: 'page5.html'
        })
        .state('Impact2030.page6', {
            url: '/page6',
            templateUrl: 'page6.html'
        });

    // catch all route
    // send users to the form page 
    $urlRouterProvider.otherwise('/page1');
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