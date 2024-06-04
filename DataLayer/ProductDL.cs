﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductDL
    {
        private readonly DatabaseContext _context;

        public ProductDL()
        {
            _context = new DatabaseContext();
        }

        public List<ProductDTO> GetProducts()
        {
            {
                var products = _context.GetContext().Products.ToList();
                return Mapper.convertToList(products);
            }
        }
    }
}
