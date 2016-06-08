function isNumber(number) {
    return !isNaN(number);
}

String.prototype.format = function () {
    var formatted = this;
    for (var arg in arguments) {
        formatted = formatted.replace("{" + arg + "}", arguments[arg]);
    }
    return formatted;
};

//checks how many times an element is found in an array
Array.prototype.occurs = function(target) {
    var array = this;
    var counter = 0;

    for (var element in array) {
        if (array[element] === target) {
            counter++;
        }
    }

    return counter;
}

function ArrayManipulator(input) {

    var numbers = [];

    for (var element in input) {
        if (isNumber(input[element])) {
            numbers.push(input[element]);
        }
    }

    numbers.sort(function(x,y) {
        return x < y
    });
    console.log("Min number: {0}".format(numbers[numbers.length - 1]));
    console.log("Max number: {0}".format(numbers[0]));
    
    //check for most frequent number
    var mostFrequent;
    var occurrances = 0;
    
    for (var element in numbers) {
        var count = numbers.occurs(numbers[element]);

        if (count > occurrances) {
            occurrances = count;
            mostFrequent = numbers[element];
        }
    }
    
    //prints the array of numbers
    console.log("Most frequent number: {0}".format(mostFrequent));
    console.log(numbers);
}

ArrayManipulator(["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0, "Penka", { bunniesCount: 10 }, [10, 20, 30, 40]]);