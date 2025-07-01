using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioProjetoHospedagem.Models;
using DesafioProjetoHospedagem.Dto.Pessoa;

namespace DesafioProjetoHospedagem.Services.Pessoa
{
    public interface IPessoaInterface
    {
        Task<ResponseModel<List<PessoaModel>>> ListarPessoa();
        Task<ResponseModel<PessoaModel>> BuscarPessoaPorId(int IdPessoa);
        Task<ResponseModel<PessoaModel>> BuscarPessoaPorIdReserva(int idReserva);
        Task<ResponseModel<List<PessoaModel>>> CriarPessoa(PessoaCriacaoDto pessoaCriacaoDto);
        Task<ResponseModel<List<PessoaModel>>> EditarPessoa(PessoaCriacaoDto pessoaEdicaoDto);
        Task<ResponseModel<List<PessoaModel>>> ExcluirPessoa(int IdPessoa);
    }
}
