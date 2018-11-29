using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterProjectt.Models
{
    interface IMachineRepo
    {
        Task<IEnumerable<Machine>> GetMachines(string category = null);
        Task<Machine> GetMachineById(int machineId);

        void updateMachine(Machine machine);
        Task AddMachineAsync(Machine machine);
        void Delete(int id);
    }
}
