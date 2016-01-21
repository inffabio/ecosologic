appGlobal.controller('CtrlAnalisePedidoOrcamento', ['$scope', 'uiGridConstants', 'i18nService', 'PedidoOrcamentoServico', 
                                           
    function ($scope, uiGridConstants, i18nService, PedidoOrcamentoServico) {

        i18nService.setCurrentLang('pt-br');


        //CONFIGURAÇÃO DA GRID    
        $scope.gridPedidosOrcamento = {
            //SELEÇÃO  
            enableRowSelection: true, //TAG DE SELEÇÃO UNITÁRIA
            enableSelectAll: true, //TAG DE SELEÇÃO GERAL
            selectionRowHeaderWidth: 0, //TAG TAMANHO DA COLUNA DE SELEÇÃO
            //GRID
            // rowHeight: 40, //TAG TAMANHO DA LINHA DA GRID

            //PAGINAÇÃO  
            paginationPageSizes: [25, 50, 75], //TAG SELEÇÃO QUANTIDADE DE ITENS POR PAGINA
            paginationPageSize: 25, //TAG QUANTIDADE PADRÃO DE ITENS POR PAGINA

            //MENU
            exporterMenuCsv: true, //TAG DE EXPORTAR EM CSV
            enableGridMenu: true, //TAG ATIVAR MENU DA GRID
         
            multiSelect: true //TAG ATIVAÇÃO DE MULTIPLA SELEÇÃO
        };

        
        //DEFINIÇÃO DAS COLUNAS DA GRID     
        $scope.gridPedidosOrcamento.columnDefs = [
         
          {
              name: 'Nome',
              displayName: 'Nome',
              width: '10%',
              enableColumnMenu: false
          },
          {
              name: 'Email',
              displayName: 'Email',
              width: '10%',
              enableColumnMenu: false
          },
          {
              name: 'Telefone',
              displayName: 'Telefone',
              width: '10%',
              enableColumnMenu: false
          },
          {
              name: 'Celular',
              displayName: 'Celular',
              width: '10%',
              enableColumnMenu: false
          },
          {
              name: 'Cidade',
              displayName: 'Cidade',
              width: '10%',
              enableColumnMenu: false
          },
          {
              name: 'Estado',
              displayName: 'Estado',
              width: '10%',
              enableColumnMenu: false
          },
          {
              name: ' MediaContaLuz',
              displayName: ' MediaContaLuz',
              width: '10%',
              enableColumnMenu: false
          },
          {
              name: 'Duvidas',
              displayName: '  Duvidas',
              width: '10%',
              enableColumnMenu: false
          },
          {
              name: 'DataPedido',
              displayName: 'DataPedido',
              width: '10%',
              enableColumnMenu: false
          },

        ];
       
        
        PedidoOrcamentoServico.GetListaPedidosOrcamento()
     .then(function (_listaPedidosOrcamento) {

         $scope.gridPedidosOrcamento.data = _listaPedidosOrcamento;
     }, function (data) {
         console.log("Erro buscando lista de Orcamentos");
     });

}]);

