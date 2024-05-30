using ManagementSystem.Domain.Balance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Domain.Appeal
{
    public interface IAppealRepository//спроси тут
    {
       // Task<Appeal?> GetByIdAsync(Id id);
        Task Add(Appeal appeal);
    }
}
