using BLL.Entity;
using BLL.Interfaces.Repository;
using BLL.Interfaces.Services;

namespace BLL.Services
{
    public class ProductServices : IProductServices
    {
        IProductRepository _productRepository;
        IKeyParamsRepository _keyParams;
        public ProductServices(IProductRepository userRepository, IKeyParamsRepository keyParams)
        {
            _productRepository = userRepository;
            _keyParams = keyParams;
        }
        public async Task<bool> CreateProduct(Product entity)
        {
            return await _productRepository.Create(entity);
        }

        public async Task<bool> DeleteProduct(Product entity)
        {
            return await _productRepository.Delete(entity);
        }

        public async Task<Product> GetProductById(Guid id)
        {
            return await _productRepository.GetById(id);
        }

        public async Task<IEnumerable<Product>> AllProducts()
        {
            return await _productRepository.Select();
        }

        public async Task<Product> UpdateProduct(Product entity)
        {
            return await _productRepository.Update(entity);
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAndPrice(string category, double max, double min)
        {
            var products = await _productRepository.Select();
            return products.Where(p => p.Category.Name == category && p.Price >= min && p.Price <= max).ToList();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAndKeyWordsWithPrice(string category, string[] keywords, double max, double min)
        {
            var products = await _productRepository.Select();
            return products
                .Where(p => p.Category.Name == category && p.Price >= min && p.Price <= max && p.KeyParams.Any(kw => keywords.Any(g => g == kw.KeyWord.KeyWord)));
        }

        public async Task<Product> GetProductByName(string name)
        {
            var products = await _productRepository.Select();
            return products.FirstOrDefault(p => p.Name == name);
        }

        public async Task<IEnumerable<Product>> ProductsByWord(string word)
        {
            return await _productRepository.GetByIdIncludWord(word);
        }
    }
}
