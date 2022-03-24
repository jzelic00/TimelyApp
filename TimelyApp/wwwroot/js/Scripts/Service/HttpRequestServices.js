app.service('httpRequestServices', function ($http) {

    //get all logs
    this.getAllLogs = function () {
        return $http({
            method: 'GET',
            url: '/Home/GetAllLogs'
        });
    }  

    //post new log
    this.addLog = function (log) {
       
        return $http({
            method: "post",
            url: "AddLog/AddLog",
            dataType: 'json',
            data: log
        });
    }

    //put new info
    this.editLog = function (log) {

        return $http({
            method: "put",
            url: "Edit/EditLog/",
            data: log
        });
    }

    //delete contact
    this.deleteMethod = function (logId) {
        return $http.delete('Home/delete', { params: { logId: logId } });
    };
});