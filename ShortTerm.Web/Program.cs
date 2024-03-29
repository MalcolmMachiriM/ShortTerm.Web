using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Configurations;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<Employee>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IClientRepository , ClientRepository>();
builder.Services.AddScoped<ISchemeRepository , SchemeRepository>();
builder.Services.AddScoped<IProductGroupRepository , ProductGroupRepository>();
builder.Services.AddScoped<IIndividualProductsRepository, IndividualProductsRepository>();
builder.Services.AddScoped<IPolicyRepository, PolicyRepository>();
builder.Services.AddScoped<IProductPolicyRequirementRepository, ProductPolicyRequirementRepository>();
builder.Services.AddScoped<IUnderwritingRepository, UnderwritingRepository>();
builder.Services.AddScoped<IReasurerRepository, ReasurerRepository>();
builder.Services.AddScoped<IPolicyReassurancesRepository, PolicyReassurancesRepository>();
builder.Services.AddScoped<IPremiumPaymentRepository, PremiumPaymentRepository>();

builder.Services.AddAutoMapper(typeof(MapperConfig));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
