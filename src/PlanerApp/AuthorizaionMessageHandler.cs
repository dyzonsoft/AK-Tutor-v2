using Blazored.LocalStorage;

public class AuthorizaionMessageHandler : DelegatingHandler
{
    private readonly ILocalStorageService _storage;

    public AuthorizaionMessageHandler(ILocalStorageService storage)
    {
        _storage = storage;
    }

    protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (await _storage.ContainKeyAsync("access_token"))
        {
            var token = await _storage.GetItemAsStringAsync("access_token");
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }
        Console.WriteLine("Handler called");
        return await base.SendAsync(request, cancellationToken);
    }

}
