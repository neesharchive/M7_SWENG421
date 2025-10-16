using System;

namespace NovelArchive
{
    public sealed class Character : EntityBase, IColumnItem, IInlineItem
    {
        public char Value { get; }
        public Character(char c) : base("Character") { Value = c; }

        public override void Save() => Console.WriteLine("A character has been saved.");
        public override void Retrieve() => Console.WriteLine("A character has been retrieved.");
        public override string View() => Value.ToString();
        public override void Edit() => Console.WriteLine("A character has been edited.");
        public override void Delete() => Console.WriteLine("A character has been deleted.");
    }
}
