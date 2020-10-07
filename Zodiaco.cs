using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SignoZodiaco
{
    public class Zodiaco
    {
        private int mes_nacimiento;
        private int dia_nacimiento;
        private string signo_zodiaco;

        public void Menu()
        {
            int opcion;
            Console.WriteLine("****************");
            Console.WriteLine("******MENU******");
            Console.WriteLine("****************");
            Console.WriteLine("");
            Console.WriteLine("SELECCIONAR: 1-PARA CALCULAR ZODIACO, CUALQUIER NUMERO PARA SALIR");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (opcion)
            {
                case 1:
                    CalculoZodiaco();
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
        }

        public void CalculoZodiaco()
        {
            Console.Clear();
            Console.WriteLine("INGRESE EL NUMERO DE SU MES DE NACIMIENTO");
            mes_nacimiento = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE SU DIA DE NACIMIENTO");
            dia_nacimiento = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (mes_nacimiento == 3 && dia_nacimiento >= 21)
            {
                signo_zodiaco = "signo zodiacal: Aries";
            }
            else if (mes_nacimiento == 4 && dia_nacimiento <= 20)
            {
                signo_zodiaco = "signo zodiacal: Aries";
            }
            else if (mes_nacimiento == 4 && dia_nacimiento >= 21)
            {
                signo_zodiaco = "Signo zodiacal: Tauro";
            }

            else if (mes_nacimiento == 5 && dia_nacimiento <= 20)
            {
                signo_zodiaco = "Signo zodiacal: Tauro";
            }

            else if (mes_nacimiento == 5 && dia_nacimiento >= 21)
            {
                signo_zodiaco = "Signo zodiacal: Geminis";
            }

            else if (mes_nacimiento == 6 && dia_nacimiento <= 21)
            {
                signo_zodiaco = "Signo zodiacal: Geminis";
            }

            else if (mes_nacimiento == 6 && dia_nacimiento >= 22)
            {
                signo_zodiaco = "Signo zodiacal: Cáncer";
            }

            else if (mes_nacimiento == 7 && dia_nacimiento <= 22)
            {
                signo_zodiaco = "Signo zodiacal: Cáncer";
            }


            else if (mes_nacimiento == 7 && dia_nacimiento >= 23)
            {
                signo_zodiaco = "Signo zodiacal: Leo";
            }

            else if (mes_nacimiento == 8 && dia_nacimiento <= 22)
            {
                signo_zodiaco = "Signo zodiacal: Leo";
            }

            else if (mes_nacimiento == 8 && dia_nacimiento >= 23)
            {
                signo_zodiaco = "Signo zodiacal: Virgo";
            }

            else if (mes_nacimiento == 9 && dia_nacimiento <= 22)
            {
                signo_zodiaco = "Signo zodiacal: Virgo";
            }

            else if (mes_nacimiento == 9 && dia_nacimiento >= 23)
            {
                signo_zodiaco = "Signo zodiacal: Libra";
            }

            else if (mes_nacimiento == 10 && dia_nacimiento <= 22)
            {
                signo_zodiaco = "Signo zodiacal: Libra";
            }

            else if (mes_nacimiento == 10 && dia_nacimiento >= 23)
            {
                signo_zodiaco = "Signo zodiacal: Escorpio";
            }

            else if (mes_nacimiento == 11 && dia_nacimiento <= 22)
            {
                signo_zodiaco = "Signo zodiacal: Escorpio";
            }

            else if (mes_nacimiento == 11 && dia_nacimiento >= 23)
            {
                signo_zodiaco = "Signo zodiacal: Sagitario";
            }

            else if (mes_nacimiento == 12 && dia_nacimiento <= 21)
            {
                signo_zodiaco = "Signo zodiacal: Sagitario";
            }

            else if (mes_nacimiento == 12 && dia_nacimiento >= 22)
            {
                signo_zodiaco = "Signo zodiacal: Capricornio";
            }

            else if (mes_nacimiento == 1 && dia_nacimiento <= 20)
            {
                signo_zodiaco = "Signo zodiacal: Capricornio";
            }

            else if (mes_nacimiento == 1 && dia_nacimiento >= 21)
            {
                signo_zodiaco = "Signo zodiacal: Acuario";
            }

            else if (mes_nacimiento == 2 && dia_nacimiento <= 18)
            {
                signo_zodiaco = "Signo zodiacal: Acuario";
            }

            else if (mes_nacimiento == 2 && dia_nacimiento >= 19)
            {
                signo_zodiaco = "Signo zodiacal: Piscis";
            }

            else if (mes_nacimiento == 3 && dia_nacimiento <= 20)
            {
                signo_zodiaco = "Signo zodiacal: Piscis";
            }

            Console.WriteLine(signo_zodiaco);
            Console.WriteLine();
            Console.ReadKey();
            Menu();

        }
    }
}
