
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DB
{

using System;
    using System.Collections.Generic;
    
public partial class Education
{

    public System.Guid ID { get; set; }

    public System.Guid EmployeeID { get; set; }

    public System.DateTime from { get; set; }

    public System.DateTime to { get; set; }

    public string EducationName { get; set; }



    public virtual Employee Employee { get; set; }

}

}
