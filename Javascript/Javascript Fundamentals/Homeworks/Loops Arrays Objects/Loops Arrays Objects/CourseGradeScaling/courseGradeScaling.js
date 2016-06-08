function courseGradeScaler(listOfPeople) {

    for (var key in listOfPeople) {
        listOfPeople[key].score = parseFloat((listOfPeople[key].score * 1.10).toFixed(1));

        if (listOfPeople[key].score >= 100) {
            listOfPeople[key].hasPassed = true;
        } else {
            listOfPeople[key].hasPassed = false;
        }
    }

    listOfPeople = listOfPeople.filter(function(student) {
        if (student.hasPassed) {
            return true;
        } else {
            return false;
        }
    });

    listOfPeople.sort(function (x, y) {
        return x.getKey > y.getKey;
    });

    sortByKey(listOfPeople, "name");

    console.log(listOfPeople);

    function sortByKey(array, key) {
        return array.sort(function (a, b) {
            var x = a[key]; var y = b[key];
            return ((x < y) ? -1 : ((x > y) ? 1 : 0));
        });
    }
}

//test
courseGradeScaler(
    [{
        'name': 'Пешо',
        'score': 91
    },
    {
        'name': 'Лилия',
        'score': 290
    },
    {
        'name': 'Алекс',
        'score': 343
    },
    {
        'name': 'Габриела',
        'score': 400
    },
    {
        'name': 'Жичка',
        'score': 70
    }]
);