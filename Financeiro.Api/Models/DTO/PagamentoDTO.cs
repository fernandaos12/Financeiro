﻿using Financeiro.Domain.Enums;

namespace Financeiro.Api.Models.DTO
{
    public class PagamentoDTO
    {
        public string? Descricao { get; set; }
        public MesCompetencia? MesCompetencia { get; set; }
        public FormaPagamentoEnum FormaPagamento { get; set; }
        public bool PagamentoParcial { get; set; } = false;
        public double ValorPagamentoParcial { get; set; } = 0;
        public double Valor { get; set; } = 0;
        public StatusConta StatusPagamento { get; set; }
        public double SaldoDevedor { get; set; } = 0;
        public ICollection<ContasPagarDTO> ContasPagar { get; set; } = new List<ContasPagarDTO>();
        public DateTime DataPagamento { get; set; }
        public object Observacao { get; internal set; }
        public object DataVencimento { get; internal set; }
    }
}
