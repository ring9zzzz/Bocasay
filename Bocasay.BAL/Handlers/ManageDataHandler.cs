using Bocasay.Model;
using Bocasay.Model.BocasayForm;
using Bocasay.Model.ManageData;
using Newtonsoft.Json;
using System.IO;

namespace Bocasay.BAL.Handlers
{
    public class ManageDataHandler : BaseHandler, IHandler
    {
        private readonly string LocationPath = @"D:\bocasay";
        public override BaseResponse InternalExecute<TRequest>(TRequest request)
        {
            var dataRequest = request as ManageDataRequest;

            var testingForm = JsonConvert.DeserializeObject<TestingForm>(dataRequest.Param.ToString());

            if (!Directory.Exists(LocationPath))
            {
                Directory.CreateDirectory(LocationPath);
            }

            var jsonOption = new JsonSerializerSettings();
            jsonOption.Formatting = Formatting.Indented;

            string jsondata = JsonConvert.SerializeObject(testingForm, jsonOption);
            // Write that JSON to txt file,  
            System.IO.File.WriteAllText($@"{LocationPath}\bocasay.txt", jsondata);

            return new BaseResponse(jsondata, $"data was stored at ${LocationPath}");
        }
    }
}
