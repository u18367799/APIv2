﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrayonKidsAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CrayonKidsEntities : DbContext
    {
        public CrayonKidsEntities()
            : base("name=CrayonKidsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<Allergy> Allergies { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Application_Status> Application_Status { get; set; }
        public virtual DbSet<Appointment_Booking> Appointment_Booking { get; set; }
        public virtual DbSet<Assessment> Assessments { get; set; }
        public virtual DbSet<Booking_Status> Booking_Status { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Class_Class_Type> Class_Class_Type { get; set; }
        public virtual DbSet<Class_Type> Class_Type { get; set; }
        public virtual DbSet<Class_Type_Employee> Class_Type_Employee { get; set; }
        public virtual DbSet<Complaint> Complaints { get; set; }
        public virtual DbSet<DateTable> DateTables { get; set; }
        public virtual DbSet<Emergency> Emergencies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_Type> Employee_Type { get; set; }
        public virtual DbSet<Employment_Status> Employment_Status { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<Equipment_Type> Equipment_Type { get; set; }
        public virtual DbSet<Homework> Homework { get; set; }
        public virtual DbSet<Marking_Scale> Marking_Scale { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Menu_Item> Menu_Item { get; set; }
        public virtual DbSet<Menu_Item_Menu> Menu_Item_Menu { get; set; }
        public virtual DbSet<Order_Line> Order_Line { get; set; }
        public virtual DbSet<Parent_Guardian> Parent_Guardian { get; set; }
        public virtual DbSet<Parent_Guardian_Menu_Item> Parent_Guardian_Menu_Item { get; set; }
        public virtual DbSet<Progress_Category> Progress_Category { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<ReportCard> ReportCards { get; set; }
        public virtual DbSet<ReportCard_Template> ReportCard_Template { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<School_Fees_Status> School_Fees_Status { get; set; }
        public virtual DbSet<School_Term> School_Term { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_Allergy> Student_Allergy { get; set; }
        public virtual DbSet<Student_Class> Student_Class { get; set; }
        public virtual DbSet<Student_Emergency> Student_Emergency { get; set; }
        public virtual DbSet<Subcategory> Subcategories { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Supplier_Order> Supplier_Order { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Timeslot> Timeslots { get; set; }
        public virtual DbSet<Timeslot_Schedule_Date> Timeslot_Schedule_Date { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<User_Tbl> User_Tbl { get; set; }
        public virtual DbSet<User_Type> User_Type { get; set; }
        public virtual DbSet<Zip_Code> Zip_Code { get; set; }
        public virtual DbSet<Parent_Feedback> Parent_Feedback { get; set; }
    }
}
