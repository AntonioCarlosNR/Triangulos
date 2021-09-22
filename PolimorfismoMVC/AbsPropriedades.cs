using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.PolimorfismoMVC
{
    public abstract class AbsPropriedades
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public string lado1 { get; set; }
        public string lado2 { get; set; }
        public string lado3 { get; set; }
        public string Resposta { get; set; }

        public string Resultado { get; set; }

        public AbsPropriedades (double Lado1, double Lado2, double Lado3)
        {
            this.Lado1 = Lado1;
            this.Lado2 = Lado2;
            this.Lado3 = Lado3;
            this.Executar();
        }
        public AbsPropriedades(string Lado1, string Lado2, string Lado3)
        {
            this.lado1 = Lado1;
            this.lado2 = Lado2;
            this.lado3 = Lado3;
            this.Executar();
        }
        public virtual void Executar() { }
    }
}
