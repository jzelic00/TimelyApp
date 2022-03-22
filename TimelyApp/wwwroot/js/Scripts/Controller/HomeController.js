app.controller('HomeController', function ($scope, $routeParams, httpRequestServices,$mdDialog) {

    $scope.button = 'Stop';
    $scope.startTime = new Date();
    $scope.logs = [];

    console.log($scope.startTime);
    $scope.status = '  ';
    $scope.customFullscreen = false;

    let newLog= { ProjectName: "", StartTime: "Doe", EndTime: "", Duration: "" };

    $scope.showPrompt = function (ev,log) {
        // Appending dialog to document.body to cover sidenav in docs app
        var confirm = $mdDialog.prompt()
            .title('Enter your project name')
            .textContent('')
            .placeholder('Project name')
            .ariaLabel('Project name')
            .initialValue(log.ProjectName)
            .targetEvent(ev)
            .required(true)
            .ok('Stop timer')
            .cancel('Back');

        $mdDialog.show(confirm).then(function (result) {
            log.ProjectName = result;
            console.log($scope.status = 'You decided to name your dog ' + result + '.');
        }, function () {
            $scope.status = 'You didn\'t name your dog.';
        });
    };


        var getAllLogsPromise = httpRequestServices.getAllLogs();

        getAllLogsPromise.then(function (response) {
            $scope.logs = response.data;
            console.log($scope.logs);
            $scope.logs.unshift(newLog);
        },
            function (error) {
                alert("Pogreška kod dohvaćanja svih kontakata " + error.statusText);
            });
   

    console.log($scope.logs);

    //deleting choosen contact
    $scope.DeleteLog = function (log) {
        console.log(log);
        var deleteLogPromise = httpRequestServices.deleteMethod(log.LogID);

        deleteLogPromise.then(function (response) {
            alert("Log uspješno obrisan");
            console.log(response.statusText);
        },
            function (error) {
                alert("Pogreška prilikom brisanja loga: " + error.statusText);
            });

        var index = $scope.logs.indexOf(log);
        $scope.logs.splice(index, 1);
    }

});