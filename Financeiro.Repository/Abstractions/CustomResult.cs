using System.Diagnostics.CodeAnalysis;

namespace Financeiro.Domain.Abstractions
{
    public class CustomResult
    {
        protected CustomResult(bool isSucess, Error error)
        {
            switch (isSucess)
            {
                case true when error != Error.None:
                    throw new InvalidOperationException();

                case false when error == Error.None:
                    throw new InvalidOperationException();

                default:
                    IsSucess = isSucess;
                    Error = error;
                    break;
            }
        }


        public bool IsSucess { get; }
        public Error Error { get; }
        public bool IsFailure => !IsSucess;
        public static CustomResult Success() => new(true, Error.None);
        public static CustomResult Failure(Error error) => new(false, error);
        public static CustomResult<T> Success<T>(T value) => new(value, true, Error.None);
        public static CustomResult<T> Failure<T>(Error error) => new(default, false, error);
        public static CustomResult<T> Create<T>(T? value) => value is not null ? Success(value) : Failure<T>(Error.NullValue);
    }

    public class CustomResult<T> : CustomResult
    {
        private readonly T? _value;
        protected internal CustomResult(T? value, bool isSucess, Error error) : base(isSucess, error)
            => _value = value;

        [NotNull]
        public T Value => _value ?? throw new InvalidOperationException("Resultado não tem valor ");
        public static implicit operator CustomResult<T>(T? value) => Create(value);

    }
}
