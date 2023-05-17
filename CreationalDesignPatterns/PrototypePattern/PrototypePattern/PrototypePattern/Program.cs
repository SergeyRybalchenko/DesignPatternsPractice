using PrototypePattern;

IFigure Prototype = new Circle(5);
var circleClone = Prototype.Clone();
circleClone.GetInfo();

Prototype = new Rectangle(5, 10);
var rectangleClone =  Prototype.Clone();
rectangleClone.GetInfo();