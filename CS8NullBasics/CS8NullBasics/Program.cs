//#nullable enable // enable it to be non nullable

using System;

namespace CS8NullBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //#nullable disable
            //string? message = null;
            Message message = new Message
            {
                //Text = "Hello there!",
                Text = null!,
                From = null
            };
            //#nullable enable
            //Console.WriteLine(message);

            MessagePopulator.Populate(message);
            Console.WriteLine(message.Text);
            //Console.WriteLine(message.From ?? "no from");
            Console.WriteLine(message.From);
            Console.WriteLine(message.From!.Length); //null forgiving operator only affects compile time
            Console.WriteLine(message.ToUpperFrom());
            //string is a reference type
            Console.WriteLine("Press enter to end");
            Console.ReadLine(); //preventing the console app from exiting until pressing enter
        }
    }
}
