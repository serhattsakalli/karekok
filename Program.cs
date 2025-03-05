namespace karekok;

class Program
{
    static void Main(string[] args)
    {
        /*Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan. Küçük olanların farklarının toplamını, büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulamasını yazınız.
                               Örnek: Input: 56 45 68 77                          Output: 33 101*/


          string input = Console.ReadLine();
          string[] numbers=input.Split(' ');
          List<int> sayilar=new List<int>();
          List<int> bsayilar=new List<int>();
          for (int i = 0; i < numbers.Length; i++)
          {
            if (int.Parse(numbers[i])<=67)
                {
                 sayilar.Add(67-int.Parse(numbers[i]));
                }
            else
                {
                bsayilar.Add(int.Parse(numbers[i])-67);
                }
          }
          for (int i = 1; i < sayilar.Count; i++)
          {
             Console.Write(sayilar[i]+sayilar[i-1]);
          }
          for (int i = 1; i < bsayilar.Count; i++)
          {
            Console.Write((bsayilar[i]*bsayilar[i])+(bsayilar[i-1]*bsayilar[i-1]));
          }
        Console.ReadLine();
    }
}
