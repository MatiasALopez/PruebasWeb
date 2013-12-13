/// <reference path="../../scripts/jquery-1.8.3.min.js" />
/// <reference path="../../scripts/knockout-2.2.1.js" />


function OrdenYFiltrosViewModel() {
    var self = this;

    //  Propiedades
    self.items = ko.observableArray([]);

    //  Funciones
    self.sort = function (data, event) {
        var target = $(event.target);
        var property = target.data("property");
        var order = target.data("order");
        if (!order || (order != "asc" && order != "desc"))
            order = "asc";
        else
            order = order == "asc" ? "desc" : "asc";
        target.data("order", order);

        self.items.sort(function (a, b) {
            if (a[property]() == b[property]())
                return 0;
            else {
                if (order == "asc")
                    return a[property]() < b[property]() ? -1 : 1;
                else
                    return a[property]() > b[property]() ? -1 : 1;
            }
        });
    }

    //  Inicializacion
    for (var i = 0; i < 100; i++) {
        self.items.push(new Persona("nombre " + i, "apellido " + i, new Date(1990, 1, i), i % 2 == 0));
    }
}

var vm = new OrdenYFiltrosViewModel();
ko.applyBindings(vm);

function Persona(nombre, apellido, fechaNacimiento, status) {
    var self = this;

    self.nombre = ko.observable(nombre);
    self.apellido = ko.observable(apellido);
    self.fechaNacimiento = ko.observable(fechaNacimiento);
    self.estaActivo = ko.observable(status);

    self.estaActivoConFormato = ko.computed(function () {
        return self.estaActivo() ? "Si" : "No";
    });

    self.fechaNacimientoConFormato = ko.computed(function () {
        var date = self.fechaNacimiento();
        return date.getDate() + "/" + (date.getMonth() + 1) + "/" + date.getFullYear();
    });
}