using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        private readonly string _nome;
        public Jogador2(string nome)
        {
            _nome = nome;
        }
        public string Chuta()
        {
            return $"{_nome} Chutou \n";
        }

        public string Corre()
        {
            return $"{_nome} Correu \n";
        }

        public string Passe()
        {
            return $"{_nome} Passou \n";
        }
    }
}