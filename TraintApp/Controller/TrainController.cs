namespace TrainApp.Controller
{
    class TrainController
    {
        private int TrainSize { get; set; }
        private Models.Train Train;

        public TrainController(int TrainSize)
        {
            this.TrainSize = TrainSize;
            Train = new Models.Train();
            Train.CreateTrain(this.TrainSize);
        }

        public int Count()
        {
            List<Models.Waggon> list = Train.GetList();
            int count = 0;

            list[0].Lighting = true; // включаем свет в стартовом вагоне                           
            for (int i = 1; i <= 500; i++)
            {
                count = i; //обновляем счётчик
                i = i == list.Count ? 0 : i; // обновляем i при достижения конца вагона
                list[i].Lighting = list[i].Lighting == true ? false : true; //если горит свет - выключаем


                if (list[0].Lighting == false)  //если в старновом вагоне выключен свет, цикл завершен
                {
                    return count;
                }
            }
            return count;
        }
    }
}
