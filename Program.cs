using System;

namespace Snake 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map.Instance().Start();
            Snake.Instance().Start();

            for(; ; )
            {
                Map.Instance().Update();
                Snake.Instance().Update();

                Map.Instance().Draw();
                Snake.Instance().Draw();

                Thread.Sleep(100);
            }
        }
    }
}