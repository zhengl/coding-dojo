function MineSweeper() {

}

MineSweeper.prototype.sweepTable = function(minesTable) {
    var tempTable=minesTable;
    var rows = minesTable.children.length;
    var columns = minesTable.rows[0].children.length;

    for(var rowIndex=0;rowIndex<rows;rowIndex++)
    {
    	for(var columnIndex = 0; columnIndex < columns; columnIndex++)
    	{
    		var cell = tempTable.children[rowIndex].children[columnIndex];
    		if(cell.textContent =="*")
    		{
    			if(columnIndex+1 < columns)
    			{
    				this.addOneToCell(tempTable.children[rowIndex].children[columnIndex+1]);
    				if(rowIndex - 1 >= 0)
    				{
    					this.addOneToCell(tempTable.children[rowIndex-1].children[columnIndex]);
    					this.addOneToCell(tempTable.children[rowIndex-1].children[columnIndex+1]);
    				}
    				if(rowIndex + 1 < rows)
    				{
    					this.addOneToCell(tempTable.children[rowIndex+1].children[columnIndex]);
    					this.addOneToCell(tempTable.children[rowIndex+1].children[columnIndex+1]);
    				}
    				
    			}

    			if(columnIndex-1 >= 0)
    			{
    				this.addOneToCell(tempTable.children[rowIndex].children[columnIndex-1]);
    				if(rowIndex - 1 >= 0)
    				{
    					this.addOneToCell(tempTable.children[rowIndex-1].children[columnIndex-1]);
    				}
    				if(rowIndex + 1 < rows)
    				{
    					this.addOneToCell(tempTable.children[rowIndex+1].children[columnIndex-1]);
    				}
    				
    			}
    		}
    	}

    }
	return minesTable;
};

MineSweeper.prototype.addOneToCell = function(cell) {
	if(cell.textContent != "*")
	{
		var tempvalue = Number(cell.textContent);
		cell.textContent = tempvalue++;
	}
}