﻿using System.Collections.Generic;
using DAL.Core.ModelDTO;

namespace BLL.Core.BLL_Core.Interface
{
    public interface IOrderBLL
    {       
        int SavePreOrder(OrderDto data);
        void Order(PaidOrderDTO data);
    }
}