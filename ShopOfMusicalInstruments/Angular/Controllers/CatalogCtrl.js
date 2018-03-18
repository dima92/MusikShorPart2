(function () {
    "use strict";

    // controller class definintion
    var catalogController = function ($scope, $rootScope, productService) {
        productService.getAllCatalog().then(function (value) {
           $rootScope.loadingShow();
            $scope.result = angular.copy(value);
            $rootScope.toaster("success","Данные загружены",5000);
        }, function (errorObject) {
            alert(errorObject);
        }).finally(function () {
          $rootScope.loadingHide();
        });
    };

    // register your controller into a dependent module 
    angular
        .module("Web.Controllers")
        .controller("catalogController", ["$scope", "$rootScope","productService", catalogController]);

})();