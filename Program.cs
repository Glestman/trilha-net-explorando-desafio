using DesafioProjetoHospedagem.Data;
using DesafioProjetoHospedagem.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Text;
using DesafioProjetoHospedagem.Services.Pessoa;
using DesafioProjetoHospedagem.Services.Suite;
using DesafioProjetoHospedagem.Services.Reserva;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IPessoaInterface, PessoaService>();
builder.Services.AddScoped<ISuiteInterface, SuiteService>();
builder.Services.AddScoped<IReservaInterface, ReservaService>();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Minha API",
        Version = "v1"
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{



}
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Biblioteca");
    c.RoutePrefix = string.Empty; // Torna o Swagger a página inicial (localhost:5000/)
});
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

/*Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<PessoaModel> hospedes = new List<PessoaModel>();

PessoaModel p1 = new PessoaModel(nome: "Hóspede 1");
PessoaModel p2 = new PessoaModel(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
SuiteModel suite = new SuiteModel(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
ReservaModel reserva = new ReservaModel(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}"); */