using System;
using System.Collections.Concurrent;
using Salesforce.MarketingCloud.Authentication;
using Salesforce.MarketingCloud.Model;
using NUnit.Framework;

namespace Salesforce.MarketingCloud.UnitTests
{
    [TestFixture]
    public class CacheServiceTests
    {
        [Test]
        public void Get_WhenCacheIsNotExpired_ReturnsCachedValue()
        {
            var currentTime = new DateTime(2000, 1, 1);
            var datetimeProviderStub = new SettableDateTimeProvider(currentTime);
            var tokenResponse = CreateTokenResponse();

            var cacheService = new CacheService(datetimeProviderStub);
            var cacheKey = "cacheKey";
            cacheService.AddOrUpdate(cacheKey, tokenResponse);

            datetimeProviderStub.Now = currentTime.AddMinutes(10);
            var response = cacheService.Get(cacheKey);

            Assert.AreEqual("access_token", response.AccessToken);
            Assert.AreEqual("token_type", response.TokenType);
            Assert.AreEqual(1000, response.ExpiresIn);
            Assert.AreEqual("https://rest.com", response.RestInstanceUrl);
            Assert.AreEqual("https://soap.com", response.SoapInstanceUrl);
        }

        [Test]
        public void Get_WhenCacheIsExpired_ReturnsNull()
        {
            var currentTime = new DateTime(2000, 1, 1);
            var dateTimeProvider = new SettableDateTimeProvider(currentTime);
            var cacheService = new CacheService(dateTimeProvider);
            var tokenResponse = CreateTokenResponse();

            var cacheKey = "cacheKey";
            cacheService.AddOrUpdate(cacheKey, tokenResponse);

            var newCurrentTime = currentTime.AddMinutes(20);
            dateTimeProvider.Now = newCurrentTime;

            var response = cacheService.Get(cacheKey);

            Assert.AreEqual(null, response);
        }

        [Test]
        public void AddOrUpdate_WhenCalledAndKeyIsNotInCache_AddsValueInCache()
        {
            var currentTime = new DateTime(2000, 1, 1);
            var dateTimeProvider = new SettableDateTimeProvider(currentTime);
            var cacheService = new CacheService(dateTimeProvider);
            var tokenResponse = CreateTokenResponse();

            var cacheKey = "cacheKey";
            cacheService.AddOrUpdate(cacheKey, tokenResponse);

            var cachedValue = cacheService.Get(cacheKey);
            Assert.AreSame(cachedValue, tokenResponse);
        }

        [Test]
        public void AddOrUpdate_WhenCalledTwoTimesForTheSameKey_OverwritesValueInCache()
        {
            var currentTime = new DateTime(2000, 1, 1);
            var dateTimeProvider = new SettableDateTimeProvider(currentTime);
            var cacheService = new CacheService(dateTimeProvider);
            var tokenResponse = CreateTokenResponse();

            var cacheKey = "cacheKey";
            cacheService.AddOrUpdate(cacheKey, tokenResponse);

            var newTokenResponse = CreateTokenResponse();
            cacheService.AddOrUpdate(cacheKey, newTokenResponse);

            var cachedValue = cacheService.Get(cacheKey);
            Assert.AreSame(cachedValue, newTokenResponse);
        }

        [TestCase(29, false)]
        [TestCase(30, false)]
        [TestCase(31, true)]
        public void Get_WhenCalledForACachedValue_ReturnsBasedOnInvalidCacheWindow(int windowInSeconds, bool isValid)
        {
            var currentTime = new DateTime(2000, 1, 1);
            var dateTimeProvider = new SettableDateTimeProvider(currentTime);
            var cacheService = new CacheService(dateTimeProvider);
            var tokenResponse = CreateTokenResponse();

            var cacheKey = "cacheKey";
            cacheService.AddOrUpdate(cacheKey, tokenResponse);

            dateTimeProvider.Now = currentTime.AddSeconds(tokenResponse.ExpiresIn).Subtract(TimeSpan.FromSeconds(windowInSeconds));
            var cachedValue = cacheService.Get(cacheKey);
            var expectedIsValid = cachedValue != null;
            Assert.AreEqual(expectedIsValid, isValid);
        }

        [TearDown]
        public void CleanUp()
        {
            CacheService.cache = new ConcurrentDictionary<string, Tuple<TokenResponse, DateTime>>();
        }

        private TokenResponse CreateTokenResponse()
        {
            var tokenResponse = new TokenResponse
            {
                AccessToken = "access_token",
                TokenType = "token_type",
                ExpiresIn = 1000,
                RestInstanceUrl = "https://rest.com",
                SoapInstanceUrl = "https://soap.com"
            };
            return tokenResponse;
        }
    }
}