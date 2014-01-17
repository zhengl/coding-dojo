describe("Minesweeper test", function() {

	 var builder;
	 var sweeper;
	 var aTable;
     var rowCount,colCount;
	 beforeEach(function(){
		builder = new MineBuilder();
		sweeper=new Minesweeper();
		var mines = [{x: 0, y: 0}, {x: 0, y: 2}];
		  aTable=builder.createTable(3,3,mines);
	 	 rowCount=sweeper.getRowsCount(aTable);
	 	 colCount=sweeper.getIndexesCount(aTable);

	});

	 it('Get RowIndex and Column Index', function()
	 {
	 	
	 	expect(rowCount).toBe(3);
	 	expect(colCount).toBe(3);
	 }
	 );

	 it("get value in cell",function(){
	 	var val=sweeper.GetCellValue(1,2,aTable);
		var val2=sweeper.GetCellValue(0,1,aTable);

	     expect(val).toBe(1);
	     expect(val2).toBe(2);
	 });
	

	

});