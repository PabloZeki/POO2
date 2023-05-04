using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemploherencia3
{
    internal class Tigre : AnimalSalvaje, Runner
    {
        public string correr()
        {
            return "Corre como un tigre...";
        }
    }
}
