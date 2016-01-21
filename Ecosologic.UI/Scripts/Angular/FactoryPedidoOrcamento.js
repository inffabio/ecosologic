appGlobal.factory("PedidoOrcamentoServico", [ '$http', '$q', '$location', function($http, $q, $location){
   
    var GridCursoServico =
        {
            EstruturaOrcamento: {},
            GetEstruturaOrcamento: GetEstruturaOrcamento,
            GravarPedidoOrcamento: GravarPedidoOrcamento,
            GetListaPedidosOrcamento: GetListaPedidosOrcamento

        };

    return GridCursoServico;

    function GetEstruturaOrcamento() {
        var _url = "http://" + $location.host() + ":" + $location.port() + "/";
        _url += "Home/GetEstruturaOrcamento/";
       
        var def = $q.defer();
        $http.post(_url)
        .success(function (data) {
            EstruturaOrcamento = data;
            def.resolve(data);
        })
        .error(function () {
            def.reject("Erro ao criar EstruturaGridCursoDTO");
        });

        return def.promise;
    };

    function GravarPedidoOrcamento(orcamento) {
        var _url = "http://" + $location.host() + ":" + $location.port() + "/";
        _url += "Home/GravarPedidoOrcamento/";
        var def = $q.defer();
        $http.post(_url, orcamento)
        .success(function (data) {
         
            def.resolve(data);
        })
        .error(function () {
            def.reject("Erro ao criar EstruturaGridCursoDTO");
        });

        return def.promise;
    };

    function GetListaPedidosOrcamento() {
        var _url = "http://" + $location.host() + ":" + $location.port() + "/";
        _url += "Home/GetListaPedidosOrcamento/";
        var def = $q.defer();
        $http.post(_url)
        .success(function (data) {

            def.resolve(data);
        })
        .error(function () {
            def.reject("Erro ao Listar Pedidos de Orçamento");
        });

        return def.promise;
    };
      
}]);
