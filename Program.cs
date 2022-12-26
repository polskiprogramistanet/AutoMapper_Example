using System;
using libAutoMapper.Application.Function.Queries.GetArticles;
using libAutoMapper.Application.Function.Mapper;
using AutoMapper;

namespace AutoMapper_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();
            });
            IMapper mapper = configurationProvider.CreateMapper();

            GetArticleQuery query = new GetArticleQuery(mapper);

            var res = query.Execute();

            Console.WriteLine($"Result: {res.Id} {res.Name} {res.Price}");
        }
    }
}
