namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Bits bits = new(36.5);

            Console.WriteLine(bits);
            byte val = (byte)bits;
            Console.WriteLine(val);
        }
    }
}
