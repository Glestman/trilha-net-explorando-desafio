using DesafioProjetoHospedagem.Dto.Pessoa;
using DesafioProjetoHospedagem.Models;
using DesafioProjetoHospedagem.Services.Pessoa;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Controllers
{
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaInterface _pessoaInterface;
        public PessoaController (IPessoaInterface pessoaInterface)
        {
            _pessoaInterface = pessoaInterface;
        }

        [HttpGet("ListarPessoas")]
        public async Task<ActionResult<ResponseModel<List<PessoaModel>>>> ListarPessoas()
        {
            var pessoas = await _pessoaInterface.ListarPessoas();
            return Ok(pessoas);
        }
        [HttpGet("BuscarPessoaPorId/{idPessoa}")]
        public async Task<ActionResult<ResponseModel<List<PessoaModel>>>>BuscarPessoaPorId(int idPessoa)
        {
            var pessoas = await _pessoaInterface.BuscarPessoaPorId(idPessoa);
            return Ok(pessoas);
        }
        [HttpGet("BuscarPessoaPorIdReserva/{idReserva}")]
        public async Task<ActionResult<ResponseModel<PessoaModel>>> BuscarPessoaPorIdReserva(int idReserva)
        {
            var pessoas = await _pessoaInterface.BuscarPessoaPorIdReserva(idReserva);
            return Ok(pessoas);
        }
        [HttpPost("CriarPessoa")]
        public async Task<ActionResult<ResponseModel<PessoaModel>>> CriarPessoa(PessoaCriacaoDto pessoaCriacaoDto)
        {
            var pessoas = await _pessoaInterface.CriarPessoa(pessoaCriacaoDto);
            return Ok(pessoas);
        }
        [HttpPost("EditarPessoa")]
        public async Task<ActionResult<ResponseModel<PessoaModel>>> EditarPessoa(PessoaEdicaoDto pessoaEdicaoDto)
        {
            var pessoas = await _pessoaInterface.EditarPessoa(pessoaEdicaoDto);
            return Ok(pessoas);
        }
        [HttpPost("ExcluirPessoa")]
        public async Task<ActionResult<ResponseModel<PessoaModel>>> ExcluirPessoa(int idPessoa)
        {
            var pessoas = await _pessoaInterface.ExcluirPessoa(idPessoa);
            return Ok(pessoas);
        }

    }
        
}
