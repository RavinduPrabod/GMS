﻿function ShowWarningMessage(msg) {
    $(function () {
        alertify.error(msg);
    });
}

function ShowSuccessMessage(msg) {
    $(function () {
        alertify.success(msg);
    });
}