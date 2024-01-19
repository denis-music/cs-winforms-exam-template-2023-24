using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static FIT.ConsoleApp.Nastava.P3;

namespace FIT.ConsoleApp.Nastava
{
    public class P3_1
    {
        static ISMSServis _sms;
        static ILogger _logger;

        public static void Pokreni(ISMSServis servis, ILogger logger)
        {
            _sms = servis;
            _logger = logger;
            Metoda1();
            Metoda2();
        }

        private static void Metoda1()
        {
            _sms.Posalji("061223322", "Korisnik  pozvao Metodu 1");
            _logger.Log("Poslata poruka iz Metode 1");
        }
        private static void Metoda2()
        {
            try
            {
                throw new Exception("Namjeran exception :)");
                //_sms.Posalji("061223322", "Korisnik  pozvao Metodu 2");
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
            }
         
        }
    }
}
