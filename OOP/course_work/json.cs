using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

class JsonHandler
{
    private string filePath;

    public JsonHandler(string filePath)
    {
        this.filePath = filePath;

        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "{}");
        }
    }

    public void AddOrUpdateEntry(string key, bool value)
    {
        var jsonData = ReadJson();
        jsonData[key] = value;
        WriteJson(jsonData);
    }

    private Dictionary<string, bool> ReadJson()
    {
        var jsonContent = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<Dictionary<string, bool>>(jsonContent);
    }

    private void WriteJson(Dictionary<string, bool> jsonData)
    {
        var jsonContent = JsonConvert.SerializeObject(jsonData, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText(filePath, jsonContent);
    }

    public bool GetBoolValue(string key)
    {
        var jsonData = ReadJson();

        if (jsonData.ContainsKey(key))
        {
            return jsonData[key];
        }

        return false;
    }
}