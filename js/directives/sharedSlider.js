angular.module('app').directive('sharedSlider', [
    '$parse', function ($parse) {
        var controller = [
        "$scope", function ($scope) {
 
            console.log('max ' + $scope.total); 
                $scope.change = function() {

                    if ($scope.model > 100 - $scope.total)
                        $scope.model = 100 - $scope.total;
                    console.log('model' + $scope.model);

                };
                
                $scope.clearValue = function () {
                    $scope.total -= parseInt($scope.model);
                    console.log('total ' + $scope.total);
                };

                $scope.updateTotal = function() {
                    $scope.total += parseInt($scope.model);
                    console.log('total ' + $scope.total);
                };
            }
        ];
        return {

            restrict: 'E',
            controller: controller,
            replace: true,
            template: '<input type="range" class="slider-input" style="width:100%" min="0" max="100" ng-change="change()" ng-model="model" ng-mouseup="updateTotal()" ng-mousedown="clearValue()" />',
            scope: {
                model: '=',
                total: '='
            },
            link: function ($scope, element, attrs, ngModelCtrl, $compile) {
                
            }
        }

    }]);