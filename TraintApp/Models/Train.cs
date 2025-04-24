namespace TrainApp.Models
{
    class Train
    {
        List<Waggon> TrainComposition = new List<Waggon>();

        public void Add(int WaggonNumber, bool Lighting)
        {
            TrainComposition.Add(new Waggon
            {
                Number = WaggonNumber,
                Lighting = Lighting
            });
        }

        public void CreateTrain(int Size)
        {
            Random rnd = new Random();
            for (int i = 1; i <= Size; i++)
            {
                bool random = rnd.Next(2) == 0 ? false : true;
                Add(i, random);
            }
        }

        public List<Waggon> GetList()
        {
            return TrainComposition;
        }

    }
}
