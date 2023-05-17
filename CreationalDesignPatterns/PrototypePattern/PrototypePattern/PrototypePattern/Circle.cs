namespace PrototypePattern
{
    internal class Circle : IFigure
    {
        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Radius: {_radius}");
        }

        public IFigure Clone()
        {
            return new Circle(_radius);
        }
    }
}
