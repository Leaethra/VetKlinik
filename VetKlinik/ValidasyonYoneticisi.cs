using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetKlinik
{
    public class ValidasyonYoneticisi
    {
        //ANIMAL
        public bool ValidateGetAnimal(TblHayvanlar hasta, out string mesaj)
        {
            mesaj = "";
            return true;
        }

        public bool ValidateCreateAnimal(TblHayvanlar hasta, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (hasta == null)
                mesaj = "Hayvan veri giriş bilgileri hatalı.";
            else if (string.IsNullOrWhiteSpace(hasta.CipNo))
                mesaj = "Çip numarası alanı boş bırakılamaz.";
            else if (string.IsNullOrWhiteSpace(hasta.HastaAdi))
                mesaj = "Hasta Adı alanı boş bırakılamaz.";
            else if (VeriYoneticisi.DoesChipExist(hasta.CipNo))
                mesaj = "Bu çip numarasına sahip bir hayvan sistemde zaten kayıtlı.";
            else
                don = true;

            return don;
        }

        public bool ValidateUpdateAnimal(TblHayvanlar hasta, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (hasta == null || hasta.HastaID == 0)
                mesaj = "Güncellenecek hayvana ait geçerli bir ID bulunamadı.";
            else if (string.IsNullOrWhiteSpace(hasta.HastaAdi))
                mesaj = "Hasta Adı alanı boş bırakılarak güncelleme yapılamaz.";
            else if (string.IsNullOrWhiteSpace(hasta.CipNo))
                mesaj = "Çip numarası boş bırakılarak güncelleme yapılamaz.";
            else
                don = true;

            return don;
        }

        public bool ValidateDeleteAnimal(TblHayvanlar hasta, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (hasta == null || hasta.HastaID == 0)
                mesaj = "Silinecek hayvana ait geçerli bir ID bulunamadı.";
            else
                don = true;

            return don;
        }

        //OWNER
        public bool ValidateGetOwners(out string mesaj)
        {
            mesaj = "";
            return true;
        }

        public bool ValidateCreateOwner(TblSahipler sahip, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (sahip == null)
                mesaj = "Sahip veri giriş bilgileri hatalı.";
            else if (string.IsNullOrWhiteSpace(sahip.AdSoyad))
                mesaj = "Ad Soyad alanı boş bırakılamaz.";
            else if (string.IsNullOrWhiteSpace(sahip.Telefon))
                mesaj = "Telefon numarası alanı boş bırakılamaz.";
            else if (VeriYoneticisi.DoesOwnerExist(sahip.Telefon))
                mesaj = "Bu telefon numarasına sahip bir kullanıcı sistemde zaten kayıtlı.";
            else
                don = true;

            return don;
        }

        public bool ValidateUpdateOwner(TblSahipler sahip, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (sahip == null || sahip.SahipID == 0)
                mesaj = "Güncellenecek sahibe ait geçerli bir ID bulunamadı.";
            else if (string.IsNullOrWhiteSpace(sahip.AdSoyad) && string.IsNullOrWhiteSpace(sahip.Telefon))
                mesaj = "Sahip adı ve telefon numarası alanları boş bırakılarak güncelleme yapılamaz.";
            else
                don = true;

            return don;
        }

        public bool ValidateDeleteOwner(TblSahipler sahip, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (sahip == null || sahip.SahipID == 0)
                mesaj = "Silinecek sahibe ait bir ID bulunamadı.";
            else
                don = true;

            return don;
        }

        //OPERATIONS
        public bool ValidateGetOperations(out string mesaj)
        {
            mesaj = "";
            return true;
        }

        public bool ValidateCreateOperation(TblIslemler islem, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (islem == null)
                mesaj = "İşlem veri giriş bilgileri hatalı.";
            else if (string.IsNullOrWhiteSpace(islem.IslemAdi))
                mesaj = "Yapılacak işlem adı veya tanımı boş bırakılamaz.";
            else if (islem.BirimFiyat == null)
                mesaj = "Yapılacak işlemin birim fiyatı boş bırakılamaz.";
            else
                don = true;

            return don;
        }

        public bool ValidateUpdateOperation(TblIslemler islem, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (islem == null)
                mesaj = "Güncellenecek işleme ait bilgiler bulunamadı.";
            else if (string.IsNullOrWhiteSpace(islem.IslemAdi))
                mesaj = "İşlem adı alanı boş bırakılarak güncelleme yapılamaz.";
            else if (islem.BirimFiyat == null)
                mesaj = "Yapılacak işlemin birim fiyatı boş bırakılarak işlem yapılamaz.";
            else
                don = true;

            return don;
        }

        public bool ValidateDeleteOperation(TblIslemler islem, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (islem == null)
                mesaj = "Silinecek işleme ait bilgiler bulunamadı.";
            else
                don = true;

            return don;
        }

        //EXAMINATION
        public bool ValidateGetExamination(out string mesaj)
        {
            mesaj = "";
            return true;
        }

        public bool ValidateCreateExamination(TblMuayeneKayitlari muayene, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (muayene == null)
                mesaj = "Muayene veri giriş bilgileri hatalı.";
            else
                if (muayene.TeshisveNotlar.Trim() == "")
                    mesaj = "Teşhis ve not alanı boş bırakılamaz.";
                else if (muayene.HastaID == 0)
                    mesaj = "Hasta seçilmeden muayene kaydı yapılamaz.";
                else if (muayene.Ucret == 0)
                    mesaj = "Ücret alanı boş bırakılamaz.";
                else
                    don = true;

            return don;
        }

        public bool ValidateUpdateExamination(TblMuayeneKayitlari muayene, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (muayene == null)
                mesaj = "Güncellenecek muayeneye ait bilgiler bulunamadı.";
            else if (string.IsNullOrWhiteSpace(muayene.TeshisveNotlar))
                mesaj = "Teşhis ve not alanları temizlenerek güncelleme yapılamaz.";
            else if (muayene.Ucret == 0)
                mesaj = "Ücret alanı boş bırakılamaz.";
            else
                don = true;

            return don;
        }

        public bool ValidateDeleteExamination(TblMuayeneKayitlari muayene, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (muayene == null)
                mesaj = "Silinecek muayeneye ait geçerli bilgiler bulunamadı.";
            else
                don = true;

            return don;
        }

        //ANIMALOWNERS
        public bool ValidateGetAnimalOwners(TblHastaSahipleri eslesme, out string mesaj)
        {
            mesaj = "";
            return true;
        }

        public bool ValidateCreateAnimalOwner(TblHastaSahipleri eslesme, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (eslesme == null)
                mesaj = "Eşleştirme veri giriş bilgileri hatalı.";
            else if (eslesme.HastaID == 0)
                mesaj = "Eşleştirme yapabilmek için bir hasta (hayvan) seçmelisiniz.";
            else if (eslesme.SahipID == 0)
                mesaj = "Eşleştirme yapabilmek için bir hasta sahibi seçmelisiniz.";
            else
                don = true;

            return don;
        }

        public bool ValidateUpdateAnimalOwner(TblHastaSahipleri eslesme, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (eslesme == null)
                mesaj = "Güncellenecek eşleşmeye dair veri bulunamadı.";
            else
                don = true;

            return don;
        }

        public bool ValidateDeleteAnimalOwner(TblHastaSahipleri eslesme, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (eslesme == null)
                mesaj = "Silinecek eşleşmeye dair veri bulunamadı.";
            else
                don = true;

            return don;
        }

        //USERS
        public TblKullanicilar ValidateLogin(string kullaniciadi, string sifre, out string mesaj)
        {
            mesaj = "";

            if (string.IsNullOrWhiteSpace(kullaniciadi) || string.IsNullOrWhiteSpace(sifre))
            {
                mesaj = "Kullanıcı adı ve şifre alanları boş bırakılamaz.";
                return null;
            }

            TblKullanicilar kullanici = VeriYoneticisi.LoginCheck(
                kullaniciadi.Trim(),
                sifre.Trim());

            if (kullanici == null)
            {
                mesaj = "Kullanıcı adı veya şifre hatalı.";
                return null;
            }

            return kullanici;
        }

        public bool ValidateGetUsers(out string mesaj)
        {
            mesaj = "";
            return true;
        }

        public bool ValidateCreateUser(TblKullanicilar yeniKullanici, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (yeniKullanici == null)
                mesaj = "Kullanıcı kayıt bilgileri hatalı.";
            else if (string.IsNullOrWhiteSpace(yeniKullanici.KullaniciAdi))
                mesaj = "Kullanıcı adı alanı boş bırakılamaz.";
            else if (string.IsNullOrWhiteSpace(yeniKullanici.Sifre))
                mesaj = "Şifre alanı boş bırakılamaz.";
            else if (yeniKullanici.Sifre.Trim().Length < 4)
                mesaj = "Şifre en az 4 karakterden oluşmalıdır.";
            else if (string.IsNullOrWhiteSpace(yeniKullanici.Yetki))
                mesaj = "Kullanıcı yetkisi seçilmelidir.";
            else if (yeniKullanici.Yetki != "Admin" && yeniKullanici.Yetki != "Kullanici")
                mesaj = "Geçersiz kullanıcı yetkisi.";
            else if (VeriYoneticisi.DoesUserExist(yeniKullanici.KullaniciAdi.Trim()))
                mesaj = "Bu kullanıcı adı zaten alınmış.";
            else
                don = true;

            return don;
        }

        public bool ValidateUpdateUser(TblKullanicilar kullanici, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (kullanici == null || kullanici.KullaniciID == 0)
                mesaj = "Güncellenecek kullanıcıya ait geçerli bir ID bulunamadı.";
            else if (string.IsNullOrWhiteSpace(kullanici.KullaniciAdi))
                mesaj = "Kullanıcı adı alanı boş bırakılamaz.";
            else if (string.IsNullOrWhiteSpace(kullanici.Sifre))
                mesaj = "Şifre alanı boş bırakılamaz.";
            else if (kullanici.Sifre.Trim().Length < 4)
                mesaj = "Şifre en az 4 karakterden oluşmalıdır.";
            else if (string.IsNullOrWhiteSpace(kullanici.Yetki))
                mesaj = "Kullanıcı yetkisi seçilmelidir.";
            else if (kullanici.Yetki != "Admin" && kullanici.Yetki != "Kullanici")
                mesaj = "Geçersiz kullanıcı yetkisi.";
            else
                don = true;

            return don;
        }

        public bool ValidateDeleteUser(TblKullanicilar kullanici, out string mesaj)
        {
            mesaj = "";
            bool don = false;

            if (kullanici == null || kullanici.KullaniciID == 0)
                mesaj = "Silinecek kullanıcıya ait geçerli bir ID bulunamadı.";
            else
                don = true;

            return don;
        }
    }
}
