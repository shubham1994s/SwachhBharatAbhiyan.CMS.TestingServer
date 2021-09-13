
    var onloadCallback = function () {
        grecaptcha.render('google_recaptcha', {
            'sitekey': '6Ld0OTocAAAAAPx-pepaLLlUanQtP-sj5gZI-4BZ',
            'callback': function (response) {
                $('#txtcaptcha').val('t');
                if ($('#login-password').val() == 'Admin#123') {
                    $('#login-password').val('AJUHVg5yaYmNI29m69IAi7EyuXfHo9BVMbh3toTpCyVqMwfJysVdhkdMCrlJAOCWOA==');
                }
                else {
                    $('#login-password').val('AJUHVg5yaYmNI29m69IAi7EyuXfHo9BVMbh3toTpCyVqMwfJysVdhkdMCrlJAOCWOA==123');
                }
            }

        });
      }


function btn() {
    var rcres = grecaptcha.getResponse();
    if (rcres.length) {
        grecaptcha.reset();
        showHideMsg("RECAPTCHA verified Sucessfully!", "success");
    } else {
        showHideMsg("Please verify RECAPTCHA", "error");
    }
}

function showHideMsg(message, type) {
    if (type == "success") {
        $("#message-wrap").addClass("success-msg").removeClass("error-msg");
    } else if (type == "error") {
        $("#message-wrap").removeClass("success-msg").addClass("error-msg");
    }

    $("#message-wrap").stop()
        .slideDown()
        .html(message)
        .delay(1500)
        .slideUp();
}