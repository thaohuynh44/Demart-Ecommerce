using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Chờ xử lý")]
        Pending,

        [EnumMember(Value = "Thanh toán thành công")]
        PaymentReceived,

        [EnumMember(Value = "Thanh toán không thành công")]
        PaymentFailed
    }
}