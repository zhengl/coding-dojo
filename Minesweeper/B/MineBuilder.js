function MineBuilder() {	
}

MineBuilder.prototype.createTable = function(rows, columns, mines) {
	var table = document.createElement('table');
	for(var rowIndex = 0; rowIndex < rows; rowIndex++) {
		var tr = document.createElement('tr');
		for(var columnIndex = 0; columnIndex < columns; columnIndex++) {
			var td = document.createElement('td');
			if(this.containsMine(mines, rowIndex, columnIndex)) td.textContent = '*';
			tr.appendChild(td);
		}
		table.appendChild(tr);
	}
	return table;
};

MineBuilder.prototype.containsMine = function(mines, rowIndex, columnIndex) {
	if(mines === undefined) return false;

	return mines.some(function(mine){
		return mine.x == rowIndex && mine.y == columnIndex;
	})
};