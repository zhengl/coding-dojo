function roman(number) {
    
    var returnStr = "",
        numberStr = number.toString();

    for (var i = 0; i < numberStr.length; i++) {
        var a=numberStr.slice(i, i + 1);
        returnStr += calculate(a, numberStr.length - 1 - i);
    };

    return returnStr;
}

var mappings = [["I", "V", "X"], ["X", "L", "C"], ["C", "D", "M"], ["M"]];

function calculate(value, pos) {
    return getSingleRoman(value, mappings[pos]);
}

function getSingleRoman(value, rpts) {
    if (value == 0) {
        return "";
    }
    if (value < 4) {
        return repeatNumber(rpts[0], value);
    }
    if (value == 4) {
        return rpts[0] + rpts[1];
    }
    if (value == 5) {
        return rpts[1];
    }
    if (value >= 6 && value < 9) {
        return rpts[1] + repeatNumber(rpts[0], value - 5);
    }
    if (value == 9) {
        return rpts[0] + rpts[2];
    }
}

function repeatNumber(romanNumber, count) {
    var aReturnStr = '';
    for (var i = 0; i < count; i++) {
        aReturnStr += romanNumber;
    };

    return aReturnStr;
}

