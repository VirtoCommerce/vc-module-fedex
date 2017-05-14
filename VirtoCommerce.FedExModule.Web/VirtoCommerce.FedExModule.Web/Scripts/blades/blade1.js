angular.module('platformWebApp.managedModule')
    .controller('blade1Controller', ['$scope', 'fedExModuleApi', function ($scope, fedExModuleApi) {
        var blade = $scope.blade;
        blade.title = 'FedEx API sample';
        blade.refresh = function () {
            managedModuleApi.get(function (data) {
                blade.data = data.result;
                blade.isLoading = false;
            });
        }
        blade.refresh();
    }]);