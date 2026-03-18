using System.Collections.Generic;

namespace EvaluationForm;

public class Criterion
{
    public string Name { get; set; }
    public List<Grade> Grades { get; } = new List<Grade>();
    public int AtcensionID {get;set;}
    
    public Criterion(string name, int atcensionID, List<Grade> grades)
    {
        Name = name;
        AtcensionID = atcensionID;
        Grades = grades;
    }
}