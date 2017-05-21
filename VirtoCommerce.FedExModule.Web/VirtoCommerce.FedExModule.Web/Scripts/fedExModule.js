//Call this to register our module to main application
var moduleName = "virtoCommerce.fedExModule";

if (AppDependencies != undefined) {
    AppDependencies.push(moduleName);
}

angular.module(moduleName,
    [])
    .config(
        [
            '$stateProvider',
            function($stateProvider) {
                $stateProvider.state('workspace.fedExModule',
                {
                    url: '/fedExModule',
                    templateUrl: '$(Platform)/Scripts/common/templates/home.tpl.html',
                    controller: [
                        '$scope', 'platformWebApp.bladeNavigationService', function($scope, bladeNavigationService) {
                            var blade = {
                                id: 'blade1',
                                // controller name must be unique in Application. Use prefix like 'um-'.
                                controller: 'fedex-blade1Controller',
                                template: 'Modules/$(VirtoCommerce.FedEx)/Scripts/blades/blade1.tpl.html',
                                isClosingDisabled: true
                            };
                            bladeNavigationService.showBlade(blade);
                        }
                    ]
                });
            }
        ]
    )
    .run(
    [
        'platformWebApp.toolbarService',
        'platformWebApp.dialogService',
        'platformWebApp.mainMenuService',
        'platformWebApp.widgetService',
        'platformWebApp.authService',
        'fedExModuleApi',
        '$state',
        function(toolbarService,
            dialogService,
            mainMenuService,
            widgetService,
            authService,
            fedExModuleApi,
            $state) {

            var menuItem = {
                path: 'browse/catalog',
                icon: 'fa fa-folder',
                title: 'fedEx.main-menu-title',
                priority: 20,
                action: function () { $state.go('workspace.fedExModule'); },
                permission: 'fedEx:access'
            };

            mainMenuService.addMenuItem(menuItem);

        }
    ]);