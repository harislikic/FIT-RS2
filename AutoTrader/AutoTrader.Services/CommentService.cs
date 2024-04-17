using System;
using AutoMapper;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
using AutoTrader.Services.Database;

namespace AutoTrader.Services
{
    public class CommentService : BaseCRUDService<Model.Comment, Comment, BaseSearchObject, CommentInsertRequest, CommentInsertRequest>, ICommentService
    {
        public CommentService(AutoTraderContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

