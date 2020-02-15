using System.Collections.Generic;
using AutoMapper;
using Modelos.Dao;
using Modelos.Dto;

namespace ApiCliente.Config
{
    public class AutoMapperConfig
    {
        public static void Config()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<LibroDto, Libro>().ReverseMap();
                cfg.CreateMap<LibroCreateForm, Libro>();
                cfg.CreateMap<ICollection<LibroDto>, ICollection<Libro>>();

            });
        }
    }
}
