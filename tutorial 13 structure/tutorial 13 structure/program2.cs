using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Point.StaticMethod();

        Point p = new Point();

        p.PointChanged += StructEventHandler;
        p.XPoint = 123;

        p.PrintPoints();
    }

    static void StructEventHandler(int point)
    {
        Console.WriteLine("Point changed to {0}", point);
    }
}

struct Point
{
    private int _x, _y;

    public int x, y;

    public static int X, Y;

    public int XPoint
    {
        get
        {
            return _x;
        }

        set
        {
            _x = value;
            PointChanged(_x);
        }
    }

    public int YPoint
    {
        get
        {
            return _y;
        }
        set
        {
            _y = value;
            PointChanged(_y);
        }
    }

    public event Action<int> PointChanged;

    public void PrintPoints()
    {
        Console.WriteLine("x: {0}, y: {1}", _x, _y);
    }

    public static void StaticMethod()
    {
        Console.WriteLine("Inside Static method");
    }
}
