public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo stv = new SayaTubeVideo("Tutorial Design By Contract - IKSAN OKTAV RISANDY");
        stv.PrintVideoDetails();
        stv.IncreasePlayCount(7);
        stv.PrintVideoDetails();
    }
}

public class SayaTubeVideo
{
    private int id;
    private String title;
    private int playCount;

    public SayaTubeVideo(String judul_video)
    {
        this.title = judul_video;
        this.playCount = 0;
        Random random = new Random();
        this.id = random.Next(10000, 99999);
    }

    public void IncreasePlayCount(int playTime) 
    {
        this.playCount += playTime;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Id: " + this.id);
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount + " Minutes");
    }
}