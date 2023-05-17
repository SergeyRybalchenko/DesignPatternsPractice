namespace PrototypePattern
{
    internal class Rectangle : IFigure
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Width: {_width}, height: {_height}");
        }

        public IFigure Clone()
        {
            return new Rectangle(_width, _height);
        }
    }
}
