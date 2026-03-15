using System;

class Program
{
    static void Main(string[] args)
    {
        KodePos kode = new KodePos();

        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();

        string hasil = kode.getKodePos(kelurahan);

        Console.WriteLine("Kode Pos: " + hasil);
    }
}