﻿using System;
using System.IO;

class Program
{
    static void Main()
    {





        int oper = 0;




        while (oper == 0)
        {
            Console.WriteLine("Zadaj koniec pre ukončenie programu a štart pre konvertovanie času.");
            string operácia = Console.ReadLine().ToLower();
            if (operácia == "koniec")
            {
                Console.WriteLine("Ukončujem program.");
                break;
            }
            else if (operácia == "štart")
            {
                Console.Write("Zadajte názov vstupného súboru: ");
                string inputFile = Console.ReadLine();
                Console.Write("Zadajte názov výstupného súborut: ");
                string outputFile = Console.ReadLine();
                Console.Write("Zadajte typ vstupných dát (typ1 alebo typ2): ");
                string formatType = Console.ReadLine().ToLower();
                oper = 0;
                string formatTypeB = formatType;


                if (inputFile != formatTypeB)
                {
                    Console.WriteLine("Súbor už v požadovanom formáte je.");
                }
                else
                {





                    using (StreamReader reader = new StreamReader($"..\\..\\{inputFile}.txt"))
                    {

                        using (StreamWriter writer = new StreamWriter($"..\\..\\{outputFile}.txt"))
                        {
                            string riadok = reader.ReadToEnd();
                            if (riadok != null)
                            {


                                if (formatType == "typ1")
                                {

                                    string[] parts = riadok.Split(':');
                                    if (parts.Length == 3)
                                    {
                                        string hodiny = parts[0];
                                        Console.WriteLine("Spracovávam hodiny: " + hodiny);
                                        string minúty = parts[1];
                                        Console.WriteLine("Spracovávam minúty: " + minúty);
                                        string sekundy = parts[2];
                                        Console.WriteLine("Spracovávam sekundy: " + sekundy);


                                        string formátovanie = $"Hodín: {hodiny}\nMinút: {minúty}\nSekúnd: {sekundy}";
                                        Console.WriteLine(formátovanie);
                                        writer.WriteLine(formátovanie);
                                        Console.WriteLine("Spracovanie bolo úspešne dokončené.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Chyba: Nesprávny formát času v súbore.");
                                    }
                                }
                                else if (formatType == "typ2")
                                {
                                    string[] riadky = riadok.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                                    string hodiny = "";
                                    string minúty = "";
                                    string sekundy = "";


                                    foreach (string r in riadky)
                                    {
                                        if (r.Contains("Hodín:"))
                                        {
                                            hodiny = r.Split(':')[1].Trim();
                                            Console.WriteLine("Spracovávam hodiny: " + hodiny);
                                        }
                                        else if (r.Contains("Minút:"))
                                        {
                                            minúty = r.Split(':')[1].Trim();
                                            Console.WriteLine("Spracovávam minúty: " + minúty);
                                        }
                                        else if (r.Contains("Sekúnd:"))
                                        {
                                            sekundy = r.Split(':')[1].Trim();
                                            Console.WriteLine("Spracovávam sekundy: " + sekundy);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Chyba: Nesprávny formát času v súbore.");
                                        }
                                    }


                                    string formátované = $"{hodiny}:{minúty}:{sekundy}";
                                    Console.WriteLine(formátované);
                                    writer.WriteLine(formátované);
                                    Console.WriteLine("Spracovanie bolo úspešne dokončené.");
                                }


                                else
                                {
                                    Console.WriteLine("Chyba: Neznámy typ dát.");
                                }


                            }
                            else
                            {
                                Console.WriteLine("Súbor je prázdny.");
                            }




                        }

                    }
                    using (StreamWriter writer2 = new StreamWriter($"..\\..\\{inputFile}.txt"))
                    {
                        writer2.WriteLine("");






                    }





                }   
            }
            else
            {
             Console.WriteLine("Zlá voľba operácie.");
            }

            }
        }
    }



            
        
   

