//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SeriesActorDetail
    {
        public int SeriesActorDetailID { get; set; }
        public int SeriesId { get; set; }
        public int ActorId { get; set; }
        public string Role { get; set; }
        public Nullable<int> ActorRate { get; set; }
    
        public virtual Actor Actor { get; set; }
        public virtual Series Series { get; set; }
    }
}