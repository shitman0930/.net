using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp.Controllers
{
    public class _01VarController : Controller
    {
        // GET: _01Var
        public string Index()//資料型別宣告非常重要 公開回傳字串 所有專案建置必須正確 條件非常嚴苛 如果建置只顯示最新 就右鍵重建
        {   //C#變數宣告與初始化直接寫資料型別
            string w = "Hello world";
            w = "12345";//值跟JS一樣 會被換掉
            return w;
        }
        public string boolIndex(bool gender)//gender給bool用的
        {
            //布林值
            bool w = gender;//?gender = true
            if (w)
                return "男生";//通常return只會寫一次 判斷式(if)是例外

            return "女生";
        }

        public string stringIndex(string name, bool gender)//gender給bool用的
        {
            //布林值
            string g = name;
            bool w = gender;//?gender = true
            string r = "";
            if (w)
                r = w ? "男生" : "女生";//通常return只會寫一次(三元運算) 判斷式是例外

            return "<h1>" + g + "你好, 您的性別是" + r + "</ h1 >";//會有html效果
        }

        public string googleMap(string addr)
        {   //利用第三方 API在哪裡傳值
            //我們專案要寫的 會一直重複 寫個forloop 只要?addr=就可以連到任何地址 行程規劃
            return "<a href='https://www.google.com/maps/place/" + addr + "' target='_black'>點我前往</a>";
        }

        public void numberIndex()//公開回傳數值 void沒有回傳值
        {
            //數值 
            byte a = 123; //0到255整數值(8位元正整數) 空間複雜度
            sbyte b = 123; //-128到+127整數值(8位元整數) 可以表示負數
            short c = 122; //短整數 含正負數的16位元整數(-32768~32767, -2的16次方到+2的16次方-1)
            int d = 234;//含正負數的32位元整數
            long e = 3882;//含正負數的64位元整數

            //數值絕對不是負整數的時候
            ushort f = 123;//16位元正整數
            uint g = 123; //32位元正整數
            ulong h = 123; //64位元正整數

            //小數(浮點數) 無窮小數(3.14.......)可以取多少位取決於精準度 雙>單
            float i = 123.333f;//單精準度浮點數 要有f
            double j = 123.54664;//雙精準度浮點數
        }
    }
}

//變數命名原則
//1.不可以用保留字
//2.開頭必須是英文字母或底線 class _01.....
//3.同一支程式區塊內,變數名稱不可重複,大小寫視為不同 變數區域性(Scope)

//變數命名原則
//1.使用有意義的名稱
//2.使用匈牙利命名法 JS也有講 區別在"資料型別"
//string strStudentNo = "12345678"; 駝峰命名法
//int intNumber = 123;