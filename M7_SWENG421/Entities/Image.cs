using System;

namespace NovelArchive
{
    public sealed class Image : EntityBase, IColumnItem, IFrameItem, IInlineItem
    {
        public string Alt { get; }
        public Image(string alt = "[img]") : base("Image") { Alt = alt; }

        public override void Save() => Console.WriteLine("An image has been saved.");
        public override void Retrieve() => Console.WriteLine("An image has been retrieved.");
        public override string View() => ""; // images do not contribute to text
        public override void Edit() => Console.WriteLine("An image has been edited.");
        public override void Delete() => Console.WriteLine("An image has been deleted.");
    }
}
