﻿
var listController = function ($scope, $resource, $http, $window) {

    $scope.carregatodos = function () {
        try {
            return $http.get('/api/data/talento/GetAll')
               .then(function (result) {
                   $scope.talentos = result.data;   // //$scope.talentos = [];
               });
        } catch (err) { alert("error " + err); }
    }

}

app.controller('listController', listController);
