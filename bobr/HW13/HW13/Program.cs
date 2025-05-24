using System;
using System.Collections.Generic;

public sealed class AppConfig
{
    private static readonly AppConfig _instance = new AppConfig();
    private Dictionary<string, string> _settings;

    private AppConfig()
    {
        _settings = new Dictionary<string, string>();
    }

    public static AppConfig Instance
    {
        get
        {
            return _instance;
        }
    }

    public void SetSetting(string key, string value)
    {
        _settings[key] = value;
    }

    public string GetSetting(string key)
    {
        return _settings.TryGetValue(key, out string value) ? value : null;
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
    static void Main(string[] args)
    {
        Console.WriteLine("Оберіть завдання:");
        Console.WriteLine("1 - Singleton AppConfig");
        Console.WriteLine("2 - Фабрика фігур");
        Console.Write("Ваш вибір: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Введіть ключ налаштування: ");
                string key = Console.ReadLine();
                Console.Write("Введіть значення налаштування: ");
                string value = Console.ReadLine();
                AppConfig.Instance.SetSetting(key, value);
                Console.WriteLine($"Збережено: {key} = {AppConfig.Instance.GetSetting(key)}");
                break;

            case "2":
                Console.WriteLine("Оберіть фігуру: 1 - Коло, 2 - Прямокутник");
                string shapeChoice = Console.ReadLine();
                ShapeFactory factory = null;

                if (shapeChoice == "1")
                    factory = new CircleFactory();
                else if (shapeChoice == "2")
                    factory = new RectangleFactory();

                if (factory != null)
                {
                    IShape shape = factory.CreateShape();
                    shape.Draw();
                }
                else
                {
                    Console.WriteLine("Невірний вибір фігури.");
                }
                break;

            default:
                Console.WriteLine("Невірний вибір завдання.");
                break;
        }
    }
}
