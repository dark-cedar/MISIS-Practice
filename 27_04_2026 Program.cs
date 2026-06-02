using ClassWork_27_04_FilesJson;

class Program
{
    static void Main()
    {
        string folder = "data";
        FileTasks.CreateFolder(folder);

        string textPath = Path.Combine(folder, "info.txt");
        FileTasks.WriteText(textPath, "Это обычный текстовый файл для практики.");

        Console.WriteLine("Текст из файла:");
        Console.WriteLine(FileTasks.ReadText(textPath));

        List<Note> notes = new List<Note>();
        notes.Add(new Note("Пара", "Разобрали файлы и json"));
        notes.Add(new Note("Домашка", "Доделать методы"));

        string jsonPath = Path.Combine(folder, "notes.json");
        FileTasks.SaveNotes(jsonPath, notes);

        Console.WriteLine();
        Console.WriteLine("Заметки из json:");
        List<Note> loaded = FileTasks.LoadNotes(jsonPath);
        for (int i = 0; i < loaded.Count; i++)
            Console.WriteLine(loaded[i]);

        Console.WriteLine();
        Console.WriteLine("Файлы в папке data:");
        FileTasks.PrintFiles(folder);
    }
}
