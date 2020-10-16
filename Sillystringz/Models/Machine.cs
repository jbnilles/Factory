using System.Collections.Generic;
namespace Sillystringz.Models
{
    public class Machine
    {
        public Machine()
        {
            this.EngineerMachines = new HashSet<EngineerMachine>();
        }
        public int MachineId {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public virtual ICollection<EngineerMachine> EngineerMachines{get; set;}
    }
}