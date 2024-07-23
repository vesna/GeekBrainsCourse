using App.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Provider
{
    public record RecieveResult(IPEndPoint EndPoint, Messages? Message);
}
