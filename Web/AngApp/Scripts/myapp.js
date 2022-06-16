var app = angular.module('MyApp', []);
app.controller('MyController', function($scope){
    $scope.Myval = "Welcome to Angular.js";

    $scope.MyFun = function ()
    {
        alert('Hello World:  ');
    }
    $scope.MyFun2 = function (val) {
        alert('parameter passed:  ' + val);
    }
});