using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCustomSection
{
    public class MySection : ConfigurationSection
    {
        [ConfigurationProperty("age", DefaultValue = 18)]
        public int Age
        {
            get { return (int)this["age"]; }
            set { this["age"] = value; }
        }

        [ConfigurationProperty("addr")]
        public AddressElement Address
        {
            get { return (AddressElement)this["addr"]; }
            set { this["addr"] = value; }
        }

        [ConfigurationProperty("members")]
        public MemberCollection Members
        {
            get { return (MemberCollection)this["members"]; }
            //set { this["members"] = value; }
        }
    }

    public class AddressElement : ConfigurationElement
    {
        [ConfigurationProperty("zip")]
        public string PostCode
        {
            get { return (string)this["zip"]; }
            set { this["zip"] = value; }
        }

        [ConfigurationProperty("addr1")]
        public string Address1
        {
            get { return (string)this["addr1"]; }
            set { this["addr1"] = value; }
        }
    }

    public class MemberCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new MemberElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((MemberElement)element).FirstName;
        }
    }

    public class MemberElement : ConfigurationElement
    {
        [ConfigurationProperty("firstName")]
        public string FirstName
        {
            get { return (string)this["firstName"]; }
            set { this["firstName"] = value; }
        }

        [ConfigurationProperty("lastName")]
        public string LastName
        {

            get { return (string)this["lastName"]; }
            set { this["lastName"] = value; }
        }
    }
}
