namespace projekt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladat f = new Feladat();       
            f.Beolvasas();
            
            int input = 0;
            do
            {
                Console.WriteLine("Válasszon a menüpontok közül: ");
                Console.WriteLine("Kilépés (0)");
                Console.WriteLine("Adatbekérés (1)");
                Console.WriteLine("Alkatrészek közt keresés (2)");
                Console.WriteLine("Alkatrészek statisztikája (3)");
                Console.WriteLine("Alkatrész leárazás (4)");
                 input= Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            f.Beir();
                            break;
                        }
                    case 2:
                        {
                            f.Kereses();
                            break;
                        }
                    case 3:
                        {
                            f.Statisztika();
                            break;
                        }
                    case 4:
                        {
                            f.Learazas();
                            break;
                        }
                    case 0:
                        {
                            break;
                        }
                }
                
            } while (input != 0);
        }

    }
}

