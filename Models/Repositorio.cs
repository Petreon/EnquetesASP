using System.Collections.Generic;
namespace EnquetesASP.Models
{
    public static class Repositorio
    {
        // WHen the satic method is used, only have one instance
        // for the class in the whole Program runtime, and cannot be
        // re-instatiated
        private static List<Resposta> respostas = new List<Resposta>();

        //Ienumerable only with get, returns the respostas list but without
        // the default methods from a list, so you only can read the list without changes
        // this is a kind of encpsulation
        public static IEnumerable<Resposta> Respostas { get { return respostas; } }

        public static void AdicionarResposta(Resposta resposta)
        {
            respostas.Add(resposta);
        }
    }
}
