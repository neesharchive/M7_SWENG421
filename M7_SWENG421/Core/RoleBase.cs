using System;

namespace NovelArchive
{
    public interface IUserRole
    {
        bool CanSave { get; }
        bool CanRetrieve { get; }
        bool CanView { get; }
        bool CanEdit { get; }
        bool CanDelete { get; }

        void Save(IEntity e);
        void Retrieve(IEntity e);
        string View(IEntity e);
        void Edit(IEntity e);
        void Delete(IEntity e);
    }

    public abstract class RoleBase : IUserRole
    {
        public abstract bool CanSave { get; }
        public abstract bool CanRetrieve { get; }
        public abstract bool CanView { get; }
        public abstract bool CanEdit { get; }
        public abstract bool CanDelete { get; }

        public void Save(IEntity e) { if (!CanSave) throw new InvalidOperationException("Not allowed: Save"); e.Save(); }
        public void Retrieve(IEntity e) { if (!CanRetrieve) throw new InvalidOperationException("Not allowed: Retrieve"); e.Retrieve(); }
        public string View(IEntity e) { if (!CanView) throw new InvalidOperationException("Not allowed: View"); return e.View(); }
        public void Edit(IEntity e) { if (!CanEdit) throw new InvalidOperationException("Not allowed: Edit"); e.Edit(); }
        public void Delete(IEntity e) { if (!CanDelete) throw new InvalidOperationException("Not allowed: Delete"); e.Delete(); }
    }
}
