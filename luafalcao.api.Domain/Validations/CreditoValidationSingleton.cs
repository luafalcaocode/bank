using luafalcao.api.Domain.Enums;
using luafalcao.api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Domain.Validations
{
    public class CreditoValidationSingleton
    {
        private static CreditoValidationSingleton _instance = new CreditoValidationSingleton();
        private IList<string> validacoes;

        private CreditoValidationSingleton()
        {

        }

        public static CreditoValidationSingleton GetInstance()
        {
            if (_instance == null)
            {
                return new CreditoValidationSingleton();
            }

            return _instance;
        }

        public IList<string> ValidarCredito(Credito credito)
        {
            this.validacoes = new List<string>();

            VerificarValor(credito.Valor);
            VerificarParcelas(credito.QuantidadeParcelas);

            if (VerificarSePessoaJuridica(credito.Tipo))
                VerificarCreditoPessoaJuridica(credito.Valor);

            VerificarDataPrimeiroVencimento(credito.DataPrimeiroVencimento);

            return this.validacoes;
        }

        private void VerificarValor(double valor)
        {
            if (valor > 1000000)
                validacoes.Add("O valor máximo a ser liberado para qualquer empréstimo é de R$ 1.000.000,00");
        }

        private void VerificarParcelas(int quantidadeParcelas)
        {
            if (quantidadeParcelas < 5 || quantidadeParcelas > 72)
                validacoes.Add("A quantidade mínima de parcelas é de 5x e a máxima é de 72x");
        }

        private bool VerificarSePessoaJuridica(TipoCreditoEnum tipo)
        {
            return (tipo == TipoCreditoEnum.PessoaJuridica);
        }

        private void VerificarCreditoPessoaJuridica(double valor)
        {
            if (valor < 15000)
                validacoes.Add("Para o crédito de pessoa jurídica, o valor mínimo a ser liberado é de R$ 15.000,00");
        }

        private void VerificarDataPrimeiroVencimento(DateTime dataPrimeiroVencimento)
        {
            var dataMinima = DateTime.Now.AddDays(15);
            var dataMaxima = DateTime.Now.AddDays(40);

            if (dataPrimeiroVencimento < dataMinima || dataPrimeiroVencimento > dataMaxima)
                validacoes.Add("A data do primeiro vencimento sempre será no mínimo 15 dias e no máximo 40 dias a partir da data atual.");
        }
    }
}
