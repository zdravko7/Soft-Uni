function groupBy(criteria) {
    
    function person(firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    var people = [
        new person("Scott", "Guthrie", 38),
        new person("Scott", "Johns", 36),
        new person("Scott", "Hanselman", 39),
        new person("Jesse", "Liberty", 57),
        new person("Jon", "Skeet", 38)
    ];

    console.log(people);

}

groupBy('firstName');