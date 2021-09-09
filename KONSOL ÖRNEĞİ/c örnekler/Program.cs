using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_örnekler
{
    class Program
    {
        static void Main(string[] args)
        {
            //if ile kullanıcı adı şifre ekranı
            //Console.WriteLine("kullanıcı adı belirleyin");
            //string kullaniciadi = Console.ReadLine();
            //Console.WriteLine("şifrenizi belirleyin");
            //string sifre1 = Console.ReadLine();
            //Console.WriteLine("belirlediğiniz şifrenizi tekrar girin");
            //string sifre2 = Console.ReadLine();
            //if (sifre1 == sifre2)
            //{
            //    Console.WriteLine("kullanıcı adı ve şifreniz başarıyla oluşturuldu");
            //}
            //else if(sifre2 != sifre1)
            //{
            //    Console.WriteLine("hatalı işlem yaptınız");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı işlem yaptınız");
            //}

            //hazır string kod(string.compare(karşılaştırma))ile kullanıcı adı şifre ekranı
            basla:
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("kullanıcı adı belirleyin");
            string kullaniciadi = Console.ReadLine();
            if (string.IsNullOrEmpty(kullaniciadi) == true)//(string.IsNullOrEmpty(kullaniciadi) == true) komutu kullanıcı kullaniciadi kısmını boş bırakıp devam edecekse uyarı verir
            {
                Console.WriteLine("lütfen kullanıcı adı alanını boş bırakmayın");
                Console.Clear();
                goto basla;
            }
            else
            {
                basla1:
                Console.WriteLine("şifrenizi belirleyin");
                string sifre1 = Console.ReadLine();
                if (kullaniciadi==sifre1)
                {
                    Console.WriteLine("kullanıcı adı ve şifre aynı olamaz. Lütfen Tekrar deneyin");
                    
                    goto basla;
                    Console.ReadKey();
                }
                else
                {
                    if (string.IsNullOrEmpty(sifre1) == true)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("lütfen şifre alanını boş bırakmayın");
                        goto basla1;
                    }
                    else
                    {
                    basla2:
                        Console.WriteLine("belirlediğiniz şifrenizi tekrar girin");
                        string sifre2 = Console.ReadLine();
                        if (string.IsNullOrEmpty(sifre2) == true)
                        {
                            Console.WriteLine("lütfen şifre alanını boş bırakmayın");
                            goto basla2;
                        }
                        else
                        {
                            int kontrol = string.Compare(sifre2, sifre1);// int kontrol = string.Compare(sifre2, sifre1) komutu sifre1 ve sifre2 değerlerini karşılaştırır. sonuç aynı ise 0 değerini verir.
                            if (kontrol == 0)
                            {
                                string sifre = sifre2;
                                Console.WriteLine("kullanıcı adı ve şifreniz başarıyla oluşturuldu. Kullanıcı Adı:{0} Şifre:{1}", kullaniciadi, sifre1);
                            }
                            else
                            {
                                Console.WriteLine("hatalı işlem yaptınız.");
                            }
                            Console.WriteLine("Tekrar denemek ister misiniz? [E,e:Evet,H,h:Hayır]");
                            char karar = Convert.ToChar(Console.ReadLine());
                            if (karar == 'E' || karar == 'e')
                            {
                                goto basla;
                            }
                            else
                            {
                                Console.WriteLine("Yine bekleriz birader");
                            }
                        }
                    }
                }

            }




            Console.ReadKey();

        }
    }
}
