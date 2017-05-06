module Todo {
    export class TodoFocusDirective implements ng.IDirective {
        static register = (appModule: ng.IModule, name = "todoFocus") => appModule.directive(name, ["$timeout", ($timeout: ng.ITimeoutService) => new TodoFocusDirective($timeout)]);
        constructor(private $timeout: ng.ITimeoutService) { }

        restrict = "A";

        link = (scope: ng.IScope, element: ng.IAugmentedJQuery, attributes: any) => {
            scope.$watch(attributes.todoFocus, newval => {
                if (newval) {
                    this.$timeout(() => element[0].focus(), 0, false);
                }
            });
        }
    }
}