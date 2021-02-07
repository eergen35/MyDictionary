using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> NameAge = new MyDictionary<string, int>();
            NameAge.Add("aaaaa", 34);
            NameAge.Add("bbbbb", 20);
            NameAge.Add("ccccc", 30);
            NameAge.Add("ddddd", 40);


            Console.WriteLine(NameAge.Count);

            NameAge.ShowList();


        }
    }
}