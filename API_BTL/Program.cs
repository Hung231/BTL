using BussinessLayer;
using BussinessLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IDatabaseHelper, DatabaseHelper>();
builder.Services.AddTransient<IProductResponsitory, ProductResponsitory>();
builder.Services.AddTransient<IProductBUSS, ProductBUS>();
builder.Services.AddTransient<ICustomerResponsitory, CustomerResponsitory>();
builder.Services.AddTransient<ICustomerBUSS, CustomerBUS>();
builder.Services.AddTransient<IOrderResponsitory, OrderResponsitory>();
builder.Services.AddTransient<IOrderBUSS, OrderBUS>();
builder.Services.AddTransient<IUserResponsitory, UserResponsitory>();
builder.Services.AddTransient<IUserBUSS, UserBUS>();
builder.Services.AddTransient<IAdminResponsitory, AdminResponsitory>();
builder.Services.AddTransient<IAdminBUSS, AdminBUS>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
