using WorldCup;

public class Program
{
    public static void Main(string[] args)
    {
        Team argentina=new Team();

        string playerName=argentina[0].Name;
        Console.WriteLine("Player: "+ playerName);
        argentina[0].Name="Nirjala Naik";
        playerName=argentina[0].Name;
        Console.WriteLine("Player: "+ playerName);
        // argentina.DisplayPlayer();

        List<Player> portugal=new List<Player>();
        portugal.Add(new Player(1, "Cristiano Ronaldo", 7, "Forward", 41, "Portugal", 3000000m));
        portugal.Add(new Player(2, "Bruno Fernandes", 8, "Midfielder", 32, "Portugal", 2200000m));
        portugal.Add(new Player(3, "Bernardo Silva", 10, "Midfielder", 32, "Portugal", 2100000m));
        portugal.Add(new Player(4, "Rafael Leao", 17, "Winger", 27, "Portugal", 2000000m));
        portugal.Add(new Player(5, "Joao Felix", 11, "Forward", 27, "Portugal", 1800000m));
        portugal.Add(new Player(6, "Ruben Dias", 3, "Defender", 30, "Portugal", 1900000m));
        portugal.Add(new Player(7, "Pepe", 4, "Defender", 43, "Portugal", 900000m));
        portugal.Add(new Player(8, "Joao Cancelo", 20, "Right Back", 33, "Portugal", 1700000m));
        portugal.Add(new Player(9, "Nuno Mendes", 19, "Left Back", 24, "Portugal", 1600000m));
        portugal.Add(new Player(10, "Vitinha", 23, "Midfielder", 27, "Portugal", 1500000m));
        portugal.Add(new Player(11, "Diogo Costa", 1, "Goalkeeper", 28, "Portugal", 1400000m));
    

        foreach (Player players in portugal)
        {
            Console.WriteLine(players);
        }
    }
}