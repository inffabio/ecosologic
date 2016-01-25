appGlobal.factory('ModalServico', ['$uibModal', function ($uibModal) {

    var ModalServico = {
        OpenModal: OpenModal,
        OpenModalDados: OpenModalDados
    }

    return ModalServico;

    function OpenModal(template, size, ctrl) {
        var modalInstance = $uibModal.open({
               
                templateUrl: template,
                size: size,
                controller: ctrl,
                backdrop: false,
                keyboard: false              
            });
        //console.log("OpenModal: " + template + " - " + size + " - " + ctrl);
    }

    function OpenModalDados(template, size, ctrl, objetos) {
        var modalInstance = $uibModal.open({
           
            templateUrl: template,
            size: size,
            controller: ctrl,
            backdrop: false,
            keyboard: false,
            resolve: {
                items: function () {
                    return objetos;
                }
            }
        });
       // console.log("OpenModal: " + template + " - " + size + " - " + ctrl);
    }
}]);