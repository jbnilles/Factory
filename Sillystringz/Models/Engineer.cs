using System.Collections.Generic;
namespace Sillystringz.Models
{
    public class Engineer
    {
        public Engineer()
        {
            this.EngineerMachines = new HashSet<EngineerMachine>();
        }
        public int EngineerId {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public virtual ICollection<EngineerMachine> EngineerMachines{get; set;}
    }
}