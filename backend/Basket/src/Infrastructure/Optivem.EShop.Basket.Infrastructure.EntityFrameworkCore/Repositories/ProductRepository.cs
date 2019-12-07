﻿using Microsoft.EntityFrameworkCore;
using Optivem.Framework.Core.Domain;
using Optivem.EShop.Basket.Core.Domain.Products;
using Optivem.EShop.Basket.Infrastructure.EntityFrameworkCore.Records;
using System.Threading.Tasks;

namespace Optivem.EShop.Basket.Infrastructure.EntityFrameworkCore.Repositories
{
    public class ProductRepository : ProductReadRepository, IProductRepository
    {
        public ProductRepository(DatabaseContext context) : base(context)
        {
        }

        public void Add(Product product)
        {
            var productRecord = GetProductRecord(product);
            Context.Products.Add(productRecord);
        }

        public async Task UpdateAsync(Product product)
        {
            var productRecordId = product.Id.Id;
            var productRecord = await Context.Products.FindAsync(productRecordId);

            UpdateProductRecord(productRecord, product);

            try
            {
                Context.Products.Update(productRecord);
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new ConcurrentUpdateException(ex.Message, ex);
            }
        }

        #region Helper

        private ProductRecord GetProductRecord(Product product)
        {
            var id = product.Id.Id;
            var productCode = product.ProductCode;
            var productName = product.ProductName;
            var listPrice = product.ListPrice;
            var isListed = product.IsListed;

            return new ProductRecord
            {
                Id = id,
                ProductCode = productCode,
                ProductName = productName,
                ListPrice = listPrice,
                IsListed = isListed,
            };
        }

        private ProductRecord GetProductRecord(ProductIdentity productId)
        {
            return new ProductRecord
            {
                Id = productId.Id,
            };
        }

        private void UpdateProductRecord(ProductRecord productRecord, Product product)
        {
            var id = product.Id.Id;
            var productCode = product.ProductCode;
            var productName = product.ProductName;
            var listPrice = product.ListPrice;
            var isListed = product.IsListed;

            productRecord.Id = id;
            productRecord.ProductCode = productCode;
            productRecord.ProductName = productName;
            productRecord.ListPrice = listPrice;
            productRecord.IsListed = isListed;
        }

        #endregion
    }
}