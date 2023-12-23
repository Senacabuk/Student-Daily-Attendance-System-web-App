
function validateForm() {
    //Validation of fname and name values.
    var fname = document.forms['form1'][0].value;
    if (fname == null || fname == "") {
        alert("You need to enter your first name.");
        return false;
    }
    var lname = document.forms['form1'][1].value;
    if (lname == null || lname == "") {
        alert("You need to enter your last name.");
        return false;
    }

    //Validation of Email value.
    var mail = document.forms['form1'][2].value;
    if (mail == null || mail == "") {
        alert("Please, enter your mail address.");
        return false;
    }

    var subject = document.forms['form1'][4].value;
    if (subject == null || subject == "") {
        alert("Please, specify the subject.");
        return false;
    }
    var message = document.forms['form1'][5].value;
    if (message == null || message == "") {
        alert("You need the type the text.");
        return false;
    }
    else {
        setTimeout(function() {window.location.href = "contact.html"}, 3);
        alert("Form submission completed successfully. We will provide a return as soon as possible.");
        return true;
    }
}