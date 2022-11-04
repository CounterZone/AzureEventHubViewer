using AzureEventHubViewer.Services.Contract;
using AzureEventHubViewer.Services.Config;
using Azure.Messaging.EventHubs;
using System;
using System.Text;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs.Producer;

namespace AzureEventHubViewer.Services.EventHubClientService

{
    public class EventHubClientService:IEventHubClientService
    {
        private IEHConfig _config;
        public EventHubClientService(IEHConfig config) {
            _config = config;
        }

        public void Config(IEHConfig config) {
            _config = config;
        }

        public Task<IEnumerable<EventData>> ReadAsync() {
            throw new NotImplementedException();
        }

        public async Task SendAsync(string message, IDictionary<string, string>? properties) {
            await using (var _client = new EventHubProducerClient(_config.ConnectionString, _config.EHName)) { 
                
            }
        }
    }
}