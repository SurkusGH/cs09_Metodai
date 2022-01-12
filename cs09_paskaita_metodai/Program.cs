using System;
using System.Collections.Generic;
using System.Linq;

namespace cs09_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs09_PASKAITA");

            #region TEORIJA – KARTOJIMAS: mastyvai ir list'ai

            // 4 paskaitos antra dalis uždavinių, masyvai ir list'ai

            #endregion

            #region TEORIJA - METODAI

            // Funkcija nuo medoto skirdavosi anksčiau – no more;
            // Metodas – kodo apvilkimas ir izoliavimas

            // static <--?
            // void <--?

            //public void AddNumbers(int firstNum, int secondNum);

            #endregion

            //Rep1(); // <-- kartojimas
            //Rep2();
            //Rep2_LecVar();
            //Rep3();
            //Rep4();
            //Rep5(); // <-- paskutinis masyvų uždavinys
            //Rep6(); // <-- list'ai
            //Rep7();
            //Rep8();
            Rep9();
            Rep10();
        }

        public static void Rep1()
        {
            //užpildyti masyvą atsitiktiniais skaičiais ir parodyti kiek
            //kartų kartojasi kiekvienas skaičius

            int[] randomNumbers = new int[100];
            Random random = new();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(1, 10);
            }

            int[] usedNumbers = new int[10]; // <-- Susidėti į dictionary savarankiškai
            int usedNumbersIndex = 0;

            foreach (var number in randomNumbers)
            {
                if (usedNumbers.Contains(number)) continue; // <-- paprasčiau pasirašyti If'ą
                int count = 0;
                foreach (var numberToCompare in randomNumbers)
                {
                    if(number == numberToCompare)
                    {
                        count++;
                    }
                }
                usedNumbers[usedNumbersIndex] = number;
                usedNumbersIndex++;
                Console.WriteLine($"Masyve {number} reišmių kintamųjų yra {count}vnt.");
            }
        }

        public static void Rep2()
        {
            // Parašyti programą, kurioje ištrinamas bet kuris elementas
            // (!) pastaba, masyvas perkeliamas be nutrinto elemento

            int[] randomNumbers = new int[10];
            Random random = new();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(1, 10);
            }
            int indexToRemove = 3;

            int[] newArray = new int[randomNumbers.Length - 1];

            int counter = 0;

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                if (i == indexToRemove) continue;
                newArray[counter] = randomNumbers[i];
                counter++;
            }

            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
            // alternatyviai:


        }

        public static void Rep2_LecVar()
        {
            int[] randomNumbers = new int[10];
            Random random = new();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(1, 10);
            }
            int indexToRemove = 3;

            int temp = 0;
            randomNumbers[3] = randomNumbers[randomNumbers.Length - 1];

            Array.Resize(ref randomNumbers, 9);

            //int[] newArray = new int[randomNumbers.Length - 1];
        }

        public static void Rep3()
        {
            // Parodyti antrą max ir min skaičių masyve
            int[] randomNumbers = new int[10];
            Random random = new();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(1, 10);
            }

            int biggestNumber = randomNumbers[0];
            int secondBigestNumber = randomNumbers[0];
            foreach (var number in randomNumbers)
            {
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }
            foreach (var number in randomNumbers)
            {
                if (number > secondBigestNumber && number < biggestNumber)
                {
                    secondBigestNumber = number;
                }
            }

            // alternatyviai:
            //int biggestNumber = randomNumbers.Max()
            //int secondBiggest = randomNumbers.Where(i => i < biggestNumber).Max();

            // alternatyviai:
            //int[] uniqueValues = randomNumbers.Select(i => i).Distinct().ToArray().OrderByDescending(x => x).ToArray();
            //int biggestNum = uniqueValues[1];
            //int smallesNum = uniqueValues[-2];
        }

        public static void Rep4()
        {
            int[,] matrix = new int[,]
            {
                { 1, 2, 3 },
                { 2, 3, 4 },
                { 3, 4, 5 },
            };
            Console.WriteLine(matrix[0,0]); // <-- pirmas skaičius taiko į eilutę,
                                            //     antras į stulpėlį
            int sum = 0;
            for (int row = 0; row <= matrix.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= matrix.GetUpperBound(1); col++)
                {
                    Console.Write($"{matrix[row, col]},");
                    sum += matrix[row, col];
                }
                Console.WriteLine();
                Console.WriteLine($"Sum: {sum}");
            }
        }

        public static void Rep5()
        {
            // Parašyti masyvų rūšiavimo algoritmą
            // "Bubble" sort

            int[] randomNumbers = new int[1000];
            Random random = new();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(1, 1000);
            }

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                for (int j = 0; j < randomNumbers.Length; j++)
                {
                    if (randomNumbers[i] > randomNumbers[j])
                    {
                        int temp = randomNumbers[i];
                        randomNumbers[i] = randomNumbers[j];
                        randomNumbers[j] = temp;
                    }
                }
            }
            foreach (var item in randomNumbers)
            {
                Console.Write($"{item} ");
            }
        }

        public static void Rep6()
        {
            // Užpildyti list'ą
            // Atspausdinti tik lyginius skaičius
            List<int> randomNumbers = new();
            Random random = new();
            for (int i = 0; i < 20; i++)
            {
                randomNumbers.Add(random.Next());
            }

            foreach (var item in randomNumbers)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();
        }

        public static void Rep7()
        {
            List<string> students = new();
            students.Add("Studentas4");
            students.Add("Studentas3");
            students.Add("Studentas2");
            students.Add("Studentas1");

            List<string> lateStudents = new();
            lateStudents.Add("Studentas8");
            lateStudents.Add("Studentas7");
            lateStudents.Add("Studentas6");
            lateStudents.Add("Studentas5");

            List<string> allStudents = new();
            allStudents.AddRange(students);
            allStudents.AddRange(lateStudents);

            foreach (var student in allStudents)
            {
                Console.WriteLine(student);
            }

            allStudents.Sort();
            Console.WriteLine();

            foreach (var student in allStudents)
            {
                Console.WriteLine(student);
            }
        }

        public static void Rep8()
        {
            // 1, 2, 4, 6, 8
            List<int> firstArray = new List<int> { 1, 2, 4, 8, 16 };
            List<int> secondArray = new List<int> { 2, 4, 8};

            List<int> union = firstArray.Intersect(secondArray).ToList();
        }

        public static void Rep9()
        {
            List<int> randomNumbers = new();
            Random random = new();
            for (int i = 0; i < 100000000; i++)
            {
                randomNumbers.Add(random.Next());
            }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            randomNumbers.Sort();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        public static void Rep10()
        {
            // File I/O
        }


    }
}

