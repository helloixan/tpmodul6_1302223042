using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo stv = new SayaTubeVideo("Tutorial Design By Contract - IKSAN OKTAV RISANDY");
        stv.PrintVideoDetails();

        // coba prekondisi
        stv.setTitle("");
        stv.IncreasePlayCount(100000000);

        // coba exception
        for (int i = 0; i <= 220;  i++)
        {
            stv.IncreasePlayCount(10000000);
        }

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
        setTitle(judul_video);
        this.playCount = 0;
        Random random = new Random();
        this.id = random.Next(10000, 99999);
    }

    public void IncreasePlayCount(int playTime) 
    {
        Debug.Assert(playTime <= 10000000, "setiap penambahan play count memiliki maksimal 10.000.000");
        try
        {
            int hasil = checked(this.playCount + playTime);
            this.playCount = hasil;
        } catch (Exception OverFlowException) {
            Console.WriteLine("Error: " + OverFlowException.Message);
        }
        
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Id: " + this.id);
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount + " Minutes");
    }

    public void setTitle(String judul_video)
    {
        Debug.Assert(judul_video.Length <= 100 && (judul_video != string.Empty && judul_video != null), "Judul tidak boleh kosong atau melebihi 100 karakter");
        this.title = judul_video;
    }
}