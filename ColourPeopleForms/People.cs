using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourPeopleForms
{
    public class People
    {
        public int PeopleId { get; set; }

        public string? Name { get; set; }

        public int? Height { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;

    }
}
