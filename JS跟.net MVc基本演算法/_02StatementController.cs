using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp2.Controllers
{
    public class _02StatementController : Controller
    {
        // GET: _02Statement
        public void Statement()
        {
            int a = 10;
            a = 20;
            a = a + 10;
            a += 10;
            a -= 15;
            a *= 10;
            a /= 25;

            a = a + 1;
            a += 1;
            a++;

            Response.Write("a=" + a);
            Response.Write("<hr>");

            int x = 123;
            float z = 12.13456f;
            float result = 0;

            result = x + z;
            Response.Write("x + z=" + result);
            Response.Write("<hr>");

            float xx = 10000.9f;
            double yy = 9999.3;

            Response.Write("xx + yy=" + ((decimal)xx+(decimal)yy));
            Response.Write("<hr>");
            Response.Write("xx - yy=" + ((decimal)xx-(decimal)yy));

        }
        public string ifStatement(int age)
        {
            if (age > 20)
                return "全票";
            else if (age > 6)
                return "半票";
            else if (age >= 0)
                return "免票";

            return "年齡輸入錯誤";

        }
        public string switchStatement(string color)
        {
            switch (color)
            {
                case "黃":
                    return "黃色";

                case "綠":
                    return "綠色";

                case "紅":
                    return "紅色";
            }
            return "這不是黃綠紅";
        }
        public void forStatement()
        {
            string[] arrRainbow = { "紅", "橙", "黃", "綠", "藍", "靛", "紫" };
            string[] arrColor = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };

            for(int i=0;i<arrRainbow.Length; i++)
            {
                Response.Write("<span style='font-size:3rem;color:" + arrColor[i] + "'>" + arrRainbow[i] + "</span>");
            }


        }
        public void foreachStatement()
        {
            string[] arrRainbow = { "紅", "橙", "黃", "綠", "藍", "靛", "紫" };
            string[] arrColor = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
            int i = 0;
            foreach (string item in arrRainbow)
            {
                Response.Write("<span style='font-size:3rem;color:" + arrColor[i] + "'>" + item + "</span>");
                i++;
            }


        }

        public void whileStatement()
        {
            int i = 1;

            while (i<=52)
            {
                Response.Write("<img src='../poker_img/"+i+".gif' />");
                i++;
        }
      }
        public void dowhileStatement()
        {
            int i = 1;

           do 
            {
                Response.Write("<img src='../poker_img/" + i + ".gif' />");
                i++;
            }
            while (i <= 52) ;
        }
    }
}