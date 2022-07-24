namespace Transportasi
{
    /**@Inheritance - BaseAlamat

    Sebagai parent class yang secara default memiliki method format
    dan bisa diubah oleh childnya.
    */
    class BaseAlamat
    {
        public virtual string format() {
            return "BaseAlamat.Format";
        }
    }
}