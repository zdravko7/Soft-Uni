function kmToKnot(speed) {
    var convertedSpeed = speed / 1.852;

    return convertedSpeed.toFixed(2);
}

console.log(kmToKnot(20));
console.log();

console.log(kmToKnot(112));
console.log();

console.log(kmToKnot(400));
console.log();