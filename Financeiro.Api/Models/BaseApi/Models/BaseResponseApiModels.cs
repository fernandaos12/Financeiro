namespace Financeiro.Api.Models;

public class BaseResponseApiModels
{
    public class PostApiRetorno
    {
        private List<PostApiMensagem> _mensagens;

        public Boolean Ok { get; set; }

        public String Mensagem { get; set; }

        public List<PostApiMensagem> Mensagens
        {
            get
            {
                if (_mensagens == null)
                    _mensagens = new List<PostApiMensagem>();
                return _mensagens;
            }
            set
            {
                _mensagens = value;
            }
        }

        public String InnerException { get; set; }
    }

    public class PostApiRetorno<K> : PostApiRetorno
    {
        public K IdObjeto { get; set; }
    }
    public enum PostApiMensagemType
    {
        Erro = 0,
        Info = 1
    }
    public class PostApiMensagem
    {
        public String Mensagem { get; set; }
        public PostApiMensagemType Tipo { get; set; }
    }
    public class DeleteApiRetorno<K>
    {
        public Boolean Ok { get; set; }

        public String Mensagem { get; set; }

        public String InnerException { get; set; }

        public K IdObjeto { get; set; }

    }
    public class Response
    {
        public bool Result { get; set; }

        public string Message { get; set; }

        public string Exception { get; set; }

        public string Stacktrace { get; set; }
    }
    public class ResponseSucesso
    {
        public bool sucesso { get; set; }

        public string msg { get; set; }
    }
    public class Response<T> : Response
    {
        public T valor { get; set; }
    }
    public class MidiaMessenger
    {
        public string attachment_id { get; set; }
    }
    public class Links
    {
        public string content { get; set; }
        public string content_direct_temporary { get; set; }
    }
}
