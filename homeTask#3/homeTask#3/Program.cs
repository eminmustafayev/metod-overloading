namespace homeTask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cumle = "men bu gun codeacademy e gedirem";
            boshluqYoxdu(cumle);
        }
        static void boshluqYoxdu(string cumle)
        {
            for (int i = 0; i < cumle.Length; i++)
            {
                int ascii_pos = (int)cumle[i];
                if (ascii_pos == 32)
                {
                    continue;

                }
                Console.Write(cumle[i] );
            }
        }
    }
}