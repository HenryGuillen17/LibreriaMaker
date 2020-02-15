using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Modelos.Dto;

namespace Servicios.Interfaces
{
    public interface ILibroService
    {
        Task<ICollection<LibroDto>> GetAll();
        Task<LibroDto> Get(int id);
        Task<LibroDto> Create(LibroCreateForm model);
        Task<LibroDto> Update(LibroDto model);
        Task<int> Delete(int id);
    }
}
