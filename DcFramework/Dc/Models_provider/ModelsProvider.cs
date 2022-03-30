using SelfCheckHybrid.Models.Sip2;
using System;
using System.Collections.Generic;
using System.Text;

namespace datacenter.Models_provider
{
   public class ModelsProvider
    {
        public BookInformation bookInformation { get; set; }
        public CheckInInformation CheckInInformation  { get; set; }
        public CheckOutInformation CheckOutInformation { get; set; }
        public PatronInformation PatronInformation { get; set; }
        public RenewInformation RenewInformation { get; set; }
        public UserInformation UserInformation { get; set; }
    }
}
