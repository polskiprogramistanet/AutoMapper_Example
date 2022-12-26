using System;
using System.Collections.Generic;
using System.Text;
using libAutoMapper.Application.Contracts.Customer;

namespace libAutoMapper.UnitTests.Mocks
{
    public class CustomerMock : ICustomer
    {
        private readonly int expectedAge;
        public CustomerMock(int expectedAge)
        {
            this.expectedAge = expectedAge;
        }
        public int GetAge() => expectedAge;
    }
}
