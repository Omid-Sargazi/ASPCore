namespace Algorithems.Sortings
{
    public class SpanAndMemory
    {
        public static void RunSpan()
        {
            string logLine = "2025-09-05 21:10:33 ERROR User not found";

            ReadOnlySpan<char> span = logLine.AsSpan();

            var datePart = span.Slice(0, 19);
            Console.WriteLine($"Date:{datePart.ToString()}");

            var levelPart = span.Slice(20, 5);
            Console.WriteLine($"Level: {levelPart.ToString()}");
        }

        public async static Task RunMemory()
        {
            byte[] buffer = new byte[1024];

            using FileStream fs = new FileStream("log.txt", FileMode.Open);

            int bytesRead;
            while ((bytesRead = await fs.ReadAsync(buffer)) > 0)
            {
                // بخش خوانده‌شده از فایل رو داخل Memory قرار می‌دیم
                Memory<byte> memory = buffer.AsMemory(0, bytesRead);

                // متد async که نیاز به حافظه پایدار داره
                await ProcessLogAsync(memory);
            }
        }
        
         static async Task ProcessLogAsync(Memory<byte> memory)
    {
        await Task.Delay(10); // شبیه پردازش async
        string text = System.Text.Encoding.UTF8.GetString(memory.Span);
        Console.WriteLine(text);
    }
    }
}