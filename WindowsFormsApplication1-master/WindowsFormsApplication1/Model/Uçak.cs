using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    public class Ders
    {
        public virtual int Id { get; set; }
        public virtual string Ad { get; set; }
        public virtual DateTime Tarih { get; set; } = DateTime.Now;
        public virtual string Icerik { get; set; }
        public virtual Rezervasyon Rezervasyon { get; set; }
        public virtual ICollection<Lokasyon> Ogrenciler { get; set; } = new List<Lokasyon>();
    }

    public class DersMap : ClassMapping<Ders>
    {
        public DersMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Native));
            Property(x => x.Ad);
            Property(x => x.Tarih);
            Property(x => x.Icerik);

            ManyToOne(x => x.Rezervasyon);

        /*  Set(e => e.Lokasyonlar, mapper =>  
            {
                mapper.Key(k => k.Column("Uçak"));
                mapper.Inverse(true);
                mapper.Cascade(Cascade.All);
            }, relation => relation.OneToMany(mapping => mapping.Class(typeof(Lokasyon))));  */

        }
    }
}

