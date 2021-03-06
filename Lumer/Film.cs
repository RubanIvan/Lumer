//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lumer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            this.Schedule = new HashSet<Schedule>();
        }
    
        public int FilmID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Actors { get; set; }
        public string Country { get; set; }
        public Nullable<System.DateTime> Year { get; set; }
        public Nullable<System.TimeSpan> Duration { get; set; }
        public string Description { get; set; }
        public string PosterName { get; set; }
        public string KadrName1 { get; set; }
        public string KadrName2 { get; set; }
        public string KadrName3 { get; set; }
        public string KadrName4 { get; set; }
        public string KadrName5 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}
