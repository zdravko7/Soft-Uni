Object.prototype.extend = function (properties) {
    function f() { };
    f.prototype = Object.create(this);
    for (var prop in properties) {
        f.prototype[prop] = properties[prop];
    }
    f.prototype._super = this;
    return new f();
};

var shapeModule = function() {

    var shape = {
        constructor : function (color) {
            this._color = color;
        },
        toString : function () {
            return "Color: " + this._color;
        }
    };

    var circle = shape.extend(
    {
       constructor : function (x, y, r, color) {
            this._x = x;
            this._y = y;
            this._r = r;
            shape.constructor.call(this, color);
            //console.log(this._super.constructor.call(this,color))
            return this;
        },
        toString : function () {
            return shape.toString() + ", X: " + this._x + ", Y: " + this._y + ", R:" + this._r;
        }
    });

    var rectangle = Object.create(shape);
    rectangle.constructor = function (x, y, r, color) {
        this._x = x;
        this._y = y;
        this._r = r;
        shape.constructor.call(this, color);
    };


    return {
        shape : shape,
        circle : circle,
        rectangle: rectangle
    }

}();

var circle = Object.create(shapeModule.circle);
//var rect = Object.create(shapeModule.rec);
circle.constructor(10,10,5,"blue");

console.log(circle.toString());




/*•	Circle – holds a center point O with coordinates x and y (written for simplicity as O(x, y)). Also has a radius r (number) and a color (in hexadecimal format)
•	Rectangle – holds the coordinates of its top left corner A(x, y), width (number), height (number) and color (in hexadecimal format)
•	Triangle – consists of three points A(x, y), B(x, y) and C(x, y). Also has a color (in hexadecimal format)
•	Line – holds two points A(x, y) and B(x, y), has a color (in hexadecimal format)
•	Segment – consists of two endpoints A(x, y) and B(x, y), also has a color (in hexadecimal format)
*/