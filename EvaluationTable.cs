namespace EvaluationForm;

public class EvaluationTable
{
    public int Id { get; set; }
    public string Description { get; set; }

    public EvaluationTable(int id, string description)
    {
        Id = id;
        Description = description;
    }
}