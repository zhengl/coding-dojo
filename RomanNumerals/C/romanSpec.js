describe("roman", function() {

	it('expect 1 to be I', function(){
		expect(roman(1)).toBe("I");
	});


	it('expect 5 to be V', function(){
		expect(roman(5)).toBe("V");
	});

	it('expect 1000 to be M', function(){
		expect(roman(1000)).toBe("M");
	});
   
	it('expect 2 to be II', function(){
		expect(roman(2)).toBe("II");
	});
   
	it('expect 3 to be III', function(){
		expect(roman(3)).toBe("III");
	});

	it('expect 4 to be IV', function(){
		expect(roman(4)).toBe("IV");
	});

	it('expect 6 to be VI', function(){
		expect(roman(6)).toBe("VI");
	});

	it('expect 9 to be IX', function(){
		expect(roman(9)).toBe("IX");
	});
    
	it('expect 10 to be X', function () {
	    expect(roman(10)).toBe("X");
	});

	it('expect 11 to be XI', function () {
	    expect(roman(11)).toBe("XI");
	});
    
	it('expect 12 to be XII', function () {
	    expect(roman(12)).toBe("XII");
	});

	it('expect 101 to be CI', function () {
	    expect(roman(101)).toBe("CI");
	});
	it('expect 499 to be DCXIX', function () {
	    expect(roman(499)).toBe("CDXCIX");
	});
    
	it('expect 1999 to be MCMXCIX', function () {
	    expect(roman(1999)).toBe("MCMXCIX");
	});
});