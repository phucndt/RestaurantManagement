using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcRole.Data;
using MvcCustomer.Data;
using MvcFeedback.Data;
using MvcMenu.Data;
using MvcOrder.Data;
using MvcOrderItem.Data;
using MvcPromotion.Data;
using MvcReview.Data;
using MvcSupplier.Data;
using MvcSupplierOrder.Data;
using MvcTableReservation.Data;
using MvcUser.Data;
using MvcInventorie.Data;
using MvcCategorie.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MvcCategorieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcCategorieContext") ?? throw new InvalidOperationException("Connection string 'MvcCategorieContext' not found.")));
builder.Services.AddDbContext<MvcInventorieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcInventorieContext") ?? throw new InvalidOperationException("Connection string 'MvcInventorieContext' not found.")));
builder.Services.AddDbContext<MvcUserContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcUserContext") ?? throw new InvalidOperationException("Connection string 'MvcUserContext' not found.")));
builder.Services.AddDbContext<MvcTableReservationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcTableReservationContext") ?? throw new InvalidOperationException("Connection string 'MvcTableReservationContext' not found.")));
builder.Services.AddDbContext<MvcSupplierOrderContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcSupplierOrderContext") ?? throw new InvalidOperationException("Connection string 'MvcSupplierOrderContext' not found.")));
builder.Services.AddDbContext<MvcSupplierContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcSupplierContext") ?? throw new InvalidOperationException("Connection string 'MvcSupplierContext' not found.")));
builder.Services.AddDbContext<MvcReviewContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcReviewContext") ?? throw new InvalidOperationException("Connection string 'MvcReviewContext' not found.")));
builder.Services.AddDbContext<MvcPromotionContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcPromotionContext") ?? throw new InvalidOperationException("Connection string 'MvcPromotionContext' not found.")));
builder.Services.AddDbContext<MvcOrderItemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcOrderItemContext") ?? throw new InvalidOperationException("Connection string 'MvcOrderItemContext' not found.")));
builder.Services.AddDbContext<MvcOrderContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcOrderContext") ?? throw new InvalidOperationException("Connection string 'MvcOrderContext' not found.")));
builder.Services.AddDbContext<MvcMenuContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcMenuContext") ?? throw new InvalidOperationException("Connection string 'MvcMenuContext' not found.")));
builder.Services.AddDbContext<MvcFeedbackContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcFeedbackContext") ?? throw new InvalidOperationException("Connection string 'MvcFeedbackContext' not found.")));
builder.Services.AddDbContext<MvcCustomerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcCustomerContext") ?? throw new InvalidOperationException("Connection string 'MvcCustomerContext' not found.")));
builder.Services.AddDbContext<MvcRoleContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcRoleContext") ?? throw new InvalidOperationException("Connection string 'MvcRoleContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
