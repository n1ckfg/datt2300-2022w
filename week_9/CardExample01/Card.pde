class Card {
  
  boolean flipped = false;
  PImage front;
  PImage back;
  PVector pos;
  PVector dim;
  
  Card(PImage _front, PImage _back, int x, int y, int w, int h) {
    front = _front;
    back = _back;
    pos = new PVector(x, y);
    dim = new PVector(w, h);
  }

  void update() {
    //
  }
  
  void draw() {
    imageMode(CENTER);
    if (flipped) {
      image(front, pos.x, pos.y);
    } else {
      image(back, pos.x, pos.y);
    }
  }
  
  void run() {
    update();
    draw();
  }

}
