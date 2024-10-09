namespace HomeTAsk_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            string cumle = "Salam Men Emin";
            bashHerf(cumle);
        }
        static void bashHerf(string cumle)
        {
            for(int i = 0; i < cumle.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(cumle[i]);
                }
                if( i>0 && cumle[i] == ' ')
                {
                    Console.WriteLine(cumle[i + 1]);
                }
                  
                
            }
        }
    }
}