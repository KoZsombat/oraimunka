using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            List<int> eredmenyek = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                lista.Add(i);
            }

            Console.WriteLine(Negyzet(2));

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(Negyzet(lista[i]));
                eredmenyek.Add(Negyzet(lista[i]));
            }

            Console.WriteLine(Osszead(eredmenyek));
            Console.WriteLine(string.Join(", ", Paros(eredmenyek)));
            Console.WriteLine(string.Join(", ", Szorzas(eredmenyek, 2)));
            Console.WriteLine(string.Join(", ", Fuzes(eredmenyek, lista)));
            Console.WriteLine(Nagy(eredmenyek));
            Console.WriteLine(Kis(eredmenyek));

            Console.WriteLine(MindenParos(eredmenyek));
            Console.WriteLine(string.Join(", ", MindenMasodik(lista)));
            Console.WriteLine(string.Join(", ", Forditott(lista)));

            List<string> szovegesLista = new List<string> { "anna", "bÉla", "cECILIA" };
            Console.WriteLine(string.Join(", ", Nagybetus(szovegesLista)));

            List<string> hosszuSzavak = new List<string> { "alma", "körte", "eper", "narancs", "görögdinnye" };
            Console.WriteLine(string.Join(", ", HosszabbMint5(hosszuSzavak)));
        }

        static int Negyzet(int szam)
        {
            return szam * szam;
        }

        static int Osszead(List<int> lista)
        {
            return lista.Sum();
        }

        static List<int> Paros(List<int> lista)
        {
            List<int> paros = new List<int>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] % 2 == 0)
                {
                    paros.Add(lista[i]);
                }
            }
            return paros;
        }

        static List<int> Szorzas(List<int> lista, int szam)
        {
            List<int> kesz = new List<int>();
            for (int i = 0; i < lista.Count; i++)
            {
                kesz.Add(lista[i] * szam);
            }
            return kesz;
        }

        static List<int> Fuzes(List<int> lista, List<int> lista2)
        {
            List<int> kesz = new List<int>();
            for (int i = 0; i < lista.Count; i++)
            {
                kesz.Add(lista[i]);
                kesz.Add(lista2[i]);
            }
            return kesz;
        }

        static int Nagy(List<int> lista)
        {
            return lista.Max();
        }

        static int Kis(List<int> lista)
        {
            return lista.Min();
        }

        static bool MindenParos(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] % 2 != 0)
                {
                    return false;
                }
            }
            return true;
        }

        static List<int> MindenMasodik(List<int> lista)
        {
            List<int> masodik = new List<int>();
            for (int i = 1; i < lista.Count; i += 2)
            {
                masodik.Add(lista[i]);
            }
            return masodik;
        }

        static List<int> Forditott(List<int> lista)
        {
            List<int> forditott = new List<int>();
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                forditott.Add(lista[i]);
            }
            return forditott;
        }

        static List<string> Nagybetus(List<string> lista)
        {
            List<string> nagybetusLista = new List<string>();
            for (int i = 0; i < lista.Count; i++)
            {
                string nagybetus = char.ToUpper(lista[i][0]) + lista[i].Substring(1).ToLower();
                nagybetusLista.Add(nagybetus);
            }
            return nagybetusLista;
        }

        static List<string> HosszabbMint5(List<string> lista)
        {
            List<string> hosszabbak = new List<string>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Length > 5)
                {
                    hosszabbak.Add(lista[i]);
                }
            }
            return hosszabbak;
        }
    }
}