namespace NovelArchive
{
    public sealed class Writer : RoleBase
    {
        public override bool CanSave => false;
        public override bool CanRetrieve => false;
        public override bool CanView => true;
        public override bool CanEdit => true;
        public override bool CanDelete => false;
    }
}
