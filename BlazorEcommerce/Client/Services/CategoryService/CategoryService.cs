namespace BlazorEcommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }
        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task GetCategories()
        {
            var res = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
            if (res != null && res.Data != null)
                Categories = res.Data;
        }
    }
}
