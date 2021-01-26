using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesAssignment25Jan2021
{
    class Program
    {
        static void WriteFile(string fileName,string str)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                byte[] b = Encoding.ASCII.GetBytes(str);
                fs.Write(b, 0, b.Length);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Flush();
                fs.Close();
            }
        }
        static void ReadFile(string fileName)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                byte[] b = new byte[1024];
                int bytesread = fs.Read(b, 0, b.Length);
                Console.WriteLine(Encoding.ASCII.GetString(b,0,b.Length));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Flush();
                fs.Close();
            }
        }
        static void Main(string[] args)
        {
            String str=null;
            bool b = true;
            string ans;
            while (b)
            {
                Console.WriteLine("Enter String which appear in text file");
                str =str+"\n"+ Console.ReadLine();
                Console.WriteLine("Do you want add more data to file?Yes/No");
                ans = Console.ReadLine();
                if (ans.Equals("No"))
                {
                    b = false;
                }
            }
            
            String fileName = @"F:\text13.txt";
           
            WriteFile(fileName, str);
            ReadFile(fileName);
           
        }
    }
}
