﻿angular.module('virtoCommerce.fedExModule')
.factory('fedExModuleApi', ['$resource', function ($resource) {
  return $resource('api/fedExModule');
}]);