using System.Text.Json;

namespace ClassWork_27_04_FilesJson;

public static class FileTasks
{
    public static void CreateFolder(string folder)
    {
        if (!Directory.Exists(folder))
            Directory.CreateDirectory(folder);
    }

    public static void WriteText(string path, string text)
    {
        File.WriteAllText(path, text);
    }

    public static string ReadText(string path)
    {
        if (!File.Exists(path))
            return "";

        return File.ReadAllText(path);
    }

    public static void SaveNotes(string path, List<Note> notes)
    {
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.WriteIndented = true;

        string json = JsonSerializer.Serialize(notes, options);
        File.WriteAllText(path, json);
    }

    public static List<Note> LoadNotes(string path)
    {
        if (!File.Exists(path))
            return new List<Note>();

        string json = File.ReadAllText(path);
        List<Note>? notes = JsonSerializer.Deserialize<List<Note>>(json);

        if (notes == null)
            return new List<Note>();

        return notes;
    }

    public static void PrintFiles(string folder)
    {
        string[] files = Directory.GetFiles(folder);
        for (int i = 0; i < files.Length; i++)
            Console.WriteLine(files[i]);
    }
}
