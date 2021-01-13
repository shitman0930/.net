using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp2.Controllers
{//把_05HW3改為傳值呼叫(記憶體會很容易爆)或傳址呼叫 把功能分開 解耦
 //傳值呼叫在此例中(呼叫4次陣列)耦合力非常高 不如直接用_05HW3(呼叫一次陣列)全部寫在一起還比較好
    public class _06FunctionController : Controller
    {
        ///<summary>
        ///底下是傳值呼叫(Call by Value)的寫法
        ///<summary>
        //主程式 
        //    public void PlayGame()
        //    {  //return poker就回到GameInit() 用a接住傳到Shuffle
        //        string[] a = GameInit();
        //       //接住之後 Shuffle也要換資料型別的參數
        //        a = Shuffle(a);
        //       //跟上面一樣 DealCard也要換資料型別的參數 但不必有回傳值
        //        DealCard(a);
        //    }
        //    //初始化(把index值變回正常的1到52)
        //    private string[] GameInit()
        //    {
        //        string[] poker = new string[52];//index為0到51
        //        for (int i = 0; i < 52; i++)
        //        {
        //            poker[i] = (i + 1).ToString();//變回正常的1到52丟回去poker[i]
        //        }
        //        //傳值呼叫 字串陣列 所以要有回傳值 void改成string[]
        //        return poker;
        //    }
        //    //洗牌 修飾詞 可否公開使用
        //    private string[] Shuffle(string[] poker)
        //    {
        //        Random r = new Random();
        //        int t = 0;
        //        string tmp = "";//類似費式數列有暫存空間跟兩數交換的概念
        //        for (int i = 0; i < poker.Length; i++)
        //        {
        //            t = r.Next(52);//隨機洗牌
        //            tmp = poker[i];
        //            poker[i] = poker[t];//跟亂數值交換
        //            poker[t] = tmp;//原本的poker[i]變成poker[t]
        //        }
        //        //跟上面一樣 不贅述
        //        return poker;
        //    }
        //    //發牌
        //    private void DealCard(string[] poker)
        //    {
        //        string p1 = "";
        //        string p2 = "";
        //        string p3 = "";
        //        string p4 = "";
        //        string result = "";//就暫存空間啦

        //        for (int i = 0; i < poker.Length; i++)
        //        {//因為上面的洗牌 poker[i]已經是亂數了
        //            result = "<img src='../poker_img/" + poker[i] + ".gif'>";
        //            switch (i % 4)//餘數一定比除數小 0123
        //            {
        //                case 0:
        //                    p1 += result;
        //                    break;
        //                case 1:
        //                    p2 += result;
        //                    break;
        //                case 2:
        //                    p3 += result;
        //                    break;
        //                case 3:
        //                    p4 += result;
        //                    break;
        //            }
        //        }
        //        Response.Write("玩家1:" + p1 + "<hr>");
        //        Response.Write("玩家2:" + p2 + "<hr>");
        //        Response.Write("玩家3:" + p3 + "<hr>");
        //        Response.Write("玩家4:" + p4 + "<hr>");
        //    }

        ///<summary>
        ///底下是傳址呼叫(Call by Reference)的寫法 
        ///直接傳記憶體位址 不用宣告也不用return
        ///<summary>
        //主程式
        public void PlayGame()
        {    //直接在主程式宣告陣列
            string[] poker = new string[52];//index為0到51
            //ref 取得索引值位置而非值
            GameInit(ref poker);
            Shuffle(ref poker);
            DealCard(ref poker);
        }
        //初始化(把index值變回正常的1到52) ref 取得索引值位置而非值
        private void GameInit(ref string[] poker)
        {

            for (int i = 0; i < 52; i++)
            {
                poker[i] = (i + 1).ToString();//變回正常的1到52丟回去poker[i]
            }
            //ref就不用return值
        }
        //洗牌 修飾詞(private..public..) 可否公開使用 ref 取得索引值位置而非值
        private void Shuffle(ref string[] poker)
        {
            Random r = new Random();
            int t = 0;
            string tmp = "";//類似費式數列有暫存空間跟兩數交換的概念
            for (int i = 0; i < poker.Length; i++)
            {
                t = r.Next(52);//隨機洗牌
                tmp = poker[i];
                poker[i] = poker[t];//跟亂數值交換
                poker[t] = tmp;//原本的poker[i]變成poker[t]
            }
            //ref就不用return值
        }
        //發牌
        private void DealCard(ref string[] poker)
        {
            string p1 = "";
            string p2 = "";
            string p3 = "";
            string p4 = "";
            string result = "";//就暫存空間啦

            for (int i = 0; i < poker.Length; i++)
            {//因為上面的洗牌 poker[i]已經是亂數了
                result = "<img src='../poker_img/" + poker[i] + ".gif'>";
                switch (i % 4)//餘數一定比除數小 0123
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