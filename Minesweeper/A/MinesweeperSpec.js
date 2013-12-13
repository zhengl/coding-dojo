describe("Minesweeper", function() {
	var builder;
	var sweeper;
	

	beforeEach(function(){
		builder = new MineBuilder();
		sweeper = new Minesweeper();

	});

	it('transforms a table to a multi-demensional array', function(){
		var table = builder.createTable(2, 3, [{x: 0, y: 1}, {x: 1, y: 2}]);
		var mineArray = sweeper.transformTable(table);
		expect(Array.isArray(mineArray)).toBe(true);
		expect(mineArray.length).toBe(2);
		expect(Array.isArray(mineArray[0])).toBe(true);
		for (var i = 0; i < mineArray.length; i++) {
			expect(mineArray[i].length).toBe(3);
		};

		expect(mineArray[0][1]).toBe('*');
		expect(mineArray[1][2]).toBe('*');
	});

	it('calculate mine in array', function(){
		originalArray = [
		['*', 0, 0, 0],
		[0,'*',0,'*'],
		[0,0,0,0]
		];
		resultArray = sweeper.calculateMine(originalArray);
		expect(resultArray[0][1]).toBe(2);
		expect(resultArray[0][2]).toBe(2);
		expect(resultArray[0][3]).toBe(1);
		expect(resultArray[1][0]).toBe(2);
		expect(resultArray[1][2]).toBe(2);
		expect(resultArray[2][0]).toBe(1);
		expect(resultArray[2][1]).toBe(1);
		expect(resultArray[2][2]).toBe(2);
		expect(resultArray[2][3]).toBe(1);
	});
});