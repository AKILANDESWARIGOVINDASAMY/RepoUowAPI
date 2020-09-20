using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepoUowAPI.DAL;
using RepoUowAPI.Models;

namespace RepoUowAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitofwork unitofwork;
        public ProductController(IUnitofwork unitOfWork)
        {
            unitofwork = unitOfWork;
        }

        [Route("getproducts")]
        [HttpGet]

        public IEnumerable<Product> GetProducts()
        {
            return unitofwork.Products.GetAll();
        }

        [Route("getproducts/{Id}")]
        [HttpGet]
        public Product GetProduct(int Id)
        {
            return unitofwork.Products.Get(Id);
        }
        [Route("addproduct")]
        [HttpPost]
        public void  AddProduct(Product product)
        {
            unitofwork.Products.Add(product);
            unitofwork.complete();
        }

        [Route("deleteproduct/{Id}")]
        [HttpGet]
        public void DeleteProduct(int Id)
        {
           // unitofwork.Products.Get(Id);
            unitofwork.Products.Remove(Id);
            unitofwork.complete();
        }


        
    }
} 
