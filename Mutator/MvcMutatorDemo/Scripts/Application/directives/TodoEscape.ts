module Todo {
    const ESCAPE_KEY = 27;
    export class TodoEscapeDirective implements ng.IDirective {
        static register = (appModule: ng.IModule, name = "todoEscape") => appModule.directive(name, [() => new TodoEscapeDirective()]);

        restrict = "A";

        link = (scope: ng.IScope, element: ng.IAugmentedJQuery, attributes: any) => {
            element.bind('keydown', (event) => {
                if (event.keyCode === ESCAPE_KEY) {
                    scope.$apply(attributes.todoEscape);
                }
            });

            scope.$on('$destroy', () => { element.unbind('keydown'); });
        }
    }
}
