using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace CompanyBlazorApp.Helpers
{
    public class ConsoleHelper
    {
        private readonly IJSRuntime _js;

        public ConsoleHelper(IJSRuntime js)
        {
            _js = js;
        }

        public async Task Log(string message)
        {
            await _js.InvokeVoidAsync("console.log", message);
        }

        public async Task Warn(string message)
        {
            await _js.InvokeVoidAsync("console.warn", message);
        }

        public async Task Error(string message)
        {
            await _js.InvokeVoidAsync("console.error", message);
        }
    }
}
