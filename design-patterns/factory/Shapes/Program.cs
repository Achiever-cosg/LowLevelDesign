namespace Factory.Shapes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();

            IShape shape = factory.GetShape("circle");
            shape.Draw();

            shape = factory.GetShape("square");
            shape.Draw();

            shape = factory.GetShape("rectangle");
            shape.Draw();
        }
    }
}
