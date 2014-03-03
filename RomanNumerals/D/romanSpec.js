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

	it('expect 11 to be XI', function () {
	    expect(roman(11)).toBe("XI");
	});

	it('expect 41 to be XLI', function () {
	    expect(roman(41)).toBe("XLI");
	});

	it('expect 95 to be XCV', function () {
	    expect(roman(95)).toBe("XCV");
	});

	it('expect 195 to be CXCV', function () {
	    expect(roman(195)).toBe("CXCV");
	});

	it('expect 495 to be CDXCV', function () {
	    expect(roman(495)).toBe("CDXCV");
	});

	it('expect 1999 to be MCMXCIX', function () {
	    expect(roman(1999)).toBe("MCMXCIX");
	});
    
	it('expect 800 to be DCCC', function () {
	    expect(roman(800)).toBe("DCCC");
	});
    
	
});

describe("normal", function () {
    it('expect DCCC to be 800', function () {
        expect(normal('DCCC')).toBe(800);
    });
});