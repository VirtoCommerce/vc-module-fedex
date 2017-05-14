angular.module('platformWebApp.managedModule')
.factory('fedExModuleApi', ['$resource', function ($resource) {
  return $resource('api/fedExModule');
}]);