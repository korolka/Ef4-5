namespace DAL_V2.Entity
{
    public class Word : BaseEntity
    {
        public string? Header { get; set; }
        public string Keyword { get; set; }

        public List<KeyParams> ProductLinks { get; set; } = new List<KeyParams>();
    }
}