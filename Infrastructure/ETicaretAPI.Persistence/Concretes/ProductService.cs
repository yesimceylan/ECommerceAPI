using ETicaretAPI.Application.Abstactions;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService

    {
        public List<Product> GetProducts()
           => new()
           {
               new() {Id=Guid.NewGuid(), Name ="Product1" , Price=190 , Stock=10 },
               new() {Id=Guid.NewGuid(), Name ="Product2" , Price=200 , Stock=10 },
               new() {Id=Guid.NewGuid(), Name ="Product3" , Price=390, Stock=10 },
               new() {Id=Guid.NewGuid(), Name ="Product4" , Price=490 , Stock=10 },
               new() {Id=Guid.NewGuid(), Name ="Product5" , Price=569 , Stock=10 },
           };
} }
