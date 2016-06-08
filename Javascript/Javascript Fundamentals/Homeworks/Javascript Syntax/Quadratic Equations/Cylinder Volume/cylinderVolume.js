function getCylinderVolume(input) {
    var radius = input[0];
    var height = input[1];

    var volume = Math.PI * radius * radius * height;

    return volume;
}

console.log(getCylinderVolume([2, 4]).toFixed(3));
console.log();

console.log(getCylinderVolume([5, 8]).toFixed(3));
console.log();

console.log(getCylinderVolume([12, 3]).toFixed(3));
console.log();