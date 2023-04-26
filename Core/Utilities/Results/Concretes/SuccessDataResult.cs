namespace Core.Utilities.Results.Concretes
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {
        }
        public SuccessDataResult(T data) : base(data, true)
        {
        }
    }
}
