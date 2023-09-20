namespace TinderDog.WebApp.Models
{
    public class UsuarioViewModel
    {
        public string usuario { get; set; }
        public string senha { get; set; }

        public bool Autenticado()
        {
            if (usuario == "Teste" && senha == "123")
                return true;
            return false;
        }
    }
}
