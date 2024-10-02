// Declare several variables by selecting for eact one of them the most appropriate of the type sbyte byte short ushort int uint long and ulong in order to assign them the following 
// values: 52.130;-115;485932;97;-10000;20000;224;970,700,000;112;-44;-1,000,000;1990;123456789123456789.
namespace Lab2
{
    public class Q1
    {
        public static void run(string[] args)
        {
            sbyte sbyteVar1 = -44;
            sbyte sbyteVar2 = -115;

            byte byteVar1 = 52;
            byte byteVar2 = 97;
            byte byteVar3 = 112;
            byte byteVar4 = 224;

            short shortVar1 = -10000;
            short shortVar2 = 1990;

            ushort ushortVar1 = 20000;

            int intVar1 = 485932;
            int intVar2 = -1000000;

            uint uintVar1 = 970700000;

            long longVar1 = 123456789123456789;

            ulong ulongVar1 = 123456789123456789UL;
            Console.WriteLine("Declared All Variables!");
        }
    }
}