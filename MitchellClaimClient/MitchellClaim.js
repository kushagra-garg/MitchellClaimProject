$(document).ready(function () {
    $("#lossDatePicker,#txtreportedDate,#txtFromDate,#txtToDate").datepicker();
    $(".txtDate").datepicker();
    $("#btnRefresh").click(function () {
        if ($("#txtFromDate").val() == "" || $("#txtToDate").val() == "")
        {
            alert("Select valid Date");
            return false;
        }
    });
    $("#btnSave").click(function () {
        if ($.trim($("#txtClaimNumber").val()) == "") {
            alert("Enter Claim Number");
            return false;
        }
    });
});