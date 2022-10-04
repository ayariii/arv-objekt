public class Program 
{
    public static void Main() 
    {
        Console.WriteLine("Type width: ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Type height: ");
        int height = int.Parse(Console.ReadLine());

        Triangle t = new Triangle (width, height);
        Rectangle r = new Rectangle (width, height);

        Console.WriteLine("Rectangle has an area of " + r.Area() + "m");
    }
}