using Logic_Dasar;

public class MainLogic
{
    public static void Main()
    {
        Console.WriteLine("Masukkan angka : ");
        string? input = Console.ReadLine();

        int n = input == null ? 0 : int.Parse(input);

        Console.WriteLine("No 1" + "\n");
        Logic02Soal01.CetakData(n);
        Console.WriteLine("No 2" + "\n");
        Logic02Soal02.CetakData(n);
        Console.WriteLine("No 3" + "\n");
        Logic02Soal03.CetakData(n);
        Console.WriteLine("No 4" + "\n");
        Logic02Soal04.CetakData(n);
        Console.WriteLine("No 5" + "\n");
        Logic02Soal05.CetakData(n);
        Console.WriteLine("No 6" + "\n");
        Logic02Soal06.CetakData(n);
        Console.WriteLine("No 7" + "\n");
        Logic02Soal07.CetakData(n);
        Console.WriteLine("No 8" + "\n");
        Logic02Soal08.CetakData(n);
    }
}