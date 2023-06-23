namespace HW_6
{
    internal class Program
    {
        static void Main(string[] args)
        {;
            Console.WriteLine(string.Join(" ", Enumerable.Range(10, 41).ToArray()));

            Console.WriteLine(string.Join(" ", Enumerable.Range(10, 41).Where(n => n % 3 == 0).ToArray()));

            Console.WriteLine(string.Join(" ", Enumerable.Repeat("Linq", 10).ToArray()));

            Console.WriteLine(string.Join(", ", "aaa;abb;ccc;dap".Split(';').Where(s => s.Contains('a')).ToArray()));

            Console.WriteLine(string.Join(", ", "aaa;abb;ccc;dap".Split(';').Select(s => s.Count(ss => ss == 'a')).ToArray()));

            Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').Contains("abb"));
            
            Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').Max());

            Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').Average(s => s.Count()));

            Console.WriteLine("aaa;xabbx;abb;ccc;dap;zh".Split(';').Reverse().Min(s => s.Count()));

            Console.WriteLine("baaa;aabb;aaa;xabbx;abb;ccc;dap;zh".Split(';').Any(s => s.StartsWith("aa") && s.Skip(2).All(ss => ss == 'b')));

            Console.WriteLine(new string("baaa;aabb;aaa;xabbx;abb;ccc;dap;zh".Split(';').Where(s => s.EndsWith("bb")).Last().Skip(2).ToArray()));

        }
    }
}