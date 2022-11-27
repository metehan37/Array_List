using System.Collections;

namespace Array_List;
class Program
{
    static void Main(string[] args)
    {
        ArrayList liste=new ArrayList();
        //liste.Add("Metehan");
        liste.Add(2);
        //liste.Add(true);
        //liste.Add('M');

        //Verilere erişim
        Console.WriteLine(liste[0]);

        foreach (var item in liste)Console.WriteLine(item);

        //AddRange
        Console.WriteLine("****AddRange");
        string[] renkler={"Mavi","Kırmızı","Turkuaz"};
        List<int> sayilar = new List<int>(){2,5,7,4,15};

        //liste.AddRange(renkler);
        liste.AddRange(sayilar);

        foreach (var item in liste)
        Console.WriteLine(item);

        //Sort
        Console.WriteLine("********* Sort **********");
        liste.Sort();

        foreach (var item in liste)
        Console.WriteLine(item);

        //binary search
        Console.WriteLine("****Binary Search*********");
        Console.WriteLine(liste.BinarySearch(7));

        //reverse
        Console.WriteLine("****Reverse*****");
        liste.Reverse();
        foreach (var item in liste)
        Console.WriteLine(item);

        //Clear
        liste.Clear();

        foreach (var item in liste)
        Console.WriteLine(item);

    }
}
