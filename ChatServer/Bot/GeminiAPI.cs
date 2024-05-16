using System.Net.Http.Headers;
using System.Text;

namespace ChatServer.Bot {
    internal static class GeminiAPI {
        // make it callable in the chatapp
        public static async Task<string> SendRequestAndGetResponse(string userInput) {
            string jsonBody = $@"{{
                ""contents"": [
                    {{
                        ""role"": """",
                        ""parts"": [
                            {{
                                ""text"": ""{userInput}""
                            }}
                        ]
                    }}
                ],
                ""generationConfig"": {{
                    ""temperature"": 0.9,
                    ""topK"": 50,
                    ""topP"": 0.95,
                    ""maxOutputTokens"": 4096,
                    ""stopSequences"": []
                }},
                ""safetySettings"": []
            }}";

            using (var client = new HttpClient()) {
                var request = new HttpRequestMessage(HttpMethod.Post, $"https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-pro-latest:generateContent?key=AIzaSyA4_FnJD9hPi4e7hh-cV6XEHXbyHUezycE");
                request.Content = new StringContent(jsonBody, Encoding.UTF8);
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await client.SendAsync(request).ConfigureAwait(false);

                if (response.IsSuccessStatusCode) {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    string aiResponse = ExtractAiResponse(responseBody);
                    string cleansedOutput = CleanseOutput(aiResponse);
                    return cleansedOutput;
                } else {
                    return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }
            }
        }
        private static string CleanseOutput(string output) {
            output = output.Replace("\\n", " ");
            output = output.Replace("\\n*", "");
            output = output.Replace("\\n\\n", "");
            output = output.Replace("##", "");
            output = output.Replace("??", "");

            return output;
        }

        private static string ExtractAiResponse(string responseBody) {

            var startIndex = responseBody.IndexOf("\"text\": \"") + 9;
            var endIndex = responseBody.IndexOf("\"", startIndex);
            return responseBody.Substring(startIndex, endIndex - startIndex);
        }
    }
}