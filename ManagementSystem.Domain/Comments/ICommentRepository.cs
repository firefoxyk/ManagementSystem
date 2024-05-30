using ManagementSystem.Domain.Balance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Domain.Comments
{
    public interface ICommentRepository
    {
        //Task<Comment?> GetByIdAsync(Id id);
        Task Add(Comment comment);
    }
}
