//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFconcept
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public Nullable<int> Esal { get; set; }
        public Nullable<int> DeptId { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
