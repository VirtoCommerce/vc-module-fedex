angular.module('virtoCommerce.fedExModule')
    .controller('fedex-blade1Controller', ['$scope', 'fedExModuleApi', function ($scope, fedExModuleApi) {
        var blade = $scope.blade;
        blade.title = 'FedEx';
        blade.refresh = function () {
            fedExModuleApi.get(function (data) {
                blade.data = data.result;
                blade.isLoading = false;
            });
        }
        blade.refresh();
    }]);