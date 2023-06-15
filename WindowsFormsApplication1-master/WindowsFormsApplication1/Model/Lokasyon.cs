using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    public class Lokasyon
    {
        public virtual int Id { get; set; }
        public virtual string Ad { get; set; }
        public virtual DateTime KayitTarihi { get; set; }

     /* public virtual Uçak Uçak { get; set; } */

    }

    public class LokasyonMap : ClassMapping<Lokasyon>
    {
        public LokasyonMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Native));
            Property(x => x.Ad);
            Property(x => x.KayitTarihi);

         /* ManyToOne(x => x.Uçak); */

        }
    }
}

