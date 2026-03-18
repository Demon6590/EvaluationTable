using System;

namespace EvaluationForm;

public class Expert
{
    public string LastName
    {

        get { return field;}
        init{
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
            
        field = value.Trim();
        } 
    }
    public string FirstName { 
        get{return field;}     
        init
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
            
        field = value.Trim();   
    } }

    public string? Patronicum
    {
        get;
        init
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(value);
            
            field = value.Trim();   
        }
    }

    public Expert(string lastName, string firstName, string? patronicum)
    {
        LastName = lastName;
        FirstName = firstName;
        Patronicum = patronicum;
    }
    
    
}