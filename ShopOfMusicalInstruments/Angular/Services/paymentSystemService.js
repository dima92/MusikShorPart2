﻿(function () {
    "use strict";

    function paymentSystemService($cookies, $http, $rootScope, $q) {
        this.getAll = function () {
            var deferred = $q.defer();
            $http.get(`api/PaymentSystem`)
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
        .service("paymentSystemService", ["$cookies", "$http", "$rootScope", "$q", paymentSystemService]);
})();