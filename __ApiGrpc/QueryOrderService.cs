using ApiGrpc.Protos;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGrpc
{
    public class QueryOrderService : ApiGrpc.Protos.QueryOrder.QueryOrderBase
    {
        public override async Task<GetOrderResponse> GetOrder(GetOrderRequest request, ServerCallContext context)
        {
            return new GetOrderResponse
            {
                Nome = "Uno"
            };
        }
    }
}
