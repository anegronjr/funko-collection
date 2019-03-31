using FunkoCollection.Controllers;
using FunkoCollection.Models;
using FunkoCollection.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FunkoCollection.Tests
{
    public class FunkoControllerTests
    {
        FunkoController underTest;
        IFunkoRepository repo;

        public FunkoControllerTests()
        {
            repo = Substitute.For<IFunkoRepository>();
            underTest = new FunkoController(repo);
        }

        [Fact]
        public void Get_Returns_Single_Funko()
        {
            var expectedId = 1;
            repo.GetById(expectedId).Returns(new Funko() { FunkoId = expectedId });

            var result = underTest.Get(expectedId);
            var actualId = result.Value.FunkoId;

            Assert.Equal(expectedId, actualId);
        }

        [Fact]
        public void Get_Returns_List_Of_Funkos()
        {
            var expected = new List<Funko>() { new Funko() };
            repo.GetAll().Returns(expected);

            var result = underTest.Get();

            Assert.IsType<List<Funko>>(result.Value);
        }

        [Fact]
        public void Post_Creates_New_Funko()
        {
            var result = underTest.Post(new Funko());

            Assert.True(result.Value);
        }

        [Fact]
        public void Post_Updates_Funko()
        {
            var result = underTest.Post(1, new Funko());

            Assert.True(result.Value);
        }

        [Fact]
        public void Post_Deletes_Funko()
        {
            var result = underTest.Post(1);

            Assert.True(result.Value);
        }
    }
}
