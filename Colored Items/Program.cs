{

    ColoredItem <Sword> blueSword = new ColoredItem<Sword>(new Sword(), "blue");
    ColoredItem<Bow> redBow = new ColoredItem<Bow>(new Bow(), "red");
    ColoredItem<Axe> greenAxe = new ColoredItem<Axe>(new Axe(), "green");


}

public class Sword { }
public class Bow { }
public class Axe { }

public class ColoredItem<T>
{
    public T Item { get; set; }
    public string Color { get; set;}

    public ColoredItem(T item, string color)
    {
        Item = item;
        Color = color;
        PrintItemWithColor(Color);

    }

    public void PrintItemWithColor(string color)
    {
        if (Color == "red" || Color == "Red")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Item);
            Console.ForegroundColor = ConsoleColor.White;
        }
        if (Color == "blue" || Color == "Blue")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Item);
            Console.ForegroundColor = ConsoleColor.White;
        }
        if (Color == "green" || Color == "Green")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Item);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}


