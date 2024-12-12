namespace ArrayAllTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array daxilinde ededlerin ceminin tapilmasi

            //int[] array = { 1, 2, 3, 4, 5 };
            //int sum = 0;

            //foreach (int num in array)
            //{
            //    //sum += num; 1 +_2 =3 
            //    sum = sum + num;
            //}

            //Console.WriteLine($"Array daxilində elementlərin cəmi: {sum}");

            ////iki ededin yerinin deyisidirlmesi
            //int a = 5;
            //int b = 10;

            //Console.WriteLine("Əvvəlki dəyərlər:");
            //Console.WriteLine($"a = {a}, b = {b}");

            //// İki ədədin yerini dəyişirik (tempsiz)
            //a = a + b;//15
            //b = a - b;//5
            //a = a - b;//10

            //Console.WriteLine("\nYer dəyişdirildikdən sonra:");
            //Console.WriteLine($"a = {a}, b = {b}");


            //daxil edilen indekslerinin yerinin deyisdirilmesi
            //int[] array = { 10, 20, 30, 40, 50 };

            //Console.WriteLine("Array: ");
            //foreach (int element in array)
            //{
            //    Console.Write(element + " ");
            //}

            //// İndeksləri daxil et
            //Console.WriteLine("\nYerini dəyişmək istədiyiniz iki elementin indekslərini daxil edin:");

            //Console.Write("Birinci indeks: ");
            //int firstIndex = int.Parse(Console.ReadLine());

            //Console.Write("İkinci indeks: ");
            //int secondIndex = int.Parse(Console.ReadLine());

            //// Şərt: indekslərin array-in ölçüsündən kənar olmaması
            //if (firstIndex < 0 || secondIndex < 0 || firstIndex >= array.Length || secondIndex >= array.Length)
            //{
            //    Console.WriteLine("Səhv: Daxil edilən indekslər array-in ölçüsündən kənardadır!");
            //    return;
            //}

            //// Elementlərin yerini dəyişmək 1 3
            //array[firstIndex] = array[firstIndex] + array[secondIndex];//4
            //array[secondIndex] = array[firstIndex] - array[secondIndex];//1
            //array[firstIndex] = array[firstIndex] - array[secondIndex];//3

            ////a = a + b;//4
            ////b = a - b;//1
            ////a = a - b;//3
            //Console.WriteLine("\nYer dəyişdirildikdən sonra array:");
            //foreach (int element in array)
            //{
            //    Console.Write(element + " ");
            //}

            //max ededin tapilmasi
            //int[] array = { 10, 45, 7, 89, 23 };

            //Console.WriteLine("Array: ");
            //foreach (int element in array)
            //{
            //    Console.Write(element + " ");
            //}

            //// Ən böyük ədədi tapmaq üçün dəyişən
            //int max = array[0]; // İlk elementi ilkin ən böyük qəbul edirik

            //// Array boyunca keçərək müqayisə edirik
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] < max)
            //    {
            //        max = array[i];
            //    }
            //}

            //// Nəticəni çap edirik
            //Console.WriteLine($"\nArray daxilində ən böyük ədəd: {max}");

            //max ve min yerinin deyisdirilmesi
            //int[] array = { 12, 7, 45, 3, 23 };

            //Console.WriteLine("Array daxil edilməzdən əvvəl:");
            //foreach (int element in array)
            //{
            //    Console.Write(element + " ");
            //}

            //// Max və Min tapmaq üçün indekslər
            //int maxIndex = 0;
            //int minIndex = 0;

            //// Array boyunca keçərək max və min indekslərini tapırıq
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > array[maxIndex])
            //    {
            //        maxIndex = i;
            //    }
            //    if (array[i] < array[minIndex])
            //    {
            //        minIndex = i;
            //    }
            //}
            ////max ve min tapdiq

            //// Max və Min ədədlərin yerini dəyişdiririk (tempsiz)
            //array[maxIndex] = array[maxIndex] + array[minIndex];
            //array[minIndex] = array[maxIndex] - array[minIndex];
            //array[maxIndex] = array[maxIndex] - array[minIndex];

            //Console.WriteLine("\nArray dəyişdirildikdən sonra:");
            //foreach (int element in array)
            //{
            //    Console.Write(element + " ");
            //}

            //Console.WriteLine($"\nMax və Min ədədlərin yerini dəyişdirildi: Max = {array[minIndex]}, Min = {array[maxIndex]}");

            //numune 2

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //int max = numbers[0];
            //int min = numbers[0];
            //int indexmin = 0;
            //int indexmax = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //        indexmin = i;
            //    }
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //        indexmax = i;
            //    }
            //}
            //numbers[indexmin] = max;
            //numbers[indexmax] = min;
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            }

            ////ardicil duzulub ya yox
            //int[] array4 = { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Array daxil edilib:");
            //foreach (int element in array)
            //{
            //    Console.Write(element + " ");
            //}

            //// Ardıcıl düzülməni yoxlamaq üçün flag (bayraq) təyin edirik
            //bool isConsecutive = true;

            //// Array boyunca keçirik və ardıcıl olub-olmadığını yoxlayırıq
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    if (array[i] + 1 != array[i + 1])
            //    {
            //        isConsecutive = false;
            //        break; // Əgər ardıcıl deyilsə, yoxlamanı dayandırırıq
            //    }
            //}

            //// Nəticəni çap edirik
            //if (isConsecutive)
            //{
            //    Console.WriteLine("\nArray daxilində ədədlər ardıcıl düzülüb.");
            //}
            //else
            //{
            //    Console.WriteLine("\nArray daxilində ədədlər ardıcıl düzülməyib.");
            //}
        }
    }
}
