var Person = function() {

    function Person (name, age) {
        this._name = name;
        this._age = age;
    }

    Person.prototype.sayHello = function() {
        return "Name: " + this._name + ", Age: " + this._age;

    };

    return Person;
}();

var Student = function() {

    function Student (name, age, grade) {
        Person.call(this, name, age);
        this._grade = grade;
    }

    Student.prototype = Object.create(Person.prototype);
    Student.prototype.constructor = Student;

    Student.prototype.sayHello = function() {
          return Person.prototype.sayHello.call(this) + ", Grade: " + this._grade;
    };

    return Student;
}();

var pesho = new Student("pesho", 22, 6.00);

//console.log(pesho);
console.log(pesho.sayHello());




//Prototypes
/*
Function.prototype.extends = function(parent) {
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
};

var Person = function(name) {
    this._name = name;

    var sayHellos = function () {
        console.log(this._name);
    }

};

Person.prototype = function () {

    return {
        sayHello : function () {
            console.log(this._name);
        }
    }

}();

var Student = function(name, grade) {
    Person.call(this, name);
    this._grade = grade;
};

Student.extends(Person);



var pesho = new Student("Pesho", 6.00);

pesho.sayHello();
*/