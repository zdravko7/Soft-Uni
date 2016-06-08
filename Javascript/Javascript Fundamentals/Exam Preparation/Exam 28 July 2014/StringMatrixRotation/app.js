function rotateMatrix(input) {
    var command = input[0];
    
    var words = [];
    
    for (var i = 1; i < input.length; i++) {
        words[i-1] = input[i].toString();
    };

    console.log(input[0]);

    words.ForEach(function (entry) {
        console.log(entry);
    });
}

rotateMatrix(Rotate(90), hello, softuni, exam);
