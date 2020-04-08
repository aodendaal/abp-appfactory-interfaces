namespace Abp.AppFactory.Interfaces
{
    public interface IAssessmentTask
    {
        int Score { get; set; }
        int MaxScore { get; set; }
        string ReplayUrl { get; set; }
    }
}