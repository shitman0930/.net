using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp2.Controllers
{
    public class _05HW3Controller : Controller
    {
        //亂數物件用法
        public void Rfunction()
        {
            Random r = new Random();
            //回傳100到500之間的隨機正整數
            Response.Write(r.Next(100,500));
        }
        public void DealCard()
        {   //初始化(把index值變回正常的1到52)
            string[] poker = new string[52];//index為0到51
            for(int i = 0; i < 52; i++)
            {
                poker[i] = (i+1).ToString();//變回正常的1到52丟回去poker[i]
            }
            //讀取內容
            //foreach (string item in poker)
            //  Response.Write(item+",");

            //洗牌
            Random r = new Random();
            int t = 0;
            string tmp = "";//類似費式數列有暫存空間跟兩數交換的概念
            for(int i=0;i < poker.Length; i++)
            {
                t = r.Next(52);//隨機洗牌
                tmp = poker[i];
                poker[i] = poker[t];//跟亂數值交換
                poker[t] = tmp;//原本的poker[i]變成poker[t]
            }
            //讀取內容
            //foreach (string item in poker)
            //    //路徑會隨著資料夾位置而變
            //    Response.Write("<img src='../poker_img/"+item+".gif'>");

            //發牌(p1p2p3p4p1p2p3p4這樣發牌)
            string p1 = "";
            string p2 = "";
            string p3 = "";
            string p4 = "";
            string result = "";//就暫存空間啦

            for (int i=0;i<poker.Length;i++)
            {//因為上面的洗牌 poker[i]已經是亂數了
                result = "<img src='../poker_img/" + poker[i] + ".gif'>";
                switch (i%4)//餘數一定比除數小 0123
                {
                    case 0:
                        p1 += result;
                        break;
                    case 1:
                        p2 += result;
                        break;
                    case 2:
                        p3 += result;
                        break;
                    case 3:
                        p4 += result;
                        break;
                }
            }
            Response.Write("玩家1:" + p1 + "<hr>");
            Response.Write("玩家2:" + p2 + "<hr>");
            Response.Write("玩家3:" + p3 + "<hr>");
            Response.Write("玩家4:" + p4 + "<hr>");

        }
    }
}