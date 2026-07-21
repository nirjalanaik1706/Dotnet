namespace WorldCup;

public class Team
{
    private Player[] players=new Player[11];

    public Team()
    {
        players[0] = new Player(1, "Lionel Messi", 10, "Forward", 39, "Argentina", 2500000m);
        players[1] = new Player(2, "Julian Alvarez", 9, "Forward", 26, "Argentina", 1200000m);
        players[2] = new Player(3, "Lautaro Martinez", 22, "Striker", 29, "Argentina", 1500000m);
        players[3] = new Player(4, "Enzo Fernandez", 24, "Midfielder", 25, "Argentina", 1800000m);
        players[4] = new Player(5, "Rodrigo De Paul", 7, "Midfielder", 32, "Argentina", 1400000m);
        players[5] = new Player(6, "Cristian Romero", 13, "Defender", 28, "Argentina", 1600000m);
        players[6] = new Player(7, "Nicolas Otamendi", 19, "Defender", 38, "Argentina", 1000000m);
        players[7] = new Player(8, "Nahuel Molina", 16, "Right Back", 28, "Argentina", 1100000m);
        players[8] = new Player(9, "Alexis Mac Allister", 20, "Midfielder", 28, "Argentina", 1700000m);
        players[9] = new Player(10, "Angel Di Maria", 11, "Winger", 38, "Argentina", 900000m);
        players[10] = new Player(11, "Emiliano Martinez", 23, "Goalkeeper", 34, "Argentina", 1300000m);
    }

    public Player this[int index]
    {
        get
        {
            return players[index];
        }
        set
        {
            players[index]=value;
        }
    }

    public void DisplayPlayer()
    {
        foreach(Player theplayer in players)
        {
            Console.WriteLine(theplayer.Name);
        }
    }
}