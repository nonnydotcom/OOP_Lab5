using System;

namespace LAB5
{
    public abstract class User
    {
        protected string firstname;
        protected string lastname;
        protected string phone;
        protected string email;

        public void SetUserInfo(string firstname, string lastname, string phone, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.phone = phone;
            this.email = email;
        }

        public abstract void ShowDetails();
    }
}