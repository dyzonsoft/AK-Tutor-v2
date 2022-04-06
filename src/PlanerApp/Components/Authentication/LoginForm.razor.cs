using Microsoft.AspNetCore.Components;
using PlanerApp.Shared.Models;

namespace PlanerApp.Components
{
    public partial class LoginForm : ComponentBase
    {
        [Inject]
        public HttpClient HttpClient { get; set; }

        private LoginRequest _model = new LoginRequest();

        private async Task LoginUserAsync()
        {
            throw new NotImplementedException();
        }
    }
}
