using Microsoft.EntityFrameworkCore;
using SubastaYa.Data;

var builder = WebApplication.CreateBuilder(args);

// Conection strings
var connectionStrings = builder.Configuration.GetConnectionString("DefaultConnection");


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SubastaYaContext>(options => options.UseSqlServer(connectionStrings));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseDeveloperExceptionPage();
    
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
