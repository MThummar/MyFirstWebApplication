function setColor() {
    var colors = ["red", "pink", "yellow", "green", "black", "blue"], color;

    var randColor;
    do {
        randColor = colors[Math.floor(Math.random() * colors.length)];
    } while (color == randColor);
    document.body.style.backgroundColor = randColor;
    this.style.backgroundColor = randColor;

}