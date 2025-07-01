using DesafioProjetoHospedagem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioProjetoHospedagem.Dto.Reserva;
using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem.Services.Reserva
{
    public class ReservaService : IReservaInterface
    {
        private readonly AppContext _context;
        public ReservaService(AppDbContext context)
        {
            _context = context;
        }

        public Task<ResponseModel<List<ReservaModel>>> BuscarLivroPorIdAutor(int idAutor)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<ReservaModel>> BuscarReservaPorId(int idReserva)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<ReservaModel>>> ExcluirReserva(int idReserva)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<ReservaModel>>> ListarReservas()
        {
            throw new NotImplementedException();
        }

        Task<ResponseModel<List<ReservaModel>>> IReservaInterface.CriarReserva(ReservaCriacaoDto reservaCriacaoDto)
        {
            throw new NotImplementedException();
        }

        Task<ResponseModel<List<ReservaModel>>> IReservaInterface.EditarLivro(ReservaEdicaoDto reservaEdicaoDto)
        {
            throw new NotImplementedException();
        }
    }
}
