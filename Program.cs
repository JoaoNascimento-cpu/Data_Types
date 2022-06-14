using System;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            /*MÉTODOS PARA VIZUALIZAÇÃO DA DATA*/
            // Console.Clear();
            // var data = DateTime.Now;
            
            // var dia = data;
            // Console.WriteLine(data);

            // Console.WriteLine(data.AddDays(25));
            // Console.WriteLine(data.AddMonths(1));
            // Console.WriteLine(data.AddYears(1));

            /*Comparando datas*/

            // Console.Clear();

            // var data = DateTime.Now;

            // if (data.Date >= DateTime.Now.Date)
            // {
            //     Console.WriteLine("é igual");
            // }

            // Console.WriteLine(data);

            /*CultureInfo*/

            // Console.Clear();

            // var pt = new CultureInfo("pt-PT");
            // var br = new CultureInfo("pt-BR");
            // var en = new CultureInfo("en-US");
            // var de = new CultureInfo("de-DE");

            // Console.WriteLine(DateTime.Now.ToString("D", en));
            // Console.WriteLine(DateTime.Now.ToString("D", br));
            // Console.WriteLine(DateTime.Now.ToString("D", pt));
            // Console.WriteLine(DateTime.Now.ToString("D", de));

            /*TimeZone*/

            Console.Clear();

            var utcDate = DateTime.UtcNow;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(utcDate);

            Console.WriteLine(utcDate.ToLocalTime());

            var fusoAustralia = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time"); //pega id da lista de TimeZone
            Console.WriteLine(fusoAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, fusoAustralia); //Mostra o horário atual do fuso horário
            Console.WriteLine(horaAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("---------------------------");
            }

            /*TimeSpan*/

            // Console.Clear();

            // var timeSpan = new TimeSpan();
            // Console.WriteLine(timeSpan);

            // var nanosegundo = new TimeSpan(1);
            // Console.WriteLine(nanosegundo);
            
            // var horaMinutoSegundo = new TimeSpan(5, 12, 16);
            // Console.WriteLine(horaMinutoSegundo);
        }
    }
}
