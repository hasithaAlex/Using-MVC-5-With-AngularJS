'use strict';


App.controller("weatherController", ['$scope', 'readFile', 'forecast', function ($scope, readFile, forecast) {

    
    
    
    
    
    function init() {
        $scope.jsonData = {};
        $scope.city = '';
        
        readFile.getData('data/Step1.json').then(function (result) {
            $scope.jsonData = result;
            
            angular.forEach($scope.jsonData, function(item){
              $scope.city += item.CityCode+',';
           })
        });
    }

    
    

    
    
    
    $scope.buttonEnable = true;    
    $scope.setWeather = function () { 
        forecast.setCity($scope.city);    
        $scope.buttonEnable = false;
    }
    
    
    

    
    
    
    $scope.getWeather = function () { 
        $scope.weatherData = {};
        
        console.log('get weather');
        forecast.getWeather()
        .success(function (data) {
            console.log('success', data);
            $scope.weatherData = data.list;
            debugger;
        }).error(function (err) {
            console.log('error', err);
            $scope.weatherError = err;
        });
    };


    


    init();
    

}]
);