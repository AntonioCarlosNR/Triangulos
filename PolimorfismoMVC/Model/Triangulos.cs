using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.PolimorfismoMVC.Model
{
    public class Triangulos : AbsPropriedades
    {
        public Triangulos(double Lado1, double Lado2, double Lado3): base(Lado1, Lado2, Lado3) { }

        public override void Executar()
        {
            double soma12 = this.Lado1 + this.Lado2;
            double soma13 = this.Lado1 + this.Lado3;
            double soma23 = this.Lado2 + this.Lado3;
            if(soma12 > this.Lado3 && soma13 > this.Lado2 && soma23 > this.Lado1)
            {
                if(Lado1 == Lado2 && Lado2 == Lado3 && Lado1 == Lado3)
                {
                    this.Resposta = "Equilátero";
                }
                else if (Lado1 != Lado2 && Lado2 != Lado3 && Lado1 != Lado3)
                {
                    this.Resposta = "Escaleno";
                }
                else
                {
                    this.Resposta = "Isósceles";
                }
            }

        }
    }
}
