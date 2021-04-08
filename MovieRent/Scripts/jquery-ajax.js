function callAll(jsfile) {
    var src = document.createElement("script");
    src.setAttribute("type","text/javascript");
    src.setAttribute("src",jsfile);
    document.getElementsByTagName("head")[0].appendChild(src);
}
callAll("C:\Users\hp\source\repos\Vidly\Vidly\Scripts\jquery-3.4.1.js");
callAll("C:\Users\hp\source\repos\Vidly\Vidly\Scripts\jquery.unobtrusive-ajax.js");
