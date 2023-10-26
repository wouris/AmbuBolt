using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AmbuBolt
{
    public class RestService
    {
        HttpClient client;
        JsonSerializerOptions serializerOptions;

        public List<Patient> patients { get;  set; }
        
        public RestService()
        {
            client = new HttpClient(); 

            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }

        //public async Task GetListOfPatients()
        //{
        //    string BaseAdress = (DeviceInfo.Platform == DevicePlatform.Android) ? "http://10.0.2.2:5293" : "http://localhost:5293";

        //    string Server = BaseAdress + "/api/Patient";

        //    Debug.WriteLine(Server);

        //    Uri uri = new Uri(Server);

        //}

        public async Task SendPatientInfo(Patient patient, bool isNewItem = false)
        { 
            string BaseAdress = (DeviceInfo.Platform == DevicePlatform.Android) ? "http://10.0.2.2:5293" : "http://localhost:5293";

            string Server = BaseAdress + "/api/Patient";

            Debug.WriteLine(Server);

            Uri uri = new Uri(Server);

            try
            {
                string json = JsonSerializer.Serialize(patient, serializerOptions);
                
                Debug.WriteLine($"{json}");

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;

                response = await client.PostAsync(uri, content);

                if (response.IsSuccessStatusCode) 
                {
                    Debug.WriteLine("Pog");
                }
                else
                {
                    Debug.WriteLine($"{response.StatusCode}");
                }
            }
            catch (Exception ex) 
            {
                Debug.WriteLine(ex.Message);
            }

        }

    }
}
