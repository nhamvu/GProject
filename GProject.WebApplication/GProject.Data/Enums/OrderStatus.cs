using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject.Data.Enums
{
    public enum OrderStatus
    {
        [Description("Đang xử lí")]
        InProgress = 0,

        [Description("Đã bàn giao")]
        Confirmed = 1,

        [Description("Đang giao hàng")]
        Delivery = 2,

        [Description("Đã hoàn thành")]
        Accomplished = 3,

        [Description("Đã thanh toán")]
        Paided = 4,

        [Description("Đã hủy")]
        Canceled = 5
    }
}
