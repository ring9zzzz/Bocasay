using Bocasay.Model;

namespace Bocasay.BAL
{
    public interface IHandler
    {
        TResponse Execute<TRequest, TResponse>(TRequest request) where TRequest : BaseRequest where TResponse : BaseResponse;
    }
}
