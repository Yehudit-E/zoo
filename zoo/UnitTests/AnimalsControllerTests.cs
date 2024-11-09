using Microsoft.AspNetCore.Mvc;
using zoo.Controllers;
using zoo.Entities;

namespace UnitTests
{
    public class AnimalsControllerTests
    {
        [Fact]
        public void Get_ListAnimals()
        {
            var controller = new AnimalsController();
            var result = controller.Get();
            Assert.IsType<ActionResult<IEnumerable<Animal>>>(result);
            //לא עובד      
        }
        [Fact]
        public void Get_Animal()
        {
            var id = 1;
            var obj = new Animal();
            var controller = new AnimalsController();
            controller.Post(obj);
            var result = controller.Get(id);
            Assert.IsType<ActionResult<Animal>>(result);
        }
        [Fact]
        public void Post_AddToList()
        {
            var obj = new Animal();
            var controller = new AnimalsController();
            var result = controller.Post(obj);
            Assert.True(result.Value);
        }
        
        [Fact]////לא עובד
        public void GetByIdNotFound()
        {
            var id = 5;
            var controller = new AnimalsController();
            var result = controller.Get(id);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}