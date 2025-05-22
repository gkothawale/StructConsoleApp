internal class Program
{
    private static void Main(string[] args)
    {
        Point p1 = new Point(10, 20);
        Point p2 = p1;
        p2.X = 100;
        Console.WriteLine("P1.X:" + p1.X);
        Console.WriteLine("P2.X:" + p2.X);
    }

    public struct Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public double Calculate()
        {
            return X * Y;
        }
    }
}