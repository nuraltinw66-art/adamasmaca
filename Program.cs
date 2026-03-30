using System.ComponentModel.Design;

namespace adamasmaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adam asmaca oyununa hoşgeldiniz..");
            Console.WriteLine("kelimelerin hepsi bilgisayar ve programlama hakkındadır");
            string[] kelimeler =
            {
                "bilgisayar",
                "programlama",
                "dongu",
                "degisken",
                "kosul",
                "dizi"
            };

            Random rastgele = new Random();
            string secilenkelime = kelimeler[rastgele.Next(0,kelimeler.Length)];
            HashSet<char> belirliharf = new HashSet<char>(secilenkelime);
            int hak = 4;
            char[]harf = new char[secilenkelime.Length];
            
            for(int i = 0; i< harf.Length;i++)
            {
                harf[i] = '_';
            }
            foreach(var item in harf)
            {
                Console.Write(item + " ");
            }

            while(hak>0 && harf.Contains('_'))
            {
                Console.WriteLine("\n bir harf giriniz:");
                char tahmin = char.Parse(Console.ReadLine());

                if (belirliharf.Contains(tahmin))
                {
                    belirliharf.Remove(tahmin);
                    Console.WriteLine("harfiniz var");
                    for (int i = 0; i < harf.Length; i++)
                    {

                        if (secilenkelime[i] == tahmin)
                        {
                            harf[i] = tahmin;
                           
                          
                        }
                       
                    }
                    foreach (var item in harf)
                    {
                        Console.Write(item + " ");

                    }

                }
                else
                {
                    Console.WriteLine("bu harf kelimde yok");
                    hak--;
                    if (hak == 3)
                    {
                        string adamcim = "   _\n" +
                                         "   |\n"; 
                        Console.Write(adamcim);
                    }
                    else if(hak == 2)
                    {
                        string adamcim2 = "   _\n" +
                                      "   |\n" +
                                      "   o\n";
                                      
                        Console.Write(adamcim2);
                    }
                    else if(hak==1)
                    {
                        string adamcim3 = "   _\n" +
                                      "   |\n" +
                                      "   o\n" +
                                      "  ı|ı\n";
                                      
                        Console.Write(adamcim3);

                    }
                    if (hak <= 0)
                    {
                        string adamcim3 = "   _\n" +
                                      "   |\n" +
                                      "   o\n" +
                                      "  ı|ı\n" +
                                      "   ^\n";
                        Console.WriteLine("\n------------------------------------------------\n");
                        Console.Write($"{adamcim3}hakkınız bitti, adam öldü... kelime :{secilenkelime}");
                    }
                }
            }
             if(!harf.Contains('_'))
            {
                Console.WriteLine("\n------------------------------------------------\n");
                Console.WriteLine("TEBRİKLER OYUNU KAZANDINIZ"); }
            

            Console.ReadKey();
                
                   
            

            }
           
        }
    }

