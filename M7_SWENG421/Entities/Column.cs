using System;
using System.Collections.Generic;

namespace NovelArchive
{
    // IMPORTANT: Column does NOT implement IColumnItem, so it cannot directly contain another Column
    public sealed class Column : EntityBase, IPageItem, IFrameItem
    {
        private readonly List<IColumnItem> _items = new();

        public Column() : base("Column") { }

        public void Add(IColumnItem item) => _items.Add(item);

        public override void Save() => Console.WriteLine("One column has been saved.");
        public override void Retrieve() => Console.WriteLine("One column has been retrieved.");
        public override string View() => Compose(_items);
        public override void Edit() => Console.WriteLine("One column is updated.");
        public override void Delete() => Console.WriteLine("One column has been deleted.");
    }
}
