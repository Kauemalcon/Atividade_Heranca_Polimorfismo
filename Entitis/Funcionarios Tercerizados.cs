using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Herança_Polimorfismo.Entitis
{
    class Funcionarios_Tercerizados : Funcionarios
    {
        public double Bonus { get; set; }

        public Funcionarios_Tercerizados()
        {

        }

        public Funcionarios_Tercerizados(string nome, double hora, double valorHora, double bonus) : base (nome, hora, valorHora)
        {
            Bonus = bonus;
        }
        public override double Pagamento()
        {
            return base.Pagamento() + (1.1 * Bonus);
        }
    }
}
