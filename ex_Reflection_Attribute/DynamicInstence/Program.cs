using System;
using System.Reflection;
using static System.Console;

namespace DynamicInstence
{
    class Profile
    {
        private string name;
        private string phone;

        public Profile()
        {
            name = "";
            phone = " ";
        }
        public Profile(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public void Print()
        {
            WriteLine($"{name}, {phone}");
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("DynamicInstence.Profile");
            MethodInfo methodInfo = type.GetMethod("Print");
            PropertyInfo nameproperty = type.GetProperty("Name");
            PropertyInfo phoneproperty = type.GetProperty("Phone");

            object profile = Activator.CreateInstance(type, "박찬명", "50621234");
            methodInfo.Invoke(profile, null);

            profile = Activator.CreateInstance(type);
            nameproperty.SetValue(profile, "박찬호", null);
            phoneproperty.SetValue(profile, "0123456789",null);

            WriteLine($"{nameproperty.GetValue(profile, null)}, {phoneproperty.GetValue(profile, null)} ");
        }
    }
}
