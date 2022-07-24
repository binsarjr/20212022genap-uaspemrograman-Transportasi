namespace Transportasi
{
    /**@Interface
    
    Digunakan untuk membuat kontrak dengan class Menu yang mana class Menu wajib
    membuat method display dan displayAlamat
    */
    interface IMenu
    {
        void display();
        Alamat displayAlamat(string jenis);
    }
}