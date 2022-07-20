using System;

namespace recursive_ekstension // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //recursive öz yinelemeli 3^4
           
            int result=1;
            for(int i=1;i<5;i++)
                result=result*3;
            Console.WriteLine(result);
            islemler instance=new islemler();
            Console.WriteLine(instance.Expo(3,4));
            //extension metodlar
            string ifade="So At";
            bool sonuc=ifade.Checkspace();
            Console.WriteLine((ifade.Checkspace));
            Console.WriteLine(sonuc);
            if(sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpace());
            Console.WriteLine(ifade.makeupper());
            Console.WriteLine(ifade.lowercase());
            int[] dizi={9,6,4,8,2,5,1};
            dizi.Sortarray();
            dizi.Ekranayaz();
            int sayi=15;
            Console.WriteLine(sayi.Iseven());
            Console.WriteLine(ifade.firstcharacter());
        }
    }
    public class islemler
    {
        public int Expo(int sayi,int üs)
        {
            if(üs<2)
                return sayi;
            return Expo(sayi,üs-1)*sayi;

        }

    }
    public static class extension
    {
        public static bool Checkspace(this string param)
        {
            return param.Contains("");
        }
        public static string RemoveWhiteSpace(this string param)
        {
            string[] dizi=param.Split(" ");
            return string.Join("*",dizi);
        }
        public static string makeupper(this string param)
        {
            return param.ToUpper();
        }
        public static string lowercase(this string param)
        {
            return param.ToLower();
        }
        public static int[] Sortarray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void Ekranayaz(this int[] param)
        {
            foreach(int item in param)
            Console.WriteLine(item);
        }
        public static bool Iseven(this int param)
        {
            return param%2==0;
        }
        public static string firstcharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
