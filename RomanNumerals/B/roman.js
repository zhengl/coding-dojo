function roman(number) {
	

	var arg = new Array();
	var tempNum = number;
	while (tempNum > 1)
	{
		var item = tempNum % 10;
		arg.push(item);
		tempNum = tempNum / 10;
	}

	var numArg = new Array();

	for (var i = 0; i < arg.length; i++) {
		var item = arg[i] + repeatNumber("0", i);
		numArg.push(item);
	};

	var aFinalRoma= '';

	for (var i = numArg.length - 1; i >= 0; i--) {
		var numberInt = parseInt(numArg[i])
		if(numberInt < 4)
		{
			aFinalRoma += repeatNumber("I", number);
		}
		else if(numberInt === 4)
		{
			aFinalRoma += "IV";
		}
		else if(numberInt === 9)
		{
			aFinalRoma += "IX";
		}
		else if (5 < numberInt && numberInt < 9)
		{
			aFinalRoma += "V" + repeatNumber("I", numberInt-5);
		}		
	};	

	return aFinalRoma;
}

function repeatNumber(romanNumber, count)
{
	var aReturnValue = '';
	for (var i = count - 1; i >= 0; i--) {
		aReturnValue += romanNumber;
	};

	return aReturnValue;
}

function gerKeyPoint(number)
{
	var aKey = {
		1:"I",
		5:"V",
		10:"X",
		50:"L",
		100:"C",
		500:"D",
		1000:"M"
	}

	switch(number)
	{
		case 1: return aKey[number];
				break;
		case 5: return aKey[number];
				break;
		case 10: return aKey[number];
				break;
		case 50: return aKey[number];
				break;
		case 100: return aKey[number];
				break;
		case 500: return aKey[number];
				break;
		case 1000: return aKey[number];
				break;
	}
}