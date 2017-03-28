using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Resposta
    {

        [Key]

        public int Codigo { get; set; }

        public int D { get; set; }

        public int I { get; set; }

        public int S { get; set; }

        public int C { get; set; }

        public virtual List<Usuario> Usuario { get; set; }


    }
}
