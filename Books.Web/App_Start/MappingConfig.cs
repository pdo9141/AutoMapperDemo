using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Books.Entities;
using Books.Web.ViewModels;

namespace Books.Web.App_Start
{
    public static class MappingConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<Book, BookViewModel>()
                    .ForMember(dest => dest.Category,
                               opt => opt.MapFrom(src => src.Category.ToString()));
            });
        }
    }
}