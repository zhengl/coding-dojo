function Minesweeper(){

}

Minesweeper.prototype.transformTable = function(table) {
	var rows = table.children.length;
	var array = new Array(rows);
	for (var i = 0; i < array.length; i++) {
		var columns = table.children[i].children.length;
		array[i] = new Array(columns);
		for (var j = 0; j < columns; j++) {
			if (table.children[i].children[j].textContent == '*') {
				array[i][j] = '*';
			};
		};
	};

	return array;
};

Minesweeper.prototype.calculateMine = function(array){
	return array;
}