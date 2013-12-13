function Minesweeper(){}

Minesweeper.prototype.changeToArray = function(table){
	console.log(table)
	var rows = table.children.length;
	var result = new Array(rows);
	for(var row = 0; row < rows; row++) {
		result[row] = new Array(table.children[row].children.length);
		var columns=table.children[row].children.length;
		for (var column = 0; column<columns; column++) {

			if(table.children[row].children[column].textContent=='*')
			{
				result[row][column]='*';
			}	
		};
	}
	return result;
}