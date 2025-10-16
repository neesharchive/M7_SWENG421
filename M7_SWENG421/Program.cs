using System;

namespace NovelArchive
{
    internal static class Program
    {
        private static void Main()
        {
            var novel = new Novel();
            var page1 = new Page();
            novel.Add(page1);

            var col1 = new Column();
            var lot1 = new LineOfText();
            foreach (var ch in "SWENG") lot1.Add(new Character(ch));
            col1.Add(lot1);

            var frame1 = new Frame();
            var innerCol = new Column();
            var lot2 = new LineOfText();
            foreach (var ch in "421") lot2.Add(new Character(ch));
            innerCol.Add(lot2);
            frame1.Add(innerCol);

            page1.Add(col1);
            page1.Add(frame1);

            var writer = new Writer();
            Console.WriteLine(writer.View(novel)); // prints: SWENG421
        }
    }
}
