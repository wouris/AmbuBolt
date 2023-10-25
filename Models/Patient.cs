using Newtonsoft.Json;

namespace AmbuBolt.Models
{
    public class Patient
    {
        [JsonProperty("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [JsonProperty("condition")]
        public string Condition { get; set; } = null!;

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("diagnosis")]
        public string Diagnosis { get; set; } = null!;

        [JsonProperty("description")]
        public string Description { get; set; } = null!;

        [JsonProperty("inTransport")]
        public DateTime InTransport { get; set; } = DateTime.UtcNow;
    }
}
