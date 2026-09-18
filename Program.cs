string namaSiswa;
int nilaiSiswa;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.WriteLine("Masukkan nama siswa: ");
namaSiswa = Console.ReadLine();

Console.WriteLine("Masukkan nilai siswa: ");
nilaiSiswa = int.Parse(Console.ReadLine()!);

if (nilaiSiswa >= 75)
{
    Console.WriteLine($"Selamat {namaSiswa}, Anda lulus dengan nilai {nilaiSiswa}");
}
else
{
    Console.WriteLine($"Maaf kepada {namaSiswa}, Anda tidak lulus dengan nilai {nilaiSiswa}");
}
