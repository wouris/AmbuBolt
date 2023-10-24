namespace AmbuBolt.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Condition { get; set; } = null!;
        public string Age { get; set; } = null!;
        public string Diagnosis { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
