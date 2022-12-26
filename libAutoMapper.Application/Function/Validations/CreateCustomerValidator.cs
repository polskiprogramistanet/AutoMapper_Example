using System;
using System.Collections.Generic;
using System.Text;
using libAutoMapper.Application.Contracts.Customer;

namespace libAutoMapper.Application.Function.Validations
{
    public class CreateCustomerValidator
    {
        public bool Validate(ICustomer customer)
        {
            const int minimumAge = 18;
            if (customer == null) throw new ArgumentNullException(nameof(customer));
            if (customer.GetAge() < minimumAge) return false;
            return true;
        }
    }
}
