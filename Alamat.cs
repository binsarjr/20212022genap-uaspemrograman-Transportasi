namespace Transportasi
{
    /*@Polymorphism
    Terdapat polymorphism pada class method yaitu polymorphism statis

    terdapat dua method yang pertama full memformat alamat ke string
    Sedangkan, method kedua ada tambahan prefix untuk menambahkan kata di depan
    sebelum diformat
    */
    class Alamat : BaseAlamat
    {
        int rt, rw;
        string kecamatan, kabupaten, provinsi, catatan;
        public Alamat(int _rt, int _rw, string _kecamatan, string _kabupaten, string _provinsi)
        {
            rt = _rt;
            rw = _rw;
            kecamatan = _kecamatan;
            kabupaten = _kabupaten;
            provinsi = _provinsi;

            catatan = "";
        }

        public void setCatatan(string note)
        {
            catatan = note;
        }

        public override string format()
        {
            if (catatan != "")
            {
                catatan = $" (Catatan: {catatan})";
            }
            return $"RT {rt} RW {rw} Kec. {kecamatan} Kab. {kabupaten} Prov. {provinsi}{catatan}";
        }

        public string format(string prefix)
        {
            return prefix + this.format();
        }
    }
}