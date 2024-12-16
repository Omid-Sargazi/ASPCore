using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Features.Products.Commands;
using AutoMapper;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using MediatR;

namespace Application.Features.Products.Handlers
{
    public class CreateProductCommandHandler:IRequestHandler<CreateProductCommand,ProductDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(request.CategoryId);
            if(category==null)
            {
                throw new EntityNotFoundException(nameof(Category), request.CategoryId);
            }

            var product = new Product
        {
            Name = request.Name,
            Price = request.Price,
            CategoryId = request.CategoryId
        };

        await _unitOfWork.Products.AddAsync(product);
        await _unitOfWork.SaveChangesAsync();
        return _mapper.Map<ProductDto>(product);
        }
    }
}