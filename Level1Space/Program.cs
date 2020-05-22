using System;
using System.Collections.Generic;


namespace Level1Space
{
    public static class Level1
    {
        public static int squirrel(int n) //2147483647
        {
          double result;
          int otv;
          result = 1;
          bool temp;
          temp = true;
          if (n < 0)
          {
               Console.WriteLine("protivorechit usloviam zadachi n>=0");
               temp = false;
          }
            //ichem factorial
           if (n == 0) result = 1;
           for (int i = 1; i <= n; i++)
           {
                result = result * i;
                if (result <= 1.7 * Math.Pow(10, 308)) temp = true;
                else temp = false;
                       
           }

           //ichem pervuy tsifru factoriala
            if (temp)
            {  string str;
                str = result.ToString("E3");
                otv = int.Parse(str[0].ToString());
                //Console.WriteLine("factorial=" + result + " stroka=" + str + 
                //                        " otvet=" + otv);
            }
            else
            {   Console.WriteLine("belochke nel'zy stolko oreshkov");
                otv = 0;
            }

            return otv;
            
        }


        //public static void Main(string[] args)
        //{

        //}
    }
}

