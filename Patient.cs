using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AmbuBolt
{
    
public class Patient
    {
        public Patient()
        {
        }

        public Patient(string Condition, int Age, string Diagnosis, string Description)
        {
            this.Condition = Condition;
            this.Age = Age;
            this.Diagnosis = Diagnosis;
            this.Description = Description;
        }

        [JsonPropertyName("condition")]
        public string? Condition { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("diagnosis")]
        public string? Diagnosis { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        public override string ToString()
        {
            return $"Condition: {Condition ?? "N/A"}, Age: {Age}, Diagnosis: {Diagnosis ?? "N/A"}, Description: {Description ?? "N/A"}";
        }

    }
}
