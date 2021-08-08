using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SignumAddressGenerator
{
    #region Interface
    public interface IGetBlockchainStatus
    {
        public int Time { get; }

        public int LastBlockTimestamp { get; }


    }

    #endregion

    #region Class

    public class GetBlockchainStatus : IGetBlockchainStatus
    {
        

        #region API Properties



        [JsonPropertyName("time")]
        public int Time { get; set; }


        [JsonPropertyName("lastBlockTimestamp")]
        public int LastBlockTimestamp { get; set; }

        #endregion


        #region Error Conditions

        [JsonPropertyName("errorCode")]
        public int ErrorCode { get; set; }

        [JsonPropertyName("errorDescription")]
        public string ErrorDescription { get; set; }


        #endregion



    }

    #endregion

}
