using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCap03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atividade cap 03 - Unidade 3 - ADS - FIAP - 1º Semestre

            Console.WriteLine("======== FIAP ATIVIDADE CAP 03 - UN. 03 - ADS 1º SEM ===========");
            Console.WriteLine("======== ESCOLHA UMA DAS OPÇÕES ABAIXO ============\n");
            Console.WriteLine("Opção [1] Exércicio 01");
            Console.WriteLine("Opção [2] Exércicio 02");
            Console.WriteLine("Opção [3] Exércicio 03");
            Console.WriteLine("Opção [4] Exércicio 04");
            Console.WriteLine("Opção [5] Exércicio 05");
            Console.WriteLine("Opção [6] Exércicio 06");
            Console.WriteLine("Opção [7] Exércicio 07");
            Console.WriteLine("Opção [8] Exércicio 08");

            Console.Write("Digite a opção desejada:");
            var opcao = Console.ReadLine();
            Opcoes(Convert.ToInt32(opcao));

        }
        

        static void exe01()
        {
            int peso, horas;

            Console.WriteLine("===========CALCULAR MET EM HORAS==========");
            Console.Write("Informe seu peso:");
            peso = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a quantidade de horas:");
            horas = Convert.ToInt32(Console.ReadLine());
            calMET(peso, horas);
            verificaTermino();
        }

        static void exe02()
        {
            int peso, minutos;
            Console.WriteLine("===========Calcular MET em MINUTOS==========");
            Console.Write("Informe seu peso:");
            peso = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a quantidade de minutos:");
            minutos = Convert.ToInt32(Console.ReadLine());
            calMET(peso,0,minutos);
            verificaTermino();
        }

        static void exe03()
        {
            Console.WriteLine("===========Resultado de Exame OSTEOPOROSE==========");
            Console.Write("Digite o resultado do exame:");
            var valor = Convert.ToDouble(Console.ReadLine());
            medeOsteoporose(valor);
            verificaTermino();
        }

        static void exe04()
        {
            Console.WriteLine("=======Conversão de CELCIUS para FAHRENHEIT======");
            Console.Write("Digite o valor em Celcius:");
            var valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado foi : {celciusToFahrenheit(valor)} °F");
            verificaTermino();
        }

        static void exe08()
        {
            Console.WriteLine("=======CAP 08======");
            Console.Write("Digite hora inicial:");
            var horaInicial = Convert.ToInt32(Console.ReadLine())*60;
            Console.Write("Digite os minutos iniciais:");
            var minutoInicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a hora final:");
            var horaFim = Convert.ToInt32(Console.ReadLine())*60;
            Console.Write("Digite os minuto finais:");
            var minutoFim = Convert.ToInt32(Console.ReadLine());

            var resultoInicial = horaInicial + minutoInicial;
            var resultadoFinal = horaFim + minutoFim;
            //Console.WriteLine("Teste :"+(resultadoFinal-resultoInicial));
            verificaHorario(resultadoFinal - resultoInicial);
            Console.ReadKey();
            //verificaTermino();
        }


        //Funções
        static void calMET(int peso, int horas = 0, int minutos = 0)
        {
            if (horas > 0 || minutos > 0)
            {
                if (horas > 0 && minutos == 0)
                    Console.WriteLine("Resultado do MET:"+ 10 * peso * horas);
                if (minutos > 0 && horas == 0)
                    Console.WriteLine("Resultado do MET:" + 10 * peso * minutos / 60);
            }
            else
            Console.WriteLine("Valores informados não são válidos.");
            
        }

        static string medeOsteoporose(double valor)
        {
            if (valor == 1.05)
                return "NORMAL";
            else if (valor >= 0.89 || valor <= 1.04)
                return "Baixa Massa Óssea";
            else if (valor >= 0.00 || valor <= 0.88)
                return "Osteoporose";
            else 
                return "Refazer Exame";
        }

        static double celciusToFahrenheit(double valor)
        {
            return (9 * valor + 160) / 5;
        }

        static void Opcoes(int opcao)
        {
    
            switch (opcao)
            {
                case 1:
                    exe01();
                    break;
                case 2:
                    exe02();
                    break;
                case 3:
                    exe03();
                    break;
                case 4:
                    exe04();
                    break;
                case 8:
                    exe08();
                    break;
            }
        }

        static void verificaTermino()
        {
            Console.Write("\n Deseja utilizar outra opção? S ou N");
            var resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                Console.Write("Digite a opção desejada:");
                var opcao = Console.ReadLine();
                Opcoes(Convert.ToInt32(opcao));
            }
            else
            {
                Console.Write("Pressione qualquer tecla para sair.");
                Console.ReadKey();
            }
        }

        static void verificaHorario(int valor)
        {
            Console.WriteLine("Resultado Teste"+valor);
            var x = valor - (valor % 60);
            if (valor >= 60)
            {
                Console.WriteLine($"Resultado foi: ({x/60}:{valor % 60})");
            }
            else
            {
                Console.WriteLine($"Resultado foi: ({x / 60}:{valor % 60})");
            }
        }

    }
}
