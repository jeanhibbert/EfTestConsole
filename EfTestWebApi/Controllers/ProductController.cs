namespace EfTestWebApi.Controllers
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Http;
    using System.Web.Http.Description;

    using EfTest.AdventureWorks.Data;
    using EfTest.AdventureWorks.Model.Models;
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework.Repositories;

    public class ProductController : ApiController
    {
        #region Fields

        private readonly IProductRepository _productRepository;
        private readonly ProductRepository _repository;

        #endregion

        #region Constructors and Destructors

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _repository = _productRepository as ProductRepository;
            _repository.DbContextConfiguration.ProxyCreationEnabled = false;
        }

        #endregion

        #region Public Methods and Operators

        [ResponseType(typeof(Product))]
        public async Task<IHttpActionResult> DeleteProduct(int id)
        {
            Product product = await _productRepository.GetAsync(id);
            if (product == null)
            {
                return this.NotFound();
            }

            await _productRepository.DeleteAsync(product);
            return this.Ok(product);
        }

        // GET api/Product/Search?=bottom
        public async Task<List<Product>> Search(string term)
        {
            const string sql = "SELECT * FROM Production.Product WHERE CONTAINS((Name), @p0)";

            var products = await _repository.GetDbSet().SqlQuery(sql, term).ToListAsync();
            
            return products;
        }

        // GET api/Product/5
        [ResponseType(typeof(Product))]
        public async Task<IHttpActionResult> GetProduct(int id)
        {
            Product product = await _productRepository.GetAsync(id);
            if (product == null)
            {
                return this.NotFound();
            }

            return this.Ok(product);
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _productRepository.GetAllAsync();
        }

        // PUT api/Product/5

        // POST api/Product
        [ResponseType(typeof(Product))]
        public async Task<IHttpActionResult> PostProduct(Product product)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            await _productRepository.AddAsync(product);

            return CreatedAtRoute("DefaultApi", new { id = product.ProductID }, product);
        }

        public async Task<IHttpActionResult> PutProduct(int id, Product product)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (id != product.ProductID)
            {
                return this.BadRequest();
            }

            try
            {
                await _productRepository.UpdateAsync(product, id);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.ProductExists(id))
                {
                    return this.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return this.StatusCode(HttpStatusCode.NoContent);
        }

        #endregion

        // DELETE api/Product/5

        #region Methods

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _productRepository.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(int id)
        {
            return _productRepository.FindAll(e => e.ProductID == id).Count > 0;
        }

        #endregion
    }
}