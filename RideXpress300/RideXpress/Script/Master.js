$(function () {
    $('[data-toggle="popover"]').popover();
});
$('#myModal').on('shown.bs.modal', function () {
    $('#myInput').focus()
})