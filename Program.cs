class Program
{
    static void Main(string[] args)
    {
        DataSiswa siswa = new DataSiswa();
        Quest quest = new Quest();

        siswa.nama = "Rizki";
        siswa.alamat = "Jakarta";
        siswa.umur = 18;
        siswa.beratBadan = 70.5f;
        siswa.isMenikah = true;

        System.Console.WriteLine(quest.options[1]);
        
        System.Console.WriteLine("Nama : " + siswa.nama);
        System.Console.WriteLine("Alamat : " + siswa.alamat);
        System.Console.WriteLine("Umur : " + siswa.umur);
        System.Console.WriteLine("Berat Badan : " + siswa.beratBadan);
        System.Console.WriteLine("Status Menikah : " + siswa.isMenikah);
    }
}
