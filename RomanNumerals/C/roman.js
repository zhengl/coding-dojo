function roman(number) {
    var numerial = {
        1: "I",
        5: "V",
        10: "X",
        50: "L",
        100: "C",
        500: "D",
        1000: "M"
    };    
  var arg = new Array();

  var numberStr = number.toString();
  

 
  switch (number) {
      case 1:
          return numerial[1];
      case 5:
          return numerial[5];
      case 10:
          return numerial[10];
      case 50:
          return numerial[50];
      case 100:
          return numerial[100];
      case 500:
          return numerial[500];
      case 1000:
          return numerial[1000];
  }

  var returnStr = "";

  for (var i = 0; i < numberStr.length; i++) {
      
      returnStr = returnStr + calculate(numberStr[i], numberStr.length - i - 1);

  };

  
  return returnStr;
}

function calculate(value, pos)
{
    if (pos == 0) {
        if (value < 4) {
            return repeatNumber("I", value);
        }
        if (value == 4) {
            return "IV";
        }
        if (value >= 6 && value < 9) {
            return "V" + repeatNumber("I", value - 5);
        }
        if (value == 9) {
            return "IX";
        }
    } else if (pos == 1){
        if (value < 4) {
            return repeatNumber("X", value);
        }
        if (value == 4) {
            return "XL";
        }
        if (value >= 6 && value < 9) {
            return "L" + repeatNumber("X", value - 5);
        }
        if (value == 9) {
            return "XC";
        }
    } else if (pos == 2) {
        if (value < 4) {
            return repeatNumber("C", value);
        }
        if (value == 4) {
            return "CD";
        }
        if (value >= 6 && value < 9) {
            return "D" + repeatNumber("C", value - 5);
        }
        if (value == 9) {
            return "CM";
        }
    } else if (pos == 3) {
        if (value < 4) {
            return repeatNumber("M", value);
        }
    }
}

function calculate2(value, pos, val1, val2) {
    if (pos == 0) {
        if (value < 4) {
            //return repeatNumber("I", value);
            return repeatNumber(val1, value);

        }
        if (value == 4) {
            //return "IV";
            return val1 + '' + val2;

        }
        if (value >= 6 && value < 9) {
            //return "V" + repeatNumber("I", value - 5);
            return val2 + "" + val1 + repeatNumber(val1, value - 5);
        }
        if (value == 9) {
            //return "IX";
            return val1 + '' + val2;
        }
    }
}


 function repeatNumber(romanNumber, count)
 {
 	var aReturnStr = '';
 	for (var i = 0; i < count; i++) {
 		aReturnStr += romanNumber;
 	};

 	return aReturnStr;
 }




//  
