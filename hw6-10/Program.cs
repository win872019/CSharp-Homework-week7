namespace hw6_10
{
    using System;
    using System.Globalization;

    // 6. 寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點
    public class Decrease
    {
        public static string ReduceText(string input, int N)
        {
            //int n =N;

            if (input.Length > N)
            {
                input = input.Remove(N).Insert(N, "...");
            }

            return input;
        }
    }



    //// 7. 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式 **
    public class Transform
    {
        public static string DateOfROC(string inputDate)
        {
            DateTime dt = DateTime.Parse(inputDate);
            CultureInfo culture = new CultureInfo("zh-TW");
            culture.DateTimeFormat.Calendar = new TaiwanCalendar();
            return dt.ToString("民國yyy年 MM月 dd日", culture);
        }

        //8. 寫一個function，輸入一個日期，把該日期轉成民國XX年XX月XX日 星期X 格式 ***
        public static string DateDay(string inputDate)
        {
            DateTime dateTime = DateTime.Parse(inputDate);
            CultureInfo culture = new CultureInfo("zh-TW");
            culture.DateTimeFormat.Calendar = new TaiwanCalendar();
            return dateTime.ToString("民國yyy年 MM月 dd日 dddd", culture);

        }
    }


    // 9. 寫一個function，回傳輸入的年是否閏年
    public class Determine
    {
        public static string LeapYear(string year)
        {
            int n = Convert.ToInt32(year);
            if (DateTime.IsLeapYear(n) == true)
            {
                return "是閏年";
            }
            else
            {
                return "不是閏年";
            }
        }




        // 10. 寫一個function，輸入手機號碼，回傳今天運勢
        // (手機運勢算法：用你的手機號碼的最後四位數除以80，
        // 再減去整數部分（只留小數），再乘以80，就會得到一個數，
        // 這就是代表吉凶的數字，印出結果。)
        public double Fortune(string phoneNum)
        {
            double n = Convert.ToDouble(phoneNum.Remove(0, 6));
            return n = (n / 80 - (int)(n / 80)) * 80;



        }


    }






























    internal class Program
    {
        static void Main(string[] args)
        {

            ////6.

            //Console.Write("輸入一字串: ");
            //string input = Console.ReadLine();

            //Console.Write("請輸入 超過幾個字後不顯示? (將以...取代) ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //string result = Decrease.ReduceText(input, num);
            //Console.WriteLine(result);
            //Console.ReadKey();



            ////7. 8.
            //Console.Write("輸入西元日期，轉換成民國日期: ");
            //string a = Transform.DateDay(Console.ReadLine());
            //Console.WriteLine(a);
            //Console.ReadKey();


            ////9.
            //Console.Write("輸入西元年，判斷是否為閏年: ");
            //string ans = Determine.LeapYear(Console.ReadLine());
            //Console.WriteLine(ans);
            //Console.ReadKey();



            //10.
            Determine det = new Determine();
            Console.Write("輸入手機號碼，算運勢: ");
            Console.WriteLine($"運勢數字 {det.Fortune(Console.ReadLine())}");
            Console.ReadKey();






            //DateTime a = new DateTime(2023, 9, 22);
            //Console.WriteLine(a.DayOfWeek.ToString("d"));
            //Console.ReadKey();

            //Console.WriteLine(a.Year);
            //Console.WriteLine(a.Year.GetType());
            //Console.WriteLine(a.Month);
            //Console.WriteLine(a.Month.GetType());
        }
    }
}
    
