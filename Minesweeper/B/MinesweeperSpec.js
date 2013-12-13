describe("Minesweeper", function() {
	var sweeper;

	beforeEach(function(){
		sweeper = new Minesweeper();
	});
	
	it('check table', function(){
		var builder = new MineBuilder();
		var table = builder.createTable(1, 2);
		var result = sweeper.changeToArray(table);
		expect(result.length).toBe(1);
		expect(result[0].length).toBe(2);
	});
        
    it('check mines', function(){
		var builder = new MineBuilder();
		var mines = [{x: 0, y: 1}];
		var table = builder.createTable(1, 2,mines);
		var result = sweeper.changeToArray(table);
		expect(result[0][1]).toBe('*');
	});
		
});