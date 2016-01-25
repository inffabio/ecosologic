var appGlobal = angular.module('appGlobal', ['angularFileUpload', 'ngTouch', 'ui.grid', 'ui.grid.selection',
    'ui.grid.pagination', 'ui.grid.exporter', 'ui.grid.moveColumns', 
    'chieffancypants.loadingBar', 'cfp.loadingBarInterceptor',
     'ui.mask', 'ngSanitize', 'angucomplete-alt', 'ui.bootstrap', 'ngAnimate', 'dialogs.main', 'pascalprecht.translate', 'ui.materialize']);

appGlobal.config(['dialogsProvider', '$translateProvider', 'cfpLoadingBarProvider', function (dialogsProvider, $translateProvider, cfpLoadingBarProvider) {

    cfpLoadingBarProvider.includeSpinner = true;
    cfpLoadingBarProvider.includeBar = true;

    dialogsProvider.useEscClose(true);
    dialogsProvider.setSize('sm');

    $translateProvider.translations('pt-BR', {
        DIALOGS_ERROR: "Erro",
        DIALOGS_ERROR_MSG: "Ocorreu um erro desconhecido.",
        DIALOGS_CLOSE: "Fechar",
        DIALOGS_PLEASE_WAIT: "Aguarde",
        DIALOGS_PLEASE_WAIT_ELIPS: "Aguarde...",
        DIALOGS_PLEASE_WAIT_MSG: "Aguardando a operação terminar.",
        DIALOGS_PERCENT_COMPLETE: "% Completo",
        DIALOGS_NOTIFICATION: "Notificação",
        DIALOGS_NOTIFICATION_MSG: "Notificação desconhecida.",
        DIALOGS_CONFIRMATION: "Confirmação",
        DIALOGS_CONFIRMATION_MSG: "Confirmação requerida.",
        DIALOGS_OK: "OK",
        DIALOGS_YES: "Sim",
        DIALOGS_NO: "Não"
    });

    $translateProvider.preferredLanguage('pt-BR');
    $translateProvider.useSanitizeValueStrategy('escape');

    
}]);