namespace COMP123_Assignment5_Sayda_301042327.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        //public static int PRODUCT_ID { get; internal set; }
        //public static int COST { get; internal set; }
        //public static int MANUFACTURER { get; internal set; }
        //public static int CONDITION { get; internal set; }
        //public static int PLATFORM { get; internal set; }
        //public static int MODEL { get; internal set; }
        //public static int RAM_SIZE { get; internal set; }
        //public static int SCREEN_SIZE { get; internal set; }
        //public static int HDD_SIZE { get; internal set; }
        //public static int CPU_BRAND { get; internal set; }
        //public static int CPU_NUMBER { get; internal set; }
        //public static int GPU_TYPE { get; internal set; }
        //public static int CPU_TYPE { get; internal set; }
        //public static int CPU_SPEED { get; internal set; }
        //public static object Value { get; internal set; }
        //public static int WEBCAM { get; internal set; }

        public short productID { get; set; }

        [Column(TypeName = "money")]
        public decimal? cost { get; set; }

        [StringLength(255)]
        public string manufacturer { get; set; }

        [StringLength(255)]
        public string model { get; set; }

        [StringLength(255)]
        public string RAM_type { get; set; }

        [StringLength(255)]
        public string RAM_size { get; set; }

        [StringLength(255)]
        public string displaytype { get; set; }

        [StringLength(255)]
        public string screensize { get; set; }

        [StringLength(255)]
        public string resolution { get; set; }

        [StringLength(255)]
        public string CPU_Class { get; set; }

        [StringLength(255)]
        public string CPU_brand { get; set; }

        [StringLength(255)]
        public string CPU_type { get; set; }

        [StringLength(255)]
        public string CPU_speed { get; set; }

        [StringLength(255)]
        public string CPU_number { get; set; }

        [StringLength(255)]
        public string condition { get; set; }

        [StringLength(255)]
        public string OS { get; set; }

        [StringLength(255)]
        public string platform { get; set; }

        [StringLength(255)]
        public string HDD_size { get; set; }

        [StringLength(255)]
        public string HDD_speed { get; set; }

        [StringLength(255)]
        public string GPU_Type { get; set; }

        [StringLength(255)]
        public string optical_drive { get; set; }

        [StringLength(255)]
        public string Audio_type { get; set; }

        [StringLength(255)]
        public string LAN { get; set; }

        [StringLength(255)]
        public string WIFI { get; set; }

        [StringLength(255)]
        public string width { get; set; }

        [StringLength(255)]
        public string height { get; set; }

        [StringLength(255)]
        public string depth { get; set; }

        [StringLength(255)]
        public string weight { get; set; }

        [StringLength(255)]
        public string moust_type { get; set; }

        [StringLength(255)]
        public string power { get; set; }

        [StringLength(255)]
        public string webcam { get; set; }
    }
}
