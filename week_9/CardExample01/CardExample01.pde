PImage card_back, card_front;
int cardWidth = 100;
int cardHeight = 200;
int numCards = 20;
Card[] cards = new Card[numCards];


void setup() {
  size(800, 600, P2D);
  
  card_back = loadImage("card_back.png");
  card_back.resize(cardWidth, cardHeight);
  card_front = loadImage("card_back.png");
  card_front.resize(cardWidth, cardHeight);
  
  for (int i=0; i<cards.length; i++) {
    cards[i] = new Card(card_front, card_back, width/2 + i * 20, height/2 - i * 20, cardWidth, cardHeight);
  }
}

void draw() {
  background(127);
  
  if (random(1) < 0.01) {
    int index = int(random(cards.length));
    cards[index].flipped = !cards[index].flipped;
  }
  
  for (int i=0; i<cards.length; i++) {
    cards[i].run();
  }
}
