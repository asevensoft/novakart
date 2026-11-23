using NovaKart.Application.Dtos.Categories;
using NovaKart.Application.Dtos.ProductImage;

namespace NovaKart.Application.Dtos.Products;

public record ProductDto(
    Guid Id,
    string Name,
    string Description,
    decimal Price,
    int Stock,
    bool IsActive,
    ProductCategoryDto Category,
    ProductImageDto ProductImage);

public record GetProductsResponse(
    List<ProductDto> Products,
    int TotalCount,
    int PageNumber,
    int PageSize);