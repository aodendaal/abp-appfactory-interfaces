namespace Abp.AppFactory.Interfaces
{
    public interface IAssessmentSkill
    {
        string Name { get; set; }
        int Points { get; set; }
        int TotalPoints { get; set; }
        double Score { get; set; }
    }
}