using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace SignumAddressGenerator
{
    public interface IGetAccount
    {

        public string Account { get; }
        public string AccountRS { get; }

        public int ErrorCode { get;  }

        public string ErrorDescription { get; }


    }

    public class GetAccount : IGetAccount
    {

        #region API Properties

         [JsonPropertyName("account")]
        public string Account { get; set; }

        [JsonPropertyName("accountRS")]
        public string AccountRS { get; set; }

        #endregion


        #region Error Conditions
        [JsonPropertyName("errorCode")]
        public int ErrorCode { get; set; }

        [JsonPropertyName("errorDescription")]
        public string ErrorDescription { get; set; }
        #endregion




    }




}
