using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace LemonWay_WebserviceChallenge_Test
{
    [TestClass]
    public class WebserviceTest
    {
        [TestMethod]
        public void Fibonnaci_WithValidInt_ReturnsAmount()
        {
            int Fibo_iterations = 6;
            int Fibo_result = 8;

            int actual = WebserviceMock.Fibonacci(Fibo_iterations);

            Assert.AreEqual(Fibo_result, actual);
        }

        [TestMethod]
        public void Fibonacci_WithLessThanOne_ReturnMinusOne()
        {
            int Fibo_iterations = 0;
            int Fibo_result = -1;

            int actual = WebserviceMock.Fibonacci(Fibo_iterations);

            Assert.AreEqual(Fibo_result, actual);
        }

        [TestMethod]
        public void Fibonacci_WithMoreThanOneHundred_ReturnMinusOne()
        {
            int Fibo_iterations = 200;
            int Fibo_result = -1;

            int actual = WebserviceMock.Fibonacci(Fibo_iterations);

            Assert.AreEqual(Fibo_result, actual);
        }

        [TestMethod]
        public void XmlToJson_WithCorrectFormat_ReturnsJson()
        {
            string XmlString = "<foo>bar</foo>";
            string result = "{\"foo\":\"bar\"}";

            string actual = WebserviceMock.XmlToJson(XmlString);

            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void XmlToJson_WithWrongFormat_ReturnsBadXMLFormat()
        {
            string XmlString = "<foo>bar</bar>";
            string result = "Bad Xml format";

            string actual = WebserviceMock.XmlToJson(XmlString);

            Assert.AreEqual(result, actual);
        }
    }
}
