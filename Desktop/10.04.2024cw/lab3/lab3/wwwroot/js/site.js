// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('#myTable tr td').click(function () {
    document.querySelector("#id").value = this.parentElement.cells[0].innerText;
    $('#form').submit();
});