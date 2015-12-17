using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCenter
{
    public class Owner
    {
        public string Name { get; private set; }
        public Bankaccount Bankaccount { get; private set; }

        /// <summary>
        /// Create a owner.
        /// </summary>
        /// <param name="name">Name of the owner.</param>
        /// <param name="bankaccount">Bankaccountnumber.</param>
        /// <param name="authenticationCode">authenticationCode of the owner.</param>
        public  Owner (string name, Bankaccount bankaccount)
        {
            Name               = name;
            Bankaccount        = bankaccount;
        }
    }
}
