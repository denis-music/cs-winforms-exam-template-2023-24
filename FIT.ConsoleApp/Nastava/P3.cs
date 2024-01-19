using FIT.Data;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static FIT.ConsoleApp.Nastava.P3;

namespace FIT.ConsoleApp.Nastava
{

    public class AppData
    {
        public const string Naziv = "FITApp";
        public readonly string Autor;

        public AppData(string autor) 
        {
            Autor = autor;
        }
        public override string ToString()
        {           
            return base.ToString();
        }
    }
    public interface ISMSServis
    {
        bool Posalji(string broj, string poruka);
        bool Dostupan(string broj);
    }
    public class BHTelecomSMSServis : ISMSServis
    {
        public bool Dostupan(string broj) { return true; }

        public bool Posalji(string broj, string poruka)
        {
            Console.WriteLine($"BHTELECOM -> {broj}: {poruka}");
            return true;

        }
    }
    public class TestSMSServis : ISMSServis
    {
        public bool Dostupan(string broj) { return true; }

        public bool Posalji(string broj, string poruka)
        {
            Console.WriteLine($"TestSMSServis -> {broj}: {poruka}");
            return true;

        }
    }

    public interface ILogger { 
        void Log(string message);
    }
    public class FileLogger : ILogger
    {
        const string Putanja = @"C:\logs\log.txt";
        public void Log(string poruka)
        {
            Console.WriteLine($"FILE LOG {Putanja} -> {poruka}");
        }
    }
    public class DBLogger : ILogger
    {
        const string Putanja = @"Server=192.168.1.18;database=Logger;user=denis;pass=test";
        public void Log(string poruka)
        {
            Console.WriteLine($"DB LOG {Putanja} -> {poruka}");
        }
    }



    public class P3
    {      

        public static void Pokreni()
        {
            //Var();
            //Imutabilnost();
            //Params();
            //Indekseri();
            //Nasljedjivanje();
            Interfejsi();
        }

        private static void Interfejsi()
        {
            //ISMSServis bhtelecom = new BHTelecomSMSServis();
            //ISMSServis testServis = new TestSMSServis();
            //ILogger logger = new DBLogger();
            //P3_1.Pokreni(bhtelecom, logger);          

            cStudent denis = new cStudent("IB150051","Denis","Music");
            foreach (var ocjena in denis)//denis.GetEnumerator()
            {
                Console.WriteLine(ocjena);
            }

            using (cStudent denis2 = new cStudent("IB150051", "Denis", "Music"))
            {

            }//denis2.Dispose()
        }
        private static void Nasljedjivanje()
        {
            //Osoba denis = new Osoba("Denis","Music");
            Osoba jasmin = new cStudent("IB150051", "Denis", "Music");
            //OsobaInfo(denis);
            OsobaInfo(jasmin);

        }

        private static void OsobaInfo(Osoba osoba)
        {
            if (osoba is cStudent)
            {
                cStudent student1 = (cStudent)osoba;
                cStudent student2 = osoba as cStudent; //dynamic_cast<Student*>(osoba)

                Console.WriteLine(student2);
            }else
                Console.WriteLine(osoba);
        }

        private static void Indekseri()
        {
            cStudent denis = new cStudent();
            Console.WriteLine(denis[1]);
        }

        private static void Params()
        {
            Console.WriteLine($"Suma1 -> {Sumiraj(new int[] { 2, 6, 9, 8, 22, 66 })}");
            Console.WriteLine($"Suma2 -> {Sumiraj( 2, 6, 9, 8, 22, 66, 1 ,55 )}");

            var noviString = string.Join(" - ", 2, 6, 9, "FIT", 22);
            Console.WriteLine(noviString);
        }

        private static int Sumiraj(params int[] niz)
        {
            int suma = 0;
            for (int i = 0; i < niz.Length; i++)
                suma += niz[i];
            return suma;

            //return niz.Sum();
        }       

        private static void Imutabilnost()
        {            
            string fit = "Fakultet informacijskih tehnologija";
            fit = fit.ToUpper();
            Console.WriteLine(fit);

            DateTime danas = DateTime.Now;
            var za156dana = danas.AddDays(156);
            Console.WriteLine(danas);
            Console.WriteLine(za156dana);

        }

        private static void Var()
        {
            int a = 0;
            var b = 0;
            var denis = new cStudent();
            var ime = "Denis";

            cStudent jasmin = new ();
            Osoba zanin = new cStudent();


            var ex = new SynchronizationLockException();
            string[] podaci = GetPodatkeByGodina(1);

        }

        private static string[] GetPodatkeByGodina(int v)
        {

            return new string[] { "" };
        }
    }

}
