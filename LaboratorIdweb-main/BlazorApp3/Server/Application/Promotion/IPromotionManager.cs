using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp3.Server.Application.Promotion
{
    public interface IPromotionManager
    {
        decimal GetDefaultAmount(string currency);
    }
}
