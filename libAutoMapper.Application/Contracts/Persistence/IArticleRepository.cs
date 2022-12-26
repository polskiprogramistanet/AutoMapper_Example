using System;
using System.Collections.Generic;
using System.Text;
using libAutoMapper.Domain.Entities;

namespace libAutoMapper.Application.Contracts.Persistence
{
    public interface IArticleRepository : IAsyncRepository<Article>
    {
    }
}
