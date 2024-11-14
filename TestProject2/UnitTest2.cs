using blood_donations.Controllers;
using blood_donations.Entities;
using blood_donations.Servies;
using blood_donations.Subjects;
using Microsoft.AspNetCore.Mvc;

namespace TestProject2
{
    public class UnitTest2
    {

       

        [Fact]
        public void GetByid_istype()
        {
            var id = 1;
            var controller=new DonorsController(new blood_donations.Servies.DonorService(new FakeContext()));
            var result = controller.Get(id);

            Assert.IsType<OkObjectResult>(result.Result);
        }
        [Fact]
        public void GetByid_notfound()
        {
            var id = 9;
            var controller = new DonorsController(new blood_donations.Servies.DonorService(new FakeContext()));
            var result = controller.Get(id);

            Assert.IsType<NotFoundResult>(result.Result);
        }
        [Fact]
        public void Get_istype()
        {
            //Act
            var controller = new DonorsController(new DonorService(new FakeContext()));
            var result = controller.Get();

            //Assert
            Assert.IsNotType<UnauthorizedObjectResult>(result);
        }

        [Fact]
        public void Post_isOk()
        {
              var e = new Donor() { FirstNameDonor = "avi", LastNameDonor = "levi" };

            var controller = new DonorsController(new DonorService(new FakeContext()));
            var result = controller.Post(e);

            //Assert
            Assert.IsNotType<UnauthorizedObjectResult>(result);
        }
        //[Fact]
        //public void Put_isOk()
        //{
        //    var id = 1;
        //    var e = new Employee() { FirstNameEmployee = "avi", LastNameEmployee = "levi" };

        //    var result = controller.Put(id, e);
        //    Assert.IsType<OkResult>(result.Result);

        //}
        //[Fact]
        //public void put_notfound()
        //{
        //    var id = 9;
        //    var e = new Employee() { FirstNameEmployee = "avi", LastNameEmployee = "levi" };

        //    var result = controller.Put(id,e);

        //    Assert.IsType<BadRequestResult>(result.Result);
        //}
        [Fact]
        public void Delete_is()
        {
            var id = 1;
            var controller = new DonorsController(new DonorService(new FakeContext()));
            var result = controller.Delete(id);

            //Assert
            Assert.IsNotType<UnauthorizedObjectResult>(result);
        }
        [Fact]
        //public void delete_notfound()
        //{
        //    var id = 9;
        //    var controller = new DonorsController(new blood_donations.Servies.DonorService(new FakeContext()));

        //    var result = controller.Delete(id);

        //    Assert.IsType<BadRequestResult>(result.Result);
        //}
    }
}