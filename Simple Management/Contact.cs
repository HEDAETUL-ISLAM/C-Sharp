using System;

namespace Simple_Management
{
    public class Contact
    {
        private string personName;
        private string personID;
        private int age;
        private string mobileNumber;
        private char gender;

        public Contact()
        {

        }
        public Contact(string personName, string personID, int age, string mobileNumber, char gender)
        {
            this.personName = personName;
            this.personID = personID;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;
        }
        public string GetPersonName()
        {
            return personName;
        }
        public string GetPersonID()
        {
            return personID;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetMobileNumber()
        {
            return mobileNumber;
        }
        public char GetGender()
        {
            return gender;
        }
        public void ShowPersonInfo()
        {
            System.Console.WriteLine("Person Name: " + GetPersonName() + " ," + "Id: " + GetPersonID() + " ," + "Age: " + GetAge() + " ," + "Mobile No: " + GetMobileNumber() + " ," + "Gender: " + GetGender() + " ");
        }
        public void DetectorMobileOperator()
        {
            if (mobileNumber.Contains("019"))
            {
                System.Console.WriteLine("banglalink");
            }
            else if (mobileNumber.Contains("017"))
            {
                System.Console.WriteLine("Gp");
            }
            else if (mobileNumber.Contains("018"))
            {
                System.Console.WriteLine("Robi");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
