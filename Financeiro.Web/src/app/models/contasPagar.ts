export interface ContasPagar {
  length: any;
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
  anexos: [];
  dataAlteracao: string;
  caminhoAnexos: string;
}

export enum TipoRepeticao {
  UNICO,
  PARCELADO,
  FIXO,
}
