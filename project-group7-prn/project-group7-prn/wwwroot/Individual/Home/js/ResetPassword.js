$('#rs-a').click(function () {

    $('#reset-modal').modal({
        backdrop: "static",
        keybroad: true,
        show: true
    });
});

$('.btn-reset').click(function () {
    var email = $('#email-id').val();

    $.ajax({
        url: "/Home/ResetPassword",
        type: "get", //send it through get method
        data: {
            email: email
        },
        success: function (response) {
            //Do Something
            $('#reset-modal').modal('toggle');
            toastr.success("Password reset successful, please check your email.");

        },
        error: function (xhr) {
            //Do Something to handle error
            toastr.error("Email does not exist in the system.");
        }
    });
});

