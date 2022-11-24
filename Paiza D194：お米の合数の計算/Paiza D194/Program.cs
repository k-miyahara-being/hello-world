using System;

namespace Paiza_D194 {
    class Program {
        static void Main(string[] args) {
            //1 合あたり 540 kcalとして1日に食べるお米の量 n 合が与えられるので何 kcal摂取するのかを出力してください。

            //1回目の提出
            //var n = int.Parse(Console.ReadLine());//入力した整数を読み込む            
            //Console.WriteLine("{0}",n * 540);//フォーマット出力」

            //2回目の提出
            //if(double.TryParse(Console.ReadLine(), out double n) == true && n >= 0){
            //    Console.WriteLine($"{n * 540}");//文字列補間
            //}
            //else if(n < 0) {
            //    Console.WriteLine("正の値を入力してください");
            //}
            //else{
            //    Console.WriteLine("正の数字を入力してください。");
            //}

            //3回目の提出
            if(!double.TryParse(Console.ReadLine(), out double n)){
                Console.WriteLine("数字を入力してください");
                return;
            }
            if(n < 0){
                Console.WriteLine("正の数字を入力してください");
            }
            if(n >= 0){
                Console.WriteLine($"{n * 540}");
            }
        }
    }
}
