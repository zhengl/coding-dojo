function roman(number) {
   var numerial ={
     1:"I",
     5:"V",
     10:"X",
     50:"L",
     100:"C",
     500:"D",
     1000:"M" 
   };

  var arg = new Array();

  arg.push(number);
  
  var numberStr = number.toString();
  
  for (var i = 0; i < numberStr.length; i++) {
     arg.push(numberStr.slice(i,i+1));
  };
 
    switch(number){
  	case 1 : return numerial[1];
  	case 5 : return numerial[5];
  	case 10 : return numerial[10];
  	case 50 : return numerial[50];
  	case 100 : return numerial[100];
  	case 500 : return numerial[500];
  	case 1000 : return numerial[1000];
  
  }

  var returnStr = "";

  for (var i = 0; i < arg.length; i++) {
      returnStr += calculate(arg[i], i);
  };
  
  return returnStr;
}

function calculate(value, pos)
 {
	if(pos == 0 )
	{
		if(value < 4)
		{
			return repeatNumber("I", value);
		}
		if(value == 4){
			return "IV";
		}
		if(value >= 6 && value<9)
		{
			return "V" + repeatNumber("I",value-5);
		}
		if(value == 9){
			return "IX";
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
