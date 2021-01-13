using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp2.Controllers
{
    public class _03HW1Controller : Controller
    {
        public void No1()
        {
            int a = 42;
            float b = 2.5f;

            Response.Write("a + b =" + (a + b));
            Response.Write("<hr>");
            Response.Write("a - b =" + (a - b));
            Response.Write("<hr>");
            Response.Write("a * b =" + a * b);
            Response.Write("<hr>");
            Response.Write("a / b =" + a / b);
            Response.Write("<hr>");
            Response.Write("a % b =" + a % b);
            Response.Write("<hr>");
        }
        public float No2(float c)
        {
            return c * 9 / 5 + 32;
        }
        public void No3(int x, int y)
        {
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
            Response.Write("交換後x=" + x + ", y=" + y);
        }
        public void No4(int score)
        {
            if(score<0 || score>100)
                Response.Write("請輸入正確的成績");
            else { 
            int result = score / 10;

               switch (result)
                 {
                case 10:    
                case 9:
                    Response.Write("優等");
                    break;
                case 8:
                    Response.Write("甲等");
                    break;
                case 7:
                    Response.Write("乙等");
                    break;
                case 6:
                    Response.Write("丙等");
                    break;

                default:
                    Response.Write("丁等");
                    break;
            }
            }
        }
        public void No5(int n)
        { for(int i = 1; i <= n; i++)
            {
                if (i % 5 != 0)
                    Response.Write(i+" ");
            }  
        }
        public void No6(int n)
        {
            decimal sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0)
                    sum += i;
                    
            }
            Response.Write(sum);
        }
        public void No7(int n)
        {
            int i = 1;
            string r = "";
            while (i<=n)
            {
                r += "*";
                Response.Write(r + "<br>");
                i++;

            }
        }
        public void No8()
        {

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Response.Write(i + "*" + j + "=" + i * j + " ");
                }
                Response.Write("<hr>");
                }
        }
    }
}