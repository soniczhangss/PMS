//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBServiceLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int PropertyOwnerId { get; set; }
        public int PropertyManagementFeeId { get; set; }
    
        public virtual PropertyManagementFee PropertyManagementFee { get; set; }
        public virtual PropertyOwner PropertyOwner { get; set; }
    }
}