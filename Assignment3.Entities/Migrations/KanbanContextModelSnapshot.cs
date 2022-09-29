﻿// <auto-generated />
using System;
using Assignment3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment3.Entities.Migrations
{
    [DbContext(typeof(KanbanContext))]
    partial class KanbanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0-rc.1.22426.7");

            modelBuilder.Entity("Assignment3.Entities.Tag", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Assignment3.Entities.User", b =>
                {
                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Email");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Assignment3.Entities.WorkItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserEmail");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("TagWorkItem", b =>
                {
                    b.Property<string>("TagsName")
                        .HasColumnType("TEXT");

                    b.Property<int>("WorkItemsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TagsName", "WorkItemsId");

                    b.HasIndex("WorkItemsId");

                    b.ToTable("WorkItemsTags", (string)null);
                });

            modelBuilder.Entity("Assignment3.Entities.WorkItem", b =>
                {
                    b.HasOne("Assignment3.Entities.User", null)
                        .WithMany("WorkItems")
                        .HasForeignKey("UserEmail");
                });

            modelBuilder.Entity("TagWorkItem", b =>
                {
                    b.HasOne("Assignment3.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment3.Entities.WorkItem", null)
                        .WithMany()
                        .HasForeignKey("WorkItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Assignment3.Entities.User", b =>
                {
                    b.Navigation("WorkItems");
                });
#pragma warning restore 612, 618
        }
    }
}
