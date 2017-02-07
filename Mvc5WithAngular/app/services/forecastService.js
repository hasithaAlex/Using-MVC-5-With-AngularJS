App.factory('forecast', ['$http', function($http) { 
    
    var cityId;
    
    
    var api_base_url = 'http://api.openweathermap.org/data/2.5/group?id';
    var other_params = 'units=metric&appid';
    var appId = '30b30863875be8332d9f28272b8ea2bf';
    
    
    
    
    return {
        setCity: function(_cityId){
            cityId = _cityId ;
            console.log(cityId);
        },
        getWeather: function () {
          console.log(cityId);
          if (cityId) this.setCity(cityId);
            if (!cityId) throw new Error('City is not defined');
            return $http.get(getURI());
        }
    }

    
    
    function getURI(){
        return api_base_url + '=' + cityId + '&' + other_params+ '='+ appId;
    }
    
    
}]);