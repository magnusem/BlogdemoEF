namespace BlogdemoEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Blogs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Blogs()
        {
            Posts = new HashSet<Posts>();
        }

        [Key]
        public int BlogId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Url { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Posts> Posts { get; set; }
    }
}
