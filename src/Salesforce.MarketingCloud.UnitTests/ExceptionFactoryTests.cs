using System;
using System.Net;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Internal;
using RestSharp;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Exceptions;
using UnauthorizedAccessException = Salesforce.MarketingCloud.Exceptions.UnauthorizedAccessException;

namespace Salesforce.MarketingCloud.UnitTests
{
    [TestFixture]
    public class ExceptionFactoryTests
    {
        private const string ApiMethod = "ApiMethod";
        private const string ExpectedExceptionMessage = "Error calling ApiMethod: Response content";

        [Test]
        public void DefaultExceptionFactory_WhenStatusCodeInResponseIsBadRequest_ReturnsBadRequestException()
        {
            var requestResponse = CreateRequestResponse(HttpStatusCode.BadRequest);
            var exception = Configuration.DefaultExceptionFactory(ApiMethod, requestResponse);

            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
            Assert.IsInstanceOf<BadRequestException>(exception);
        }

        [Test]
        public void DefaultExceptionFactory_WhenStatusCodeInResponseIsUnauthorized_ReturnsAuthenticationFailureException()
        {
            var requestResponse = CreateRequestResponse(HttpStatusCode.Unauthorized);
            var exception = (ApiException)Configuration.DefaultExceptionFactory(ApiMethod, requestResponse);

            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
            Assert.IsInstanceOf<AuthenticationFailureException>(exception);
        }

        [Test]
        public void DefaultExceptionFactory_WhenStatusCodeInResponseIsForbidden_ReturnsUnauthorizedAccessException()
        {
            var requestResponse = CreateRequestResponse(HttpStatusCode.Forbidden);
            var exception = Configuration.DefaultExceptionFactory(ApiMethod, requestResponse);

            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
            Assert.IsInstanceOf<UnauthorizedAccessException>(exception);
        }

        [Test]
        public void DefaultExceptionFactory_WhenStatusCodeInResponseIsResourceNotFound_ReturnsResourceNotFoundException()
        {
            var requestResponse = CreateRequestResponse(HttpStatusCode.NotFound);
            var exception = Configuration.DefaultExceptionFactory(ApiMethod, requestResponse);

            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
            Assert.IsInstanceOf<ResourceNotFoundException>(exception);
        }

        [Test]
        public void DefaultExceptionFactory_WhenStatusCodeInResponseIsInternalServerError_ReturnsInternalServerErrorException()
        {
            var requestResponse = CreateRequestResponse(HttpStatusCode.InternalServerError);
            var exception = Configuration.DefaultExceptionFactory(ApiMethod, requestResponse);

            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
            Assert.IsInstanceOf<InternalServerErrorException>(exception);

        }

        [Test]
        public void DefaultExceptionFactory_WhenStatusCodeInResponseIsBadGateway_ReturnsBadGatewayException()
        {
            var requestResponse = CreateRequestResponse(HttpStatusCode.BadGateway);
            var exception = Configuration.DefaultExceptionFactory(ApiMethod, requestResponse);

            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
            Assert.IsInstanceOf<BadGatewayException>(exception);
        }

        [Test]
        public void DefaultExceptionFactory_WhenStatusCodeInResponseIsServiceUnavailable_ReturnsServiceUnavailableException()
        {
            var requestResponse = CreateRequestResponse(HttpStatusCode.ServiceUnavailable);
            var exception = Configuration.DefaultExceptionFactory(ApiMethod, requestResponse);

            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
            Assert.IsInstanceOf<ServiceUnavailableException>(exception);
        }

        [Test]
        public void DefaultExceptionFactory_WhenStatusCodeInResponseIsGatewayTimeout_ReturnsGatewayTimeoutException()
        {
            var requestResponse = CreateRequestResponse(HttpStatusCode.GatewayTimeout);
            var exception = Configuration.DefaultExceptionFactory(ApiMethod, requestResponse);

            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
            Assert.IsInstanceOf<GatewayTimeoutException>(exception);
        }

        [Test]
        public void DefaultExceptionFactory_WhenSpecificStatusCodeNotCovered_ReturnsApiException()
        {
            var requestResponse = CreateRequestResponse(HttpStatusCode.HttpVersionNotSupported); 
            var exception = Configuration.DefaultExceptionFactory(ApiMethod, requestResponse);

            Assert.AreEqual(ExpectedExceptionMessage, exception.Message);
            Assert.IsInstanceOf<ApiException>(exception);
        }

        [Test]
        public void DefaultExceptionFactory_WhenStatusCodeIs0_ReturnsApiException()
        {
            var requestResponse = CreateRequestResponse(0);
            var exception = Configuration.DefaultExceptionFactory(ApiMethod, requestResponse);

            Assert.AreEqual("Error calling ApiMethod: Error Message", exception.Message);
            Assert.IsInstanceOf<ServerUnreachableException>(exception);
        }

        private IRestResponse CreateRequestResponse(HttpStatusCode httpStatusCode)
        {
            IRestResponse requestResponse = Substitute.For<IRestResponse>();
            requestResponse.StatusCode.Returns(httpStatusCode);
            requestResponse.Content = "Response content";

            return requestResponse;
        }

        private IRestResponse CreateRequestResponse(int statusCode)
        {
            IRestResponse requestResponse = Substitute.For<IRestResponse>();
            requestResponse.StatusCode.Returns((HttpStatusCode)statusCode);
            requestResponse.ErrorMessage = "Error Message";

            return requestResponse;
        }
    }
}