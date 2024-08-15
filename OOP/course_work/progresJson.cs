using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class ProgresJson
{
    private string filePath;
    private Dictionary<string, int> presetStructure = new Dictionary<string, int>
    {
        { "beginning_test_0_good", 0 },
        { "beginning_test_0_bad", 0 },
        { "beginning_test_1_good", 0 },
        { "beginning_test_1_bad", 0 },
        { "string_test_0_good", 0 },
        { "string_test_0_bad", 0 },
        { "string_test_1_good", 0 },
        { "string_test_1_bad", 0 },
        { "variable_test_0_good", 0 },
        { "variable_test_0_bad", 0 },
        { "variable_test_1_good", 0 },
        { "variable_test_1_bad", 0 }
    };

    public ProgresJson(string filePath)
    {
        this.filePath = filePath;

        if (!File.Exists(filePath))
        {
            WriteJson(presetStructure);
        }
    }

    public int GetValueByKey(string key)
    {
        var jsonData = ReadJson();

        if (jsonData.ContainsKey(key))
        {
            return jsonData[key];
        }

        throw new KeyNotFoundException($"Ключ '{key}' не знайдено у JSON файлі.");
    }

    public void AddValueToKey(string key, int value)
    {
        var jsonData = ReadJson();

        if (jsonData.ContainsKey(key))
        {
            jsonData[key] += value;
            WriteJson(jsonData);
        }
        else
        {
            throw new KeyNotFoundException($"Ключ '{key}' не знайдено у JSON файлі.");
        }
    }

    private Dictionary<string, int> ReadJson()
    {
        var jsonContent = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<Dictionary<string, int>>(jsonContent);
    }

    private void WriteJson(Dictionary<string, int> jsonData)
    {
        var jsonContent = JsonConvert.SerializeObject(jsonData, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText(filePath, jsonContent);
    }
}