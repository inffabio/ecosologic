appGlobal.controller('CtrlFormOrcamento', ['$scope', 'PedidoOrcamentoServico',
                                           
    function ($scope, PedidoOrcamentoServico) {

        $scope.orcamento = {};
        $scope.ListUF = [];
        $scope.msgWarning = false;
        $scope.msgSuccess = false;
        $scope.resposta = false;
        //Cria Estrutura
        PedidoOrcamentoServico.GetEstruturaOrcamento()
        .then(function (_estruturaOrcamento) {
            $scope.orcamento = _estruturaOrcamento;
            $scope.ListUF = _estruturaOrcamento.ListUF;
             var _index=  ($.map($scope.ListUF, function (obj, index) {
                if (obj.Sigla == "RJ")
                    return index;
             }));

             $scope.orcamento.UFSelecionado =  _estruturaOrcamento.ListUF[_index];
        }, function (data) {
            console.log("Erro criando estrutura CadastoCursoFormacaoDTO");

        });


        $scope.gravarPedidoOrcamento = function () {
           
            if ($scope.FormPedidoOrcamento.$valid) {
                PedidoOrcamentoServico.GravarPedidoOrcamento($scope.orcamento)
                .then(function (_OrcamentoResultado) {

                    $scope.resposta = true;

                }, function (data) {
                    console.log("Erro ao Gravar pedido de orçamento");
                });
            }
       }
           
        

       
     
}]);

