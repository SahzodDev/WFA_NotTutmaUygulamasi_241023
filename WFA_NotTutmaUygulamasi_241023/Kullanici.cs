using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WFA_NotTutmaUygulamasi_241023
{
    public class Kullanici
    {
		private string kullaniciAdi;

		public string KullaniciAdi
		{
			get { return kullaniciAdi; }
			set 
			{ 
				if (value.Length >= 6) 
				{
                    kullaniciAdi = value;
                }
				else
				{
					throw new ArgumentException("Kullanıcı adı 6 karakterden az olamaz.");
				}
				
			}
		}

		private string password;

		public string Password
		{
			get { return password; }
			set 
			{ 
				if (value.Length >= 5) 
				{
					if (!Regex.IsMatch(value, @"[A-Z]"))
					{
						throw new Exception("Şifre en az 1 büyük harf içermeli.");
					}
					else if (!Regex.IsMatch(value, @"[a-z]"))
					{
						throw new Exception("Şifre en az 1 küçük harf içermeli.");
					}
					else if (!Regex.IsMatch(value, @"\d"))
					{
						throw new Exception("Şifre en az 1 rakam içermeli.");
					}
					else
					{
                        password = value;
                    }
				}
				else
				{
					throw new Exception("Şifre en az 5 karakterden oluşmalı.");
				}
				
			}

			
		}

        



    }
}
