using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project_Karel_Gortz.Data;
using Project_Karel_Gortz.Models.Users;
using Project_Karel_Gortz.Services;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<CustomUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    //Passwoord-restrictions toevoegen
    options.Password.RequireDigit = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 7;
    options.Password.RequireNonAlphanumeric = false;
}).AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();


//policy
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policyBuilder => policyBuilder.RequireClaim("CanDeletePosts", "1"));
});

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ApplicationDbContext>();
builder.Services.AddScoped<FixtureService>();
builder.Services.AddScoped<TeamService>();
builder.Services.AddScoped<PostService>();
builder.Services.AddScoped<CommentService>();
builder.Services.AddSession();



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
app.UseSession();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetService<UserManager<CustomUser>>();
    if (userManager.FindByEmailAsync("karel.gortz@student.odisee.be").Result == null)
    {
        //Create new user
        CustomUser adminUser = new CustomUser();
        adminUser.UserName = "karel.gortz@student.odisee.be";
        adminUser.Email = "karel.gortz@student.odisee.be";
        adminUser.EmailConfirmed = true;
        adminUser.FirstName = "Karel";
        adminUser.LastName = "Görtz";


        var result = userManager.CreateAsync(adminUser, "User1234").Result;
        if (result.Succeeded)
        {
            Claim[] claims = new Claim[] {
                    new Claim("CanDeletePosts", string.Empty)
                    };
            userManager.AddClaimsAsync(adminUser, claims).Wait();
        }

        adminUser = new CustomUser();
        adminUser.UserName = "sam.vanbuggenhout@odisee.be";
        adminUser.Email = "sam.vanbuggenhout@odisee.be";
        adminUser.EmailConfirmed = true;
        adminUser.FirstName = "Sam";
        adminUser.LastName = "Van Buggenhout";

        result = userManager.CreateAsync(adminUser, "Admin1234").Result;
        if (result.Succeeded)
        {
            Claim[] claims = new Claim[] {
                    new Claim("CanDeletePosts", "1")
                    };
            userManager.AddClaimsAsync(adminUser, claims).Wait();
        }
    }
}

app.Run();
