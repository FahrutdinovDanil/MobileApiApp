using System;
using System.Collections.Generic;
using System.Text;
using MobileApiApp.Models;
using System.Threading.Tasks;

namespace MobileApiApp.Services
{
    public interface IRestService
    {
        Task<List<Cat>> GetTodoItemAsync();
        Task SaveTodoItemAsync(Cat cat, bool isNewItem);
        Task DeleteTodoItemAsync(Cat cat);
    }
}
