using System;
using System.Collections.Generic;
using System.Text;
using libAutoMapper.Application.Function.Validations;
using libAutoMapper.UnitTests.Mocks;
using Xunit;
using Shouldly;

namespace libAutoMapper.UnitTests.Customers
{
    public class CustomerTests
    {
        [Fact]
        public void WhenCustomerIsNull_ThenArgumentNullExceptionIsThroe()
        {
            var validator = new CreateCustomerValidator();
            Action action = () => validator.Validate(null);
            action.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void WhenCustomerHasAgeLessThan18_ThenValidationFals()
        {
            var validator = new CreateCustomerValidator();
            var customer = new CustomerMock(expectedAge: 16);

            bool validate = validator.Validate(customer);
            validate.ShouldBeFalse();
        }

        [Fact]
        public void WhenCustomerHasAgeGreaterOrEquealTo18_ThenValidationPasses()
        {
            int expectedAge = 19;
            var validator = new CreateCustomerValidator();
            var customer = new CustomerMock(expectedAge: expectedAge);
            bool validate = validator.Validate(customer);
            validate.ShouldBeTrue();
        }
    }
}
