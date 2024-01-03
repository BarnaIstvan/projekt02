using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    internal class Feladat
    {
        
       
        List<Alkatreszek> adatok = new List<Alkatreszek>();
        List<string> lista = new List<string>();
        string toFile = "";
        List<List<string>> Alista = new List<List<string>>();
        List<List<List<string>>> biglist=new List<List<List<string>>>();
        

        public void Beir()
        {
            
            Console.WriteLine("Akar-e adatot bevinni? I/N");
            string dontes = Console.ReadLine() ?? "";
            if (dontes.ToLower() == "i")
            {
                
                string eleg = "";
                do
                {
                    Console.WriteLine("Adja meg az alkatrész típusát: ");
                    string tipus = Console.ReadLine().ToLower() ?? "";
                    lista.Add($"{tipus + ";"}");
                    Console.WriteLine("Adja meg az alkatrész nevét: ");
                    string nev = Console.ReadLine().ToLower() ?? "";
                    lista.Add($"{nev + ";"}");
                    
                    Console.WriteLine("Adja meg az alkatrész paraméterét: ");
                    string paramet = Console.ReadLine().ToLower() ?? "";
                    lista.Add($"{paramet + ";"}");
                    Console.WriteLine("Adja meg az alkatrész árát: ");
                    int ar = Convert.ToInt32(Console.ReadLine() ?? "");
                    lista.Add(Convert.ToString($"{ar + "\n"}"));

                   
                    StreamWriter sw = new StreamWriter("alkatresz.txt");
                    
                    foreach (var item in lista)
                    {
                        sw.Write(item);

                    }
                    sw.Close();
                    Console.WriteLine("Elég adatot írt be? (I vagy N)");
                    eleg = Console.ReadLine() ?? "";
                    
                    
                    
                } while (eleg.ToUpper() != "I");
            }
            Alista.Add(lista);
            biglist.Add(Alista);
            
            toFile += "<!DOCTYPE html>" + "\n";
            toFile += "<html lang = \"hu\" >"+ "\n";
            toFile += "<head>" + "\n";
            toFile += "<meta charset=\"UTF-8\">" + "\n";
            toFile += "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">" + "\n";
            toFile += "<link rel=\"stylesheet\" href=\"style.css\">" + "\n";
            toFile += "<title>Document</title>" + "\n";
            toFile += "</head>" + "\n";
            toFile += "<body>" + "\n";
            foreach (var type in biglist)
            {
                toFile += "<table class=\"flex-container\">";
                foreach (var element in type)
                {
                    toFile += "<tr>";
                    foreach (var data in element)
                    {
                        toFile += $"<td>{data}</td>";
                    }
                    toFile += "</tr>";
                }
                toFile += "</table>";
            }
            toFile += "</body>" + "\n";
            toFile += "</html>";
            if (File.Exists("allomany.txt"))
            { 
                File.WriteAllText("alomany.txt", toFile, Encoding.UTF8); 
            }
            else
            {
                File.WriteAllText("alomany.txt", toFile, Encoding.UTF8);
            }
            
                

        }
        public void Beolvasas()
        {
            foreach (var item in File.ReadAllLines("alkatresz.txt", Encoding.UTF8))
            {
                string[] resz = item.Split(';');
                string tipus = resz[0];
                string nev = resz[1];
                string parameter = resz[2];
                int ar =Convert.ToInt32(resz[3]);
                Alkatreszek ujAlkatreszek = new Alkatreszek(tipus, nev, parameter, ar);
                adatok.Add(ujAlkatreszek);
                
            }
            
        }
        public void Kereses()
        {
            int talalatok = 0;
            Console.WriteLine("Mire szeretne rákeresni?");
            Console.WriteLine("Alkatrész típusára (T)");
            Console.WriteLine("Alkatrész nevére (N)");
            Console.WriteLine("Alkatrész árára(C)");
            string keresett = Console.ReadLine() ??"";
            if (keresett.ToUpper()=="T")
            {
                Console.Write("Írja be az alkatrész típusát: ");
                string type= Console.ReadLine().ToLower()??"";
                foreach (var item in adatok)
                {
                    if (item.Tipus.ToLower() == type)
                    {
                        Console.WriteLine($"A keresett típusú alkatrész adatai: {item.Tipus},{item.Nev},{item.Parameter},{item.Ar}");
                        talalatok++;
                    }
                
                }
                if (talalatok == 0)
                {
                    Console.WriteLine("Nincs Találat");
                }
            }
            else if (keresett.ToUpper() == "N")
            {
                Console.Write("Írja be az alkatrész nevét: ");
                string name = Console.ReadLine() ?? "";
                foreach (var item in adatok)
                {
                    if (item.Nev == name)
                    {
                        Console.WriteLine($"A keresett típusú alkatrész adatai: {item.Tipus},{item.Nev},{item.Parameter},{item.Ar}");
                        talalatok++;
                    }
                    
                        
                }
                if(talalatok == 0)
                {
                    Console.WriteLine("Nincs találat");
                }
            }
            else if (keresett.ToUpper()=="C")
            {
                Console.Write("Adja meg az ár alsó határát: ");
               int alsoar= Convert.ToInt32(Console.ReadLine() ?? "");
                Console.Write("Adja meg az ár felső határát: ");
                int felsoar = Convert.ToInt32(Console.ReadLine() ?? "");
                foreach (var item in adatok)
                {
                    if(item.Ar>=alsoar && item.Ar<=felsoar)
                    {
                        Console.WriteLine($"A két ár közötti alkatrészek adatai: {item.Tipus},{item.Nev},{item.Parameter},{item.Ar}");
                        talalatok++;
                    }
                }
                if (talalatok == 0)
                {
                    Console.WriteLine("Nincs találat");
                }
            }

            
        }
        public void Statisztika()
        {
            int Alaplap = 0, Processzor = 0, Memória = 0, Grafikuskártya = 0, HDD = 0, SSD = 0, Monitor = 0, Egér = 0, Billentyűzet = 0, integrált = 0;


           foreach (var item in adatok)
            {
                if (item.Tipus.ToLower()=="monitor")
                {
                    Monitor++;
                }
                else if (item.Tipus.ToLower() == "processzor")
                {
                    Processzor++;
                }
                else if (item.Tipus.ToLower()=="alaplap")
                {
                    Alaplap++;
                }
                else if (item.Tipus.ToLower() == "memória")
                {
                    Memória++;
                }
                else if (item.Tipus.ToLower() == "grafikuskártya")
                {
                    Grafikuskártya++;
                }
                else if (item.Tipus.ToLower() == "hdd")
                {
                    HDD++;
                }
                else if (item.Tipus.ToLower() == "ssd")
                {
                    SSD++;
                }
                else if (item.Tipus.ToLower() == "egér")
                {
                    Egér++;
                }
                else if (item.Tipus.ToLower() == "billentyűzet")
                {
                    Billentyűzet++;
                }
                else if (item.Tipus.ToLower() == "integrált")
                {
                    integrált++;
                }
                
            }
            Console.WriteLine("Az alkatrészek típusainak menniségei: ");
            Console.WriteLine($"Alaplapok: {Alaplap}"); Console.WriteLine($"Processzorok: {Processzor}"); Console.WriteLine($"Memóriák: {Memória}"); Console.WriteLine($"Grafikuskártyák: {Grafikuskártya}"); Console.WriteLine($"HDD-k: {HDD}");
            Console.WriteLine($"SSD-k: {SSD}"); Console.WriteLine($"Monitorok: {Monitor}"); Console.WriteLine($"Egerek: {Egér}"); Console.WriteLine($"Billentyűzetek: {Billentyűzet}"); Console.WriteLine($"Integrált grafikuskártyák : {integrált}");


        }

        public void Learazas()
        {
            Dictionary<int, string> My_dicion =new Dictionary<int, string>();
            My_dicion.Add(1,"alaplap"); My_dicion.Add(2, "processzor"); My_dicion.Add(3, "memória"); My_dicion.Add(4, "grafikuskártya"); My_dicion.Add(5, "hdd");
            My_dicion.Add(6, "ssd"); My_dicion.Add(7, "monitor"); My_dicion.Add(8, "egér"); My_dicion.Add(9, "billentyűzet"); My_dicion.Add(10, "integrált");

            Random r = new();
            StreamWriter sw = new StreamWriter("alkatreszek2.txt");
            int valasztott = r.Next(1, 9);
            
                    foreach (var item in adatok)
                    {
                        if(item.Tipus.ToLower()== My_dicion[valasztott])
                        {
                        sw.WriteLine($"{item.Tipus};{item.Nev};{item.Parameter};{Convert.ToDouble(item.Ar*(r.Next(50,99) / 100.0))}");
                        Console.WriteLine($"A cég a(z) {item.Tipus}-t árazta le ");
                        }
                        else
                        {
                        sw.WriteLine($"{item.Tipus};{item.Nev};{item.Parameter};{item.Ar}");
                           }
                    }
                
               

            sw.Close();
        }
        
    }
}
