var editController = function ($scope, $resource, $http, $window) {

    $scope.carrega = function () {
        id = $scope.GetURLParameter();
        //if (id == 0)             // novo        //} else {            // edit
        return $http.get('/api/data/talento/' + id)
            .then(function (result) {
                $scope.talento = result.data;
                return result.data;
            });
    }

    $scope.salva = function () {
        dataService = $resource('/api/data/talento/Update/:id');
        return dataService.save($scope.talento);
    };

    $scope.salvaemudaurl = function (gotourlwhendone) {
        $scope.salva().$promise.then(
        function (response) {

            window.location = gotourlwhendone;
            alert("Dados enviados");
        });
    }

    $scope.GetURLParameter = function () {
        // http://stackoverflow.com/a/16971150/194717

        var sPageURL = window.location.href;
        var indexOfLastSlash = sPageURL.lastIndexOf("/");

        if (indexOfLastSlash > 0 && sPageURL.length - 1 != indexOfLastSlash)
            return sPageURL.substring(indexOfLastSlash + 1);
        else
            return 0;
    }

}

app.controller('editController', editController);
