module Todo {
    const ESCAPE_KEY = 27;
    export class TodoBlurDirective implements ng.IDirective {
        static register = (appModule: ng.IModule, name = "todoBlur") => appModule.directive(name, [() => new TodoBlurDirective()]);

        restrict = "A";

        link = (scope: ng.IScope, element: ng.IAugmentedJQuery, attributes: any) => {
            element.bind('blur', () => { scope.$apply(attributes.todoBlur); });
            scope.$on('$destroy', () => { element.unbind('blur'); });
        }
    }
}
