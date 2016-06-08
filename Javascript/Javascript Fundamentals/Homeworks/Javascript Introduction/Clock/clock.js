function clock() {
        var date = new Date();
        var hours = convertDate(date.getHours());
        var minutes = convertDate(date.getMinutes());
        var seconds = convertDate(date.getSeconds());

        document.getElementById("clock").innerHTML = (hours + ":" + minutes + ":" + seconds);
        var t = setTimeout(clock, 500);
}

function convertDate(number) {
    if (number < 10) {
        return "0" + number;
    } else {
        return number;
    }
}