using Curso.Domain.Entities;
using Curso.Domain.Enuns;
using Primeiro.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Area ContaCorrente

            // criando as contas (instanciando as contas)
            AcoesController acao = new AcoesController();

            ContaInvestimento ccInvest = new ContaInvestimento
            {
                Chave = "xhyj-yut-123-pou",
                Saldo = 3000,
                TaxaAdm = 2
            };


            //  instanciando classe fazendo uso do construtor
            ContaCorrente ccCliente = new ContaCorrente
            {
                NumeroConta = "12345",
                NumeroAgencia = "43",
                Saldo = 100,
                Limite = 350
            };

            // simplesmente instanciando classes com construtor simples
            ContaCorrente conta = new ContaCorrente
            {
                NumeroConta = "56789",
                NumeroAgencia = "86",
                Saldo = 300,
                Limite = 200
            };

            acao.Saque(ref ccInvest, 300);

            // depoisto de 20 em uma conta
            acao.Deposito(ref conta, 20);

            try
            {
                // forçado erro de divisao por zero para demosntrar o try/catch
                var numero = 0;
                var divisao = 100 / numero;
            }
            catch (Exception ex)
            {
                // capturando o erro
                var erro = ex;

                // gerando uma excessao e parando o programa (remover comentarios abaixo)
                // throw new Exception("Ocorreu uma falha, chame o adm.");

                // apresentando a mensagem para o usuario
                Console.WriteLine("Ocorreu uma falha, chame o adm [0005].");

                // caso queira parar o programa apos o erro, remover os 
                // comentarios abaixo
                // return;
            }

            // depositei 500
            acao.Deposito(ref ccCliente, 500);

            // tentei sacar de novo
            var outracoisa = acao.Saque(ref ccCliente, 700);

            // passagem de parametro por referencia alterando a conta
            // que esta fora do metodo
            acao.Transferencia(200, ref conta, ref ccCliente);

            // metodo com parametro opcional codigo de barras
            // fornece se tiver.
            acao.Pagamento(ref conta, 50);

            // utilizando enuns
            acao.Pix(ref conta, 100, EnumTipoPix.Pagamento);

            // saldo atual
            var saldo = ccCliente.Saldo;

            // imprimindo n tela
            Console.WriteLine($"Saldo da conta:{ccCliente.NumeroConta} é {ccCliente.Saldo}");
            Console.WriteLine($"Saldo da conta:{conta.NumeroConta} é {conta.Saldo}");

            #endregion

            #region Area Listas Simples

            // declarando a lista
            var nomes = new List<string>
            {
                // adicionando itens na lista
                "Marcos",
                "Matheus",
                "Mary",
                "Jhonny"
            };

            // segue apenas se tivermos nomes na lista
            if (nomes.Count > 0)
            {
                // para cada item da colçao nomes faça ...
                foreach (var item in nomes)
                {
                    Console.WriteLine($"O nome é: {item}.");
                }

                Console.WriteLine($"Temos:{nomes.Count} nomes na lista");
            }
            else
            {
                Console.WriteLine("Nomes nao carregados.");
            }

            // buscando todos os nomes que contenham a letra m
            // usando tolower para q todos os nomes sejam convertidos 
            // para minuscula senao teriamos q fazer dois contains
            // um para o maiusculo e outro para o minusculo.
            var pesquisa = nomes.Where(x => x.ToLower().Contains("m"));

            // executa um looping uma vez para cada item da pesquisa
            foreach (var item in pesquisa)
            {
                Console.WriteLine($"O nome é: {item}.");
            }

            // se algo retornou da pesquisa, segue
            if (pesquisa != null && pesquisa.Count() > 0)
            {
                // imprimindo o primeiro item da lista e o ultimo
                Console.WriteLine($"O nome é: {pesquisa.FirstOrDefault()}.");
                Console.WriteLine($"O nome é: {pesquisa.LastOrDefault()}.");
            }

            #endregion

            #region Area de Listas complexas

            var bc = new List<Banco>();

            var bc1 = new Banco
            {
                CodBanco = 1,
                NomeBanco = "Banco do Brasil"
            };

            var bc2 = new Banco
            {
                CodBanco = 341,
                NomeBanco = "Itau"
            };

            var bc3 = new Banco
            {
                CodBanco = 237,
                NomeBanco = "Banco Bradesco"
            };

            bc.Add(bc1);
            bc.Add(bc2);
            bc.Add(bc3);

            var buscaItau = bc.Where(x => x.NomeBanco.ToLower().Contains("itau"));
            var buscaBB = bc.Where(x => x.CodBanco == 1);

            #endregion
        }
    }
}
