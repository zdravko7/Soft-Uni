Function.prototype.extends = function(parent) {
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
};

function Shape (color) {
    this._color = color;

    this.toString = function () {
        return "color: " + this._color;
    }
}

function Circle (x, y, r, color) {
    Shape.call(this, color);
    this._x = x;
    this._y = y;
    this._r = r;

}

var shape = new Shape("blue");
var circle = new Circle(10,10,5,"green");

console.log(shape.toString());
console.log(circle.toString());