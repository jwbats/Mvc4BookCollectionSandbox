$(function(){
	var oTable = $('#myDataTable').dataTable({
		"bServerSide": true,
		"sAjaxSource": "AjaxHandler",
		"bProcessing": true,
		"aoColumns": [
						{   "sName": "ID",
							"bSearchable": false,
							"bSortable": false,
							"fnRender": function (oObj) {
								return '<a href=\"details/' + oObj.aData[0] + '\">View</a>';
							}
						},
						{ "sName": "COMPANY_NAME" },
						{ "sName": "ADDRESS" },
						{ "sName": "TOWN" }
					]
	});

});