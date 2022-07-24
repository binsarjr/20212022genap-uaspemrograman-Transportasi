namespace Transportasi
{
    /*@Dependecies
        class Pengguna memiliki ketergantungan terhadapat class Alamat

        alamatRumah merupakan dependecies constructor inject
        Sedangkan, alamatKantor merupakan dependecies setter inject
    */
    /*@Generic Class Pengguna untuk Alamat
        
        class Pengguna menggunakan alamat via generic
        dengan generic yang harus instance terhadap class Alamat
    */
    class Pengguna<TypeAlamat> where TypeAlamat : Alamat
    {
        string nama, nik, nohp, noKartuVaksin;
        bool vaksinKe3;
        TypeAlamat alamatRumah, alamatKantor;
        public Pengguna(
            string nama,
            string nik,
            string nohp,
            string noKartuVaksin,
            TypeAlamat alamatRumah
        )
        {
            this.nama = nama;
            this.nik = nik;
            this.nohp = nohp;
            this.noKartuVaksin = noKartuVaksin;
            this.alamatRumah = alamatRumah;
            vaksinKe3 = false;
        }
        public void setAlamatKantor(TypeAlamat _alamatKantor)
        {
            alamatKantor = _alamatKantor;
        }

        public void setSudahVaksinKe3(bool status)
        {
            vaksinKe3 = status;
        }

        public override string ToString()
        {
            string vaksinKe3Str = "\nStatus Vaksin Ke-3: ";
            if (vaksinKe3)
            {
                vaksinKe3Str += "Sudah Vaksin";
            }
            else
            {
                vaksinKe3Str += "Belum Vaksin";
            }

            string alamatKantorStr = "";
            if (alamatKantor != null)
            {
                alamatKantorStr = alamatKantor.format("\nAlamat Kantor: ");
            }

            return $"Nama: {nama}\n" + $"NIK: {nik}\nNoHP: {nohp}\nNo Kartu Vaksin: {noKartuVaksin}\nAlamat Rumah: {alamatRumah.format()}{alamatKantorStr}{vaksinKe3Str}";
        }
    }
}