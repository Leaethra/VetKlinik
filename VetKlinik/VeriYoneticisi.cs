using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace VetKlinik
{
    public class VeriYoneticisi : DVetKlinikEntities //contextden inherit aldığım ksım 
    {

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

        public bool DoesChipExist(string cipNo)
        {
            if (string.IsNullOrEmpty(cipNo))
                return false;//TblHayvanlarda dışarıdan gelen CipNo ile eşleşen kayıt var mı diy bakıyoruz
            return this.TblHayvanlar.Any(h => h.CipNo == cipNo);
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

        public bool DoesOwnerExist(string telefon)
        {
            if (string.IsNullOrEmpty(telefon))
                return false;
            return this.TblSahipler.Any(h => h.Telefon == telefon);
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

        public bool LoginCheck(string kullaniciAdi, string sifre)
        {

            return this.TblKullanicilar.Any(kullanici => kullanici.KullaniciAdi == kullaniciAdi && kullanici.Sifre == sifre);
        }

        public bool DoesUserExist(string kullaniciAdi) //böyle bir kullanıcı daha önce var mıydı?
        {
            return this.TblKullanicilar.Any(kullanici => kullanici.KullaniciAdi == kullaniciAdi);
        }

        public void CreateUser(TblKullanicilar yeniKullanici)
        {
            this.TblKullanicilar.Add(yeniKullanici);
            SaveChanges();
        }
    }
}