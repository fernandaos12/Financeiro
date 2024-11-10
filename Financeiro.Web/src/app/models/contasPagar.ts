export interface ContasPagar{   

        id: number;
        nome: string;
        descricao: string;
        data_Emissao: string;
        data_Vencimento: string;
        dataAlteracao:string;
        pagamento: number;
        valor: string;
        pagamentoParcial: boolean;
        valorPagamentoParcial: number;
        saldoDevedor: number;
        categoria: string;
        repeticao: boolean;
        qdadeRepeticao: number;
        observacoes: string;
        tags:string;
        status:number;
        status_Conta: number;
        corGrafico: string;
    
    }