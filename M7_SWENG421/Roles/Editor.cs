namespace NovelArchive
{
    public sealed class Editor : RoleBase
    {
        public override bool CanSave => true;
        public override bool CanRetrieve => true;
        public override bool CanView => false;
        public override bool CanEdit => false;
        public override bool CanDelete => true;
    }
}
