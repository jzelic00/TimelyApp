app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

    $routeProvider
        .when("/startTimer", {
            templateUrl: "Home/logsPartialView",
            controller: "HomeController"
        })
       
        .otherwise({
            redirectTo: '/'
        });

}]);