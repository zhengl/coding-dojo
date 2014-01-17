describe("Minesweeper", function() {
	var builder;
	var sweeper;

	beforeEach(function(){
		sweeper = new MineSweeper();
		builder = new MineBuilder();
	});

	it('builds a table', function(){
		var mines = [{x: 0, y: 0}];
		var minesTable=builder.createTable(1,2,mines);
		expect(sweeper.sweepTable(minesTable).tagName).toBe('TABLE');
		expect(minesTable.children[0].children[0].textContent).toBe('*');
		expect(minesTable.children[0].children[1].textContent).toBe('1');
	});

	it('builds a table', function(){
		var mines = [{x: 0, y: 0},{x: 1, y: 1}];
		var minesTable=builder.createTable(2,2,mines);
		expect(sweeper.sweepTable(minesTable).tagName).toBe('TABLE');
		expect(minesTable.children[0].children[1].textContent).toBe('2');
		expect(minesTable.children[1].children[0].textContent).toBe('2');
	});
});
