namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Video game list
            var videoGames = new List<string>()
            {
                "Final Fantasy VII", "Dark Souls", "Elden Ring", 
                "Dragon Quest XI", "Xenogears", "Chrono Trigger", 
                "Legend of Legaia", "Shadow of the Colossus", "Brave Fencer Musashi", 
                "The Elder Scrolls: Morrowind"
            };

            videoGames.OrderByDescending(x => (x.Length)).ToList().ForEach(Console.WriteLine);
        }
    }
}
