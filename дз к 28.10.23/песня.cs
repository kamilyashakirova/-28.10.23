using System;
class Song
{
    string name;
    string author;
    Song prev;

    public void Name(string name)
    {
        this.name = name;
    }

    public void Author(string author)
    {
        this.author = author;
    }

    public void Prev(Song prev)
    {
        this.prev = prev;
    }

    public void print()
    {
        Console.WriteLine($"{name} - {author}");
    }

    public string title()
    {
        return $"{name} - {author}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Song song = (Song)obj;
        return name == song.name && author == song.author;
    }
}