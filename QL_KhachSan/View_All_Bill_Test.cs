namespace QL_KhachSan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_All_Bill_Test
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillFoodID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string idkh { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime transdate { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string transmonth { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrandToTal { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string trangthai { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PosID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillID { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int foodcode { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string foodname { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cost { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int qty { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int totalprice { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FoodID { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(100)]
        public string Ten { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(20)]
        public string Muc { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Gia { get; set; }
    }
}
