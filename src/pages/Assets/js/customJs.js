function Login () {
document.getElementById("NormalLogin").style.display='none';
}
function ResetPassword () {
    document.getElementById("AfterLogin").style.display="none"
    document.getElementById("NormalLogin").style.display="none"
    document.getElementById("ResetPassword").style.display=""
}


function OpenFolder() {
    const menu =  document.getElementById("MenuExpended");
    if(menu.classList.contains('bxs-folder-open')) menu.setAttribute('class', 'bx bxs-folder');
   else menu.setAttribute("class","bx bxs-folder-open");
}