using System.Text.RegularExpressions;

namespace functionHw
{


    //1.寫一個function 可以把一般對話框的文字轉成HTML。
    //> 轉成 &gt; < 轉成 &lt; \r\n 轉成 <br> | 轉成 &brvbar; 空白 轉成 &nbsp;
    public class Transform
    {
        public string ToHtml(string input)
        {
            
            input = input.Replace(">", "&gt").Replace("<", "&lt")
                .Replace("\\r\\n", "<br>").Replace("|", "&brvbar")
                .Replace(" ", "&nbsp");

            return input;
        }
    }













    public class Determine
    {
        //// 2.寫一個function，回傳輸入的值是否為數字
        //public void IsNum()
        //{
        //    Console.Write("輸入一字串，判斷是否為數字: ");
        //    string input = Console.ReadLine();

        //    string[] num = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        //    int i, j = 0;

        //    // 假設 input 為負數
        //    if (Convert.ToString(input[0]) == "-")
        //    {
        //        j = 1;
        //    }

        //    // 開始檢查 input 
        //    for (i = j; i < input.Length; i++)
        //    {

        //        if (Array.IndexOf(num, Convert.ToString(input[i])) == -1)
        //        {
        //            Console.WriteLine($"{input} 不是數字");
        //            return;
        //        }
        //    }
        //    Console.WriteLine($"{input} 是數字");
        //    return;

        //}




        // 3.寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
        //public string IsEmailFormat(string emailAddr)
        //{
            
        //}


    }









    internal class Program
    {
        static void Main(string[] args)
        {
            //1.

            //string text = "<h1>標題</h1>\r\n<p> |內容 |內容 | </p>";
            Console.WriteLine("輸入> 轉成 &gt; < 轉成 &lt; \\r\\n 轉成 <br> | 轉成 &brvbar; 空白 轉成 &nbsp;");
            string text=Console.ReadLine();

            Transform trans = new Transform();
            string transText = trans.ToHtml(text);
            Console.WriteLine(transText);

            Console.ReadKey();





            //// 2. 執行
            //Determine determine = new Determine();
            //determine.IsNum();

            //Console.ReadKey();














            //////////////////////////////////////////////////////
            // int.TrtParse() - method - 判斷輸入字串是否為數字

            //    int i = 0;
            //    string s = "108";
            //    bool result = int.TryParse(s, out i); //i now = 108
            //    Console.WriteLine(result);
            //    Console.WriteLine(i);


            //    string b = "hi";
            //    bool result2 = int.TryParse(b, out i); 
            //    Console.WriteLine(result2);
            //    Console.WriteLine(i);


            // Observation - for 2.
            //string[] num = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            //string a = "0sd";
            //Console.WriteLine(Array.IndexOf(num, a[0]));
            //Console.WriteLine((a[0]).GetType());
            //Console.WriteLine((num[0]).GetType());
            //Console.WriteLine(Convert.ToChar(num[0]) == a[0]);



            /////////////////////////////////////////////////
            // Regular Expression - 正則表達式

            //// 手機號碼
            //while (true)
            //{
            //    Console.WriteLine("輸入手機號碼: ");
            //    string tel=Console.ReadLine();
            //    bool telcheck = Regex.IsMatch(tel, @"^09[0-9]{8}$");
            //    if (telcheck)
            //    {
            //        Console.WriteLine("手機號碼格式正確");
            //    }else
            //    {
            //        Console.WriteLine("格式不正確");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.ReadKey();




            // 把多個參數放到陣列            
            // public void ReduceText(params object[] parameters)









        }
    }
}