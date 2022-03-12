namespace TretiHodina
{
    public class VybaveniModel
    {

        public string Name { get; set; }
        public DateTime BoughtDate { get; set; }
        public DateTime LastRevisionDate { get; set; }
        public bool NeedRevision { get; }

        public VybaveniModel(string name, DateTime bought, DateTime revision, bool needRevision)
        {
            Name = name;
            BoughtDate = bought;
            LastRevisionDate = revision;
            NeedRevision = needRevision;
        }

    }
}
