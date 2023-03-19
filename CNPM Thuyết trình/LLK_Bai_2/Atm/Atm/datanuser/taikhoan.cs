namespace Atm.datanuser
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("taikhoan")]
    public partial class taikhoan
    {
        public int id { get; set; }

        [StringLength(50)]
        public string tentaikhoan { get; set; }

        [StringLength(50)]
        public string matkhau { get; set; }

        public int? SoDu { get; set; }
    }
}
