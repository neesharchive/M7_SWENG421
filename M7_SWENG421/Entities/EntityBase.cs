using System.Text;
using System.Collections.Generic;

namespace NovelArchive
{
    public abstract class EntityBase : IEntity
    {
        protected readonly string Label;
        protected EntityBase(string label) => Label = label;

        public abstract void Save();
        public abstract void Retrieve();
        public abstract string View();
        public abstract void Edit();
        public abstract void Delete();

        protected string Compose<T>(IEnumerable<T> children) where T : IEntity
        {
            var sb = new StringBuilder();
            foreach (var c in children) sb.Append(c.View());
            return sb.ToString();
        }
    }
}
