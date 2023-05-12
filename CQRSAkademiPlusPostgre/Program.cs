using CQRSAkademiPlusPostgre.CQRSPattern.Handlers;
using CQRSAkademiPlusPostgre.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Context>(opt=>opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<GetEmployeeQueryHandler>();
builder.Services.AddScoped<GetEmployeeByIDQueryHandler>();
builder.Services.AddScoped<CreateEmployeeCommandHandler>();
builder.Services.AddScoped<RemoveEmployeeCommandHandler>();
builder.Services.AddScoped<GetEmployeeUpdateByIDQueryHandler>();
builder.Services.AddScoped<GetProductQueryHandler>();
builder.Services.AddScoped<GetProductByIDQueryHandler>();
builder.Services.AddScoped<CreateProductCommandHandler>();
builder.Services.AddScoped<RemoveProductCommandHandler>();
builder.Services.AddScoped<GetProductUpdateByIDQueryHandler>();
builder.Services.AddScoped<UpdateEmployeeCommandHandler>();


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
