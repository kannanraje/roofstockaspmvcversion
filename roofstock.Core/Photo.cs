//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace roofstock.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Photo
    {
        public int PhotoId { get; set; }
        public string ResourceType { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string Url { get; set; }
        public string UrlMedium { get; set; }
        public string UrlSmall { get; set; }
        public string Description { get; set; }
        public long PropertyId { get; set; }
    
        public virtual Property Property { get; set; }
    }
}
