namespace _0921_class
{
    using System.Security.Cryptography.X509Certificates;
    using System.Text.RegularExpressions;

    //1.
    public class Transform
    {
        public string ToHtml(string input)
        {
            input = input.Replace(">", "&gt").Replace("<", "&lt")
                .Replace("\r\n", "<br>").Replace("|", "&brvbar")
                .Replace(" ", "&nbsp");

            return input;
        }
    }


    public class Determine
    {
        //2.
        public static void IsNum(string input)
        {
            double num;
            bool ans = double.TryParse(input, out num);

            if (ans == true)
            {
                Console.WriteLine("是數字");
            }
            else
            {
                Console.WriteLine("不是數字");
            }
        }


        //3.
        public static void IsCorrect(string input)
        {
            string pattern = @"^\w+@\w+\.\w+$";
            bool ans= Regex.IsMatch(input, pattern);
            if (ans)
            {
                Console.WriteLine("格式正確");
            }
            else
            {
                Console.WriteLine("格式不正確");
            }
        }


        //4.mobile number 
        public static void mobileNum(string inputNum)
        {
            string pattern = @"^09[0-9]{8}$";
            bool ans= Regex.IsMatch(inputNum, pattern);
            if (ans)
            {
                Console.WriteLine("格式正確");
            }
            else
            {
                Console.WriteLine("格式不正確");
            }

        }


        //5.ID Number
        public static void IDNum(string inputNum)
        {
            string pattern = @"^[A-Z]{1}[1-2]{1}[0-9]{8}$";
            bool ans = Regex.IsMatch(inputNum, pattern);
            if (ans)
            {
                Console.WriteLine("格式正確");
            }
            else
            {
                Console.WriteLine("格式不正確");
            }

        }











    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            string text = "<h1>標題</h1>\r\n<p> |內容 |內容 | </p>";

            Transform trans = new Transform();
            string transText= trans.ToHtml(text);
            Console.WriteLine(transText);

            Console.ReadKey();



            ////2.
            //Console.Write("輸入字串: ");
            //string a = Console.ReadLine();
            //Determine.IsNum(a);
            //Console.ReadKey();



            ////3.
            //Console.Write("輸入email: ");
            //string email = Console.ReadLine();
            //Determine.IsCorrect(email);

            //Console.ReadKey();


            ////4.
            //Console.Write("輸入手機號碼: ");
            //string num = Console.ReadLine();
            //Determine.mobileNum(num);

            //Console.ReadKey();



            ////5.
            //Console.Write("輸入身分證字號: ");
            //string input = Console.ReadLine();
            //Determine.IDNum(input);

            //Console.ReadKey();


            ////////////////////////////////


            //string a = "abc cba";
            //string b = a.Replace("c", "d");
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(a);



            //// 比較 - ref type
            //string a = "3";
            //string b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //a = "5";
            //Console.WriteLine(a);
            //Console.WriteLine(b);



            //// 比較 - value type
            //int a = 3;
            //int b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //a = 5;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int c = 3;
            //int d



        }
    }
}