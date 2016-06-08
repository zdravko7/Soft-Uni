function scoreModification(input) {
    
    function filterScores(scores) {
        var validScores = [];

        for (var index in scores) {
            if (scores[index] > 0 && scores[index] < 400) {
                validScores.push(scores[index]);
            }
        }

        return validScores;
    }
    
    function reduceGrade(grade) {
        return grade * 0.80;
    }

    var scores = input;
    scores = filterScores(scores);
    
    //reduces by 20%
    for (var index in scores) {
        scores[index] = parseFloat(reduceGrade(scores[index]).toFixed(2));
    }

    scores.sort(function (x, y) {
        return x > y;
    });

    console.log(scores);
}

//test
scoreModification([200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1]);