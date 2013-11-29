describe("roman", function() {

	var aKey = {
		1:"I",
		2:"II",
		4:"IV",
		6:"VI",
		5:"V",
		9:"IX",
		10:"X",
		50:"L",
		100:"C",
		500:"D",
		1000:"M"
	}

	it('input number:1', function(){
		expect(roman(1)).toBe("I");
	});

	it('input number:5', function(){
		expect(roman(5)).toBe("V");
	});

	it('input number:10', function(){
		expect(roman(10)).toBe("X");
	});

	it('input number:2', function(){
		expect(roman(2)).toBe("II");
	});

	it('input number:4', function(){
		expect(roman(4)).toBe("IV");
	});

	it('input number:9', function(){
		expect(roman(9)).toBe("IX");
	});

	it('input number:8', function(){
		expect(roman(8)).toBe("VIII");
	});

	it('input number:14', function(){
		expect(roman(14)).toBe("XIV");
	});
});