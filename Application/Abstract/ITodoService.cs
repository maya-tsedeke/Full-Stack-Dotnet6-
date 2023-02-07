using Domain.Entities;
using Application.Models;

namespace Application.Abstract
{
    public interface ITodoService
    {
        Task<int> Add(TodoDto entity);
        Task<WebApiResponse> Update(int? todoId, TodoDto entity, int updatedUserId);
        Task<WebApiResponse> UpdateStatus(int? todoId, int status, int updatedUserId);
        Task<WebApiResponse> Delete(int? todoId);
        Task<IEnumerable<Todo>> Get();
        Task<Todo> Get(int? todoId);
        Task<IEnumerable<Todo>> Page(string sort = "Id", bool desc = true, int skip = 0, int take = 10);
        Task<IEnumerable<Todo>> Page(string sort = "Id", bool desc = true, string param = "", int skip = 0, int take = 10);
        Task<IEnumerable<Todo>> Search(string sort = "Id", bool desc = true, string param = "");
        Task<IEnumerable<Todo>> GetByStatus(string sort = "Id", bool desc = true, int status = 0);
    }
}
