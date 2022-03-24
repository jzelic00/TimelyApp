
app.controller('AddLogController', function ($scope, $route,httpRequestServices, $mdDialog) {

    //Opening dialog box for entering project name
$scope.showPrompt = function (ev) {
    
    var confirm = $mdDialog.prompt()
        .title('Enter your project name')
        .textContent('')
        .placeholder('Project name')
        .ariaLabel('Project name')
        .initialValue("")
        .targetEvent(ev)
        .required(true)
        .ok('Stop timer')
        .cancel('Back');

    if ($scope.buttonFlag == true) {
        $mdDialog.show(confirm).then(function (result) {
            
            $scope.button = "Start";
            $scope.buttonFlag = false;

            $scope.logs[0].EndTime = new Date();
            $scope.logs[0].ProjectName = result;
            $scope.logs[0].Duration = $scope.logs[0].EndTime.getTime() - $scope.logs[0].StartTime.getTime();

            saveData($scope.logs[0]);
            
        }, function () {
            $scope.status = '';
        });
    }
    };

    //Add new empty record to grid
    $scope.addNewLogOnClick = function () {
        if ($scope.buttonFlag == false) {
            
            let newLog = { ProjectName: "", StartTime: new Date(), EndTime: "", Duration: "" };
            $scope.logs.unshift(newLog);
            $scope.button = "Stop";
            $scope.buttonFlag = true;
        }
    }


    function saveData (log) {
        var addLogPromise = httpRequestServices.addLog(log);

        addLogPromise.
            then(function succesCallback(response) {
                console.log(response.data);
                
                alert("Log uspješno dodan");             
            }
            ,function errorCallback(error) {
               alert("Greška u dodavanju loga" + error.statusText);                   
                });

        

       
    }

   
});