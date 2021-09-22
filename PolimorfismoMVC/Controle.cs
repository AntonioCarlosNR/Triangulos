using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangulos.PolimorfismoMVC.Model;

namespace Triangulos.PolimorfismoMVC
{
    public class Controle : AbsPropriedades
    {
        private AbsPropriedades LadosConverter;

        public Controle(string lado1, string lado2, string lado3) : base(lado1, lado2, lado3) { }

        public override void Executar()
        {
            LadosConverter = new Validacao(this.lado1, this.lado2, this.lado3);

            if (LadosConverter.Resposta == "valido")
            {
                this.Lado1 = LadosConverter.Lado1;
                this.Lado2 = LadosConverter.Lado2;
                this.Lado3 = LadosConverter.Lado3;

                LadosConverter = new Triangulo(this.Lado1, this.Lado2, this.Lado3);
            }
            this.Resposta = LadosConverter.Resposta;
        }
    }
}
