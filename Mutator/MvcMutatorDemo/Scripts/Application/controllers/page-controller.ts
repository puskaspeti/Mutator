module Todo {
    export class PageController {
        static register = (appModule: ng.IModule, name = "PageController") => appModule.controller(name, [PageController]);

        tabIndex: number;
    }
}