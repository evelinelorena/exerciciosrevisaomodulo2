using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao1
{
    public abstract class Empresa
    {
        public string Nome {get;set;}
        public string CNPJ { get;set;}
        
        public void ImprimirInformacoesEmpresa()
        {
            Console.WriteLine($"O nome da empresa é: {Nome} e seu CNPJ: {CNPJ}");
        }

        public abstract void RealizarVenda();
    }
}
