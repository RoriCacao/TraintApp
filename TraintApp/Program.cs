namespace TrainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int rand;
            Random r = new Random();
            rand = r.Next(1, 500); //лимит 500 вагонов

            Controller.TrainController train = new Controller.TrainController(rand);

            Console.WriteLine("Кол-во вагонов = " + train.Count());
            Console.ReadKey();

        }
    }
}
