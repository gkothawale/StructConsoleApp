internal class Program
{
    private static void Main(string[] args)
    {
        Point p1 = new Point(10, 20);
        Console.WriteLine("P1.X:" + p1.X);
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