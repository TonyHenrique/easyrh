
var listController = function ($scope, $resource, $http, $window) {
   
    $scope.carregatodos = function () {
        return $http.get('/api/data/talento/GetAll')
           .then(function (result) {
               $scope.talentos = result.data;   // //$scope.talentos = [];
           });
    }

}

app.controller('listController', listController);
