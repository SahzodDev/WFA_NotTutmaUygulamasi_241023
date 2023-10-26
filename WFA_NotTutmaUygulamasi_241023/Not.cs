using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_NotTutmaUygulamasi_241023
{
    public class Not
    {
        public string NotBasligi { get; set; }

        public string NotGovdesi { get; set;}

        public Kullanici NotunKullanicisi { get; set; }

        public override string ToString()
        {
            return $"{NotBasligi}";
        }
    }
}
