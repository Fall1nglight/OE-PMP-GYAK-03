using System.ComponentModel.DataAnnotations.Schema;

namespace OE_PMP_GYAK_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1
            #region
            string[] szin = { "Kőr", "Káró", "Treff", "Pikk" };

            string[] magassag =
            {
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "Jumbó",
                "Dáma",
                "Király",
                "Ász",
            };

            string[] kombinalt = new string[52];

            for (int j = 0; j < szin.Length; j++)
            {
                for (int k = 0; k < magassag.Length; k++)
                {
                    int calculatedIndex = j * magassag.Length + k;
                    kombinalt[calculatedIndex] = szin[j] + " " + magassag[k];
                }
            }
            #endregion

            // #2
            #region
            Random rand = new Random();

            for (int i = 0; i < kombinalt.Length; i++)
            {
                int j = rand.Next(i, kombinalt.Length);
                string oldItem = kombinalt[i];
                kombinalt[i] = kombinalt[j];
                kombinalt[j] = oldItem;
            }

            #endregion

            // #3
            //#region
            //int numOfWords = 3;
            //string[] words = new string[numOfWords];

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.Write($"Kérek egy szót ({i + 1}/{numOfWords}): ");
            //    words[i] = Console.ReadLine()!;
            //}

            //Console.Write("Kérek még egy szót: ");
            //string extraWord = Console.ReadLine()!;

            //int indexOfExtrsWord = Array.IndexOf(words, extraWord);

            //Console.WriteLine($"Benne van-e a gyűjteményben a megadott szó? | {((indexOfExtrsWord == -1) ? "Nem" : "Igen")}");

            //if (indexOfExtrsWord != -1) Console.WriteLine($"Ha benne van, hol található először? | {indexOfExtrsWord}. indexnél");

            //#endregion

            // #4
            //#region
            //List<String> listOfWords = new List<String>();

            //Console.Write("Kérek egy szót: ");
            //for (string inWord; (inWord = Console.ReadLine()!) != "STOP";)
            //{
            //    listOfWords.Add(inWord);
            //    Console.Write("Kérek egy szót: ");
            //}

            //Console.Write("Kérek még egy szót: ");
            //string inExtraWord = Console.ReadLine()!;

            //int indexOfExtraInWord = listOfWords.IndexOf(inExtraWord);

            //Console.WriteLine($"Benne van-e a gyűjteményben a megadott szó? | {((indexOfExtraInWord == -1) ? "Nem" : "Igen")}");

            //if (indexOfExtraInWord != -1) Console.WriteLine($"Ha benne van, hol található először? | {indexOfExtraInWord}. indexnél");

            //#endregion

            // #5
            //#region
            //List<String> names = new List<String>();
            //List<int> ages = new List<int>();
            //List<bool> experiences = new List<bool>();


            //Console.Write("Adj meg egy nevet: ");
            //for (string name; (name = Console.ReadLine()!) != "";)
            //{
            //    Console.Write("Életkor: ");
            //    int age = int.Parse(Console.ReadLine()!);

            //    Console.Write("Rendelkezik-e programozói tapasztalattal? (true / false): ");
            //    bool experience = bool.Parse(Console.ReadLine()!);

            //    names.Add(name);
            //    ages.Add(age);
            //    experiences.Add(experience);

            //    // loop miatt kell
            //    Console.Write("Adj meg egy nevet: ");
            //}

            //// teljes adathalmaz átlagéletkora
            //int sumOfAge = 0;
            //foreach (int a in ages)
            //{
            //    sumOfAge += a;
            //}

            //double avgAge = (double)sumOfAge / ages.Count;


            //// programozói tapasztalat nélküli személyek átlagéletkora
            //int sumOfNewbieAge = 0;
            //int numOfNewbies = 0;
            //for (int i = 0; i < experiences.Count; i++)
            //{
            //    if (!experiences[i])
            //    {
            //        sumOfNewbieAge += ages[i];
            //        numOfNewbies++;
            //    }
            //}

            //double avgNewbieAge = (double)sumOfNewbieAge / numOfNewbies;

            //// legidősebb programozó
            //int oldest = ages[0];
            //int indexOfOldest = 0;
            //for (int i = 1; i < ages.Count; i++)
            //{
            //    if (ages[i] > oldest)
            //    {
            //        oldest = ages[i];
            //        indexOfOldest = i;
            //    }
            //}

            //Console.WriteLine($"Átlag életkor a teljes adathalmazban: {avgAge}");
            //Console.WriteLine($"Átlag életkor a programozói tapasztalat nélküli személyek között: {avgNewbieAge}");
            //Console.WriteLine($"A legidősebb programozó {oldest} éves, neve: {names[indexOfOldest]}");

            //#endregion

            // #6
            //#region
            //int N = 3; // sorok száma (lefele megy)
            //int M = 5; // oszlopok száma (oldalasan megy)

            //int[,] matrix = new int[N, M];
            //int[,] transzponalt = new int[M, N];

            ////feltöltés random számokkal (0-9)
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        matrix[i, j] = rand.Next(0, 10);
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            ////transzponálás
            //for (int i = 0; i < transzponalt.GetLength(0); i++)
            //{
            //    for (int j = 0; j < transzponalt.GetLength(1); j++)
            //    {
            //        transzponalt[i, j] = matrix[j, i];
            //        Console.Write(transzponalt[i, j] + " ");
            //    }
            //    Console.WriteLine();

            //}

            //#endregion

            // #7
            #region
            int numOfFisherman = rand.Next(1, 11);
            int numOfFishTypes = rand.Next(1, 11);
            int[,] F = new int[numOfFisherman, numOfFishTypes];

            // feltöltés random számokkal
            for (int i = 0; i < F.GetLength(0); i++)
            {
                for (int j = 0; j < F.GetLength(1); j++)
                {
                    F[i, j] = rand.Next(1, 15);
                }
            }

            // megjelenítés formázottan
            for (int i = 0; i < F.GetLength(0); i++)
            {
                for (int j = 0; j < F.GetLength(1); j++)
                {
                    if (j == 0)
                        Console.Write("|");

                    Console.Write($"{F[i, j].ToString("00")}|");
                }

                string divider = new string('-', F.GetLength(1) * 3 + 1);
                Console.WriteLine($"\n{divider}");
            }

            // Adjuk meg, hogy a horgászok mennyit fogtak az egyes halfajtákból.
            // i => az adott hotgász
            // j => az adott halfaj
            // [i,j] => az adott horgász [i] által az adott halfajból [j] mennyit fogott [i,j]

            Dictionary<int, int> stat = new Dictionary<int, int>();

            // dictionary feltöltése [int = halfaj, int = fogott db]
            for (int i = 0; i < F.GetLength(0); i++)
            {
                for (int j = 0; j < F.GetLength(1); j++)
                {
                    if (stat.ContainsKey(j))
                    {
                        stat[j] += F[i, j];
                    }
                    else
                    {
                        stat[j] = F[i, j];
                    }
                }
            }

            Console.WriteLine("Statisztika");

            foreach (var s in stat)
            {
                Console.WriteLine($"\tFaj: {s.Key}, Fogott db: {s.Value}");
            }

            // ugyan ez a megoldás, csak könyebben?
            int[] arrStat = new int[numOfFishTypes];

            for (int i = 0; i < F.GetLength(0); i++)
            {
                for (int j = 0; j < F.GetLength(1); j++)
                {
                    arrStat[i] = F[i, j];
                }
            }

            // Melyik horgász fogta a legtöbb halat összesen?
            int maxCatch = 0;
            int indexOfFisherman = 0;

            for (int i = 0; i < F.GetLength(0); i++)
            {
                int sumOfCatch = 0;

                for (int j = 0; j < F.GetLength(1); j++)
                {
                    sumOfCatch += F[i, j];
                }

                if (sumOfCatch > maxCatch)
                {
                    maxCatch = sumOfCatch;
                    indexOfFisherman = i;
                }
            }

            Console.WriteLine(
                $"{indexOfFisherman + 1}. horgász fogta a legtöbb halat => {maxCatch} db"
            );

            // ugyan ez a megoldás csak könyebben
            int maxCatch2 = 0;
            int indexOfFisherman2 = 0;

            for (int i = 0; i < arrStat.Length; i++)
            {
                if (arrStat[i] > maxCatch2)
                {
                    maxCatch2 = arrStat[i];
                    indexOfFisherman2 = i;
                }
            }

            // Volt-e olyan horgász, aki egyetlen halat sem fogott?
            bool result = false;
            for (int i = 0; i < F.GetLength(0); i++)
            {
                int sumOfCatch = 0;

                for (int j = 0; j < F.GetLength(1); j++)
                {
                    sumOfCatch += F[i, j];
                }

                if (sumOfCatch == 0)
                {
                    result = true;
                    break;
                }
            }

            Console.WriteLine(
                $"Volt-e olyan horgász, aki egyetlen halat sem fogott? | {((result) ? "Igen" : "Nem")}"
            );

            // ugyan ez a megoldás csak könyebben
            bool result2 = false;
            for (int i = 0; i < arrStat.Length; i++)
            {
                if (arrStat[i] == 0)
                {
                    result2 = true;
                    break;
                }
            }

            #endregion

            // #8
            //#region

            //Console.Write("Kérek egy pozitív számot, N = ");
            //int N_8f = int.Parse(Console.ReadLine()!);
            //List<int> collatzList = new List<int>();

            //collatzList.Add(N_8f);
            //int numOfTries = 0;

            //while (collatzList[collatzList.Count - 1] != 1)
            //{
            //    int K = collatzList[collatzList.Count - 1];
            //    collatzList.Add((K % 2 == 0) ? K / 2 : 3 * K + 1);
            //    numOfTries++;
            //}

            //#endregion

            // #9
            //#region
            //int[] x = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //for (int i = 0; i < x.Length / 2; i++)
            //{
            //    int tmp = x[i];
            //    x[i] = x[x.Length - i - 1];
            //    x[x.Length - i - 1] = tmp;
            //}

            //#endregion

            // #10
            #region

            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }

            Console.WriteLine("Original");
            foreach (int a in arr)
            {
                Console.Write(a + ", ");
            }

            // minden második elem kigyűjtése egy új gyűjteménybe
            int[] everySecondItemArr = new int[arr.Length / 2];

            for (int i = 0; i < everySecondItemArr.Length; i++)
            {
                everySecondItemArr[i] = arr[i + 1];
            }

            // fordítsuk meg a gyűjtemény elemeinek sorrendjét
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }

            Console.WriteLine("\nReversed");
            foreach (int a in arr)
            {
                Console.Write(a + ", ");
            }

            // Rendezzük a lehető legkisebb négyzetes mátrixba a gyűjtemény elemeit
            // info: négyzetes mátrix = sorok és oszlopok száma megegyezik
            // tipp: Math.sqrt() használata


            int equalMatrixLength = (int)Math.Ceiling(Math.Sqrt(arr.Length));
            int[,] equalMatrix = new int[equalMatrixLength, equalMatrixLength];
            int lastIndex = arr.Length - 1;

            Console.WriteLine();
            Console.WriteLine($"Arr.length: {arr.Length}");
            Console.WriteLine($"equalMatrixLength: {equalMatrixLength}");

            for (int i = 0; i < equalMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < equalMatrix.GetLength(1); j++)
                {
                    int currIndex = i * equalMatrix.GetLength(1) + j;
                    equalMatrix[i, j] = (currIndex > lastIndex) ? 0 : arr[currIndex];
                }
            }

            // megjelnítés formázottan
            for (int i = 0; i < equalMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < equalMatrix.GetLength(1); j++)
                {
                    if (j == 0)
                        Console.Write("|");

                    Console.Write($"{equalMatrix[i, j].ToString("00")}|");
                }

                string divider = new string('-', equalMatrix.GetLength(1) * 3 + 1);
                Console.WriteLine($"\n{divider}");
            }

            #endregion

            // #11
            #region
            // Készítsünk algoritmust, amely egy N ×M-es mátrix elemeit
            // az óramutató járásának megfelelően K ×90◦-kal „elforgatja”,
            // ahol K egész szám.

            int N2 = rand.Next(0, 11);
            int M2 = rand.Next(0, 11);
            int K = 1;
            int[,] algoMatrix = new int[N2, M2];

            // 2x2-es mátrix esetén | 2
            // [9] [7] 0
            // [3] [6] 1

            // 3x3-as mátrix esetén | 3
            // [9] [7] [2] 0
            // [3] [6] [4] 1
            // [1] [5] [9] 2

            // 5x5-os mátrix esetén | 5
            // [9] [7] [2] [1] [8] 0
            // [3] [6] [4] [2] [9] 1
            // [1] [4] [9] [3] [2] 2
            // [4] [3] [6] [7] [1] 3
            // [8] [2] [3] [4] [7] 4

            // 3x2-as mátrix esetén
            // [1] [4]
            // [4] [3]
            // [8] [2]

            // két féle mozgás van, oldalra vagy felfele
            // felfele mozgás: csak bal oldalt
            // lefele mozgás: csak jobb oldalt
            // ballról->jobbra mozgás: fent
            // balra<-jobbról mozgás: lent
            // mitől függ hogy merre mozog az adott elem?
            // a mátrix magasságának felétől megváltozik ugye a vízszintes mozgás

            // --> | ha a mátrix felső pontjában vagyunk (i < magassag/2)
            //     | valamint, ha van jobbra szomszédunk

            // <-- | ha a mátrix alsó pontjába vagyunk ()
            //

            // formula: magassag - (int)magassag/2
            // kalkulalt indexet kell alkalmazni ha a magassag paros
            // mivel 2x2-es matrix eseten a magassag/2 => 2/2=1 lenne
            // és a mátrix felső pontja i<magassag/2-ig tart, tehát
            // amikor a mátrix az utolsó sorba érne, index = 1
            // ezért a feltétle: 1<2/2 HAMIS, szóval kalkulált indexet kell használni,
            // amihez hozzáadunk 1-et ha páros hosszú a tömb
            // ha a mátrix közepén vagyunk, ami akkor van ha a magassága páratlan
            // akkor nem mozgunk

            // műveletek
            //- megtudni, hogy melyik oldalt vannak szomszédai
            //- megtudni, hogy a mátrix melyik részén van az irány miatt
            //- mozgatni az adott elemet a formula szerint az adott irányba
            //- K-szor történjen ez meg

            for (int i = 0; i < algoMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < algoMatrix.GetLength(1); j++) { }
            }

            // HA A MAGASSÁG NAGYOBB MINT 2 AKKOR KELL CSAK
            static String getPosition(int[,] m, int i, int j)
            {
                int numOfRows = m.GetLength(0); // height
                int middleLine = numOfRows / 2;
                string result = null;

                if (i < middleLine)
                    result = "T";

                if (i == middleLine)
                    result = "M";

                if (i > middleLine)
                    result = "B";

                return result;
            }

            #endregion
        }
    }
}
