using AutoMapper;
using DDDDemo.Dominio.Entidades;
using DDDDemo.MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDDDemo.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CategoriaViewModel, Categoria>();
        }
    }
}