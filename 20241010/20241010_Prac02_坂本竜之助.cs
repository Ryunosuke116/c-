using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241010
{
    internal class _20241010_Prac01_name
    {
         public struct Record
        {
            private int amount;          //収入
            private DateTime date;       //日付
            public string memo;          //メモ

            public int Amount
            {
                get { return amount; }
                set { amount = value; }
            }
            public DateTime Date
            {
                get { return date; }
                set { date  = value; }
            }
         };
        static void Main(string[] args)
        {
            Record record = new Record();

            //　収入
            List<Record> revenue = new List<Record>();
            //  支出
            List<Record> expenditure = new List<Record>();

            while (true)
            {
                record = new Record();

                //金額入力
                Console.WriteLine("金額を入力してください。");
                record.Amount = int.Parse(Console.ReadLine());

                //日付入力
                Console.WriteLine("日付を入力してください。");
                record.Date = DateTime.Parse(Console.ReadLine());

                //メモ
                Console.WriteLine("メモを入力してください。");

                Console.WriteLine("まだ記録しますか？");
            }
        }
    }
}
