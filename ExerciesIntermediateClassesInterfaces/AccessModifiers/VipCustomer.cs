using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesIntermediateClassesInterfaces.AccessModifiers
{
    // derived class of customer
    public class VipCustomer : Customer
    {
        public void OfferVouchar()
        {
            // using exposes implementation of the base class -
            var level = this.CalculateRating();
        }
    }
}
