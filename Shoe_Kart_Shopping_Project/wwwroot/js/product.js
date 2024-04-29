var dataTable
$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Product/GetAll"
        },
        "columns": [
            { "data": "serialNo", "width": "30%" },
            { "data": "description", "width": "30%" },
            /*{ "data": "category", "width": "15%" },*/
            { "data": "price", "width": "25%" },
           /* { "data": "shoeSize", "width": "15%" },*/
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <div class="text-center">
                    <a class="btn btn-info" href="/Admin/Product/Upsert/${data}">
                    <i class="fas fa-edit"></i>
                    </a>
                    <a class="btn btn-danger" onClick=Delete("/Admin/Product/Delete/${data}")>
                    <i class="fas fa-trash"></i>
                    </a>
                    </div>
                   `;
                }
            }
        ]
    })
}


function Delete(url) {
    /*alert(url);*/
    swal({
        title: "Want To Delete Data??",
        text: "Delete Information!!!",
        icon: "warning",
        buttons: true,
        dangerModel: true
    }).then((willdelete) => {
        if (willdelete) {
            $.ajax({
                url: url,
                type: "DELETE",
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}
