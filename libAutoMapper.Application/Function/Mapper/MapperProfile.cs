using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using libAutoMapper.Domain.Entities;
using libAutoMapper.Application.Function.Queries.GetArticles;

namespace libAutoMapper.Application.Function.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Article, ArticleViewModel>();
        }
    }
}
