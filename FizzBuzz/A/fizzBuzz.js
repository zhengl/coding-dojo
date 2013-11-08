function FizzBuzz()
{
	var cont=function(tmpResult,number){
		   var threeRep=0;
		   var fiveRep=0;
           var tmpStr=number.toString();
           var start=0;
           var end=tmpStr.length;
           while(start<end){
           	if(tmpStr[start] == "3")
           	{
           		tmpResult+="Fizz";
           	}
           	if(tmpStr[start] == "5")
           	{
           		tmpResult+="Buzz";
           	}

           	if(tmpStr[start] == "7")
           	{
           		tmpResult+="Woof";
           	}
            start++;
           }
           
           
           return tmpResult;
	}

   this.go=function(number){
   	if(number % 15 === 0)
   		return cont("FizzBuzz",number);
   	if(number % 3 === 0)
   		return cont("Fizz",number);
		if(number % 5 === 0)
		return cont("Buzz",number);
	if(number % 7 === 0)
		return cont("Woof",number);
   	return number;
   }

   this.goWithFormat=function(number){
   		return "<li>"+this.go(number)+"</li>";
   }

   this.goWithLoop=function(start,end){
   		var html='';
   		for (var i = start; i <= end; i++) {
   			html+=this.goWithFormat(i);
   		};
   		return html;
   }
}