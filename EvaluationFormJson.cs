using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace EvaluationForm;

public static class EvaluationFormJson
{
    public static string Serialize<T>(T obj) => JsonSerializer.Serialize(obj);
    
    public static T Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json)!;
    
    public static void SerializeToFile<T>(T obj, string filePath)
    {
        string json = Serialize(obj);
        File.WriteAllText(filePath, json);
    }

    public static T DeserializeFromFile<T>(string filePath)
    {
        if (!File.Exists(filePath)) throw new FileNotFoundException($"File not found: {filePath}");
        
        string json = File.ReadAllText(filePath);
        return Deserialize<T>(json);
    }
}