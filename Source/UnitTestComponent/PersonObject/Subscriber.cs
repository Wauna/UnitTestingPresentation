using System;
using System.ComponentModel;


namespace Components
{
    public class Subscriber
    {

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }





        public bool IsOver18() {
            if (this.Birthday < DateTime.Now.AddYears(-21))
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
