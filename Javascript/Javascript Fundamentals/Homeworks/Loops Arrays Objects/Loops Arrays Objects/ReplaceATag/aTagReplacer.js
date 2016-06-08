function replaceTag(document) {
    
    var html = document.getElementById("a");

    html.outerHTML = "URL";

    console.log(html);
}

//test
replaceTag();