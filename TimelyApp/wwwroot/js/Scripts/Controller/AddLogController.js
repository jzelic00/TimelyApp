app.controller('AddLogController', function ($scope, httpRequestServices, $uibModalInstance) {

    $scope.contact = {};
    $scope.TagOptions = {};

    //$scope.contact.Number = [{ PhoneNumber: "" }];
    //$scope.contact.Mail = [{ MailAddress: "" }];

   
    $scope.first_name = user.first_name;
    $scope.last_name = user.last_name;
    $scope.address = user.address;

    $scope.cancelModal = function () {
        console.log("cancelmodal");
        $uibModalInstance.dismiss('close');
    }
    $scope.ok = function () {
        $uibModalInstance.close('save');

    }

    $scope.savedata = function (contact) {
        contact.TagID = parseInt(contact.TagID);
        var addContactPromise = httpRequestServices.addContact(contact);

        addContactPromise.
            then(function succesCallback(response) {
                console.log(response.data);
                alert("Kontakt uspješno dodan");
            }
                , function errorCallback(error) {
                    alert("Greška u dodavanju kontakta" + error.statusText);
                    console.log(contact);
                });

        $scope.contact = {};
        $scope.contact.Number = [{ PhoneNumber: "" }];
        $scope.contact.Mail = [{ MailAddress: "" }];
    }

});