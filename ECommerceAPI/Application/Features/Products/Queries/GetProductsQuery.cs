using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using MediatR;

namespace Application.Features.Products.Queries
{
    public record GetProductsQuery:IRequest<IEnumerable<ProductDto>>;
}