using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayCation.Hotel.Models.Models
{
    public class Transaction
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string TransactionDetails { get; set; }
        public string status { get; set; }
        public string PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
