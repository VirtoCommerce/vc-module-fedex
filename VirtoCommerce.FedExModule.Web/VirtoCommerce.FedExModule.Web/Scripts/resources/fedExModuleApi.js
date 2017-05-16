angular.module('platformWebApp.fedExModule')
.factory('fedExModuleApi', ['$resource', function ($resource) {
  return $resource('api/fedExModule');
}]);