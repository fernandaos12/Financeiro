using System.Diagnostics.CodeAnalysis;

namespace Financeiro.Domain.Abstractions
{
    public class Result
    {
        protected Result(bool isSucess, Error error)
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
        public static Result Success() => new(true, Error.None);
        public static Result Failure(Error error) => new(false, error);
        public static Result<T> Success<T>(T value) => new(value, true, Error.None);
        public static Result<T> Failure<T>(Error error) => new(default, false, error);
        public static Result<T> Create<T>(T? value) => value is not null ? Success(value) : Failure<T>(Error.NullValue);
    }

    public class Result<T> : Result
    {
        private readonly T? _value;
        protected internal Result(T? value, bool isSucess, Error error) : base(isSucess, error)
            => _value = value;

        [NotNull]
        public T Value => _value ?? throw new InvalidOperationException("Resultado não tem valor ");
        public static implicit operator Result<T>(T? value) => Create(value);

    }
}
