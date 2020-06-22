using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriaAgroalimentaria.Modelos
{
    public class Usuario
    {
        public uint Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"El id es {Id}), con el username {Username} y password {Password} ";
        }
    }
}
