using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    public class Rezervasyon
    {
        public virtual int Id { get; set; }
        public virtual string Ad { get; set; }
        public virtual string Icerik { get; set; }
      /*  public virtual ICollection<Uçak> Dersler { get; set; } = new List<Uçak>();  */

    }

    public class RezervasyonMap : ClassMapping<Rezervasyon>
    {
        public RezervasyonMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Native));
            Property(x => x.Ad);
            Property(x => x.Icerik);

         /* Set(e => e.Dersler, mapper => 
            {
                mapper.Key(k => k.Column("Rezervasyon"));
                mapper.Inverse(true);
                mapper.Cascade(Cascade.All);
            }, relation => relation.OneToMany(mapping => mapping.Class(typeof(Uçak)))); */
        }
    }
}

