using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace VetKlinik
{
    //bir sınıf sadece bir sınıftan inherit alabilir.
    //bir sınıf N tane interface'den inherit alabilir.
    //bir sınıf hem sınıftan hem de interface' den inherit alabilir. 
    //ancak önce sınıf sonra interface
    //örnek: Child : MasterSınıf, Interface1, interface2 ...

    public class VeriYoneticisi : DVetKlinikEntities //contextden inherit aldığım ksım 
    {
        //DVetKlinikEntities DbContext = new DVetKlinikEntities();

        public List<TblHayvanlar> GetAnimal()
        {
            return this.TblHayvanlar.ToList(); //onu bulur listeler
        }

        public void CreateAnimal(TblHayvanlar hasta)
        {
            this.TblHayvanlar.Add(hasta);
            SaveChanges();
        }

        public void UpdateAnimal(TblHayvanlar hasta)
        {
            Entry(hasta).State = EntityState.Modified;//entitye veride değişilik olduğunu söylüyorsun
            SaveChanges();
        }

        public void DeleteAnimal(TblHayvanlar hasta)
        {
            this.TblHayvanlar.Remove(hasta);
            SaveChanges();
        }

        public static bool DoesChipExist(string cipNo)
        {
            if (string.IsNullOrEmpty(cipNo))
                return false;//TblHayvanlarda dışarıdan gelen CipNo ile eşleşen kayıt var mı diy bakıyoruz

            using (var db = new DVetKlinikEntities())
            {
                return db.TblHayvanlar.Any(h => h.CipNo == cipNo);
            }
        }

        public TblHayvanlar GetAnimalById(int animalId) //bununla ekranda seçtiğimiz hayvanın bütün kayıtlarını görebileceğiz
        {
            return this.TblHayvanlar.FirstOrDefault(a => a.HastaID == animalId);
        }


        public List<TblSahipler> GetOwners()
        {
            return this.TblSahipler.ToList(); //onu bulur listeler
        }

        public void CreateOwner(TblSahipler sahip)
        {
            this.TblSahipler.Add(sahip);
            SaveChanges();
        }

        public void UpdateOwner(TblSahipler sahip)
        {
            Entry(sahip).State = EntityState.Modified;//entitye veride değişilik olduğunu söylüyorsun
            SaveChanges();
        }

        public void DeleteOwner(TblSahipler sahip)
        {
            this.TblSahipler.Remove(sahip);
            SaveChanges();
        }

        public static bool DoesOwnerExist(string telefon)
        {
            if (string.IsNullOrEmpty(telefon))
                return false;

            using (var db = new DVetKlinikEntities())
            {
                return db.TblSahipler.Any(h => h.Telefon == telefon);
            }
        }

        public bool DoesOwnerHaveAnimal(int sahipID)
        {
            return this.TblHayvanlar.Any(h => h.SahipID == sahipID);
        }

        public TblSahipler GetOwnerById(int ownerId)
        {
            return this.TblSahipler.FirstOrDefault(o => o.SahipID == ownerId); //Shaip id ile sahibin bütün bilgilerini görüntüleyebilirirz
        }


        public List<TblIslemler> GetOperations()
        {
            return this.TblIslemler.ToList();
        }

        public void CreateOperation(TblIslemler islem)
        {
            this.TblIslemler.Add(islem);
            SaveChanges();
        }

        public void UpdateOperation(TblIslemler islem)
        {
            Entry(islem).State = EntityState.Modified;
            SaveChanges();
        }

        public void DeleteOperation(TblIslemler islem)
        {
            this.TblIslemler.Remove(islem);
            SaveChanges();
        }

        public List<TblMuayeneKayitlari> GetExaminations()
        {
            return this.TblMuayeneKayitlari.ToList(); //muayenedeki notlar tarih değiştiğinde
        }

        public void CreateExamination(TblMuayeneKayitlari muayene)
        {
            this.TblMuayeneKayitlari.Add(muayene);//hayvana o gün yapılan muayeneyi işler
            SaveChanges();
        }

        public void UpdateExamination(TblMuayeneKayitlari muayene)
        {
            Entry(muayene).State = EntityState.Modified;
            SaveChanges();
        }

        public void DeleteExamination(TblMuayeneKayitlari muayene)
        {
            this.TblMuayeneKayitlari.Remove(muayene); //muayene kaydını siler
            SaveChanges();
        }

        public List<TblHastaSahipleri> GetAnimalOwners()
        {
            return this.TblHastaSahipleri.ToList(); //hayvan-sahip eşleşmelerini listele
        }

        public void CreateAnimalOwner(TblHastaSahipleri eslesme)
        {
            this.TblHastaSahipleri.Add(eslesme); //bir hayvanı bir sahibe bağlar N:N many to many
            SaveChanges();
        }

        public void UpdateAnimalOwner(TblHastaSahipleri eslesme)
        {
            Entry(eslesme).State = EntityState.Modified; //sahiplik durumunu günceller
            SaveChanges();
        }

        public void DeleteAnimalOwner(TblHastaSahipleri eslesme)
        {
            this.TblHastaSahipleri.Remove(eslesme); //sahiplik bağını sil
            SaveChanges();
        }

        public List<TblKullanicilar> GetUsers()
        {
            return this.TblKullanicilar.ToList();
        }

        public static TblKullanicilar LoginCheck(string kullaniciAdi, string sifre)
        {
            using (var db = new DVetKlinikEntities())
            {
                return db.TblKullanicilar.FirstOrDefault(
                    kullanici => kullanici.KullaniciAdi == kullaniciAdi
                              && kullanici.Sifre == sifre);
            }
        }

        public static bool DoesUserExist(string kullaniciAdi) //böyle bir kullanıcı daha önce var mıydı?
        {
            using (var db = new DVetKlinikEntities())
            {
                return db.TblKullanicilar.Any(kullanici => kullanici.KullaniciAdi == kullaniciAdi);
            }
        }
        public bool IsLastAdmin(int kullaniciID)
        {
            return this.TblKullanicilar.Count(k => k.Yetki == "Admin" && k.KullaniciID != kullaniciID) == 0;
        }

        public void CreateUser(TblKullanicilar yeniKullanici)
        {
            this.TblKullanicilar.Add(yeniKullanici);
            SaveChanges();
        }

        public void UpdateUser(TblKullanicilar kullanici)
        {
            Entry(kullanici).State = EntityState.Modified;
            SaveChanges();
        }

        public void DeleteUser(TblKullanicilar kullanici)
        {
            TblKullanicilar silinecekKullanici = this.TblKullanicilar.FirstOrDefault(k => k.KullaniciID == kullanici.KullaniciID);

            if (silinecekKullanici != null)
            {
                this.TblKullanicilar.Remove(silinecekKullanici);
                SaveChanges();
            }
        }
    }
}
