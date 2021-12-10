/*
2.	Viết chương trình nhập vào một số nguyên dương rồi in ra tất cả các ước số của số đó.
đỗ phan duy hùng 
cd21tt11

**/
using System;


namespace CH5_BT2
{
    class Bt2_Ch5
    {
        static void Main(string[] args)
        {
            int uocSo = 0;
            int n = 0;
            int a = 0;
            Console.WriteLine("nhap so nguyen bat ki n = ");
            int.TryParse(Console.ReadLine(), out n);
            for(a=1;a<= n;a++)
            {if (n % a == 0)

                {
                   //onsole.Write();
                    Console.Write(a + " : ");
                }
            }
            Console.ReadKey();
        }
    }
}
