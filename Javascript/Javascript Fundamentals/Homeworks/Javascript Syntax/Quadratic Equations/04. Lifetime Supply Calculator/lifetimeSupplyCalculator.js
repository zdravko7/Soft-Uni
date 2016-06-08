function calcSupply(age, maxAge, food, foodPerDay) {
    var remainingAge = maxAge - age;
    var foodToBeEaten = remainingAge * 365 * foodPerDay;

    console.log(foodToBeEaten + "kg of " + food + " would be enough until I am " + maxAge + " old.");
}

calcSupply(38, 118, "chocolate", 0.5);
console.log();

calcSupply(20, 87, "fruits", 2);
console.log();

calcSupply(16, 102, "nuts", 1.1);
console.log()