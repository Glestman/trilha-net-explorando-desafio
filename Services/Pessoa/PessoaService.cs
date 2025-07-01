using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioProjetoHospedagem.Data;
using DesafioProjetoHospedagem.Dto.Pessoa;
using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem.Services.Pessoa
{
    public class PessoaService : IPessoaInterface
    {
        private readonly AppContext _context;
        public PessoaService(AppDbContext context)
        {
            _context = context;
        }

        public Task<ResponseModel<PessoaModel>> BuscarPessoaPorId(int IdPessoa)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<PessoaModel>> BuscarPessoaPorIdReserva(int idReserva)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<PessoaModel>>> CriarPessoa(PessoaCriacaoDto pessoaCriacaoDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<PessoaModel>>> EditarPessoa(PessoaCriacaoDto pessoaEdicaoDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<PessoaModel>>> ExcluirPessoa(int IdPessoa)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<PessoaModel>>> ListarPessoa()
        {
            throw new NotImplementedException();
        }
    }
}
