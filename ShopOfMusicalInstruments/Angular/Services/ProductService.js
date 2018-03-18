(function () {
    "use strict";

    function productService($cookies, $http, $rootScope, $q) {
        this.getAll = function () {
            var deferred = $q.defer();
            $http.get("api/Product/GetAllDataBase")
                .then(function (response) {
                    deferred.resolve(response.data);
                }).catch(function onError(response) {
                    deferred.reject(response.data);
                });
            return deferred.promise;
        };

        this.getAllCatalog = function () {
            var deferred = $q.defer();
            $http.get("api/Product/GetAllCatalog")
                .then(function (response) {
                    deferred.resolve(response.data);
                }).catch(function onError(response) {
                    deferred.reject(response.data);
                });
            return deferred.promise;
        };

        this.add = function (product) {
            var newProduct = {
                Name: product.Name, CountryId: product.CountryId, BrandId: product.BrandId, NumberStringId: product.NumberStrId,
                Price: product.Price, NumberProduct: product.NumberProduct, DateManufacture: product.DateManufacture, Window: product.Window,
                SubcategoriesId: product.SubcategoryId
            };
            var deferred = $q.defer();
            $http.post("api/Product", newProduct)
                .then(function (response) {
                    deferred.resolve(response.data);
                }).catch(function onError(response) {
                    deferred.reject(response.data);
                });
            return deferred.promise;
        };

        this.edit = function (gridData) {
            var data = gridData;
            var deferred = $q.defer();
            $http.put("api/Product", data)
                .then(function (response) {
                    deferred.resolve(response.data);
                }).catch(function onError(response) {
                    deferred.reject(response.data);
                });
            return deferred.promise;
        };

        this.delete = function (productId) {
            var id = productId;
            var deferred = $q.defer();
            $http.delete("api/Product?Id=" + id)
                .then(function (response) {
                    deferred.resolve(response.data);
                }).catch(function onError(response) {
                    deferred.reject(response.data);
                });
            return deferred.promise;
        };
    };

    angular
        .module("Web.Services")
        .service("productService", ["$cookies", "$http", "$rootScope", "$q", productService]);

})(); 