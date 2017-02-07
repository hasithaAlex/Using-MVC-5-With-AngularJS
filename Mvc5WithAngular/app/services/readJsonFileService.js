/**
 * Created by Deb on 8/21/2014.
 */
"use strict";


App.service("readFile", function ($http) {
   
    this.getData = function (fileName) {
        var defer = $.Deferred();
        $http.get(fileName)
             .success(function (response) {
                 defer.resolve(response.List);
             })
             .error(function (error) {
                 console.error("The async call has fail");
                 debugger;
             });
        return defer.promise();
    }
    
});

