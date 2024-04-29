var dataTable
$(document).ready(function () {
    loadDataTable();

})
function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Brand/GetAll",
        },
        "columns": [
            { "data": "name", "width": "70%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <div class="text-center">
                      <a class="btn btn-primary" href="/Admin/Brand/Upsert/${data}">
                        <i class="fas fa-edit"></i>
                        </a>
                        <a class="btn btn-danger" onClick=Delete("/Admin/Brand/Delete/${data}")>
                            <i class="fas fa-trash-alt"></i>
                        </a>
                        </div>
                       `;
                }
            }
        ]
    })
}

function Delete(url) {
    // alert(url);
    swal({
        title: "Want To Delete Data??",
        icon: "warning",
        text: "Are You Sure!!!",
        buttons: true,
        dangerModel: true
        /*dangerMode: true*/
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
