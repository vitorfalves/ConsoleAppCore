﻿using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador2("Vitor"), new Jogador1("Ronaldo"));
            jogo.IniciarJogo();
        }
    }
}
