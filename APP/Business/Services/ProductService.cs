using APP.Business.Models;
using APP.DataAccess;
using CORE.Models;
using CORE.Repositories;
using CORE.Services;

namespace APP.Business.Services
{
    public class ProductService : Service<Product, ProductRequest, ProductResponse>
    {
        public ProductService(RepoBase<Product> repo) : base(repo)
        {
        }
        public override Result<List<ProductResponse>> GetList()
        {
            List<ProductResponse> list = null;
            try
            {
                list = _repo.Query().OrderBy(productEntity => productEntity.Name).Select(productEntity => new ProductResponse()
                {
                    CreatedBy = productEntity.CreatedBy,
                    Description = productEntity.Description,
                    Guid = productEntity.Guid,
                    Id = productEntity.Id,
                    Name = productEntity.Name,
                    UnitPrice = productEntity.UnitPrice,
                    UpdatedBy = productEntity.UpdatedBy
                }).ToList();
                if (list.Count > 0) // if (list.Any())
                    return Success(list, list.Count + " record(s) found.");
                return Error(list, "No records found.");
            }
            catch (Exception exc) // exc.Message loglama için kullanılır
            {
                return Error(list, "An exception occurred during the operation!");
            }
        }
        public override Result<ProductResponse> GetItem(int id)
        {
            ProductResponse item = null;
            var entity = _repo.Query().SingleOrDefault(productEntity => productEntity.Id == id);
            if (entity is null)
                return Error(item, "Product not found!");
            item = new ProductResponse()
            {
                CreatedBy = entity.CreatedBy,
                Description = entity.Description,
                Guid = entity.Guid,
                Id = entity.Id,
                Name = entity.Name,
                UnitPrice = entity.UnitPrice,
                UpdatedBy = entity.UpdatedBy
            };
            return Success(item);
        }

        public override Result Create(ProductRequest request)
        {
            if (_repo.Query().Any(productEntity => productEntity.Name.ToUpper() == request.Name.ToUpper().Trim()))
                return Error("Product with the same name exists!");
            var entity = new Product()
            {
                Description = request.Description?.Trim(),
                Name = request.Name?.Trim()
            };
            _repo.Create(entity);
            return Success("Product created successfully.", entity.Id);
        }

        public override Result Update(ProductRequest request)
        {
            if (_repo.Query().Any(c => c.Id != request.Id && c.Name.ToUpper() == request.Name.ToUpper().Trim()))
                return Error("Product with the same name exists!");
            var entity = _repo.Query().SingleOrDefault(c => c.Id == request.Id);
            if (entity is null)
                return Error("Product not found!");
            entity.Name = request.Name?.Trim();
            entity.Description = request.Description?.Trim();
            _repo.Update(entity);
            return Success("Product updated successfully.");
        }

        public override Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Result<ProductRequest> GetItemForEdit(int id)
        {
            throw new NotImplementedException();
        }
    }
}
