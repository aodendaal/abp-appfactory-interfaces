namespace Abp.AppFactory.Interfaces
{
    public interface IEmail
    {
        string SenderEmailAddress { get; set; }
        string SenderName { get; set; }
        string SubjectContent { get; set; }
        string BodyTextContent { get; set; }
        string BodyHtmlContent { get; set; }
        string RecepientEmailAddress { get; set; }
        string RecepientName { get; set; }
    }
}