using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.PolimorfismoMVC.Model
{
    public class Validacao : AbsPropriedades
    {
        public Validacao(string lado1, string lado2, string lado3) : base(lado1,lado2,lado3) { }

        public override void Executar()
        {
            try
            {
                this.Lado1 = Convert.ToDouble(this.lado1);
                this.Lado2 = Convert.ToDouble(this.lado2);
                this.Lado3 = Convert.ToDouble(this.lado3);
                this.Resposta = "valido";
            }
            catch (Exception)
            {
                this.Resposta = "Entrada Invalida!";
            }
        }
    }
}
