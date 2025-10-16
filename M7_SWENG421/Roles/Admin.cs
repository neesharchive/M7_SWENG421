namespace NovelArchive
{
    public sealed class Admin : RoleBase
    {
        public override bool CanSave => true;
        public override bool CanRetrieve => true;
        public override bool CanView => true;
        public override bool CanEdit => true;
        public override bool CanDelete => true;
    }
}
