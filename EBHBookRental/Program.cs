
using BookRental.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EBHBookRental.Data;

var builder = WebApplication.CreateBuilder(args);

#pragma warning disable CS0436 // Type conflicts with imported type
IServiceCollection serviceCollection = builder.Services.AddDbContext<BookRentalDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
#pragma warning restore CS0436 // Type conflicts with imported type

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<EBHBookRentalContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("EBHBookRentalContext") ?? throw new InvalidOperationException("Connection string 'EBHBookRentalContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
