using System.Text.Json;

namespace Infrastructure.Gateway.Clients
{
    public abstract class BaseClient
	{
        private static readonly JsonSerializerOptions _jsonSerializerOptions = new() { PropertyNameCaseInsensitive = true, IgnoreNullValues = true };

        public static async Task<TResponse> GetAsync<TResponse>(string endpoint, string authKey)
		{
            var client = GetClient(authKey);

            try
            {
                var response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    if (content is not null)
                    {
                        return JsonSerializer.Deserialize<TResponse>(content, _jsonSerializerOptions);
                    }
                }

                throw new Exception($"Request failed with status code {response.StatusCode}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<TResponse> PostAsync<TRequest, TResponse>(string endpoint, string authKey, TRequest data)
        {
            try
            {
                var client = GetClient(authKey);

                var request = JsonSerializer.Serialize(data, _jsonSerializerOptions);

                var contentRequest = new StringContent(request);

                var response = await client.PostAsync(endpoint, contentRequest);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    if (content is not null)
                    {
                        return JsonSerializer.Deserialize<TResponse>(content, _jsonSerializerOptions);
                    }
                }

                throw new Exception($"HTTP request failed with status code {response.StatusCode}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static HttpClient GetClient(string authKey)
        {
            var client = new HttpClient();

            client
                .DefaultRequestHeaders
                .Add("Authorization", $"Token token={authKey}");

            return client;
        }
    }
}

