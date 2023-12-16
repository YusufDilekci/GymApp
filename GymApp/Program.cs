using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using CoreLayer.Entities.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories.EntityFramework;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IBranchService, BranchManager>();
builder.Services.AddTransient<IBranchDal, EfBranchRepository>();
builder.Services.AddTransient<ITrainerService, TrainerManager>();
builder.Services.AddTransient<ITrainerDal, EfTrainerRepository>();
builder.Services.AddTransient<IDescriptionService, DescriptionManager>();
builder.Services.AddTransient<IDescriptionDal, EfDescriptionRepository>();
builder.Services.AddTransient<IImageService, ImageManager>();
builder.Services.AddTransient<IImageDal, EfImageRepository>();
builder.Services.AddTransient<IContactService, ContactManager>();
builder.Services.AddTransient<IContactDal, EfContactRepository>();
builder.Services.AddTransient<IMemberService, MemberManager>();
builder.Services.AddTransient<IMemberDal, EfMemberRepository>();
builder.Services.AddTransient<IPacketService, PacketManager>();
builder.Services.AddTransient<IPacketDal, EfPacketRepository>();
builder.Services.AddTransient<ICategoryService, CategoryManager>();
builder.Services.AddTransient<ICategoryDal, EfCategoryRepository>();
builder.Services.AddTransient<ISubCategoryService, SubCategoryManager>();
builder.Services.AddTransient<ISubCategoryDal, EfSubCategoryRepository>();
builder.Services.AddTransient<IProductService, ProductManager>();
builder.Services.AddTransient<IProductDal, EfProductRepository>();
builder.Services.AddTransient<ICartService, CartManager>();
builder.Services.AddTransient<ICartDal, EfCartRepository>();
builder.Services.AddTransient<ICartLineService, CartLineManager>();
builder.Services.AddTransient<ICartLineDal, EfCartLineRepository>();
builder.Services.AddTransient<IUserService, UserManager>();
builder.Services.AddTransient<IUserDal, EfUserRepository>();
builder.Services.AddTransient<IShippingDetailService, ShippingDetailManager>();
builder.Services.AddTransient<IShippingDetailDal, EfShippingDetailRepository>();
builder.Services.AddTransient<IAdminService, AdminManager>();
builder.Services.AddTransient<IAdminDal, EfAdminRepository>();
builder.Services.AddTransient<ICommentService, CommentManager>();
builder.Services.AddTransient<ICommentDal, EfCommentRepository>();

//Authorization

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();

    config.Filters.Add(new AuthorizeFilter(policy));
});

//Identity
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>(x =>
{
    x.Password.RequireUppercase = false;
    x.Password.RequireNonAlphanumeric = false;
    x.Password.RequiredLength = 1;
    x.Password.RequireLowercase= false;
})
    .AddEntityFrameworkStores<Context>();



// Authentication gereken sayfalara girmeye çalýþýnca kullanýcýyý login sayfasýna yönlendirecek.
// Amaç kullanýcýnýn giriþ veya kayýt olmadan sayfalarý görmemesidir.
builder.Services.AddMvc();
builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(x =>
    {
        x.LoginPath = "/Login/Index";
    });

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

    options.LoginPath = "/Login/Index";
    options.SlidingExpiration = true;
});

// Session
//builder.Services.AddSession(); Bu yöntem yerine SignInAsync() yöntemini kullanýcaðýz.





var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();


//app.UseSession();

app.MapControllerRoute(
  name: "areas",
  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
