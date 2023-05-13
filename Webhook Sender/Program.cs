using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection.PortableExecutable;

namespace Webhook_Sender
{
    internal class Program
    {
        public static void sendWebHook(string URL, string msg, string username)
        {
            Http.Post(URL, new NameValueCollection()
        {
                {
                    "username",
                        username
                },
                {
                    "content",
                        msg
                }
            });
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Webhook URL: ");
            Console.ForegroundColor = ConsoleColor.White;
            string webHookUrl = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Message: ");
            Console.ForegroundColor = ConsoleColor.White;
            string messageTBS = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Username: ");
            Console.ForegroundColor = ConsoleColor.White;
            string webHookUserName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Times to send: ");
            Console.ForegroundColor = ConsoleColor.White;
            string tts = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Delay: ");
            Console.ForegroundColor = ConsoleColor.White;
            string delay = Console.ReadLine();
            int x1 = 0;
            int d1 = 1;
            Int32.TryParse(delay, out d1);
            Int32.TryParse(tts, out x1);
            for (int i = 0; i < x1; i++)
                sendWebHook(webHookUrl, messageTBS, webHookUserName);
            Thread.Sleep(d1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("DONE!");
            Console.ReadKey();
            Console.Clear();
            string cdir = Environment.CurrentDirectory;
            Process.Start(cdir + @"\Webhook Sender.exe");
        }
    }
}