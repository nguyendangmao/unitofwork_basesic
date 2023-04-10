using AutoMapper;
using UnitOfWork_PhamTruong.Automap;
using UnitOfWork_PhamTruong.DTOs.ProductDto;
using UnitOfWork_PhamTruong.Entities;
using UnitOfWork_PhamTruong.Repository;

namespace UnitOfWork_PhamTruong.Service
{
    public class ProductService : IProductService
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> CreateProduct(productDto productDetails)
        {
            var product = _mapper.Map<Product>(productDetails);
            if (product != null)
            {
                await _unitOfWork.Products.Add(product);

                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            if (productId > 0)
            {
                var productDetails = await _unitOfWork.Products.GetById(productId);
                if (productDetails != null)
                {
                    _unitOfWork.Products.Delete(productDetails);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<productDto>> GetAllProducts()
        {
            var productDetailsList = await _unitOfWork.Products.GetAll();
            var abc = _mapper.Map<IEnumerable<productDto>>(productDetailsList);
            return abc; 
        }

        public async Task<productDto> GetProductById(int productId)
        {
            if (productId > 0)
            {
                var productDetails = await _unitOfWork.Products.GetById(productId);
                if (productDetails != null)
                {
                    var productDto = _mapper.Map<productDto>(productDetails);
                    return productDto;
                }
            }
            return null!;
        }

        public async Task<bool> UpdateProduct(productDto product)
        {
         
            if (product != null)
            {
                var productupdate = await _unitOfWork.Products.GetById(product.IdProduct);
                if (productupdate != null)
                {
                    productupdate.Id = product.IdProduct;
                    productupdate.Name = product.NameProduct;
                    productupdate.Price = product.PriceProduct;
             
                    _unitOfWork.Products.Update(productupdate);

                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
    }
}
