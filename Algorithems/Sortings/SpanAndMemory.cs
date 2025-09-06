namespace Algorithems.Sortings
{
    public class SpanAndMemory
    {
        public static void Run()
        {
            string logLine = "2025-09-05 21:10:33 ERROR User not found";

            ReadOnlySpan<char> span = logLine.AsSpan();

            var datePart = span.Slice(0, 19);
            Console.WriteLine($"Date:{datePart.ToString()}");

            var levelPart = span.Slice(20, 5);
            Console.WriteLine($"Level: {levelPart.ToString()}"); 
        }
    }
}