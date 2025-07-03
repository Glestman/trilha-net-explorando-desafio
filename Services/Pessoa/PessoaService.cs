using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioProjetoHospedagem.Data;
using DesafioProjetoHospedagem.Dto.Pessoa;
using DesafioProjetoHospedagem.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioProjetoHospedagem.Services.Pessoa
{
    public class PessoaService : IPessoaInterface
    {
        private readonly AppDbContext _context;
        public PessoaService(AppDbContext context)
        {
            _context = context;
        }

        Task<ResponseModel<PessoaModel>> IPessoaInterface.BuscarPessoaPorId(int IdPessoa)
        {
            throw new NotImplementedException();
        }

        Task<ResponseModel<PessoaModel>> IPessoaInterface.BuscarPessoaPorIdReserva(int idReserva)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<List<PessoaModel>>> CriarPessoa(PessoaCriacaoDto pessoaCriacaoDto)
        {
            ResponseModel<List<PessoaModel>> resposta = new ResponseModel<List<PessoaModel>>();
            try
            {
                var pessoa = new PessoaModel()
                {
                    Nome = pessoaCriacaoDto.Nome,
                    Sobrenome = pessoaCriacaoDto.Sobrenome,
                  
                };
                _context.Add(pessoa);
                await _context.SaveChangesAsync();

                resposta.Dados = await _context.Pessoas.ToListAsync();
                resposta.Mensagem = "Criado cadastro com sucesso";
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }

        Task<ResponseModel<List<PessoaModel>>> IPessoaInterface.EditarPessoa(PessoaEdicaoDto pessoaEdicaoDto)
        {
            throw new NotImplementedException();
        }

        Task<ResponseModel<List<PessoaModel>>> IPessoaInterface.ExcluirPessoa(int IdPessoa)
        {
            throw new NotImplementedException();
        }

       public async Task<ResponseModel<List<PessoaModel>>> ListarPessoas()
        {
            ResponseModel<List<PessoaModel>> resposta = new ResponseModel<List<PessoaModel>>();
            try
            {
                var pessoas = await _context.Pessoas.ToListAsync();
                resposta.Dados = pessoas;
                resposta.Mensagem = "Todos os autores foram coletados";
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }
    

    
        public Task<ResponseModel<PessoaModel>> BuscarPessoaPorId(int IdPessoa)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<PessoaModel>> BuscarPessoaPorIdReserva(int idReserva)
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
