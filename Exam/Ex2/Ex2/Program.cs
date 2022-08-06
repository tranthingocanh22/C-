class Base
{
    string name;
    double weight;

    public void SetMe(string name, double weight)
    {
        this.name = name;
        this.weight = weight;
    }
    public void Show()
    {
        Console.WriteLine("Name: " + name + ", Weight: " + weight);
    }
}

class Lion : Base
{
    public Lion(string name, double weight)
    {
        SetMe(name, weight);
        Show();
    }
}

class Tiger : Base
{
    public Tiger(string name, double weight)
    {
        SetMe(name, weight);
        Show();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Tiger objTiger = new Tiger("Tiger", 100);

        Lion objLion = new Lion("Lion", 200);
    }
}