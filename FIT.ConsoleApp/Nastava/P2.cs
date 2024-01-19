using FIT.Data;
using FIT.Infrastructure;

using System;

namespace FIT.ConsoleApp.Nastava
{

    public class P2
    {
        public static void Pokreni()
        {
            //BazniTip();
            //Override();
            //Slojevi();
            //VrijednostiReference();
            //Nizovi();
            //PodrazumijevaneVrijednosti();
            ProvjeraNullVrijednosti();
        }

        private static void ProvjeraNullVrijednosti()
        {
            StudentService studentService = new StudentService();
            cStudent student = studentService.GetByBrojIndeksa("IB220022");
            //student?.Semestri[1]?.Uplate[3]?.Iznos            
            Console.WriteLine(student?.Prezime);
            // uslov_ispunjen ? DA : NE;
            string ime = student?.Ime ?? "<NOT SET>" ;


        }
        private static void PodrazumijevaneVrijednosti()
        {
            cStudent denis = null;
            denis.Indeks = "IB230032";
            cStudent jasmin = new cStudent();
            jasmin.Indeks = "IB230032";

            int ? a = null;
            Nullable<int> godina = null;
            if(godina.HasValue)
                Console.WriteLine(godina.Value);
        }
        private static void Nizovi()
        {
            int[] ocjene = new int[3];
            ocjene[0] = 1;

            sStudent[] prvaGodina = new sStudent[3];
            cStudent[] drugaGodina = new cStudent[3];

            for (int i = 0; i < prvaGodina.Length; i++)
            {
                prvaGodina[i].Indeks = $"IB{230000 + i}";
                prvaGodina[i].Ime = $"Ime{i}";
                prvaGodina[i].Prezime = $"Prezime{i}";
            }
            for (int i = 0; i < drugaGodina.Length; i++)
            {
                drugaGodina[i] = new cStudent();
                drugaGodina[i].Indeks = $"IB{230000 + i}";
                drugaGodina[i].Ime = $"Ime{i}";
                drugaGodina[i].Prezime = $"Prezime{i}";
                drugaGodina[i].Fakultet = null;

            }


        }
        private static void VrijednostiReference()
        {
            cStudent denis1 = new cStudent() { Indeks = $"IB{230000}", Ime = $"Ime", Prezime = $"Prezime" };
            cStudent denis2 = denis1;
            denis2.Indeks = "IB230032";
            Console.WriteLine(denis1);
            Console.WriteLine(denis2);


            sStudent jasmin1 = new sStudent() { Indeks = $"IB{230000}", Ime = $"Ime", Prezime = $"Prezime" };
            sStudent jasmin2 = jasmin1;
            jasmin2.Indeks = "IB230032";
            Console.WriteLine(jasmin1);
            Console.WriteLine(jasmin2);
        }
        private static void Slojevi()
        {
            StudentService studentService = new StudentService();
            cStudent student = studentService.GetByBrojIndeksa("IB220022");
            Console.WriteLine(student);
        }
        private static void Override()
        {
            cStudent denis = new cStudent();           

            Console.WriteLine(denis);
            Console.WriteLine(denis.ToString());

        }
        private static void BazniTip()
        {
            int godina = 2023;
            cStudent denis = new cStudent();

            object oGodina = godina;
            object oDenis = denis;
            FromObject(denis);
            FromObject(godina);
        }
        private static void FromObject(object obj)
        {
            if(obj is cStudent)
            { 
               (obj as cStudent).PredstaviSe();
            }
            else if (obj is int)
                Console.WriteLine("Int");

        }
    }

}
