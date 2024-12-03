using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Exercises
{
    public record Car(string Make, string Model, int Year)
    {
        public override string ToString()
        {
            return $"Car info: {Make}, {Model}, {Year}";
        }

    }
}
