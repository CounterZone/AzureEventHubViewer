using Azure.Messaging.EventHubs;

namespace AzureEventHubViewer.Services.Contract {
    public interface IEventHubClientService {
        Task SendAsync(string message, IDictionary<string,string>? properties);
        Task<IEnumerable<EventData>> ReadAsync();
    }
}
