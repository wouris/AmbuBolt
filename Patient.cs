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

        [JsonPropertyName("Condition")]
        public string? Condition { get; set; }

        [JsonPropertyName("Age")]
        public int Age { get; set; }

        [JsonPropertyName("Diagnosis")]
        public string? Diagnosis { get; set; }

        [JsonPropertyName("Description")]
        public string? Description { get; set; }
    }

}
