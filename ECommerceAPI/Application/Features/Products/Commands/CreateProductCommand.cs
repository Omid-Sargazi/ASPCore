using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using MediatR;

namespace Application.Features.Products.Commands
{
    public record CreateProductCommand(string Name, decimal Price, int CategoryId):IRequest<ProductDto>;
}