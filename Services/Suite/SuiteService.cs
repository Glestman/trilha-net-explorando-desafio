using DesafioProjetoHospedagem.Data;
using DesafioProjetoHospedagem.Dto.Suite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioProjetoHospedagem.Models;


namespace DesafioProjetoHospedagem.Services.Suite
{
    public class SuiteService : ISuiteInterface
    {
        private readonly AppContext _context;
        public SuiteService(AppDbContext context)
        {
            _context = context;
        }

        public Task<ResponseModel<SuiteModel>> BuscarSuitesPorId(int idLivro)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<SuiteModel>>> BuscarSuitesPorIdReserva(int idReserva)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<SuiteModel>>> ExcluirSuite(int idSuite)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<SuiteModel>>> ListarSuites()
        {
            throw new NotImplementedException();
        }

        Task<ResponseModel<List<SuiteModel>>> ISuiteInterface.CriarSuite(SuiteCriacaoDto suiteCriacaoDto)
        {
            throw new NotImplementedException();
        }

        Task<ResponseModel<List<SuiteModel>>> ISuiteInterface.EditarSuite(SuiteEdicaoDto suiteEdicaoDto)
        {
            throw new NotImplementedException();
        }
    }
}
