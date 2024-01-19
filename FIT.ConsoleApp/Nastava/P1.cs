using FIT.Data;

namespace FIT.ConsoleApp.Nastava
{
    public class P1
    {
        public static void Pokreni()
        {
            //TipoviPodataka();
            //Pokazivaci();
            //Klase();
            VrsteTipova();
        }

        private static void VrsteTipova()
        {
            int indeks1 = 0;//VALUE
            int indeks2 = new int();
            if(indeks1==230032)
                Console.WriteLine("Student Denis Music");
            if (indeks2 == 230032)
                Console.WriteLine("Student Denis Music");

            int a = 10;
            int b = a;

            //REFERENCE
            Predmet prII_1 = new Predmet();
            Predmet prII_2 = prII_1;

            prII_2.Semestar = 4;




        }
        private static void Klase()
        {
            Predavanje prIII = new Predavanje(godina: 2, tema:"C# intro");
            prIII.Tema += " u WinForms";
            prIII.Godina = 1;//value

            Console.WriteLine($"{prIII.Tema} na {prIII.Godina}. godini studija");

            Predmet prII = new Predmet()
            {
                Naziv = "Programiranje II",
                Semestar = 1
            };
        }
        private static void Pokazivaci()
        {
            int indeks = 220022;
            unsafe
            {
                int* pIndeks = &indeks;
                *pIndeks = 66;
            }
        }
        private static void TipoviPodataka()
        {
            int indeks = 220022;
            string naziv = "Programiranje III";
            bool aktivan = true;

            Console.WriteLine(indeks + " " + naziv +" " + aktivan);
            Console.WriteLine($"{indeks} je polozi {naziv} i student je aktivan {aktivan}");

        }
    }
}
