using System;
using System.Collections.Generic;

namespace NovelArchive
{
    public sealed class Page : EntityBase
    {
        private readonly List<IPageItem> _items = new();

        public Page() : base("Page") { }

        public void Add(IPageItem item) => _items.Add(item);

        public override void Save() => Console.WriteLine("A page has been saved.");
        public override void Retrieve() => Console.WriteLine("A page has been retrieved.");
        public override string View() => Compose(_items);
        public override void Edit() => Console.WriteLine("A page has been updated.");
        public override void Delete() => Console.WriteLine("A page has been deleted.");
    }
}
