﻿let dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/movie",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "name", "width": "20%" },
            { "data": "genre", "width": "20%" },
            { "data": "medium", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                        <a href="/MovieList/Edit?id=${data}" class="btn btn-success text-white" style='cursor:pointer; width:70px;'>Edit</a>
                        &nbsp
                        <a class="btn btn-danger text-white" style='cursor:pointer; width:70px;'>Delete</a>
                        </div>`;
                }, "width":"40%"
            }
        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width":"100%"
    })
}