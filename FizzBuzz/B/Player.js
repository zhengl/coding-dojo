function Player() {}

Player.prototype.play = function(song) {
	this.isPlaying = true;

	var i;

	for (i = 0; i < 100; i++) {
		this.insertElementAtPos(i);
	}


};

Player.prototype.insertElementAtPos = function(pos) {
	var v = '';
	pos += 1;

	var des = '',
		checkDivision = function() {
			if (pos % 3 === 0) {
				v += 'fizz';
			}
			if (pos % 5 === 0) {
				v += 'buzz';
			}
			if (pos % 7 === 0) {
				v += 'woof';
			}
		},
		checkContains = function() {
			var array = pos.toString().split('');
			for (var i = 0; i < array.length; i++) {
				if (array[i] === '3') {
					v += "fizz"
				} else if (array[i] === '5') {
					v += "buzz"
				} else if (array[i] === '7') {
					v += "woof"
				}
			};

		};

	checkDivision();
	checkContains();

	if (v === '') {
		v = pos;
	}

	this.insertElement(v);
}

Player.prototype.insertElement = function(v) {
	var container = document.getElementById("fizzbuzz");

	var element = document.createElement("li");
	element.innerHTML = v;

	container.appendChild(element);
}