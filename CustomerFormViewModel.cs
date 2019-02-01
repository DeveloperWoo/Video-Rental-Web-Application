using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRental.Models;

namespace VideoRental.ViewModels
{
    public class CustomerFormViewModel
    {
        /*The reason why we use 'IEnumerable' instead of 'List'
         * The only function we use is iterating MembershipType.
         * We won't use any functionalities of List
         */
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}