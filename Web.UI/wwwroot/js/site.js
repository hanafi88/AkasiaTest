// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var selectBox = document.getElementById("selectBox");
var selectOptionsBox = document.getElementById("selectOptionsBox");
var selectOptions = selectOptionsBox.getElementsByTagName("li");

selectBox.innerHTML = selectOptions[0].innerHTML;

selectBox.onclick = function () {
    if (selectOptionsBox.style.display != "block") {
        selectOptionsBox.style.display = "block";
    } else {
        selectOptionsBox.style.display = "none";
    }
}
window.onclick = function (e) {
    if (e.target != selectBox &&
        selectOptionsBox.style.display == "block") {
        selectOptionsBox.style.display = "none";
    }
}

for (var i = 0; i < selectOptions.length; i++) {
    (function (i) {
        selectOptions[i].onclick = function () {
            selectBox.innerHTML = this.innerHTML;
		    alert(this.innerHTML);
        }
    })(i);
}