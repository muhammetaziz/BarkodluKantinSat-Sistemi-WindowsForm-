//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarkodSatışSistemi
{
    using System;
    using System.Collections.Generic;
    
    public partial class islemozet
    {
        public int Id { get; set; }
        public Nullable<int> islemNo { get; set; }
        public Nullable<bool> iade { get; set; }
        public string odemeSekli { get; set; }
        public Nullable<double> Nakit { get; set; }
        public Nullable<double> Kart { get; set; }
        public Nullable<bool> Gelir { get; set; }
        public Nullable<bool> Gider { get; set; }
        public Nullable<double> AlisFiyatToplam { get; set; }
        public string Aciklama { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string Kullanici { get; set; }
    }
}
