$(function () {
    var l = abp.localization.getResource('BookStore');

    var dataTable = $('#EmployeesTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(acme.ems.employees.employee.getList),
            columnDefs: [
                {
                    title: l('Name'),
                    data: "name"
                },
             
                {
                    title: l('DOB'),
                    data: "DOB"
                
                    
                }
               
          
            ]
        })
    );
});
