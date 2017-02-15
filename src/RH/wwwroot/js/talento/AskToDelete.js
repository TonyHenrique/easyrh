var askToDeleteController = function ($scope, $resource, $http, $window) {

    $scope.carrega = function (id) {
        try {
            return $http.get('/api/data/talento/' + id)
                .then(function (result) {
                    $scope.talento = result.data;
                    return result.data;
                });
        } catch (err) { alert("error " + err); }
    }

    $scope.apaga = function (id_Talento, gotourlwhendone) {
        try {
            return $http.delete('/api/data/talento/' + id_Talento)
                .then(function (data) {
                    //$scope.talento.id_Talento
                    window.location = gotourlwhendone;
                });
        } catch (err) { alert("error " + err); }
    };

    $scope.gotourl = function (url) {
        $window.location.href = url;
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

    //alert('wn');
}

app.controller('askToDeleteController', askToDeleteController);
