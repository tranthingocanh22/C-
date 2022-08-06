class Cylinder
{
    static void Main(String[] args)
    {

        double Radius;
        double Height;
        double BaseArea;
        double LateralArea;
        double TotalArea;
        double Volume;
        Console.WriteLine("Enter the dimenstions of the cylinder");
        Console.Write("Radius : ");
        Radius = double.Parse(Console.ReadLine());
        Console.Write("Height : ");
        Height = double.Parse(Console.ReadLine());

        Console.WriteLine("\nCylinder Characteristics");
        Console.WriteLine("Radius: " + Radius + ", Height: " + Height);
        
        BaseArea = Radius * Radius * Math.PI;
        LateralArea = 2 * Math.PI * Radius * Height;
        TotalArea = 2 * Math.PI * Radius * (Height + Radius);
        Volume = Math.PI * Radius * Radius * Height;
        Console.WriteLine("Base: " + BaseArea + " | Latera: " + LateralArea + " | Total: " + TotalArea + " | Volume: " + Volume);
    }
}