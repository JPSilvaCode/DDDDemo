﻿using AutoMapper;
using DDDDemo.Dominio.Entidades;
using DDDDemo.MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDDDemo.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Categoria, CategoriaViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}