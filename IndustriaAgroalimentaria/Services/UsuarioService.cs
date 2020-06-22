using IndustriaAgroalimentaria.DAO;
using IndustriaAgroalimentaria.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndustriaAgroalimentaria.Services
{
    public static class UsuarioService
    {
        public static bool Login()
        {
            Console.WriteLine("\n---Login---\n");
            Console.WriteLine("Por favor, ingrese el nombre de usuario");
            Usuario usuario = new Usuario();
            usuario.Username = Console.ReadLine();
            Console.WriteLine("Por favor, ingrese la contraseña");
            usuario.Password = Seguridad.EncriptarContraseña(Console.ReadLine());
            return ValidarLogin(usuario);
        }

        public static bool ValidarLogin(Usuario usuario)
        {
            using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
            {
                Usuario usuarioDB = context.Usuarios.Where(x => x.Username == usuario.Username).FirstOrDefault();
                if (usuarioDB != null)
                {
                    if (usuario.Password.Equals(usuarioDB.Password))
                    {
                        return true;
                    }
                }
                Console.WriteLine("El usuario y/o contraseña son incorrectos\n");
                return false;
            }
        }

        public static void InitUsers()
        {
            using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
            {
                List<Usuario> usuarios = context.Usuarios.ToList();
                if (usuarios.Count == 0)
                {
                    Usuario usuario = new Usuario();
                    usuario.Username = "Erick";
                    usuario.Password = Seguridad.EncriptarContraseña("Contraseña");
                    context.Add(usuario);
                    context.SaveChanges();
                }
            }
        }
    }
}
