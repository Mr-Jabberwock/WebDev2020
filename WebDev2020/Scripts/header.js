
function toggleLogin() {
    // get the Elements
    var pfp = document.getElementById('orale');
    var signin = document.getElementById('signins');

    // get the current value of the elements display property
    var displaySetting = pfp.style.display = "block";
    var removeSignin = signin.style.display




    // now toggle the elements depending on current state
    if (removeSignin == 'block') {
        // element is visible. hide it
        signin.style.display = 'block';


    }
    else {
        // element is hidden. show it
        signin.style.display = 'none';


    }
}

var hidden = true;
function showProfile() {
    var elem = document.getElementById("popOp");

    hidden = !hidden;
    console.log(hidden);
    if (!hidden) {
        elem.style.display = "block";
        elem.style.animationName = "popUp";
        elem.style.animationDuration = "0.5s";

    } else {
        elem.style.display = "none";
    }
}

