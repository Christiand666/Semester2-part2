
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
    
public partial class Hour
{

    public int ID { get; set; }

    public int HoursSpent { get; set; }

    public int HoursDriven { get; set; }

    public string Date { get; set; }

    public int Link { get; set; }



    public virtual Service Service { get; set; }

}

}
