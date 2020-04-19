using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakeCase.Formatter;

namespace SnakeCase.Formatter.Test
{
    [TestClass]
    public class SnakeCaseTest
    {
        public class TestModel
        {
            public Guid Id { get; set; }

            public string DocumentProfile { get; set; }
        }

        [TestMethod]
        public void SnakeCaseTestMethod()
        {
            var param = "PDF";
            var result = Extensions.SnakeCase($"select * from {$"{nameof(TestModel)}"} where {nameof(TestModel.DocumentProfile)} = {param}");
            return;
        }
    }
}