    // public class DataUtil
    // {
    //     public static void Main(string[] args)
    //     {
    //         var dataType = DateTime.Now;
    //         Console.WriteLine(dataType.GetType());
    //     }
    // }


    public class DataUtil
    {
        public static void Main(string[] args)
        {
            var today = DateTime.Now;
            var answer = today.AddDays(36);

            System.Console.WriteLine("Hoje é " +today.Day +"/" +today.Month +" - " +today.DayOfWeek);
            System.Console.WriteLine("Daqui a 36 dias será "+answer.Day +"/" +answer.Month +" - " +answer.DayOfWeek);
        }
    }