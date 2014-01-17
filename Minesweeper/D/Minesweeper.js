
function Minesweeper() {	
}

Minesweeper.prototype.getRowsCount = function(theTable) {
	// body...
	return theTable.children.length;
};

Minesweeper.prototype.getIndexesCount=function(theTable)
{
	return theTable.children[0].children.length;
}

Minesweeper.prototype.GetCellValue=function(x,y,table)
{

	var result=0;
	var rouCount=this.getRowsCount(table);
	var colCount=this.getIndexesCount(table);
	for(var i=x-1;i<=x+1;i++){
		for(var j=y-1;j<=y+1;j++)
		{
		   if(i<0||i>rouCount-1) continue;
		   if(j<0||j>colCount-1)continue;

			var temp=table.children[x].children[y].textContent;
            if(temp=='*')
            	result++;
		}
	}
	return result;
}