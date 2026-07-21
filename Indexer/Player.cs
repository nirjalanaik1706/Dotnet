namespace WorldCup;

public class Player
{
    private int playerId;

    public Player(int playerId, string name, int jerseyNumber, string position, int age, string nationality, decimal salary)
    {
        PlayerId = playerId;
        Name = name;
        JerseyNumber = jerseyNumber;
        Position = position;
        Age = age;
        Nationality = nationality;
        Salary = salary;
    }

    public int PlayerId
    {
        get { return this.playerId; }
        set { this.playerId = value; }
    }

    public string Name { get; set; }
    public int JerseyNumber { get; set; }
    public string Position { get; set; }
    public int Age { get; set; }
    public string Nationality { get; set; }
    public decimal Salary { get; set; }

    public override string ToString()
    {
        return "Id = " + PlayerId +
            ", Player Name = " + Name +
            ", Jersey No. = " + JerseyNumber +
            ", Position = " + Position +
            ", Age = " + Age +
            ", Nationality = " + Nationality +
            ", Salary = " + Salary;
    }

}