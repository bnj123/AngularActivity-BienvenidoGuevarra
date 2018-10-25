﻿using ShippingPro.EFCore.Domain;
using ShippingPro.EFCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingPro.EFCore.Domain
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        OrderDetail GetOrderDetailsWithForeignKey(Guid id);
    }
}
