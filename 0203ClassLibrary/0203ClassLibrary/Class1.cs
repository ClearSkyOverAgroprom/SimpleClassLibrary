using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace _0203ClassLibrary;

public class FileManager
{
    public static string GetContent(string path)
    {
        return File.ReadAllText(path);
    }

    public static void WriteContent(string path, string content)
    {
        File.WriteAllText(path, content);
    }

    public static object GetContentJson(string path)
    {
        string json = File.ReadAllText(path);
        object generic = JsonSerializer.Deserialize<object>(json);
        return generic;
    }

    public static void WriteContentJson<T>(string path, T content)
    {
        var contentJson = JsonSerializer.Serialize(content);
        File.WriteAllText(path, contentJson);
    }
}

