describe("Player", function() {
	var player;

	beforeEach(function() {
		player = new Player();
		player.play();
	});

	var verifyAtPositioin = function(pos, expectedValue) {
		var child = document.getElementById("fizzbuzz").children[pos];
		expect(child.innerHTML).toBe(expectedValue);
	}

	it("should be able to play", function() {
		expect(player.isPlaying).toBe(true);
		// expect(player.isPlaying).toBeTruthy();
	});

	it("firt child should be 1", function() {
		verifyAtPositioin(0, '1');
	});

	it("second child should be 2", function() {
		verifyAtPositioin(1, '2');
	});

	it("third child should be fizzfizz", function() {
		verifyAtPositioin(2, 'fizzfizz');
	});

	it("fiveth child should be fizz", function() {
		verifyAtPositioin(4, 'buzzbuzz');
	});

	it("7 child should be woofwoof", function() {
		verifyAtPositioin(6, 'woofwoof');
	});

	it("15 child should be fizzbuzzbuzz", function() {
		verifyAtPositioin(14, 'fizzbuzzbuzz');
	});

	it("21 child should be fizzwoof", function() {
		verifyAtPositioin(20, 'fizzwoof');
	});

	it("35 child should be buzzwooffizzbuzz", function() {
		verifyAtPositioin(34, 'buzzwooffizzbuzz');
	});

	it("42 child should be fizzwoof", function() {
		verifyAtPositioin(41, 'fizzwoof');
	});

	it("75 child should be fizzbuzzwoofbuzz", function() {
		verifyAtPositioin(74, 'fizzbuzzwoofbuzz');
	});

	it("77 child should be woofwoofwoof", function() {
		verifyAtPositioin(76, 'woofwoofwoof');
	});

	it("83 child should be 83fizz", function() {
		verifyAtPositioin(82, 'fizz');
	});

	it("87 child should be fizzwoof", function() {
		verifyAtPositioin(86, 'fizzwoof');
	});

	it("99 child should be fizz", function() {
		verifyAtPositioin(98, 'fizz');
	});

	afterEach(function() {
		document.getElementById("fizzbuzz").innerHTML = "";
	});


});