using KenkataWebshop.Data;
using KenkataWebshop.WebClient.Controllers;
using KenkataWebshop.WebClient.Models;
using KenkataWebshop.WebClient.Models.Fixtures;
using KenkataWebshop.WebClient.Models.Mapping;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KenKataWebshop.UnitTests
{
    public class CategoryMvcTestShould
    {
       
        [Fact]
        public void Generate_View_with_ViewModel()
        {
            //Arr
            var sut = new CategoryController();
            var categoryViewModel = new CategoryViewModel();

            //Act
            var result = sut.View(categoryViewModel);

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Mapp_CategoryDto_to_CategoryViewModel()
        {
            //Arr
            var name = "Category 1";
            var dto = new CategoryDto
            {
                Category = name
            };

            //Act
            var viewModel = dto.MapToViewModel();

            //Assert
            Assert.Equal(name, viewModel.Category);

        }

        [Fact]
        public async void List_all_categories()
        {
            //Arr
            var categories = new CategoryFixtures();

            //Act
            var categoryViewModels = categories.GetAll();
            

            //Assert
            Assert.NotNull(categoryViewModels);
            Assert.Equal(6, categoryViewModels.Count);
         
        }
    }
}
