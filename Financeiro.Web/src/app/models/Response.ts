export interface Response<T>{
    dadosRetorno: T,
    mensagem: string,
    sucesso: boolean
}