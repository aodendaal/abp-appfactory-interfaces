namespace Abp.AppFactory.Interfaces
{
    public interface ISendGridEmail: IEmail
    {
        string SenderEmailAddress { get; set; }
    }
}