using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using libAutoMapper.Domain.Entities;
using libAutoMapper.Application.Function.Queries;
using libAutoMapper.Application.Function.Mapper;

namespace libAutoMapper.Application.Function.Queries.GetArticles
{
    public class GetArticleQuery
    {
        private readonly IMapper mapper;
        public GetArticleQuery(IMapper mapper)
        {
            this.mapper = mapper; 
        }
        public ArticleViewModel Execute()
        {
            var article = new Article()
            {
                Id = 1,
                Name = "Microcontroller AVR",
                Price = 20.50m,
                Availability = 500
            };

            return mapper.Map<ArticleViewModel>(article);
        }
    }
}
