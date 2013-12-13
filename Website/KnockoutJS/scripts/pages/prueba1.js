var model = {
    statusList: ko.observableArray()
};

function updateData() {
    $.getJSON('Datos.svc/ObtenerStatusLista?' + new Date(), function (data) {
        model.statusList.removeAll();
        model.statusList.push.apply(model.statusList, data);
    });
}

updateData();
ko.applyBindings(model);

setInterval(updateData, 5000);