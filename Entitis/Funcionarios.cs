using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Herança_Polimorfismo.Entitis
{
    class Funcionarios
    {
        public string Nome { get; set; }
        public double Hora { get; set; }
        public double ValorHora { get; set; }
        public Funcionarios()
        {


        }
        public Funcionarios(string nome, double hora, double valorHora)
        {
            Nome = nome;
            Hora = hora;
            ValorHora = valorHora;
        }
        public virtual double Pagamento()
        {
            return Hora * ValorHora;
            
        }
    }
   
}
