// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        var list = new List<int>(new [] { 1,2,3,4,}); 
        var t = list.Select(s =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(++s);
                return s;
            })
            .Where(w => w%2 == 0);
        t.Select(s =>
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(s);
            return s;
        }).ToArray();
    }
}