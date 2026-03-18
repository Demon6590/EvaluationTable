using System;

namespace EvaluationForm;

public class Grade
{
    public int Number
    {
        get { return field;}
        init
        {
            if(value<0) throw new ArgumentException("Value must be greater than zero");
            field = value;
        }
    }

    public string Description
    {
        get{return field;}
        init
        {
            if(value==null) throw new ArgumentException("Value must be greater than zero");   
        }
    }
    public Grade(int number, string description)
    {
        Number = number;
        Description = description;
    }
}