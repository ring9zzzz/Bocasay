namespace Bocasay.Model.BocasayForm
{
    using Newtonsoft.Json;
    public class TestingForm
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }
}
