app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

    $routeProvider
        .when("/startTimer", {
            templateUrl: "Home/logsPartialView",
            controller: "HomeController"
        })
        .when("/AddTimer", {
            templateUrl: "AddLog/AddLogPartialView",
            controller: "AddLogController"
        })

        //.when("/AddContact", {
        //    templateUrl: "AddContact/AddContact",
        //    controller: 'AddContactController'
        //})
        //.when("/contact/:id", {
        //    templateUrl: "EditContact/Index",
        //    controller: 'EditContactController'
        //})
        //.when("/search/:selectedCriteria/:filterValue", {
        //    templateUrl: "Home/contactPartialView",
        //    controller: "HomeController"
        //})
        //vidi ovo za kasnije ako ti bude trebalo za excel i tako to

        .otherwise({
            redirectTo: '/'
        });

}]);