function normal(roman) {
    
    var number = 0;
    for (var i = roman.length-1; i >= 0; i--) {
        var a = roman.slice(i, i + 1);
        number += calculate2(a, i);
    };
    
    return number;
}

var map = { I: 1, V: 5, X: 10, L: 50, C: 100, D: 500, M: 1000 };

function calculate2(total, value) {
    if (total > value) {
        return total - value;
    }

    return total + value;
}
