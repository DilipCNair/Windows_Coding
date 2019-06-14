var myApp = angular
   .module("myModule", [])
   .controller("myController", function ($scope)
   {
        var name;
        $scope.message = "Hello World";
        $scope.name = name;
    });