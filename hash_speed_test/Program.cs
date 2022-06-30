using System;

namespace hash_speed_test
{
    class Program
    {
        static TimeSpan StartTest(string hashName,int loopCount)
        {
            Notus.Hash md5obj = new Notus.Hash();
            DateTime startTime = DateTime.Now;
            for (int a = 0; a < loopCount; a++)
            {
                
                md5obj.CommonSign(hashName, a.ToString());
                //md5obj.CommonHash(hashName, a.ToString());
            }
            DateTime finishTime = DateTime.Now;
            TimeSpan ts = finishTime - startTime;
            return ts;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int testCount = 500000;
            TimeSpan ts;

            ts = StartTest("md5", testCount);
            Console.WriteLine("MD5 Seconds (Difference) = {0}", (ts.TotalSeconds ));

            ts = StartTest("sha1", testCount);
            Console.WriteLine("SHA1 Seconds (Difference) = {0}", (ts.TotalSeconds));

            ts = StartTest("ripemd160", testCount);
            Console.WriteLine("ripemd160 Seconds (Difference) = {0}", (ts.TotalSeconds ));

            ts = StartTest("sasha", testCount);
            Console.WriteLine("sasha Seconds (Difference) = {0}", (ts.TotalSeconds ));

            ts = StartTest("sha256", testCount);
            Console.WriteLine("sha256 Seconds (Difference) = {0}", (ts.TotalSeconds ));

            ts = StartTest("sha512", testCount);
            Console.WriteLine("sha512 Seconds (Difference) = {0}", (ts.TotalSeconds ));

            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
