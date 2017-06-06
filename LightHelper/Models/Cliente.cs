using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LightHelper.Models
{
    public class Cliente
    {
        public long? ClienteID { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
    }
}