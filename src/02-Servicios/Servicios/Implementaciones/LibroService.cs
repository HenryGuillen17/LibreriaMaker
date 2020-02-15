using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Modelos.Dao;
using Modelos.Dto;
using Persistencia;
using Servicios.Interfaces;

namespace Servicios.Implementaciones
{
    public class LibroService : ILibroService
    {
        private readonly LibreriaDbContext _context;

        public LibroService(
            LibreriaDbContext context
        )
        {
            _context = context;
        }

        public async Task<ICollection<LibroDto>> GetAll()
        {
            var result = Mapper.Map<ICollection<LibroDto>>(
                await _context.Libro.ToListAsync()
                );

            return result;
        }

        public async Task<LibroDto> Get(int id)
        {
            var model = await _context.Libro.SingleOrDefaultAsync(x => x.IdLibro == id);

            return model == null ? null : Mapper.Map<LibroDto>(model);
        }

        public async Task<LibroDto> Create(LibroCreateForm model)
        {
            var objeto = Mapper.Map<Libro>(model);

            await _context.AddAsync(objeto);
            await _context.SaveChangesAsync();

            return Mapper.Map<LibroDto>(objeto);
        }

        public async Task<LibroDto> Update(LibroDto model)
        {
            var modelOriginal = await _context.Libro
                .SingleAsync(x => x.IdLibro == model.IdLibro);

            Mapper.Map(model, modelOriginal);

            _context.Update(modelOriginal);
            await _context.SaveChangesAsync();

            return Mapper.Map<LibroDto>(modelOriginal);
        }

        public async Task<int> Delete(int id)
        {
            _context.Libro.Remove(new Libro { IdLibro = id });

            return await _context.SaveChangesAsync();
        }
    }
}
