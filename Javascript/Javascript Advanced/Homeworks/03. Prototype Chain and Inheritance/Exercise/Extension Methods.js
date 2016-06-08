Array.prototype.getRandom = function () {

    var randomNum = getRandomArbitrary(0, this.length);

    console.log(randomNum);
    return this[randomNum];

    function getRandomArbitrary(min, max) {
        return Math.floor(Math.random() * (max - min) + min); //min = 0 always
    }
}

var array = [
                3 , 5 ,6 ,7 ,8 ,9 ,9 ,0, 10,
                3 , 5 ,6 ,7 ,8 ,9 ,9 ,0, 10,
                3 , 5 ,6 ,7 ,8 ,9 ,9 ,0, 10,
                3 , 5 ,6 ,7 ,8 ,9 ,9 ,0, 10,
                3 , 5 ,6 ,7 ,8 ,9 ,9 ,0, 10,
                3 , 5 ,6 ,7 ,8 ,9 ,9 ,0, 10,
                3 , 5 ,6 ,7 ,8 ,9 ,9 ,0, 10,
];

var text = "nice dude, very good support!";

//console.log(array.getRandom());
console.log(text.getRandom());