using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GymDB;Trusted_Connection=True");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<MemberBranch>()
                .HasKey(x => new {x.MemberId, x.BranchId});

            modelBuilder.Entity<MemberTrainer>()
                .HasKey(x => new { x.MemberId, x.TrainerId });

            modelBuilder.Entity<PacketBranch>()
                .HasKey(x => new { x.PacketId, x.BranchId });

            modelBuilder.Entity<Branch>()
                .HasData(
                    new Branch() { BranchId = 1, BranchName = "Fitness", BranchInfo = "üiğiüğğşğşsğaüğ", BranchPrice=1200},
                    new Branch() { BranchId = 2, BranchName = "Kickbox", BranchInfo = "üiğiüğğşğşsğaüğ", BranchPrice = 1700 },
                    new Branch() { BranchId = 3, BranchName = "Zumba", BranchInfo = "üiğiüğğşğşsğaüğ", BranchPrice = 1500 },
                    new Branch() { BranchId = 4, BranchName = "Pilates", BranchInfo = "üiğiüğğşğşsğaüğ", BranchPrice = 700 },
                    new Branch() { BranchId = 5, BranchName = "Futbol", BranchInfo = "üiğiüğğşğşsğaüğ", BranchPrice = 15.700 }
                );

            modelBuilder.Entity<Description>()
                .HasData(
                    new Description() { DescriptionId=1, BranchId= 1, DescriptionName="Fitnes-1sweıpüqrıpoıqwmskdf"},
                    new Description() { DescriptionId =2, BranchId = 1, DescriptionName = "Fitnes-2weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId =3, BranchId = 1, DescriptionName = "Fitnes-3weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 4, BranchId = 2, DescriptionName = "Kickbox-1sweıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 5, BranchId = 2, DescriptionName = "Kickbox-2sweıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 6, BranchId = 2, DescriptionName = "Kickbox-3weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 7, BranchId = 3, DescriptionName = "Zumba-1weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 8, BranchId = 3, DescriptionName = "Zumba-2weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 9, BranchId = 3, DescriptionName = "Zumba-3weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 10, BranchId = 4, DescriptionName = "Pilates-1weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 11, BranchId = 4, DescriptionName = "Pilates-2weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 12, BranchId = 4, DescriptionName = "Pilates-3weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 13, BranchId = 5, DescriptionName = "Futbol-1weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 14, BranchId = 5, DescriptionName = "Futbol-2weıpüqrıpoıqwmskdf" },
                    new Description() { DescriptionId = 15, BranchId = 5, DescriptionName = "Futbol-3weıpüqrıpoıqwmskdf" }

                );

            modelBuilder.Entity<Image>()
                .HasData(
                    new Image() { ImageId = 1, BranchId = 1, ImageName = "fitness1.jpg"},
                    new Image() { ImageId = 2, BranchId = 1, ImageName = "fitness2.jpg" },
                    new Image() { ImageId = 3, BranchId = 1, ImageName = "fitness3.jpg" },
                    new Image() { ImageId = 4, BranchId = 2, ImageName = "kickbox1.jpg" },
                    new Image() { ImageId = 5, BranchId = 2, ImageName = "kickbox2.jpg" },
                    new Image() { ImageId = 6, BranchId = 2, ImageName = "kickbox3.jpg" },
                    new Image() { ImageId = 7, BranchId = 3, ImageName = "zumba1.jpg" },
                    new Image() { ImageId = 8, BranchId = 3, ImageName = "zumba2.jpg" },
                    new Image() { ImageId = 9, BranchId = 3, ImageName = "zumba3.jpg" },
                    new Image() { ImageId = 10, BranchId = 4, ImageName = "pilates1.jpg" },
                    new Image() { ImageId = 11, BranchId = 4, ImageName = "pilates2.jpg" },
                    new Image() { ImageId = 12, BranchId = 4, ImageName = "pilates3.jpg" },
                    new Image() { ImageId = 13, BranchId = 5, ImageName = "futbol1.jpg" },
                    new Image() { ImageId = 14, BranchId = 5, ImageName = "futbol2.jpg" },
                    new Image() { ImageId = 15, BranchId = 5, ImageName = "futbol3.jpg" }
                );
            modelBuilder.Entity<Trainer>()
                .HasData(
                    new Trainer() { TrainerId=1, BranchId=1, NameSurname="Yusuf Dilekci", TrainerDescription="Fitness - Trainer - 1", TrainerImage="trainer1.jpg"},
                    new Trainer() { TrainerId = 2, BranchId = 1, NameSurname = "Savas Cebeci", TrainerDescription = "Fitness - Trainer - 2", TrainerImage = "trainer2.jpg" },
                    new Trainer() { TrainerId = 3, BranchId = 2, NameSurname = "Birol E.", TrainerDescription = "Kickbox - Trainer - 1", TrainerImage = "trainer3.jpg" },
                    new Trainer() { TrainerId = 4, BranchId = 3, NameSurname = "Mert A.", TrainerDescription = "Zumba - Trainer - 1", TrainerImage = "trainer4.jpg" },
                    new Trainer() { TrainerId = 5, BranchId = 3, NameSurname = "Azat T.", TrainerDescription = "Zumba - Trainer - 2", TrainerImage = "trainer5.jpg" },
                    new Trainer() { TrainerId = 6, BranchId = 4, NameSurname = "Oguz R.", TrainerDescription = "Pilates - Trainer - 1", TrainerImage = "trainer6.jpg" },
                    new Trainer() { TrainerId = 7, BranchId = 5, NameSurname = "Sadik S.", TrainerDescription = "Futbol - 1", TrainerImage = "trainer7.jpg" }

                );

            modelBuilder.Entity<Packet>()
                .HasData(
                    new Packet() { PacketId = 1, PacketType = "Normal", PacketPrice = 1500, PacketDescription = "Antrenman Planı, Beslenme Planı, Haftalık Kontrol" },
                    new Packet() { PacketId = 2, PacketType = "Pro", PacketPrice = 6000, PacketDescription = "Antrenman Planı, Beslenme Planı, Haftalık Kontrol, Bireysel Koç, Supplement Desteği" },
                    new Packet() { PacketId = 3, PacketType = "Jossoft Özel", PacketPrice = 10000, PacketDescription = "Antrenman Planı, Beslenme Planı, Haftalık Kontrol, Bireysel Koç, Supplement Desteği, Whatsapp Görüşme, Pro Sporcularla Tanışma Fırsatı" }
                );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Packet> Packets { get; set; }
        public DbSet<MemberBranch> MemberBranches { get; set; }
        public DbSet<MemberTrainer> MemberTrainers { get; set; }
        public DbSet<PacketBranch> PacketBranches { get; set; }
    }
}
