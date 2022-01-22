namespace Bocasay.Model
{
    public class BaseResponse
    {
        public BaseResponse(object content,string message = "") 
        {
            this.Content = content;
            this.Message = message;
        }

        public BaseResponse(string message = "")
        {
            this.Message = message;
        }

        public object Content { get; set; }

        public string Message { get; set; }
    }
}
