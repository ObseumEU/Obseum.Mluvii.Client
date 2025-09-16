using mluvii.ApiModels.Sessions;
using mluvii.ApiModels.Contacts;

namespace ObseumEU.Mluvii.Client
{
    public interface IMluviiClient
    {
        Task<HttpResponseMessage> AddContactToCampaign(int campaignId, List<int> contactIds);
        Task<(List<SessionModel> value, HttpResponseMessage response)> GetSessions(DateTime? startedFrom = null, DateTime? startedTo = null, DateTime? endedFrom = null, DateTime? endedTo = null, string[] channel = null, string[] source = null, bool verbose = false, int limit = 10000, int? offset = null, string[] status = null);
        Task GetSessionsPaged(Func<(List<SessionModel> value, HttpResponseMessage response), Task> pageAction, DateTime? startedFrom = null, DateTime? startedTo = null, DateTime? endedFrom = null, DateTime? endedTo = null, string[] channel = null, string[] source = null, bool verbose = false, int limit = 200, string[] status = null, int delayMilliseconds = 200);
        Task<(SessionModel? value, HttpResponseMessage response)> GetSession(long sessionId);
        Task<HttpResponseMessage> CreateEmailThread(EmailThreadCreateRequest request);
        Task<(List<int> value, HttpResponseMessage response)> CreateContacts(IEnumerable<Dictionary<string, List<string>>> contacts, int? departmentId = null);
        Task<(List<int> value, HttpResponseMessage response)> CreateContact(Dictionary<string, List<string>> contact, int? departmentId = null);
        Task<(List<ContactModel>? value, HttpResponseMessage response)> GetContacts(int? departmentId = null, string? filterField = null, string? filterValue = null, int limit = 10, int? offset = null);
        Task<long?> FindContactId(int departmentId, string filterField, string filterValue);
        Task<HttpResponseMessage> UpdateContact(long id, Dictionary<string, List<string>> contactData);
    }
}
