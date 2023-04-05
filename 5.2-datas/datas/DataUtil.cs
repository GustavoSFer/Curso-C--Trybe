    // public class DataUtil
    // {
    //     public static void Main(string[] args)
    //     {
    //         var dataType = DateTime.Now;
    //         Console.WriteLine(dataType.GetType());
    //     }
    // }

/* VERIFICANDO QUE DIA SERÁ APOS UM N DIAS INFORMADO EM ADD DAYS(DIAS)*/
    // public class DataUtil
    // {
    //     public static void Main(string[] args)
    //     {
    //         var today = DateTime.Now;
    //         var answer = today.AddDays(36);

    //         System.Console.WriteLine("Hoje é " +today.Day +"/" +today.Month +" - " +today.DayOfWeek);
    //         System.Console.WriteLine("Daqui a 36 dias será "+answer.Day +"/" +answer.Month +" - " +answer.DayOfWeek);
    //     }
    // }



        public class DataUtil
    {
        public static void Main(string[] args)
        {
            var today = System.DateTime.Now;
            var duration = new System.TimeSpan(-36, 0, 0, 0);
            var answer = today.Add(duration);

            System.Console.WriteLine("Hoje é " +today.Day +"/" +today.Month +" - " +today.DayOfWeek);
            System.Console.WriteLine("36 atrás era "+answer.Day +"/" +answer.Month +" - " +answer.DayOfWeek);
        }
    }
    