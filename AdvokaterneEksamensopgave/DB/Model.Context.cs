﻿

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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class AdvokaterneEntities : DbContext
{
    public AdvokaterneEntities()
        : base("name=AdvokaterneEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Case> Cases { get; set; }

    public virtual DbSet<CaseService> CaseServices { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Hour> Hours { get; set; }

    public virtual DbSet<OrderLine> OrderLines { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

}

}

