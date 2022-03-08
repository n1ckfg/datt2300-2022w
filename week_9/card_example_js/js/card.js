"use strict";

class Card {

	constructor(_front, _back, x, y, w, h) {
		this.flipped = false;
		this.clicked = false;
		this.hovered = false;
		this.front = _front;
		this.back = _back;
		this.pos = createVector(x, y);
		this.dim = createVector(w, h);
		this.hdim = createVector(w/2, h/2);
		this.offset = createVector(0, 0);
		this.marktime = 0;
	}

	update() {
		if (this.hovered && millis() > this.marktime + 10) {
			this.hovered = false;
			this.clicked = false;
		}

		if (this.clicked) {
			this.pos.x = mouseX;
			this.pos.y = mouseY;
		}
	}

	draw() {
		noTint();

		if (this.hovered && !this.clicked) {
			tint(200, 127, 0);
		} else if (this.clicked) {
			tint(255, 0, 0);
		}

		imageMode(CENTER);
	    if (this.flipped) {
	      image(this.front, this.pos.x, this.pos.y);
	    } else {
	      image(this.back, this.pos.x, this.pos.y);
	    }
	}

	run() {
		this.update();
		this.draw();
	}

	check() {
		this.hovered = mouseX > this.pos.x - this.hdim.x && mouseX < this.pos.x + this.hdim.x && mouseY > this.pos.y - this.hdim.y && mouseY < this.pos.y + this.hdim.y;
		this.clicked = this.hovered && mouseIsPressed;
		this.marktime = millis();
	}

}