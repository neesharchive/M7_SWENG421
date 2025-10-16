using System;
using System.Collections.Generic;

namespace NovelArchive
{
    public sealed class Frame : EntityBase, IPageItem, IColumnItem
    {
        private readonly List<IFrameItem> _items = new();

        public Frame() : base("Frame") { }

        public void Add(IFrameItem item) => _items.Add(item);

        public override void Save() => Console.WriteLine("A frame has been saved.");
        public override void Retrieve() => Console.WriteLine("A frame has been retrieved.");
        public override string View() => Compose(_items);
        public override void Edit() => Console.WriteLine("A frame has been updated.");
        public override void Delete() => Console.WriteLine("A frame has been deleted.");
    }
}
