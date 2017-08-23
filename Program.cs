using System;

namespace Lista21082017ex03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            decimal salarioAtual, percentualReajuste, salarioReajustado;
			Console.WriteLine("Digite o salário atual: ");
            salarioAtual = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine("Digite o porcentual de reajuste: ");
            percentualReajuste = Convert.ToDecimal(Console.ReadLine());
			percentualReajuste = (percentualReajuste / 100) + 1;
			salarioReajustado = salarioAtual * percentualReajuste;
            Console.Write("O valor do salário atualizado é {0}", salarioReajustado);
			Console.ReadLine();
        }
    }
}
