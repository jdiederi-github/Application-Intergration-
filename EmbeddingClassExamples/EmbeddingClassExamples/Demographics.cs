using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbeddingClassExamples
{
    class Demographics
    {
       

        private string email;
        private string nextOfKin;
        private string phoneNumber;

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string NextOfKin
        {
            get
            {
                return nextOfKin;
            }
            set
            {
                nextOfKin = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        public Demographics(string email, string phoneNumber, string nextOfKin)
        {
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.nextOfKin = nextOfKin;
        }

    }
}
