using System.Collections.Generic;

namespace Entities
{
    public class Departament
    {
        public IEnumerable<Employer> Employers { get; set; }
        public Manager Manager { get; set; }
        
    }
}