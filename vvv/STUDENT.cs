namespace vvv
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STUDENT")]
    public partial class STUDENT
    {
        [StringLength(20)]
        public string STUDENTID { get; set; }

        [StringLength(50)]
        public string FULLNAME { get; set; }

        public double? AVERAGESCORE { get; set; }

        public int? KHOAID { get; set; }

        public virtual KHOA KHOA { get; set; }
    }
}
