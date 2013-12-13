describe('MineBuilder', function(){
	var builder;

	beforeEach(function(){
		builder = new MineBuilder();
	});

	it('builds a table', function(){
		expect(builder.createTable().tagName).toBe('TABLE');
	});

	it('builds a table with rows', function(){
		var rows = builder.createTable(3).children;
		expect(rows.length).toBe(3);
		for(var rowIndex = 0; rowIndex < 3; rowIndex++) {
			expect(rows[rowIndex].tagName).toBe('TR');
		}
	});

	it('builds a table with columns', function(){
		var rows = builder.createTable(3, 4).children;
		for(var rowIndex = 0; rowIndex < 3; rowIndex++) {
			var cells = rows[rowIndex].children;
			expect(cells.length).toBe(4);
			for(var columnIndex = 0; columnIndex < 4; columnIndex++) {
				expect(cells[columnIndex].tagName).toBe('TD');
			}
		}
	});

	it('builds a table with mines', function(){
		var mines = [{x: 0, y: 1}, {x: 1, y: 2}];
		var table = builder.createTable(2, 3, mines);
		console.log(table);

		expect(table.children[0].children[1].textContent).toBe('*');
		expect(table.children[1].children[2].textContent).toBe('*');

		expect(table.children[0].children[0].textContent).toBe('');
	});

});