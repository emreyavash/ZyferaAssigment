using ZyferaAssigment.Business.Abstract;
using ZyferaAssigment.Business.Concrete;
using ZyferaAssigment.DataAccess.Abstract;
using ZyferaAssigment.DataAccess.Context;
using ZyferaAssigment.DataAccess.EFRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ZyferaDbContext>();
builder.Services.AddScoped<IStudentDal,EFStudentDal>();
builder.Services.AddScoped<IStudentService,StudentService>();
builder.Services.AddScoped<IGradeDal, EFGradeDal>();
builder.Services.AddScoped<IGradeService, GradeService>();

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
