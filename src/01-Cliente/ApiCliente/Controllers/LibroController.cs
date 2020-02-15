using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Modelos.Dto;
using Servicios.Interfaces;

namespace ApiCliente.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : Controller
    {
        private readonly ILibroService _libroService;

        public LibroController(
            ILibroService libroService
        )
        {
            _libroService = libroService;
        }


        /// <summary>
        /// TODO: Debería ser paginado, pero hay premura
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _libroService.GetAll();

            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _libroService.Get(id);

            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Create(LibroCreateForm model)
        {
            try
            {
                var result = await _libroService.Create(model);

                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

        }


        [HttpPut]
        public async Task<IActionResult> Update(LibroDto model)
        {
            try
            {
                var result = await _libroService.Update(model);

                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int idLibro)
        {
            try
            {
                var result = await _libroService.Delete(idLibro);

                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }

        }


    }
}