export interface ContasPagar {
  id: number;
  descricao: string;
  status_Conta: number;
  data_Vencimento: string;
  valor: string;
  categoriaId: number;
  repeticao: number;
  periodicidade: number;
  valorParcela: number;
  numeroParcelas: number;
  observacoes: string;
  anexos: string;
  dataAlteracao: string;
}

export enum TipoRepeticao {
  UNICO,
  PARCELADO,
  FIXO,
}
