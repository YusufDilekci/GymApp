using CoreLayer.Entities.Concrete;
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
    public class Context : IdentityDbContext<AppUser, AppRole, int>
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

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category() { CategoryId = 1, CategoryName = "Erkek Giyim" },
                    new Category() { CategoryId = 2, CategoryName = "Kadın Giyim" },
                    new Category() { CategoryId = 3, CategoryName = "Supplement" }
                );

            modelBuilder.Entity<SubCategory>()
                .HasData(
                    new SubCategory() { SubCategoryId=1, CategoryId=1, SubCategoryName="Tshirt" , SubCategoryImage="#"},
                    new SubCategory() { SubCategoryId = 2, CategoryId = 1, SubCategoryName = "Sweatshirt", SubCategoryImage = "#" },
                    new SubCategory() { SubCategoryId = 3, CategoryId = 1, SubCategoryName = "Eşofman", SubCategoryImage = "#" },
                    new SubCategory() { SubCategoryId = 4, CategoryId = 1, SubCategoryName = "Ayakkabı", SubCategoryImage = "#" },
                    new SubCategory() { SubCategoryId = 5, CategoryId = 2, SubCategoryName = "Tshirt", SubCategoryImage = "#" },
                    new SubCategory() { SubCategoryId = 6, CategoryId = 2, SubCategoryName = "Sweatshirt", SubCategoryImage = "#" },
                    new SubCategory() { SubCategoryId = 7, CategoryId = 2, SubCategoryName = "Eşofman", SubCategoryImage = "#" },
                    new SubCategory() { SubCategoryId = 8, CategoryId = 2, SubCategoryName = "Ayakkabı", SubCategoryImage = "#" },
                    new SubCategory() { SubCategoryId = 9, CategoryId = 3, SubCategoryName = "Protein Tozu", SubCategoryImage = "#" },
                    new SubCategory() { SubCategoryId = 10, CategoryId = 3, SubCategoryName = "Gainer", SubCategoryImage = "#" },
                    new SubCategory() { SubCategoryId = 11, CategoryId = 3, SubCategoryName = "Kreatin", SubCategoryImage = "#" },
                    new SubCategory() { SubCategoryId = 12, CategoryId = 3, SubCategoryName = "PreWorkout", SubCategoryImage = "#" },
                    new SubCategory() { SubCategoryId = 13, CategoryId = 3, SubCategoryName = "BCAA", SubCategoryImage = "#" }

                );
            modelBuilder.Entity<Product>()
                .HasData(
                    new Product() { ProductId=1, SubCategoryId=1, ProductName= "Jack & Jones", ProductPrice=200, ProductImage="#", ProductDescription= "Erkek Tshirt"},
                    new Product() { ProductId = 2, SubCategoryId = 1, ProductName = "Mavi", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 3, SubCategoryId = 1, ProductName = "DeFacto", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 4, SubCategoryId = 2, ProductName = "Jack & Jones", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 5, SubCategoryId = 2, ProductName = "Pull & Bear", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 6, SubCategoryId = 2, ProductName = "Lc Waikiki", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 7, SubCategoryId = 3, ProductName = "Nike", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 8, SubCategoryId = 3, ProductName = "Adidas", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 9, SubCategoryId = 3, ProductName = "Under Armour", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 10, SubCategoryId = 4, ProductName = "Nike", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 11, SubCategoryId = 4, ProductName = "Puma", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 12, SubCategoryId = 4, ProductName = "Adidas", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 13, SubCategoryId = 5, ProductName = "Jack & Jones", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 14, SubCategoryId = 5, ProductName = "Mavi", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 15, SubCategoryId = 5, ProductName = "DeFacto", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 16, SubCategoryId = 6, ProductName = "Jack & Jones", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 17, SubCategoryId = 6, ProductName = "Pull & Bear", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 18, SubCategoryId = 6, ProductName = "Lc Waikiki", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 19, SubCategoryId = 7, ProductName = "Nike", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 20, SubCategoryId = 7, ProductName = "Adidas", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 21, SubCategoryId = 7, ProductName = "Under Armour", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 22, SubCategoryId = 8, ProductName = "Nike", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 23, SubCategoryId = 8, ProductName = "Puma", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 24, SubCategoryId = 8, ProductName = "Adidas", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 25, SubCategoryId = 9, ProductName = "Hardline", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 26, SubCategoryId = 9, ProductName = "Protein Ocean", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 27, SubCategoryId = 9, ProductName = "Swiss", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 28, SubCategoryId = 10, ProductName = "Hardline", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 29, SubCategoryId = 10, ProductName = "Protein Ocean", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 30, SubCategoryId = 10, ProductName = "Swiss", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 31, SubCategoryId = 11, ProductName = "Hardline", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 32, SubCategoryId = 11, ProductName = "Protein Ocean", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 33, SubCategoryId = 11, ProductName = "Swiss", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 34, SubCategoryId = 12, ProductName = "Hardline", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 35, SubCategoryId = 12, ProductName = "Protein Ocean", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 36, SubCategoryId = 12, ProductName = "Swiss", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 37, SubCategoryId = 13, ProductName = "Hardline", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 38, SubCategoryId = 13, ProductName = "Protein Ocean", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" },
                    new Product() { ProductId = 39, SubCategoryId = 13, ProductName = "Swiss", ProductPrice = 200, ProductImage = "#", ProductDescription = "Erkek Tshirt" }




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
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartLine> CartLines { get; set; }
        public DbSet<ShippingDetail> ShippingDetails { get; set; }

    }
}
