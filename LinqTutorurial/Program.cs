using LinqTutorurial;
using LinqTutorurial.Model;

public class ProgramMain
{
    public static void Main()
    {
        //IntroductionLinq();
        //Product.SampleFilterProduct();
        Product.SampleFilterByName();

    }
    #region Introduction
    public static void IntroductionLinq()
    {
        Console.WriteLine("Introduction without LinQ : ");
        IntroLinq.Introduction();
        Console.WriteLine("\n Intro with Linq");
        IntroLinq.IntroductionWithLinq();
    }
    #endregion

}