
using Data;
using Model;

namespace Controller
{
    public class UsuarioController
    {
        public static void Salvar(Usuario u)
        {
            using (DataContext context = new DataContext())
            {
                context.Usuarios.Add(u);
                context.SaveChanges();
            }
        }
        public static void Atualizar(Usuario u)
        {
            using (DataContext context = new DataContext())
            {
                bool existe = context.Usuarios.Any(p => p.Id == u.Id);
                if (existe)
                {
                    context.Usuarios.Update(u);
                    context.SaveChanges();
                }
            }
        }
        public static void Remover(Usuario u)
        {
            using (DataContext context = new DataContext())
            {
                 context.Usuarios.Remove(u);
                 context.SaveChanges();
            }
        }
    }
    public class CalendarioController
    {
        public static void Salvar(Calendario c)
        {
            using (DataContext context = new DataContext())
            {
                context.Calendarios.Add(c);
                context.SaveChanges();
            }
        }
        public static void Atualizar(Calendario c)
        {
            using (DataContext context = new DataContext())
            {
                bool existe = context.Usuarios.Any(p => p.Id == c.Id);
                if (existe)
                {
                    context.Calendarios.Update(c);
                    context.SaveChanges();
                }
            }
        }
        public static void Remover(Calendario c)
        {
            using (DataContext context = new DataContext())
            {
                context.Calendarios.Remove(c);
                context.SaveChanges();
            }
        }
    }
}
