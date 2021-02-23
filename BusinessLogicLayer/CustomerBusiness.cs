using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLogicLayer;
using Entities;
using System.Windows.Forms;
using System.Data;

namespace BusinessLogicLayer
{
    public class CustomerBusiness
    {
        public int CustomerAdd(string Ad, string Soyad, string Telefon, string Telefon2, string TC, string Mail, int Sehir, int Ilce, string Adres, string VergiDairesi)
        {
            int resultReturn = 0, getData = 0;
            if (string.IsNullOrEmpty(Ad) || string.IsNullOrEmpty(Soyad) || string.IsNullOrEmpty(Telefon) || string.IsNullOrEmpty(TC) || string.IsNullOrEmpty(Mail) || string.IsNullOrEmpty(Adres) || string.IsNullOrEmpty(VergiDairesi)) resultReturn = 0;
            else
            {
                Customer customer = new Customer();
                TcKontrolBusiness tcB = new TcKontrolBusiness();
                using (CustomerDatabase cdb = new CustomerDatabase())
                {
                    bool kontrol = tcB.TcListKontrol(TC);
                    if (kontrol)
                    {
                        customer.Ad = Ad;
                        customer.Soyad = Soyad;
                        customer.Telefon = Telefon;
                        customer.Telefon2 = Telefon2;
                        customer.TC = TC;
                        customer.Mail = Mail;
                        customer.Sehir = Sehir.ToString();
                        customer.Ilce = Ilce.ToString();
                        customer.Adres = Adres;
                        customer.VergiDairesi = VergiDairesi;
                        if (Telefon2.Length > 0)
                        {
                            if (!customer._telefonKontrol) resultReturn = 1;
                            else if (!customer._telefonKontrol2) resultReturn = 2;
                            else if (!customer._tcKontrol) resultReturn = 3;
                            else
                                getData = cdb.CustomerAdd(customer);
                        }
                        else
                        {
                            if (!customer._telefonKontrol) resultReturn = 1;
                            else if (!customer._telefonKontrol2) resultReturn = 2;
                            else if (!customer._tcKontrol) resultReturn = 3;
                            else
                                getData = cdb.CustomerAdd(customer);
                        }
                        if (getData > 0) resultReturn = 4;
                    }
                    else resultReturn = -1;
                }
            }
            return resultReturn;
        }
        public int CustomerUpdate(int ID, string Ad, string Soyad, string Telefon, string Telefon2, string TC,string _TC, string Mail, int Sehir, int Ilce, string Adres, string VergiDairesi)
        {
            int resultReturn = 0, getData = 0;
            if (string.IsNullOrEmpty(Ad) || string.IsNullOrEmpty(Soyad) || string.IsNullOrEmpty(Telefon) || string.IsNullOrEmpty(TC) || string.IsNullOrEmpty(Mail) || string.IsNullOrEmpty(Adres) || string.IsNullOrEmpty(VergiDairesi)) resultReturn = 0;
            else
            {
                Customer customer = new Customer();
                TcKontrolBusiness tcB = new TcKontrolBusiness();
                using (CustomerDatabase cdb = new CustomerDatabase())
                {
                    tcB.TcListKontrol2(_TC);
                    bool kontrol = tcB.TcListKontrol(TC);
                    if (kontrol)
                    {
                        customer.ID = ID;
                        customer.Ad = Ad;
                        customer.Soyad = Soyad;
                        customer.Telefon = Telefon;
                        customer.Telefon2 = Telefon2;
                        customer.TC = TC;
                        customer.Mail = Mail;
                        customer.Sehir = Sehir.ToString();
                        customer.Ilce = Ilce.ToString();
                        customer.Adres = Adres;
                        customer.VergiDairesi = VergiDairesi;
                        if (Telefon2.Length > 0)
                        {
                            if (!customer._telefonKontrol) resultReturn = 1;
                            else if (!customer._telefonKontrol2) resultReturn = 2;
                            else if (!customer._tcKontrol) resultReturn = 3;
                            else
                                getData = cdb.CustomerAdd(customer);
                        }
                        else
                        {
                            if (!customer._telefonKontrol) resultReturn = 1;
                            else if (!customer._telefonKontrol2) resultReturn = 2;
                            else if (!customer._tcKontrol) resultReturn = 3;
                            else
                                getData = cdb.CustomerUpdate(customer);
                        }
                        if (getData > 0) resultReturn = 4;
                    }
                    else resultReturn = -1;
                }
            }
            return resultReturn;
        }

        public int CustomerDelete()
        {
            return 1;
        }
        public void CustomerList(DataGridView dg)
        {
            DataTable dt = null;
            using (CustomerDatabase cb = new CustomerDatabase())
            {
                dt = cb.CustomerList();
                dg.DataSource = dt;
            }
        }

    }
}
