using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios18
{
    class Calendario
    {
        public string DiaDaSemana(int dia)
        {

            string diaSemana = dia switch
            {
                3 or 10 or 17 or 24 or 31 => "Segunda-Feira",
                4 or 11 or 18 or 25 => "Terça-Feira",
                5 or 12 or 19 or 26 => "Quarta-Feira",
                6 or 13 or 20 or 27 => "Quinta-feira",
                7 or 14 or 21 or 28 => "Sexta-feira",
                1 or 8 or 15 or 22 or 29 => "Sábado",
                2 or 9 or 16 or 23 or 30 => "Domingo",
                _ => "Dia desconhecido"
            };

            return diaSemana;
        }
    }
}
