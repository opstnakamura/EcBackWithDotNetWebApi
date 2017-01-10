namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.book_sale_db")]
    public partial class book_sale_db
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sku { get; set; }

        public bool? shop_0 { get; set; }

        public bool? shop_1 { get; set; }

        public bool? shop_10001 { get; set; }

        public bool? shop_10002 { get; set; }

        public bool? shop_2 { get; set; }

        public bool? shop_3 { get; set; }

        public bool? shop_4 { get; set; }

        public bool? shop_20001 { get; set; }

        public bool? shop_30001 { get; set; }

        public bool? shop_30002 { get; set; }

        public bool? shop_30003 { get; set; }

        public bool? shop_30004 { get; set; }

        public bool? shop_30005 { get; set; }

        public bool? shop_30006 { get; set; }

        public bool? shop_30007 { get; set; }

        public bool? shop_5 { get; set; }

        public bool? shop_6 { get; set; }

        public bool? shop_7 { get; set; }

        public bool? shop_8 { get; set; }

        public bool? shop_9 { get; set; }

        public bool? shop_30008 { get; set; }

        public bool? shop_30009 { get; set; }

        public bool? shop_30010 { get; set; }

        public bool? shop_99 { get; set; }

        public bool? shop_30011 { get; set; }

        public bool? shop_30012 { get; set; }

        public bool? shop_30013 { get; set; }

        public bool? shop_30014 { get; set; }

        public bool? shop_30015 { get; set; }

        public bool? shop_30016 { get; set; }

        public bool? shop_10 { get; set; }

        public bool? shop_11 { get; set; }

        public bool? shop_30017 { get; set; }

        public bool? shop_12 { get; set; }

        public bool? shop_13 { get; set; }

        public bool? shop_14 { get; set; }

        public bool? shop_30018 { get; set; }

        public bool? shop_30019 { get; set; }

        public bool? shop_30020 { get; set; }

        public bool? shop_30021 { get; set; }

        public bool? shop_30022 { get; set; }

        public bool? shop_30023 { get; set; }

        public bool? shop_30024 { get; set; }

        public bool? shop_30025 { get; set; }

        public bool? shop_15 { get; set; }

        public bool? shop_16 { get; set; }

        public bool? shop_17 { get; set; }

        public bool? shop_30026 { get; set; }

        public bool? shop_18 { get; set; }

        public bool? shop_19 { get; set; }

        public bool? shop_20 { get; set; }

        public bool? shop_100 { get; set; }

        public bool? shop_101 { get; set; }

        public bool? shop_102 { get; set; }

        public bool? shop_30027 { get; set; }

        public bool? shop_103 { get; set; }

        public bool? shop_21 { get; set; }

        public bool? shop_22 { get; set; }

        public bool? shop_999 { get; set; }

        public bool? shop_200 { get; set; }

        public bool? shop_299 { get; set; }

        public bool? shop_23 { get; set; }

        public bool? shop_30028 { get; set; }

        public bool? shop_201 { get; set; }

        public bool? shop_202 { get; set; }

        public bool? shop_30029 { get; set; }

        public bool? shop_30030 { get; set; }

        public bool? shop_24 { get; set; }

        public bool? shop_98 { get; set; }

        public bool? shop_30031 { get; set; }

        public bool? shop_300 { get; set; }

        public bool? shop_304 { get; set; }

        public bool? shop_307 { get; set; }

        public bool? shop_309 { get; set; }

        public bool? shop_322 { get; set; }

        public bool? shop_308 { get; set; }

        public bool? shop_381 { get; set; }

        public bool? shop_30032 { get; set; }

        public bool? shop_203 { get; set; }

        public bool? shop_25 { get; set; }

        public bool? shop_325 { get; set; }

        public bool? shop_400 { get; set; }

        public bool? shop_404 { get; set; }

        public bool? shop_407 { get; set; }

        public bool? shop_408 { get; set; }

        public bool? shop_409 { get; set; }

        public bool? shop_422 { get; set; }

        public bool? shop_425 { get; set; }

        public bool? shop_481 { get; set; }

        public bool? shop_401 { get; set; }

        public bool? shop_26 { get; set; }

        public bool? shop_30033 { get; set; }

        public bool? shop_30034 { get; set; }

        public bool? shop_30035 { get; set; }

        public bool? shop_30036 { get; set; }

        public bool? shop_30037 { get; set; }

        public bool? shop_204 { get; set; }

        public bool? shop_27 { get; set; }

        public bool? shop_800 { get; set; }

        public bool? shop_40001 { get; set; }

        public bool? shop_40002 { get; set; }

        public bool? shop_40004 { get; set; }

        public bool? shop_40003 { get; set; }

        public bool? shop_104 { get; set; }

        public bool? shop_105 { get; set; }

        public bool? shop_30038 { get; set; }

        public bool? shop_205 { get; set; }

        public bool? shop_28 { get; set; }

        public bool? shop_501 { get; set; }

        public bool? shop_29 { get; set; }

        public bool? shop_30 { get; set; }

        public bool? shop_30039 { get; set; }

        public bool? shop_30040 { get; set; }

        public bool? shop_601 { get; set; }

        public bool? shop_701 { get; set; }

        public bool? shop_702 { get; set; }

        public bool? shop_30041 { get; set; }

        public bool? shop_106 { get; set; }

        public bool? shop_107 { get; set; }

        public bool? shop_30042 { get; set; }

        public bool? shop_801 { get; set; }

        public bool? shop_30043 { get; set; }

        public bool? shop_206 { get; set; }

        public bool? shop_30044 { get; set; }

        public bool? shop_108 { get; set; }

        public bool? shop_30045 { get; set; }

        public bool? shop_30046 { get; set; }

        public bool? shop_40005 { get; set; }

        public bool? shop_799 { get; set; }

        public bool? shop_109 { get; set; }

        public bool? shop_30047 { get; set; }

        public bool? shop_30048 { get; set; }

        public bool? shop_40006 { get; set; }

        public bool? shop_1000 { get; set; }

        public bool? shop_30049 { get; set; }

        public bool? shop_30050 { get; set; }

        public bool? shop_30051 { get; set; }

        public bool? shop_1001 { get; set; }

        public bool? shop_30052 { get; set; }

        public bool? shop_30053 { get; set; }

        public bool? shop_30054 { get; set; }

        public bool? shop_30055 { get; set; }

        public bool? shop_110 { get; set; }

        public bool? shop_111 { get; set; }

        public bool? shop_112 { get; set; }

        public bool? shop_40007 { get; set; }

        public bool? shop_113 { get; set; }

        public bool? shop_30056 { get; set; }

        public bool? shop_30057 { get; set; }

        public bool? shop_30058 { get; set; }

        public bool? shop_30059 { get; set; }

        public bool? shop_114 { get; set; }

        public bool? shop_30060 { get; set; }

        public bool? shop_30061 { get; set; }

        public bool? shop_30062 { get; set; }

        public bool? shop_30063 { get; set; }

        public bool? shop_30064 { get; set; }

        public bool? shop_30065 { get; set; }

        public bool? shop_115 { get; set; }

        public bool? shop_30066 { get; set; }

        public bool? shop_116 { get; set; }

        public bool? shop_117 { get; set; }

        public bool? shop_118 { get; set; }

        public bool? shop_30067 { get; set; }

        public bool? shop_30068 { get; set; }

        public bool? shop_119 { get; set; }

        public bool? shop_30069 { get; set; }

        public bool? shop_30070 { get; set; }

        public bool? shop_30071 { get; set; }

        public bool? shop_120 { get; set; }

        public bool? shop_30072 { get; set; }

        public bool? shop_30073 { get; set; }

        public bool? shop_602 { get; set; }

        public bool? shop_30074 { get; set; }

        public bool? shop_30075 { get; set; }

        public bool? shop_30076 { get; set; }

        public bool? shop_30077 { get; set; }

        public bool? shop_30078 { get; set; }

        public bool? shop_30079 { get; set; }

        public bool? shop_30080 { get; set; }

        public bool? shop_30081 { get; set; }

        public bool? shop_30082 { get; set; }

        public bool? shop_30083 { get; set; }
    }
}
