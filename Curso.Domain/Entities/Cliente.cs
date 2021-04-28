using Curso.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Domain.Entities
{
    public class Cliente: BaseEntity
    {
        public int CodCliente { get; set; }
        public string NomeCliente { get; set; }
    }
}
