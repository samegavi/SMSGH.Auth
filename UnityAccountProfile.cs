using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SMSGH.Auth
{
    public class UnityAccountProfile
    {
        public string AccountId { get; set; }
        public int AccountNumber { get; set; }
        public string Company { get; set; }
        public string PrimaryContact { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public decimal Balance { get; set; }
        public decimal  Credit { get; set; }
        public decimal UnpostedBalance { get; set; }
        public int NumberOfServices { get; set; }
        public string LastAccessed { get; set; }
        public string AccountManager { get; set; }
        public string AccountStatus { get; set; }

        public string Account_Id
        {
			get { return AccountId; }
        }

		public int Account_Number
        {
			get { return AccountNumber; }
        }

        public string _Company
        {
			get { return Company; }
        }

        public string Primary_Contact
        {
			get { return PrimaryContact; }
        }

        public string Mobile_Number
        {
			get { return MobileNumber; }
        }

        public string Email_Address
        {
			get { return EmailAddress; }
        }

        public string _Balance
        {
			get { return Balance.ToString(); }
        }

        public string _Credit
        {
			get { return Credit.ToString(); }
        }

        public string Unposted_Balance
        {
			get { return UnpostedBalance.ToString(); }
        }

        public int Number_Of_Services
        {
			get { return NumberOfServices; }
        }

        public string Last_Accessed
        {
			get { return LastAccessed; }
        }

        public string Account_Manager
        {
			get { return AccountManager; }
        }

        public string Account_Status
        {
			get { return AccountStatus; }
        }
    }
}