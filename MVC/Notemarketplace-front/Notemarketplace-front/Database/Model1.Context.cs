﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Notemarketplace_front.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NotesMarketPlaceEntities : DbContext
    {
        public NotesMarketPlaceEntities()
            : base("name=NotesMarketPlaceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCountry> tblCountries { get; set; }
        public virtual DbSet<tblDownload> tblDownloads { get; set; }
        public virtual DbSet<tblNoteCategory> tblNoteCategories { get; set; }
        public virtual DbSet<tblNoteType> tblNoteTypes { get; set; }
        public virtual DbSet<tblReferenceData> tblReferenceDatas { get; set; }
        public virtual DbSet<tblSellerNote> tblSellerNotes { get; set; }
        public virtual DbSet<tblSellerNotesAttachement> tblSellerNotesAttachements { get; set; }
        public virtual DbSet<tblSellerNotesReportedIssue> tblSellerNotesReportedIssues { get; set; }
        public virtual DbSet<tblSellerNotesReview> tblSellerNotesReviews { get; set; }
        public virtual DbSet<tblSystemConfiguration> tblSystemConfigurations { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblUserProfile> tblUserProfiles { get; set; }
        public virtual DbSet<tblUserRole> tblUserRoles { get; set; }
    }
}
