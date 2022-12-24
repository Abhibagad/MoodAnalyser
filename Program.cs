namespace MoodAnalizer
{
    internal class Program
    {
        public static void main()
        {
            Console.WriteLine("Sad or Happy");
            string input = Console.ReadLine();

            MoodAnalyserClass analyse = new MoodAnalyserClass("input");
           
            Console.WriteLine(analyse.AnalyseMood());
        }      
    }
}