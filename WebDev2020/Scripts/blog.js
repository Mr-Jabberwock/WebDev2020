var hidden = true;
function windowToggle() {
    buttonClick("save");
    buttonClick("image");
    buttonClick("cancel");

    var elem = document.getElementById("blogpopOp");

    hidden = !hidden;

    if (!hidden) {
        elem.style.display = "block";
        elem.style.animationName = "popUp";
        elem.style.animationDuration = "0.5s";

    } else {
        elem.style.display = "none";
    }
}

function postBlogData() {
    var title = document.getElementsByClassName("blogName");
    var body = document.getElementsByClassName("description");
    var form = document.getElementsByName("dataForm");

    console.log(title, body)

    windowToggle();

}

function buttonClick(buttonName) {
    var save = document.getElementById(buttonName);
    save.addEventListener("click", (event) => {
        event.preventDefault();
    })
}