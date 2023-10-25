using AmbuBolt.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Azure.Cosmos.Linq;

namespace AmbuBolt.Services
{
    public class PatientService : DbContext
    {
        private readonly Container _container;

        public PatientService(CosmosClient cosmosClient, string databaseName, string containerName)
        {
            _container = cosmosClient.GetContainer(databaseName, containerName);
        }

        public async Task<IEnumerable<Patient>> GetPatientsAsync()
        {
            var query = _container.GetItemLinqQueryable<Patient>();

            using FeedIterator<Patient> feed = query
                .OrderByDescending(p => p.InTransport)
                .ToFeedIterator();
            
            var results = new List<Patient>();
            while (feed.HasMoreResults)
            {
                var response = await feed.ReadNextAsync();
                results.AddRange(response.ToList());
            }
            return results;
        }

        public async Task<Patient> CreateArticleAsync(Patient patient)
        {
            var response = await _container.CreateItemAsync(patient, new PartitionKey(patient.Id));
            return response.Resource;
        }
    }
}
