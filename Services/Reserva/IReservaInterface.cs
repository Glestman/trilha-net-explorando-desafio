using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioProjetoHospedagem.Dto.Reserva;
using DesafioProjetoHospedagem.Models;
using DesafioProjetoHospedagem.Dto.Pessoa;

namespace DesafioProjetoHospedagem.Services.Reserva
{
    public interface IReservaInterface
    {
        Task<ResponseModel<List<ReservaModel>>> ListarReservas();
        Task<ResponseModel<ReservaModel>> BuscarReservaPorId(int idReserva);
        Task<ResponseModel<List<ReservaModel>>> BuscarLivroPorIdAutor(int idAutor);

        Task<ResponseModel<List<ReservaModel>>> CriarReserva(ReservaCriacaoDto reservaCriacaoDto);
        Task<ResponseModel<List<ReservaModel>>> EditarLivro(ReservaEdicaoDto reservaEdicaoDto);
        Task<ResponseModel<List<ReservaModel>>> ExcluirReserva(int idReserva);
    }
}
