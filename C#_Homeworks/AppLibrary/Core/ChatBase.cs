using System.Text.Json;
using System.Threading;

namespace Core
{
    public abstract class ChartBase
    {
        protected CancellationTokenSource CancellationTokenSource { get; set; } = new CancellationTokenSource();
        protected CancellationToken CancellationToken => CancellationTokenSource.Token;

        public abstract Task Lissener();
        public abstract Task Start();
    }
}
