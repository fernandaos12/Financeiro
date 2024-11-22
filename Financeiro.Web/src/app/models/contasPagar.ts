export interface ContasPagar {
  id: number;
  descricao: string;
  status_Conta: number;
  data_Vencimento: string;
  valor: string;
  categoria: string;
  repeticao: boolean;
  periodicidade: number;
  valorParcela: number;
  numeroParcelas: number;
  observacoes: string;
  anexos: string;
}
