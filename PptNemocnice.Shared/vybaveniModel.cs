namespace PptNemocnice.Shared
{
    public class VybaveniModel
    {
        public string Name { get; set; }
        public DateTime BoughtDate { get; set; }
        public DateTime LastRevisionDate { get; set; }
        public bool NeedRevision => DateTime.Now - LastRevisionDate > TimeSpan.FromDays(365 * 2);

        public bool IsInEditMode { get; set; }

        public VybaveniModel(string name, DateTime bought, DateTime revision)
        {
            Name = name;
            BoughtDate = bought;
            LastRevisionDate = revision;
           
        }
    }
}
