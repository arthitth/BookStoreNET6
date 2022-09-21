using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Web.API.Models
{
    public partial class _1DBContext : DbContext
    {
        public _1DBContext()
        {
        }

        public _1DBContext(DbContextOptions<_1DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Pdfagtpfm> Pdfagtpfms { get; set; } = null!;
        public virtual DbSet<Pdfagtpfm202202> Pdfagtpfm202202s { get; set; } = null!;
        public virtual DbSet<Pdfagtpfm202206> Pdfagtpfm202206s { get; set; } = null!;
        public virtual DbSet<Pdfagtpfmmail> Pdfagtpfmmails { get; set; } = null!;
        public virtual DbSet<TbFile> TbFiles { get; set; } = null!;
        public virtual DbSet<Tpol> Tpols { get; set; } = null!;
        public virtual DbSet<Tstock> Tstocks { get; set; } = null!;
        public virtual DbSet<training> training { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(60);

                entity.Property(e => e.LastName).HasMaxLength(60);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Isbn).HasMaxLength(20);

                entity.Property(e => e.Summary).HasMaxLength(60);

                entity.Property(e => e.Title).HasMaxLength(30);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("employee");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("surname");
            });

            modelBuilder.Entity<Pdfagtpfm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PDFAGTPFM");

                entity.Property(e => e.AeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AE_CODE");

                entity.Property(e => e.Ref)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REF");

                entity.Property(e => e.Xx12annu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_12ANNU");

                entity.Property(e => e.Xx12ean)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_12EAN");

                entity.Property(e => e.Xx12lan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_12LAN");

                entity.Property(e => e.XxAgncd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_AGNCD");

                entity.Property(e => e.XxAgnnm)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("XX_AGNNM");

                entity.Property(e => e.XxBrnen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_BRNEN");

                entity.Property(e => e.XxCmafy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMAFY");

                entity.Property(e => e.XxCmfyp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMFYP");

                entity.Property(e => e.XxCmgpm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMGPM");

                entity.Property(e => e.XxCmiss)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMISS");

                entity.Property(e => e.XxCmppm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMPPM");

                entity.Property(e => e.XxCmsub)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMSUB");

                entity.Property(e => e.XxCmwfy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMWFY");

                entity.Property(e => e.XxCyafy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYAFY");

                entity.Property(e => e.XxCyfyp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYFYP");

                entity.Property(e => e.XxCygpm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYGPM");

                entity.Property(e => e.XxCyiss)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYISS");

                entity.Property(e => e.XxCyppm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYPPM");

                entity.Property(e => e.XxCysub)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYSUB");

                entity.Property(e => e.XxCywfy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYWFY");

                entity.Property(e => e.XxEngnm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_ENGNM");

                entity.Property(e => e.XxEngsn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_ENGSN");

                entity.Property(e => e.XxLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_LEVEL");

                entity.Property(e => e.XxMmaac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_MMAAC");

                entity.Property(e => e.XxNoagn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOAGN");

                entity.Property(e => e.XxNofam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOFAM");

                entity.Property(e => e.XxNofav)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOFAV");

                entity.Property(e => e.XxNofdm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOFDM");

                entity.Property(e => e.XxNofgr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOFGR");

                entity.Property(e => e.XxYyaac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_YYAAC");

                entity.Property(e => e.XxYyarc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_YYARC");

                entity.Property(e => e.XxYyatm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_YYATM");
            });

            modelBuilder.Entity<Pdfagtpfm202202>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PDFAGTPFM202202");

                entity.Property(e => e.AeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AE_CODE");

                entity.Property(e => e.Ref)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REF");

                entity.Property(e => e.Xx12annu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_12ANNU");

                entity.Property(e => e.Xx12ean)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_12EAN");

                entity.Property(e => e.Xx12lan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_12LAN");

                entity.Property(e => e.XxAgncd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_AGNCD");

                entity.Property(e => e.XxAgnnm)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("XX_AGNNM");

                entity.Property(e => e.XxBrnen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_BRNEN");

                entity.Property(e => e.XxCmafy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMAFY");

                entity.Property(e => e.XxCmfyp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMFYP");

                entity.Property(e => e.XxCmgpm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMGPM");

                entity.Property(e => e.XxCmiss)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMISS");

                entity.Property(e => e.XxCmppm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMPPM");

                entity.Property(e => e.XxCmsub)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMSUB");

                entity.Property(e => e.XxCmwfy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMWFY");

                entity.Property(e => e.XxCyafy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYAFY");

                entity.Property(e => e.XxCyfyp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYFYP");

                entity.Property(e => e.XxCygpm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYGPM");

                entity.Property(e => e.XxCyiss)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYISS");

                entity.Property(e => e.XxCyppm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYPPM");

                entity.Property(e => e.XxCysub)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYSUB");

                entity.Property(e => e.XxCywfy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYWFY");

                entity.Property(e => e.XxEngnm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_ENGNM");

                entity.Property(e => e.XxEngsn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_ENGSN");

                entity.Property(e => e.XxLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_LEVEL");

                entity.Property(e => e.XxMmaac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_MMAAC");

                entity.Property(e => e.XxNoagn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOAGN");

                entity.Property(e => e.XxNofam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOFAM");

                entity.Property(e => e.XxNofav)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOFAV");

                entity.Property(e => e.XxNofdm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOFDM");

                entity.Property(e => e.XxNofgr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOFGR");

                entity.Property(e => e.XxYyaac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_YYAAC");

                entity.Property(e => e.XxYyarc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_YYARC");

                entity.Property(e => e.XxYyatm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_YYATM");
            });

            modelBuilder.Entity<Pdfagtpfm202206>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PDFAGTPFM202206");

                entity.Property(e => e.AeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AE_CODE");

                entity.Property(e => e.Ref)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REF");

                entity.Property(e => e.Xx12annu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_12ANNU");

                entity.Property(e => e.Xx12ean)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_12EAN");

                entity.Property(e => e.Xx12lan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_12LAN");

                entity.Property(e => e.XxAgncd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_AGNCD");

                entity.Property(e => e.XxAgnnm)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("XX_AGNNM");

                entity.Property(e => e.XxBrnen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_BRNEN");

                entity.Property(e => e.XxCmafy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMAFY");

                entity.Property(e => e.XxCmfyp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMFYP");

                entity.Property(e => e.XxCmgpm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMGPM");

                entity.Property(e => e.XxCmiss)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMISS");

                entity.Property(e => e.XxCmppm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMPPM");

                entity.Property(e => e.XxCmsub)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMSUB");

                entity.Property(e => e.XxCmwfy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CMWFY");

                entity.Property(e => e.XxCyafy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYAFY");

                entity.Property(e => e.XxCyfyp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYFYP");

                entity.Property(e => e.XxCygpm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYGPM");

                entity.Property(e => e.XxCyiss)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYISS");

                entity.Property(e => e.XxCyppm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYPPM");

                entity.Property(e => e.XxCysub)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYSUB");

                entity.Property(e => e.XxCywfy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_CYWFY");

                entity.Property(e => e.XxEngnm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_ENGNM");

                entity.Property(e => e.XxEngsn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_ENGSN");

                entity.Property(e => e.XxLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_LEVEL");

                entity.Property(e => e.XxMmaac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_MMAAC");

                entity.Property(e => e.XxNoagn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOAGN");

                entity.Property(e => e.XxNofam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOFAM");

                entity.Property(e => e.XxNofav)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOFAV");

                entity.Property(e => e.XxNofdm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOFDM");

                entity.Property(e => e.XxNofgr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_NOFGR");

                entity.Property(e => e.XxYyaac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_YYAAC");

                entity.Property(e => e.XxYyarc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_YYARC");

                entity.Property(e => e.XxYyatm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XX_YYATM");
            });

            modelBuilder.Entity<Pdfagtpfmmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PDFAGTPFMMAIL");

                entity.Property(e => e.Agncd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AGNCD");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Ref)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REF");
            });

            modelBuilder.Entity<TbFile>(entity =>
            {
                entity.ToTable("tb_Files");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentType).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tpol>(entity =>
            {
                entity.HasKey(e => e.PolId);

                entity.ToTable("tpol");

                entity.Property(e => e.PolId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pol_id")
                    .IsFixedLength();

                entity.Property(e => e.Addr01)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("addr01")
                    .IsFixedLength();

                entity.Property(e => e.Addr02)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("addr02")
                    .IsFixedLength();

                entity.Property(e => e.Addr03)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("addr03")
                    .IsFixedLength();

                entity.Property(e => e.AgtBrnCd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("agt_brn_cd")
                    .IsFixedLength();

                entity.Property(e => e.AgtBrnTxt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("agt_brn_txt")
                    .IsFixedLength();

                entity.Property(e => e.AgtCd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("agt_cd")
                    .IsFixedLength();

                entity.Property(e => e.AgtNm)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("agt_nm")
                    .IsFixedLength();

                entity.Property(e => e.AppId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("app_id")
                    .IsFixedLength();

                entity.Property(e => e.BillMd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("bill_md")
                    .IsFixedLength();

                entity.Property(e => e.BillTyp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("bill_typ")
                    .IsFixedLength();

                entity.Property(e => e.CityNm)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("city_nm")
                    .IsFixedLength();

                entity.Property(e => e.InsurNm)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("insur_nm")
                    .IsFixedLength();

                entity.Property(e => e.InsurSnm)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("insur_snm")
                    .IsFixedLength();

                entity.Property(e => e.InsurTitle)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("insur_title")
                    .IsFixedLength();

                entity.Property(e => e.PayNm)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("pay_nm")
                    .IsFixedLength();

                entity.Property(e => e.PaySnm)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("pay_snm")
                    .IsFixedLength();

                entity.Property(e => e.PayTitle)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("pay_title")
                    .IsFixedLength();

                entity.Property(e => e.PlanCd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("plan_cd")
                    .IsFixedLength();

                entity.Property(e => e.PlanTxt)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("plan_txt")
                    .IsFixedLength();

                entity.Property(e => e.PostCd)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("post_cd")
                    .IsFixedLength();

                entity.Property(e => e.ProvNm)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("prov_nm")
                    .IsFixedLength();

                entity.Property(e => e.PrtDt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("prt_dt")
                    .IsFixedLength();

                entity.Property(e => e.StsCd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("sts_cd")
                    .IsFixedLength();

                entity.Property(e => e.StsCofm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sts_cofm")
                    .IsFixedLength();

                entity.Property(e => e.StsStk)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sts_stk")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tstock>(entity =>
            {
                entity.HasKey(e => new { e.PolId, e.PolBatchNo, e.PolSts });

                entity.ToTable("tstock");

                entity.Property(e => e.PolId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pol_id")
                    .IsFixedLength();

                entity.Property(e => e.PolBatchNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pol_batch_no")
                    .IsFixedLength();

                entity.Property(e => e.PolSts)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pol_sts")
                    .IsFixedLength();

                entity.Property(e => e.DepRec)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dep_rec")
                    .IsFixedLength();

                entity.Property(e => e.DepReq)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dep_req")
                    .IsFixedLength();

                entity.Property(e => e.OwnerNm)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("owner_nm")
                    .IsFixedLength();

                entity.Property(e => e.PolStsDtl)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pol_sts_dtl")
                    .IsFixedLength();

                entity.Property(e => e.RecDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("rec_date")
                    .IsFixedLength();

                entity.Property(e => e.RecTime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("rec_time")
                    .IsFixedLength();

                entity.Property(e => e.ReqDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("req_date")
                    .IsFixedLength();

                entity.Property(e => e.ReqTime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("req_time")
                    .IsFixedLength();

                entity.Property(e => e.StsCofm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sts_cofm")
                    .IsFixedLength();

                entity.Property(e => e.StsDtl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sts_dtl")
                    .IsFixedLength();

                entity.Property(e => e.StsPrt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sts_prt")
                    .IsFixedLength();

                entity.Property(e => e.StsPrtFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sts_prt_flag")
                    .IsFixedLength();

                entity.Property(e => e.StsTrnf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sts_trnf")
                    .IsFixedLength();

                entity.Property(e => e.UsrKdep)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("usr_kdep")
                    .IsFixedLength();

                entity.Property(e => e.UsrKey)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("usr_key")
                    .IsFixedLength();

                entity.Property(e => e.UsrRec)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("usr_rec")
                    .IsFixedLength();

                entity.Property(e => e.UsrReq)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("usr_req")
                    .IsFixedLength();

                entity.Property(e => e.UsrTknm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("usr_tknm")
                    .IsFixedLength();

                entity.Property(e => e.WanDt)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("wan_dt");
            });

            modelBuilder.Entity<training>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.Coudt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("coudt")
                    .IsFixedLength();

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Course)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("course");

                entity.Property(e => e.Coutm)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("coutm")
                    .IsFixedLength();

                entity.Property(e => e.Crtdt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("crtdt")
                    .IsFixedLength();

                entity.Property(e => e.Crttm)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("crttm")
                    .IsFixedLength();

                entity.Property(e => e.Crtusr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("crtusr");

                entity.Property(e => e.Enddt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("enddt")
                    .IsFixedLength();

                entity.Property(e => e.Place)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.Property(e => e.Property)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("property");

                entity.Property(e => e.Regisamt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("regisamt");

                entity.Property(e => e.Regismax)
                    .HasMaxLength(10)
                    .HasColumnName("regismax")
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Upddt)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("upddt")
                    .IsFixedLength();

                entity.Property(e => e.Updtm)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("updtm")
                    .IsFixedLength();

                entity.Property(e => e.Updusr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("updusr");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
