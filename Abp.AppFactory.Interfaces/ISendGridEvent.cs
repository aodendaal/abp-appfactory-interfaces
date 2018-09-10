namespace Abp.AppFactory.Interfaces
{
    public interface ISendGridEvent
    {
        string Email { get; set; }
        int? Timestamp { get; set; }
        string Event { get; set; }
        string SMTP_Id { get; set; }
        string UserAgent { get; set; }
        string IP { get; set; }
        string SG_Event_Id { get; set; }
        string SG_Message_Id { get; set; }
        string Reason { get; set; }
        string Status { get; set; }
        string Response { get; set; }
        bool? TLS { get; set; }
        string URL { get; set; }
        int? Attempt { get; set; }
        string Category { get; set; }
        string ASM_Group_Id { get; set; }
        string Unique_Args { get; set; }
        string Custom_Args { get; set; }
    }
}