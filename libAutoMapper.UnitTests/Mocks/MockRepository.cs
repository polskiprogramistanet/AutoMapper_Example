using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using libAutoMapper.Application.Contracts.Persistence;
using libAutoMapper.Domain.Entities;
using Moq;

namespace libAutoMapper.UnitTests.Mocks
{
    public class MockRepository
    {
        public static Mock<IArticleRepository> GetArticleRepository()
        {
            var articles = GetArticles();
            var mockArticleRepository = new Mock<IArticleRepository>();
            mockArticleRepository.Setup(x => x.GetAllAsync()).ReturnsAsync(articles);

            return mockArticleRepository;
        }

        private static List<Article> GetArticles()
        {
            Article a1 = new Article()
            {
                Id = 1,
                Name = "PB-95",
                Availability = 10000,
                Price = 6.78m
            };
            Article a2 = new Article()
            {
                Id = 2,
                Name = "PB-98",
                Availability = 10,
                Price = 8.50m
            };
            Article a3 = new Article()
            {
                Id = 3,
                Name = "ON",
                Availability = 9999,
                Price = 7.98m
            };
            List<Article> a = new List<Article>();
            a.Add(a1); a.Add(a2); a.Add(a3);
            return a;
        }
    }
}
