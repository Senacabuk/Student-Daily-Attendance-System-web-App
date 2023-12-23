
function loginForm() {
    var type = document.forms['login'][0].value;
    if (type == "none") {
        alert("You need to Access Type");
        return false;
    }
    var username = document.forms['login'][1].value;
    if (username == null || username == "") {
        alert("You need to enter your username.");
        return false;
    }
    var lname = document.forms['login'][2].value;
    if (lname == null || lname == "") {
        alert("You need to enter your password.");
        return false;
    }

    else {

        var type = document.forms['login'][0].value;
        if (type == "student") {
            setTimeout(function () { window.location.href = "studentAttendance" }, 3);

        }
        var type = document.forms['login'][0].value;
        if (type == "teacher") {
            setTimeout(function () { window.location.href = "teacherAttendance" }, 3);

        }
        return true;
    }
}