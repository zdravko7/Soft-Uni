function numbers(input) {
    var startNum = input[0];
    var endNum = input[1];
    
    //var isRakiya = false;
    
    var rakiya = [];

    console.log("<ul>");
    
    for (var num = startNum; num <= endNum; num++) {
        var isRakiya = false;
        var currentNum = "" + num;
        
        //inside the current number
        for (var i = 0; i < currentNum.length; i++) {
            var num1 = currentNum[i];
            var num2 = currentNum[i + 1]

            for (var j = 0; j < currentNum.length; j++) {
                if (num1 === currentNum[j] && num2 === currentNum[j + 1] && i != j) {
                    isRakiya = true;
                }
            };  
        };

        if (isRakiya === false) {
            console.log("<li><span class='num'>%s</span></li>", currentNum);
        } else {
            console.log("<li><span class='rakiya'>%s</span><a href=\"view.php?id=%s>View</a></li>", currentNum, currentNum);
        }
        
    };
       
    console.log("</ul>");
}


