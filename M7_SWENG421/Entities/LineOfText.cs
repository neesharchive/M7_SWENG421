using System;
using System.Collections.Generic;

namespace NovelArchive
{
    public sealed class LineOfText : EntityBase, IColumnItem
    {
        private readonly List<IInlineItem> _inlines = new();

        public LineOfText() : base("LineOfText") { }

        public void Add(IInlineItem inline) => _inlines.Add(inline);

        public override void Save() => Console.WriteLine("A line of text has been saved.");
        public override void Retrieve() => Console.WriteLine("A line of text has been retrieved.");
        public override string View() => Compose(_inlines);
        public override void Edit() => Console.WriteLine("A line of text has been updated.");
        public override void Delete() => Console.WriteLine("A line of text has been deleted.");
    }
}
