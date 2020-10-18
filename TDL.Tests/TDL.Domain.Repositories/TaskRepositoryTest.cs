using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDL.Domain.Models;
using TDL.Domain.Repositories.Abstraction;

namespace TDL.Tests.TDL.Domain.Repositories
{
    [TestClass()]
    public class TaskRepositoryTest
    {
        [TestMethod()]
        public void TaskAdding()
        {
            // Arrange
            Task task = new Task()
            {
                Name = "Test",
                Description = "This task created by unit test",
                Created = DateTime.Now,
                TaskStatus = TaskStatus.Executing
            };

            var mock = new Mock<IRepository<Task>>();
            mock.Setup(x => x.Add(task)).Returns(() => task);

            // Act


            // Assertion

        }
    }
}
