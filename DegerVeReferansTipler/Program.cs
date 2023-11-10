namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 =30;    
            number1 = number2;  
            // sayi1=30 olur.

            int[] numbers1 = new int[] {10, 20, 30};
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = number2;
            number2[0] = 999; 
            //sayilar1[0] = 999 olur. Açıklama referans tipleri notlarına kayıtlı. tekrar bak.
        }
    }
}