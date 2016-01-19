using System.Collections;
using System.Collections.Generic;

namespace CarWash.Domain.Entities
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public virtual IList<Car> Cars { get; set; }
    }
}
