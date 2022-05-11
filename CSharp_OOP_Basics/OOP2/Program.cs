using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Exercício 02
            Crie uma classe denominada Elevador para armazenar as informações de um elevador dentro de um prédio. A 
            classe deve armazenar o andar atual (0=térreo), total de andares no prédio, excluindo o térreo, capacidade do 
            elevador (em pessoas), e quantas pessoas estão presentes nele.
            A classe deve também disponibilizar os seguintes métodos: 
            Inicializa: que deve receber como parâmetros: a capacidade do elevador e o total de andares no prédio 
            Entra: para acrescentar uma pessoa no elevador 
            Sai: para remover uma pessoa do elevador 
            Sobe: para subir um andar desce: para descer um andar
            */

            Elevador elevador1 = new Elevador();

            elevador1.Andar = 0; //Térreo é o andar zero
            elevador1.CapacidadeEmUtilizacao = 0;
            elevador1.AndarTotal = 20;
            elevador1.CapacidadeTotal = 10;

            elevador1.Inicializa(elevador1.CapacidadeTotal, elevador1.AndarTotal);
            elevador1.Sobe();
            elevador1.Sobe();
            elevador1.Sobe();
            elevador1.Sobe();
            elevador1.Sobe();
            elevador1.Entra();
            elevador1.Entra();
            elevador1.Entra();

            Console.WriteLine("Elevador está no " + elevador1.Andar +"º andar.");
            Console.WriteLine("Elevador está lotado com " + elevador1.CapacidadeEmUtilizacao + " usuários.");
            Console.ReadLine();
        }
    }
}
