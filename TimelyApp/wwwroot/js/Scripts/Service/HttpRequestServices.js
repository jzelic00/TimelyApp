app.service('httpRequestServices', function ($http) {

    //get all logs
    this.getAllLogs = function () {
        return $http({
            method: 'GET',
            url: '/Home/GetAllLogs'
        });
    }
    
    //get single log data
    this.getSingleLog = function (id) {
        return $http.get("EditContact/GetLog", { params: { id: id } });
    }

    //post new log
    this.addLog = function (log) {
       
        return $http({
            method: "post",
            url: "/LogContactController/AddLog",
            dataType: 'json',
            data: log
        });
    }

    //put new info
    this.editContact = function (log, id) {

        return $http({
            method: "put",
            url: "EditLog/EditLog/" + id,
            data: log
        });
    }

    //delete contact
    this.deleteMethod = function (logId) {

        return $http.delete('Home/delete', { params: { logId: logId } });

    };

});