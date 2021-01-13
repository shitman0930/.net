using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp2.Controllers
{
    public class _04HW2Controller : Controller
    {
       public void No1(int n)
        {//true就不是質數(被2除完餘數不為0就是質數) 傳參數?n=
            bool flag = false;
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0) 
                { 
                    flag = true;
                    break;
                }
            }
            if (flag)
                Response.Write(n + "不是質數");
            else
                Response.Write(n + "是質數");
        }  
        //相互為除數與被除數 餘數為0那次即為最大公因數 明明就費式數列
        public void No2(int a, int b)
        {//xx被除數 yy除數 z餘數
            int xx = a, yy = b, z = 0;
            while (xx % yy != 0)
            {
             z= xx % yy;//先暫存 xx為除數
             xx = yy;//換yy為除數
             yy = z;//xx與yy互為除數與被除數 不用++捏0..0
            }
            Response.Write(a+"與"+b+"的最大公因數為"+yy);
        }
        public void No3(int n)
        {//nn與q就被除數 除數就10 除到q是商數不為0 r就餘數
            int r = 0, q = 0, nn = n, result = 0;

            do
            {//45/10商4餘5 result=0*10+5=5 4/10商0餘4 result=5*10+4=54

             //12321/10商1232餘1 result=0*10+1=1  1232/10商123餘2 result=1*10+2=12 
             //123/10商12餘3 result=12*10+3=123 
             //12/10商1餘2 result=123*10+2=1232 1/10商0餘1 result=1232*10+1=12321
                r = nn % 10;
                result *= 10;//*10才會依次加入數字 放對位置才不會多一個0
                result += r;
                q = nn / 10;//取商數
                nn = q;//商數變為下一輪的被除數 
            }
            while (q != 0);

            Response.Write(result);
            //if (n == result)
            //    Response.Write(result + "是迴文");
            //else
            //    Response.Write(result + "不是迴文");
        }
    }
}