using System;
using System.Collections.Generic;

namespace NovelArchive
{
    public sealed class Novel : EntityBase
    {
        private readonly List<Page> _pages = new();

        public Novel() : base("Novel") { }

        public void Add(Page p) => _pages.Add(p);

        public override void Save() => Console.WriteLine("The novel has been saved.");
        public override void Retrieve() => Console.WriteLine("The novel has been retrieved.");
        public override string View() => Compose(_pages);
        public override void Edit() => Console.WriteLine("The novel has been edited.");
        public override void Delete() => Console.WriteLine("The novel has been deleted.");
    }
}
