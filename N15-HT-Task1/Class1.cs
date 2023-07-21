namespace N15_HT_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            WheatherReportServer obj = new WheatherReportServer();
            obj.Add(new DateOnly(2023, 7, 13), "Sovuq -25^");
            obj.Add(new DateOnly(2023, 7, 14), "Issiq +40^");
            obj.Add(new DateOnly(2023, 7, 15), "Iliq +20^");
            obj.Add(new DateOnly(2023, 7, 16), "Sovuq -5^");
            obj.Add(new DateOnly(2023, 7, 17), "Issiq +50^");
            obj.Add(new DateOnly(2023, 7, 18), "Iliq +20^");
            obj.Get(new DateOnly(2023, 7, 13));
            obj.Get(new DateOnly(2023, 10, 23));
        }
    }




    public class WheatherReportServer
    {
        protected Dictionary<DateOnly, string> weatherinformationlist = new Dictionary<DateOnly, string>();
        public WheatherReportServer()
        {

        }

        public string Get(DateOnly dates)
        {
            return Find(dates) == null ? "Berilgan kunga ob-havo topilmadi, boshqa kunlar uchun qidiirb ko'ring" : Find(dates);
        }

        private string Find(DateOnly dates)
        {
            foreach(var item in weatherinformationlist)
            {
                if (dates == item.Key)
                {
                     return item.Value;
                }
            }
            return null;
        }

        public void Add(DateOnly dates, string obhavo)
        {
            weatherinformationlist[dates] = obhavo;
        }
    }
}