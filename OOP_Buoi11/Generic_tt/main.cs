using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_tt
{
    internal class main
    {   
        
        /*static public void checkDic(Dictionary<string, string> myDic, string x)
        {
            string n;
            Console.Write("Nhập từ cần dịch: ");
            n= Console.ReadLine();
            foreach (KeyValuePair<string, string> item in myDic)
            {
                if (n == item.Key)
                {
                    Console.WriteLine("Dịch sang tiếng anh: "+item.Value);
                }                
            }
        }*/

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Dictionary<string, string> MyHash = new Dictionary<string, string>();
            /*Dictionary<string, string> MyDic = new Dictionary<string, string>();
            MyDic.Add("Xin chào", "Hello");
            foreach (KeyValuePair<string, string> item in MyDic)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

            checkDic(MyDic);*/
            //Console.WriteLine(MyDic["Xin chào"]);

            nhap(new Queue());


            Console.ReadKey();
        }
    }
}
