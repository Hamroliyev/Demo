namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mathi mathi= new Mathi();
            int xValue = mathi.x;
            Console.WriteLine(xValue);
        }
    }
    public struct Mathi
    {
        public int x;
    }
}