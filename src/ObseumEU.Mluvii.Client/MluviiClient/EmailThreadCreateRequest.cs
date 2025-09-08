using System.Text.Json.Serialization;

namespace ObseumEU.Mluvii.Client
{
    public class EmailThreadCreateRequest
    {
        [JsonPropertyName("inboxId")] public int InboxId { get; set; }

        [JsonPropertyName("operatorUserId")] public int? OperatorUserId { get; set; }

        [JsonPropertyName("contactId")] public long? ContactId { get; set; }

        [JsonPropertyName("clientEmails")] public List<string> ClientEmails { get; set; } = new();

        [JsonPropertyName("subject")] public string Subject { get; set; } = string.Empty;

        [JsonPropertyName("body")] public string Body { get; set; } = string.Empty;
    }
}

