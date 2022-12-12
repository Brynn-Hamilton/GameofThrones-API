namespace Assessment9.Models
{
    public class DAL
    {
        public async static Task<Book> FindBook(int id)
        {
            HttpClient client = new HttpClient();
            var bookRequest = await client.GetAsync($"https://anapioficeandfire.com/api/books/{id}");
            Book response = await bookRequest.Content.ReadAsAsync<Book>();

            return response;
        }
        public async static Task<House> FindHouse(int id)
        {
            HttpClient client = new HttpClient();
            var houseRequest = await client.GetAsync($"https://anapioficeandfire.com/api/houses/{id}");
            House response = await houseRequest.Content.ReadAsAsync<House>();

            return response;
        }
        public async static Task<Character> FindCharacter(string url)
        {
            HttpClient client = new HttpClient();
            var charRequest = await client.GetAsync(url);
            Character response = await charRequest.Content.ReadAsAsync<Character>();

            return response;
        }
        // if needed
        public async static Task<Character> GetSpecificCharacter(int id)
        {
            HttpClient client = new HttpClient();
            var charRequest = await client.GetAsync($"https://anapioficeandfire.com/api/characters/{id}");
            Character response = await charRequest.Content.ReadAsAsync<Character>();

            return response;
        }

    }
}
