namespace ClassWork_27_04_FilesJson;

public class Note
{
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime CreatedAt { get; set; }

    public Note()
    {
    }

    public Note(string title, string text)
    {
        Title = title;
        Text = text;
        CreatedAt = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Title}: {Text} ({CreatedAt})";
    }
}
