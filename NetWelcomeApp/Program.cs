namespace NetWelcomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // types:
            bool flag = true; // true | false
            Boolean flag1;


            byte b = 107; // 0..255
            Byte b1;

            sbyte sb = -100; //-128..127
            SByte sb1;

            short sshort = -100; // -32768..32767
            Int16 sh2;

            ushort ush = 1000; // 0..65535
            UInt16 sh3;

            int n;
            Int32 n2;

            uint un = 100U;
            UInt32 un2;

            long ln = 123L;
            Int64 ln2;

            ulong ul = 100000UL;
            UInt64 uln2;

            float x = 100.5F;
            Single x2;

            double y = 345.8;
            Double y2;

            decimal z = 1977M;
            Decimal z2;


            char ch = 'y';
            Char ch2;

            // classes

            string str = "hello world";
            String str2;

            object obj;
            Object obj2;



            int c = Sum(10, 20);


            Console.Write("Hello \t");
            Console.WriteLine("Hello, World!");

            int number = Int32.Parse(Console.ReadLine());

        }

        static int Sum(int a , int b)
        {
            return a + b;
        }
    }
}