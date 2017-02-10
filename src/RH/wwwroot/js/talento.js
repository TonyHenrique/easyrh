var app = angular.module('talentoApp', ['ngResource']);
//JSON.stringify(
//alert(
//    JSON.stringify(
//    $scope.talentos[1]
//    )
//    );   

app.controller('formController', function ($scope, $resource, $http) {

    $scope.novo = function () {

        return $http.get('/api/data/talento/new').then(function (result) {
            $scope.talento = result.data;            //alert("r" + $scope.talento.nome);
            return result.data;
        });

        //alert('final novo');
    }

    $scope.carrega = function (id) {
        return $http.get('/api/data/talento/' + id)
            .then(function (result) {
                $scope.talento = result.data;
                return result.data;
            });
    }

    $scope.carregatodos = function () {
        $scope.talentos = [];

        return $http.get('/api/data/talento/GetAll')
           .then(function (result) {
               $scope.talentos = result.data;
           });
    }


    $scope.salva = function () {
        dataService = $resource('/api/data/talento/Update/:id');

        return dataService.save($scope.talento);
    };

    $scope.salvaemudaurl = function (gotourlwhendone) {

        $scope.salva().$promise.then(
        function (response) {
            alert("Dados enviados");
            window.location = gotourlwhendone;
        });

    }

    $scope.apaga = function (id_Talento, gotourlwhendone) {
        //$scope.talento.id_Talento
        return $http.delete('/api/data/talento/' + id_Talento)
            .then(function (data) {
                window.location = gotourlwhendone;
            });
    };

    window.novo = $scope.novo;
    window.carrega = $scope.carrega;
    window.carregatodos = $scope.carregatodos;

    window.salva = $scope.salva;
    window.apaga = $scope.apaga;

    //alert('wn');
});

function GetURLParameter() {
    // http://stackoverflow.com/a/16971150/194717
    var sPageURL = window.location.href;
    var indexOfLastSlash = sPageURL.lastIndexOf("/");

    if (indexOfLastSlash > 0 && sPageURL.length - 1 != indexOfLastSlash)
        return sPageURL.substring(indexOfLastSlash + 1);
    else
        return 0;
}

