using Logic_Dasar;

public class MainLogic
{
    public static void Main()
    {
        Console.WriteLine("Masukkan angka : ");
        string? input = Console.ReadLine();

        int n = input == null ? 0 : int.Parse(input);

        Logic02Soal01.CetakData(n);
        Logic02Soal02.CetakData(n);
        Logic02Soal03.CetakData(n);
    }
}