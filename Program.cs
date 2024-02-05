namespace CA240205
{
    internal class Program
    {
        static void Main()
        {
            //string name = "Zoltán";
            //string name = "Béla";

            //Console.WriteLine("...történik valami...");

            //Console.Write("Írd be a neved: ");
            //name = Console.ReadLine();

            //Console.WriteLine($"Szia, {name}!");
            //Console.WriteLine($"Milyen szép név az, hogy {name}! :3");

            //Console.Write("Írd be melyik évben születtél: ");
            //int birthYear = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Akkor te idén {DateTime.Today.Year - birthYear} éves leszel!");

            //egész (integer)

            // sbyte/byte
            // short/ushort
            // int/uint
            // long/ulong
            // (+ char)

            // lebegőpontos (floating point)

            // float
            // double
            // decimal

            // "karakteres"
            // char -> 1db karakter -> 'a'
            // string -> 'tetszőleges, véges hosszúságú karakterek láncolata'
            //char x1 = 'a';
            //string x2 = "b";

            //Console.WriteLine(x1 + x2);

            // logikai
            // bool true/false

            //float x01 = 32.5f;
            //long x02 = 2450000000000;

            //Console.WriteLine(x01 + x02);

            //bool logikai = Convert.ToBoolean(-123);
            //float x = 10;

            //bool a = true;
            //bool b = false;

            // tagadás (egy operandusú): !
            // logikai és: &&
            // logikai vagy: ||
            // kizáró vagy/antivalencia: !=
            // ekvivalencia: ==

            //Console.WriteLine(a && b);

            //elágazás (szelekció)

            //if (<kritérium/feltétel>)
            //{
            //  --> kód, ami akkor fut le, ha a feltétel 'igaz'
            //}
            //else
            //{
            //  --> kód, ami akkor fut le, ha a feltétel hamis
            //}

            //INPUT: egész szám
            //OUTPUT: az inputnak, mint osztályzatnak megfelelő szöveges értékelés

            Console.Write("írd be az osztályztatot: ");
            int osztalyzat = int.Parse(Console.ReadLine());

            if (osztalyzat == 1) Console.WriteLine("elégtelen");
            else if (osztalyzat == 2) Console.WriteLine("elégséges");
            else if (osztalyzat == 3) Console.WriteLine("közepes");
            else if (osztalyzat == 4) Console.WriteLine("jó");
            else if (osztalyzat == 5) Console.WriteLine("jeles");
            else Console.WriteLine("valami nem stimmel :(");


            switch (osztalyzat)
            {
                case 1:
                    Console.WriteLine("elégtelen");
                    break;
                case 2:
                    Console.WriteLine("elégséges");
                    break;
                case 3:
                    Console.WriteLine("közepes");
                    break;
                case 4:
                    Console.WriteLine("jó");
                    break;
                case 5:
                    Console.WriteLine("jeles");
                    break;
                default:
                    Console.WriteLine("valami baj van");
                    break;
            }


            //ciklus (iteráció)

            for (int i = 10; i <= 100; i += 5) Console.WriteLine(i);
            
            string[] dolgok = ["cica", "kutya", "hörcsög", "fluxuskondenzátor"];

            foreach (string elem in dolgok)
            {
                Console.WriteLine(elem);
            }

            //2 hatványai 10Mig
            int k = 1;
            double n = 2;
            while (n < 10000000)
            {
                Console.WriteLine(n);
                n = Math.Pow(2, k);
                k++;
            }

            string jelszo = "1234";
            string proba = null;
            do
            {
                Console.Write("írd be a jelszót: ");
                proba = Console.ReadLine();
            } while (jelszo != proba);
            Console.WriteLine("SIKERÜLÜT!");
        }
    }
}