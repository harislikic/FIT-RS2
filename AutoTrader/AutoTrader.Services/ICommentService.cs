using System;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;

namespace AutoTrader.Services
{
    public interface ICommentService : ICRUDService<Model.Comment, BaseSearchObject, CommentInsertRequest, CommentInsertRequest>
	{
		
	}
}

