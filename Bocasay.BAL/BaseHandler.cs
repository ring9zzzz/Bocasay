namespace Bocasay.BAL
{
    using Bocasay.Model;
    public abstract class BaseHandler
    {
        public virtual TResponse Execute<TRequest, TResponse>(TRequest request) where TRequest : BaseRequest where TResponse : BaseResponse
        {
            var result = InternalExecute(request);
            return (TResponse)result;
        }

        public abstract BaseResponse InternalExecute<TRequest>(TRequest request);
    }
}
