using System;
using FluentAssertions;
using OtomatikMuhendis.Cognitive.Face.Core;
using OtomatikMuhendis.Cognitive.Face.Services;
using TechTalk.SpecFlow;

namespace OtomatikMuhendis.Cognitive.Face.Specs.Steps
{
    [Binding]
    public sealed class CurfewServiceStepDefinitions
    {
        private readonly CurfewRequest _curfewRequest;
        private bool _isFree;

        public CurfewServiceStepDefinitions()
        {
            _curfewRequest = new CurfewRequest();
        }

        [Given("(.*) yaşındayım")]
        public void GivenAgeIs(int number)
        {
            _curfewRequest.Age = number;
        }

        [Given("günlerden (.*)")]
        public void GivenDayIs(string day)
        {
            _curfewRequest.Day = ToDayOfWeek(day);
        }

        [Given("saat (.*)")]
        public void GivenHourIs(int hour)
        {
            _curfewRequest.Hour = hour;
        }

        [When("dışarı çıkmak istersem")]
        public void WhenIWantToGoOut()
        {
            var sut = new CurfewService();
            _isFree = sut.IsFreeToGoOut(_curfewRequest);
        }

        [Then("çıkabilirim")]
        public void ThenICanGoOut()
        {
            _isFree.Should().BeTrue();
        }

        [Then("çıkamam")]
        public void ThenICannotGoOut()
        {
            _isFree.Should().BeFalse();
        }

        private DayOfWeek ToDayOfWeek(string day)
        {
            DayOfWeek dayOfWeek;

            switch (day)
            {
                case "Pazartesi":
                    dayOfWeek = DayOfWeek.Monday;
                    break;
                case "Salı":
                    dayOfWeek = DayOfWeek.Tuesday;
                    break;
                case "Çarşamba":
                    dayOfWeek = DayOfWeek.Wednesday;
                    break;
                case "Perşembe":
                    dayOfWeek = DayOfWeek.Thursday;
                    break;
                case "Cuma":
                    dayOfWeek = DayOfWeek.Friday;
                    break;
                case "Cumartesi":
                    dayOfWeek = DayOfWeek.Saturday;
                    break;
                default:
                    dayOfWeek = DayOfWeek.Sunday;
                    break;
            }

            return dayOfWeek;
        }
    }
}
