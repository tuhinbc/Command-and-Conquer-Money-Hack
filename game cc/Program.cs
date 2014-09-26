using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace game_cc
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Open("g://INIZH.big", FileMode.Open);
            //FileStream fs = new FileStream("g://INIZH.big", FileMode.Open);
            StreamReader st=
                File.OpenText(@"I:\Game\cc\Command & Conquer The First Decade\Command & Conquer(tm) Generals\INI_2.big");
            string ss=st.ReadToEnd();

            byte[] ar=new byte[200000000];
            ar = File.ReadAllBytes(@"I:\Game\cc\Command & Conquer The First Decade\Command & Conquer(tm) Generals\INI_2.big");
            ss=System.Text.Encoding.Default.GetString(ar);
            Console.WriteLine(ar.Length.ToString()+" "+
                ss.Length.ToString());
            
            int ln=ss.Length;
            int cnt=0;
            for (int i = 0; i < ln - 500;)
            {
                i = ss.IndexOf("BuildCost", i);
                if (i == -1) break;

                while (!char.IsNumber(ss, i))
                {
                    //Console.Write(ss[i]);Console.ReadKey();
                    i++;
                }
                //Console.WriteLine("mm");
                while (char.IsNumber(ss, i))
                {
                    ar[i] = 48;
                    i++;
                }
            }
            File.WriteAllBytes(@"I:\Game\cc\Command & Conquer The First Decade\Command & Conquer(tm) Generals\INI.big", ar);
        }
    }
}
