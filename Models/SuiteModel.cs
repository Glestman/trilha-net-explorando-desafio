using Microsoft.EntityFrameworkCore;

namespace DesafioProjetoHospedagem.Models
{
    public class SuiteModel
    {
        public SuiteModel() { }

        public SuiteModel(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        public int Id { get; set; }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        [Precision(10, 2)]
        public decimal ValorDiaria { get; set; }
    }
}