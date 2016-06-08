function solveQuadratic(a, b, c) {
    var root1 = (b * - 1 - Math.sqrt((b * b) - (4 * a * c))) / (2 * a);
    var root2 = ((b * -1) + Math.sqrt((b * b) - (4 * a * c))) / (2 * a);
    
    if (isNaN(root1) === true) {
        console.log("No real rots");
    } else if (root1 !== root2) {
        console.log("x1 = " + root1);
        console.log("x2 = " + root2);
    } else if (root1 === root2) {
        console.log("X = " + root1);
    }
}

solveQuadratic(2, 5, -3);
console.log();

solveQuadratic(2, -4, 2);
console.log();

solveQuadratic(4, 2, 1);