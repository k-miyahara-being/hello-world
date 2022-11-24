using System;

namespace Paiza_D199_お餅の個数 {
    class Program {
        static void Main(string[] args) {
//            あなたは正月に向けてお餅の用意をしています。

//1 人当たり n 個のお餅を m 人分用意します。
//合計で何個のお餅が必要か出力してください。

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(n * m);
        }
    }
}
