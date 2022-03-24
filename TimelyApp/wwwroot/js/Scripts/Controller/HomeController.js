app.controller('HomeController', function ($scope, $location, $filter, httpRequestServices) {

    $scope.button = 'Stop';
    $scope.logs = [];
    $scope.buttonFlag = true;   
    $scope.disableIndexButton =false;

    //dont show start button from index page
    if ($location.absUrl().indexOf('#!/startTimer') !== -1) {
        $scope.disableIndexButton = true;       
    }

    
    let newLog = {
        ProjectName: "",
        StartTime: new Date(),
        EndTime: "",
        Duration: ""
    };

    //get all logs
    var getAllLogsPromise = httpRequestServices.getAllLogs();

    getAllLogsPromise.then(function (response) {
        $scope.logs = response.data;
        console.log($scope.logs);
        $scope.logs.unshift(newLog);
    },
      function (error) {
         alert("Pogreška kod dohvaćanja svih kontakata " + error.statusText);
    });
    
    //deleting choosen contact
    $scope.DeleteLog = function (log) {      
        //delete first log in array
        if (log.ProjectName == "") {
            $scope.logs.shift();
            $scope.button = "Start";
            $scope.buttonFlag = false;
            return
        }

        var deleteLogPromise = httpRequestServices.deleteMethod(log.LogID);

        deleteLogPromise.then(function (response) {
            
            console.log(response.statusText);
        },
            function (error) {
                alert("Pogreška prilikom brisanja loga: " + error.statusText);
            });
        //remove log from array
        var index = $scope.logs.indexOf(log);
        $scope.logs.splice(index, 1);
    }

    //export to excel function
    $scope.Export = function () {
        let logArrayForExcel = [];
        
        angular.copy( $scope.logs, logArrayForExcel);

        //format change for export
        for (i = 0; i < logArrayForExcel.length; i++) {
            logArrayForExcel[i].StartTime = $filter('date')(logArrayForExcel[i].StartTime, 'y.MM.dd hh:mm:ss');
            
            logArrayForExcel[i].EndTime = $filter('date')(logArrayForExcel[i].EndTime, 'y.MM.dd hh:mm:ss');
            
            logArrayForExcel[i].Duration = $filter('date')(logArrayForExcel[i].Duration, 'HH:mm:ss','UTC');            
        }

       //export to excel with alasql
        alasql('SELECT * INTO XLSX("export.xlsx",{headers:true}) FROM ?', [logArrayForExcel]);                
    };    
});