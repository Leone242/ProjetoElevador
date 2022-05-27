using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    class Elevador
    {
        public int totalDeAndares = 5;

        public int andar = 0;

        public int capacidade = 0;

        public int capMaxima = 6;

        public bool continuar = true;


        public void ElevadorMenu()
        {
            do
            {
                MostrarMenu();
                string resposta = Console.ReadLine();
                Console.Clear();
                VerificaResposta(resposta);
            }
            while (continuar);
        }


        public void MostrarMenu()
        {
            Console.WriteLine(@"
                        |--------------------|
                        | Escolha uma opção: |
                        |--------------------|
                        | 1 - Inicializar    |
                        |--------------------|
                        | 2 - Entrar         |
                        |--------------------|
                        | 3 - Subir          |
                        |--------------------|
                        | 4 - Descer         |
                        |--------------------|
                        | 5 - Sair           |
                        |--------------------|
                        | 6 - Finalizar      |
                        |--------------------|");            
        }


        public void VerificaResposta(string resp)
        {
            if (resp == "1")
            {
                Inicializar();
            }
            else if (resp == "2")
            {
                Entrar();
            }
            else if (resp == "3")
            {
                Subir();
            }
            else if (resp == "4")
            {
                Descer();
            }
            else if (resp == "5")
            {
                Sair();
            }
            else if(resp == "6")
            {
                Console.WriteLine(@"
                        Saindo da aplicação...");
                continuar = false;
            }
            else
            {
                Console.WriteLine(@"
                        Opção inválida.");
            }
        }

        private void Inicializar()
        {
            Console.WriteLine(@"
                        Elevador inicializado.");
        }

        public void Entrar()
        {
            if(capacidade < capMaxima)
            {
                Console.WriteLine(@"
                        Você entrou no elevador.");
                capacidade++;
            }
            else
            {
                Console.WriteLine(@"
                        Elevador cheio. 
                        Não é possível entrar.");
            }
        }

        

        public void Subir()
        {
            if (andar < totalDeAndares)
            {
                Console.WriteLine(@"
                        Você subiu um andar.");
                andar++;
            }
            else
            {
                Console.WriteLine(@"
                        Último andar atingido. 
                        Não é possível subir mais.");
            }

        }

        public void Descer()
        {
            if (andar > 0)
            {
                Console.WriteLine(@"
                        Você desceu um andar.");
                andar--;
            }
            else
            {
                Console.WriteLine(@"
                        Você está no térreo. 
                        Não é possível descer mais.");
            }
        }

        public void Sair()
        {
            if (capacidade > 0)
            {
                Console.WriteLine(@"
                        Você saiu do elevador.");
                capacidade--;
            }
            else
            {
                Console.WriteLine(@"
                        O elevador está vazio.");
            }
        }
    }
}
