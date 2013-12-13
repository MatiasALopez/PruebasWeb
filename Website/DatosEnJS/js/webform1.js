$(document).ready(doc_ready);

var divDatos,
    datos;

function doc_ready() {
    try {
        inicializarControles();
        obtenerDatos();
        mostrarDatos();
    } catch (e) {
        alert(e.message);
    }
}

function inicializarControles() {
    divDatos = $("#divDatos");
}

function obtenerDatos() {
    datos = new Array();

    datos.push(new Persona("matias", "lopez", new Date(1985, 3, 31)));
    datos.push(new Persona("natalia", "zappacosta", new Date(1985, 4, 20)));
    datos.push(new Persona("lola", "zappacosta", new Date(1985, 3, 9)));
}

function mostrarDatos() {
    var len = datos.length;
    for (var i = 0; i < len; i++) {
        var dato = datos[i];
        divDatos.append("<div><span>" + dato.nombre + "</span><span>" + dato.apellido + "</span><span>" + dato.fechaNacimiento.toDateString() + "</span></div>");
    }
}

function Persona(nombre, apellido, fechaNacimiento) {
    this.nombre = nombre;
    this.apellido = apellido;
    this.fechaNacimiento = fechaNacimiento;
}