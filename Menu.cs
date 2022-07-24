
namespace Transportasi
{
    class Menu : IMenu
    {
        string nik, nama, nohp, noKartuVaksin;
        bool vaksinKe3 = false;
        Alamat alamatRumah, alamatKantor;
        public void display()
        {
            Console.WriteLine("====Program Informasi Pemesanan Tiket sederhana====");
            Console.WriteLine("Silakan inputkan data diri Anda");

            Console.Write("Nama: ");
            nama = Console.ReadLine();
            Console.Write("NIK: ");
            nik = Console.ReadLine();
            Console.Write("NoHP: ");
            nohp = Console.ReadLine();
            Console.Write("No. Kartu Vaksin: ");
            noKartuVaksin = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Apakah Anda sudah vaksin ke-3? (y/n) ");
            string isSudahVaksin3 = Console.ReadLine();
            if (isSudahVaksin3 == "y" || isSudahVaksin3 == "Y") vaksinKe3 = true;

            Console.WriteLine("");
            this.alamatRumah = this.displayAlamat("Rumah");


            Console.WriteLine("");
            Console.Write("Apakah Anda ingin menambahkan alamat kantor? (y/n) ");
            string isAlamatKantor = Console.ReadLine();
            if (isAlamatKantor == "y" || isAlamatKantor == "Y")
            {
                this.alamatKantor = this.displayAlamat("Kantor");
            }

            Pengguna<Alamat> kelompok5 = new Pengguna<Alamat>(nama,nik,nohp,noKartuVaksin,alamatRumah);
            if(alamatKantor!=null) kelompok5.setAlamatKantor(alamatKantor);
            kelompok5.setSudahVaksinKe3(vaksinKe3);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("===Informasi data diri Anda sebagai berikut===");
            Console.WriteLine(kelompok5.ToString());
        }

        public Alamat displayAlamat(string jenis)
        {
            int rt, rw;
            string kecamatan, kabupaten, provinsi;
            Console.WriteLine($"Silakan Inputkan Alamat {jenis} Anda");
            Console.Write("RT: ");
            rt = Convert.ToInt32(Console.ReadLine());
            Console.Write("RW: ");
            rw = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kecamatan: ");
            kecamatan = Console.ReadLine();

            Console.Write("Kabupaten: ");
            kabupaten = Console.ReadLine();

            Console.Write("Provinsi: ");
            provinsi = Console.ReadLine();
            Alamat alamat = new Alamat(rt, rw, kecamatan, kabupaten, provinsi);



            Console.Write("Apakah Anda ingin menambahkan catatan? (y/n) ");
            string isTambahCatatan = Console.ReadLine();
            if (isTambahCatatan == "y" || isTambahCatatan == "Y")
            {
                Console.Write("Catatan: ");
                alamat.setCatatan(Console.ReadLine());
            }

            return alamat;
        }
    }
}