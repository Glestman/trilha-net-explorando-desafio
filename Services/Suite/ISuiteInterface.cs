using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioProjetoHospedagem.Dto.Suite;
using DesafioProjetoHospedagem.Models;
using DesafioProjetoHospedagem.Dto.Reserva;


namespace DesafioProjetoHospedagem.Services.Suite
{
    public interface ISuiteInterface
    {
        Task<ResponseModel<List<SuiteModel>>> ListarSuites();
        Task<ResponseModel<SuiteModel>> BuscarSuitesPorId(int idLivro);
        Task<ResponseModel<List<SuiteModel>>> BuscarSuitesPorIdReserva(int idReserva);

        Task<ResponseModel<List<SuiteModel>>> CriarSuite(SuiteCriacaoDto suiteCriacaoDto);
        Task<ResponseModel<List<SuiteModel>>> EditarSuite(SuiteEdicaoDto suiteEdicaoDto);
        Task<ResponseModel<List<SuiteModel>>> ExcluirSuite(int idSuite);
    }
}
