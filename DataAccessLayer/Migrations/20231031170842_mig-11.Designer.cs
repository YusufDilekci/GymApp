﻿// <auto-generated />
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231031170842_mig-11")]
    partial class mig11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CategoryPrice")
                        .HasColumnType("float");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryInfo = "üiğiüğğşğşsğaüğ",
                            CategoryName = "Fitness",
                            CategoryPrice = 1200.0
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryInfo = "üiğiüğğşğşsğaüğ",
                            CategoryName = "Kickbox",
                            CategoryPrice = 1700.0
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryInfo = "üiğiüğğşğşsğaüğ",
                            CategoryName = "Zumba",
                            CategoryPrice = 1500.0
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryInfo = "üiğiüğğşğşsğaüğ",
                            CategoryName = "Pilates",
                            CategoryPrice = 700.0
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryInfo = "üiğiüğğşğşsğaüğ",
                            CategoryName = "Coaching",
                            CategoryPrice = 15.699999999999999
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"), 1L, 1);

                    b.Property<string>("ContactContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Description", b =>
                {
                    b.Property<int>("DescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DescriptionId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("DescriptionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DescriptionId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Descriptions");

                    b.HasData(
                        new
                        {
                            DescriptionId = 1,
                            CategoryId = 1,
                            DescriptionName = "Fitnes-1sweıpüqrıpoıqwmskdf"
                        },
                        new
                        {
                            DescriptionId = 2,
                            CategoryId = 1,
                            DescriptionName = "Fitnes-2weıpüqrıpoıqwmskdf"
                        },
                        new
                        {
                            DescriptionId = 3,
                            CategoryId = 1,
                            DescriptionName = "Fitnes-3weıpüqrıpoıqwmskdf"
                        },
                        new
                        {
                            DescriptionId = 4,
                            CategoryId = 2,
                            DescriptionName = "Kickbox-1sweıpüqrıpoıqwmskdf"
                        },
                        new
                        {
                            DescriptionId = 5,
                            CategoryId = 2,
                            DescriptionName = "Kickbox-2sweıpüqrıpoıqwmskdf"
                        },
                        new
                        {
                            DescriptionId = 6,
                            CategoryId = 2,
                            DescriptionName = "Kickbox-3weıpüqrıpoıqwmskdf"
                        },
                        new
                        {
                            DescriptionId = 7,
                            CategoryId = 3,
                            DescriptionName = "Zumba-1weıpüqrıpoıqwmskdf"
                        },
                        new
                        {
                            DescriptionId = 8,
                            CategoryId = 3,
                            DescriptionName = "Zumba-2weıpüqrıpoıqwmskdf"
                        },
                        new
                        {
                            DescriptionId = 9,
                            CategoryId = 3,
                            DescriptionName = "Zumba-3weıpüqrıpoıqwmskdf"
                        },
                        new
                        {
                            DescriptionId = 10,
                            CategoryId = 4,
                            DescriptionName = "Pilates-1weıpüqrıpoıqwmskdf"
                        },
                        new
                        {
                            DescriptionId = 11,
                            CategoryId = 4,
                            DescriptionName = "Pilates-2weıpüqrıpoıqwmskdf"
                        },
                        new
                        {
                            DescriptionId = 12,
                            CategoryId = 4,
                            DescriptionName = "Pilates-3weıpüqrıpoıqwmskdf"
                        },
                        new
                        {
                            DescriptionId = 13,
                            CategoryId = 5,
                            DescriptionName = "Coaching-1weıpüqrıpoıqwmskdf"
                        },
                        new
                        {
                            DescriptionId = 14,
                            CategoryId = 5,
                            DescriptionName = "Coaching-2weıpüqrıpoıqwmskdf"
                        },
                        new
                        {
                            DescriptionId = 15,
                            CategoryId = 5,
                            DescriptionName = "Coaching-3weıpüqrıpoıqwmskdf"
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ImageId = 1,
                            CategoryId = 1,
                            ImageName = "fitness1.jpg"
                        },
                        new
                        {
                            ImageId = 2,
                            CategoryId = 1,
                            ImageName = "fitness2.jpg"
                        },
                        new
                        {
                            ImageId = 3,
                            CategoryId = 1,
                            ImageName = "fitness3.jpg"
                        },
                        new
                        {
                            ImageId = 4,
                            CategoryId = 2,
                            ImageName = "kickbox1.jpg"
                        },
                        new
                        {
                            ImageId = 5,
                            CategoryId = 2,
                            ImageName = "kickbox2.jpg"
                        },
                        new
                        {
                            ImageId = 6,
                            CategoryId = 2,
                            ImageName = "kickbox3.jpg"
                        },
                        new
                        {
                            ImageId = 7,
                            CategoryId = 3,
                            ImageName = "zumba1.jpg"
                        },
                        new
                        {
                            ImageId = 8,
                            CategoryId = 3,
                            ImageName = "zumba2.jpg"
                        },
                        new
                        {
                            ImageId = 9,
                            CategoryId = 3,
                            ImageName = "zumba3.jpg"
                        },
                        new
                        {
                            ImageId = 10,
                            CategoryId = 4,
                            ImageName = "pilates1.jpg"
                        },
                        new
                        {
                            ImageId = 11,
                            CategoryId = 4,
                            ImageName = "pilates2.jpg"
                        },
                        new
                        {
                            ImageId = 12,
                            CategoryId = 4,
                            ImageName = "pilates3.jpg"
                        },
                        new
                        {
                            ImageId = 13,
                            CategoryId = 5,
                            ImageName = "coaching1.jpg"
                        },
                        new
                        {
                            ImageId = 14,
                            CategoryId = 5,
                            ImageName = "coaching2.jpg"
                        },
                        new
                        {
                            ImageId = 15,
                            CategoryId = 5,
                            ImageName = "coaching3.jpg"
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberId"), 1L, 1);

                    b.Property<string>("MemberEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberNameSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MemberStatus")
                        .HasColumnType("bit");

                    b.Property<string>("MemberUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("EntityLayer.Concrete.MemberCategory", b =>
                {
                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("MemberId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("MemberCategories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.MemberTrainer", b =>
                {
                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("MemberId", "TrainerId");

                    b.HasIndex("TrainerId");

                    b.ToTable("MemberTrainers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Packet", b =>
                {
                    b.Property<int>("PacketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PacketId"), 1L, 1);

                    b.Property<string>("PacketDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PacketPrice")
                        .HasColumnType("float");

                    b.Property<string>("PacketType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PacketId");

                    b.ToTable("Packets");

                    b.HasData(
                        new
                        {
                            PacketId = 1,
                            PacketDescription = "Antrenman Planı, Beslenme Planı, Haftalık Kontrol",
                            PacketPrice = 1500.0,
                            PacketType = "Normal"
                        },
                        new
                        {
                            PacketId = 2,
                            PacketDescription = "Antrenman Planı, Beslenme Planı, Haftalık Kontrol, Bireysel Koç, Supplement Desteği",
                            PacketPrice = 6000.0,
                            PacketType = "Pro"
                        },
                        new
                        {
                            PacketId = 3,
                            PacketDescription = "Antrenman Planı, Beslenme Planı, Haftalık Kontrol, Bireysel Koç, Supplement Desteği, Whatsapp Görüşme, Pro Sporcularla Tanışma Fırsatı",
                            PacketPrice = 10000.0,
                            PacketType = "Jossoft Özel"
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.PacketCategory", b =>
                {
                    b.Property<int>("PacketId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("PacketId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("PacketCategory");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Trainer", b =>
                {
                    b.Property<int>("TrainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainerId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("NameSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainerId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Trainers");

                    b.HasData(
                        new
                        {
                            TrainerId = 1,
                            CategoryId = 1,
                            NameSurname = "Yusuf Dilekci",
                            TrainerDescription = "Fitness - Trainer - 1",
                            TrainerImage = "trainer1.jpg"
                        },
                        new
                        {
                            TrainerId = 2,
                            CategoryId = 1,
                            NameSurname = "Savas Cebeci",
                            TrainerDescription = "Fitness - Trainer - 2",
                            TrainerImage = "trainer2.jpg"
                        },
                        new
                        {
                            TrainerId = 3,
                            CategoryId = 2,
                            NameSurname = "Birol E.",
                            TrainerDescription = "Kickbox - Trainer - 1",
                            TrainerImage = "trainer3.jpg"
                        },
                        new
                        {
                            TrainerId = 4,
                            CategoryId = 3,
                            NameSurname = "Mert A.",
                            TrainerDescription = "Zumba - Trainer - 1",
                            TrainerImage = "trainer4.jpg"
                        },
                        new
                        {
                            TrainerId = 5,
                            CategoryId = 3,
                            NameSurname = "Azat T.",
                            TrainerDescription = "Zumba - Trainer - 2",
                            TrainerImage = "trainer5.jpg"
                        },
                        new
                        {
                            TrainerId = 6,
                            CategoryId = 4,
                            NameSurname = "Oguz R.",
                            TrainerDescription = "Pilates - Trainer - 1",
                            TrainerImage = "trainer6.jpg"
                        },
                        new
                        {
                            TrainerId = 7,
                            CategoryId = 5,
                            NameSurname = "Sadik S.",
                            TrainerDescription = "Coaching - 1",
                            TrainerImage = "trainer7.jpg"
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Description", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Descriptions")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Image", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Images")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityLayer.Concrete.MemberCategory", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Members")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Member", "Member")
                        .WithMany("Categories")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("EntityLayer.Concrete.MemberTrainer", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Member", "Member")
                        .WithMany("Trainers")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Trainer", "Trainer")
                        .WithMany("Members")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("EntityLayer.Concrete.PacketCategory", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Packets")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Packet", "Packet")
                        .WithMany("Categories")
                        .HasForeignKey("PacketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Packet");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Trainer", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Trainers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("Descriptions");

                    b.Navigation("Images");

                    b.Navigation("Members");

                    b.Navigation("Packets");

                    b.Navigation("Trainers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Member", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Trainers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Packet", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Trainer", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
