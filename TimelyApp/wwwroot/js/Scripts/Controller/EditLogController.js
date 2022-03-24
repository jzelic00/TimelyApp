app.controller('EditLogController', function ($scope, httpRequestServices,$mdDialog) {
   
    //Opening dialog box for edit project name
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
            .ok('Ok')
            .cancel('Back');
            
        $mdDialog.show(confirm).then(function (result) {
            
            //Making PUT request
            sendData(log,result);          
        });
    };

    function sendData(log,result) {
        log.ProjectName = result;
        var editLogtPromise = httpRequestServices.editLog(log);

        editLogtPromise.
            then(function succesCallback(response) {
                $scope.log.ProjectName = result;
                alert("Podaci loga uspješno promijenjeni");            
            }
            ,function errorCallback(error) {
                alert("Greška u promjeni informacija loga" + error.statusText);
            });
    }
});