//Call this to register our module to main application
var moduleName = "virtoCommerce.fedExModule";

if (AppDependencies != undefined) {
    AppDependencies.push(moduleName);
}

angular.module(moduleName, [
])

    .run(
    ['platformWebApp.toolbarService', 'platformWebApp.dialogService', 'platformWebApp.mainMenuService', 'platformWebApp.widgetService', 'platformWebApp.authService', function (toolbarService, dialogService, avataxModuleResources, mainMenuService, widgetService, authService) {

    }])
    ;