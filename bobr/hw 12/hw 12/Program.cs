using System;
using System.Collections.Generic;


public class AppConfig
{
    private static readonly AppConfig _instance = new AppConfig();
    private Dictionary<string, string> _settings;

    private AppConfig()
    {
        _settings = new Dictionary<string, string>();
    }

    public static AppConfig Instance => _instance;

    public void SetSetting(string key, string value)
    {
        _settings[key] = value;
    }

    public string GetSetting(string key)
    {
        return _settings.ContainsKey(key) ? _settings[key] : null;
    }
}





public interface IShape
{
    void Draw();
}

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

public abstract class ShapeFactory
{
    public abstract IShape CreateShape();
}

public class CircleFactory : ShapeFactory
{
    public override IShape CreateShape()
    {
        return new Circle();
    }
}

public class RectangleFactory : ShapeFactory
{
    public override IShape CreateShape()
    {
        return new Rectangle();
    }
}



class Program
{
    static void Main()
    {
        Console.WriteLine("Select a task:");
        Console.WriteLine("1 — AppConfig (Singleton)");
        Console.WriteLine("2 — ShapeFactory (Factory Method)");
        Console.Write("Your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                RunAppConfigExample();
                break;

            case "2":
                RunShapeFactoryExample();
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void RunAppConfigExample()
    {
        AppConfig config = AppConfig.Instance;
        config.SetSetting("Theme", "Dark");
        config.SetSetting("Language", "English");

        Console.WriteLine("Theme: " + config.GetSetting("Theme"));       // Dark
        Console.WriteLine("Language: " + config.GetSetting("Language")); // English
    }

    static void RunShapeFactoryExample()
    {
        ShapeFactory circleFactory = new CircleFactory();
        IShape circle = circleFactory.CreateShape();
        circle.Draw(); // Drawing a circle

        ShapeFactory rectangleFactory = new RectangleFactory();
        IShape rectangle = rectangleFactory.CreateShape();
        rectangle.Draw(); // Drawing a rectangle
    }
}
