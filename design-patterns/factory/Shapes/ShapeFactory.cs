namespace Factory.Shapes
{
    public class ShapeFactory
    {
        public IShape GetShape(string type)
        {
            if (type.Equals("square", StringComparison.OrdinalIgnoreCase))
            {
                return new Square();
            }
            else if (type.Equals("rectangle", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();
            }
            else if (type.Equals("circle", StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();
            }
            else
            {
                throw new ArgumentException("Shape type not supported: " + type);
            }
        }
    }
}
