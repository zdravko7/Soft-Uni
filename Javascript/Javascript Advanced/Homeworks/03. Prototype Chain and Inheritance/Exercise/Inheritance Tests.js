var person = {
    constructor: function (name, age) {
        this._name = name;
        this._age = age;

        return this;
    },
    sayHello : function () {
        return "Name: " + this._name + ", Age: " + this._age;
    }
};

var student = Object.create(person);
student.constructor = function(name,age,grade) {
    person.constructor.call(this, name, age);
    this._grade = grade;

    return this;
};

student.sayHello = function() {
    return person.sayHello.call(this) + ", Grade: " + this._grade;
};


var pesho = Object.create(student).constructor("Pesho", 23, 6.00);

console.log(pesho.sayHello());




//classic OOP
/*Function.prototype.extends = function(parent) {
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
}

function Person (name) {

    this._name = name;
}

function Student (name, age) {

    this._name = name;
    this._age = age;

}

Person.prototype.sayHello = function () {
    console.log("%s", this._name);
}

Student.extends(Person);

var pesho = new Student("Pesho", 23);

pesho.sayHello();*/

