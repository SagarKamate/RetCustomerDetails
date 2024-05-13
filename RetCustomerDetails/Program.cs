using RetCustomerDetails.Service;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddTransient<ICustomerService, CustomerService>();

var app = builder.Build();

//app.UseStaticFiles();
app.UseRouting();

//app.MapControllers();
app.Run();
