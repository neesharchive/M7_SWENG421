using System;

namespace NovelArchive
{
    public interface IEntity
    {
        void Save();
        void Retrieve();
        string View();
        void Edit();
        void Delete();
    }
}
