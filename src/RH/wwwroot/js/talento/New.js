

//var newController = function ($scope, $resource, $http, $window) {

//    $scope.novo = function () {
//        return $http.get('/api/data/talento/new')
//            .then(function (result) {
//                $scope.talento = result.data;            //alert("r" + $scope.talento.nome);
//                return result.data;
//            });
//    }

//    $scope.carrega = function (id) {
//        return $http.get('/api/data/talento/' + id)
//            .then(function (result) {
//                $scope.talento = result.data;
//                return result.data;
//            });
//    }

//    $scope.carregatodos = function () {
//        return $http.get('/api/data/talento/GetAll')
//           .then(function (result) {
//               $scope.talentos = result.data;   // //$scope.talentos = [];
//           });
//    }

//    $scope.salva = function () {
//        dataService = $resource('/api/data/talento/Update/:id');
//        return dataService.save($scope.talento);
//    };

//    $scope.salvaemudaurl = function (gotourlwhendone) {
//        $scope.salva().$promise.then(
//        function (response) {
//            alert("Dados enviados");
//            window.location = gotourlwhendone;
//        });
//    }

//    $scope.apaga = function (id_Talento, gotourlwhendone) {
//        return $http.delete('/api/data/talento/' + id_Talento)
//            .then(function (data) {
//                //$scope.talento.id_Talento
//                window.location = gotourlwhendone;
//            });
//    };

//    $scope.GetURLParameter = function () {
//        // http://stackoverflow.com/a/16971150/194717

//        var sPageURL = window.location.href;
//        var indexOfLastSlash = sPageURL.lastIndexOf("/");

//        if (indexOfLastSlash > 0 && sPageURL.length - 1 != indexOfLastSlash)
//            return sPageURL.substring(indexOfLastSlash + 1);
//        else
//            return 0;
//    }

//    //alert('wn');
//}

//app.controller('newController ', newController);
