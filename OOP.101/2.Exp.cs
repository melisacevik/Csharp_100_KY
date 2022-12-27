internal class Program
{
    private static void Main(string[] args)
    {
        LaLakersTeam laLakersTeam = new LaLakersTeam();

        laLakersTeam.Leauge = "NBA";
        laLakersTeam.Founded = 1947;
        laLakersTeam.Location = "Los Angeles, California";
        laLakersTeam.TeamColour = "purple, gold, black";
        laLakersTeam.HeadCoach = "Darvin Ham";
        laLakersTeam.Championships = 18;
        laLakersTeam.DreamTeam = "Kobe Bryant, Steve Nash, Pau Gasol, Shaq ";



        Console.WriteLine("League of team: " + laLakersTeam.Leauge + " Colours of team: " + laLakersTeam.TeamColour);

        Console.ReadKey();




    }
    public class LaLakersTeam
    {

        public string Leauge { get; set; }
        public int Founded = 1947;
        public string Location { get; set; }
        public string TeamColour { get; set; }
        public string HeadCoach { get; set; }
        public int Championships { get; set; }
        public string DreamTeam { get; set; }


    }

}