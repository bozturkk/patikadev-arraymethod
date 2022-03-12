using System;

namespace DiziMetotları // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = {1,11,3,20,5,10,7,8,9,0};
            Console.Write("Dizi elemanları : ");
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi + " ");
            }
            //sort
            Console.WriteLine(" ");
            Array.Sort(sayiDizisi); // artan sıralama yapar.
            Console.Write("Sort methodunu kullandığımda    : ");
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi  + ", ");
            }
            Console.WriteLine(" ");
            //clear
            Array.Clear(sayiDizisi,2,2); // 2. indexden başlayarak iki tane elamanı clear et.
            Console.Write("Clear methodunu kullandığımda   : ");
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi + ", ");
            }
            Console.WriteLine(" ");
            //Reverse aynalama işlemi yapar
            Array.Reverse(sayiDizisi); // 
            Console.Write("Reverse methodunu kullandığımda : ");
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi + ", ");
            }
            Console.WriteLine(" ");

             // 11 değeri kaçıncı index de
            Console.WriteLine("IndexOf methodunu kullandığımda : " + Array.IndexOf(sayiDizisi,11));

             // resize
            Array.Resize<int>(ref sayiDizisi,11);
            sayiDizisi[10] = 99;
            Console.Write("Resize methodunu kullandığımda : ");
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi + ", ");
            }
            Console.WriteLine(" ");

            

        }
    }
}
