namespace Lests_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Islam's Store , Pay attention for our Limited Time offer , reead Below");
            Console.WriteLine("*Sale*\nLarge Carpet: 35$\nSmall Carpet: 15$\nTax: 6% of total");
            //السجادة الكبيرة
            Console.Write("Please Tell Us How Many Large Carpet Do You Want?: ");
            int LargeCarpetCount = Convert.ToInt32(Console.ReadLine());
            int LargeCarpetCost = LargeCarpetCount * 35; // ثمن القطعة الكبيرة 
            double LargeCarpetTax = LargeCarpetCost * 0.06; // ض
                                                            //السجادة الصغيرة
            Console.Write("Please Tell Us How Many Small Carpet Do You Want?: ");
            int SmallCarpetCount = Convert.ToInt32(Console.ReadLine());
            int SmallCarpetCost = SmallCarpetCount * 15;
            double SmallCarpetTax = SmallCarpetCost * 0.06;
            //--------------------------------------------------
            Console.WriteLine("======INVOICE======");
            //بيان السجادة الكبيرة
            Console.Write($"Large Qty: {LargeCarpetCount}");
            Console.Write($",Large Cost : {LargeCarpetCost}");
            Console.WriteLine($",Large Tax : {LargeCarpetTax}");
            double LargeCarpetTotal = LargeCarpetCost + LargeCarpetTax;
            //_________________________________________________
            //بيان السجادة الصغيرة
            Console.Write($"Small Qty: {SmallCarpetCount}");
            Console.Write($",Small Cost : {SmallCarpetCost},");
            Console.WriteLine($",Small Tax : {SmallCarpetTax}");
            double SmallCarpetTotal = SmallCarpetCost + SmallCarpetTax;
            //_________________________________________________
            Console.WriteLine("---GRAND TOTAL---");
            Console.WriteLine("ToTaL: " + (LargeCarpetTotal + SmallCarpetTotal));
            Console.WriteLine("-----------------");
            Console.WriteLine("DONT FORGET JUST 30 DAY"); ;
        }
    }
}
