using System.Xml.Serialization;
using System;
using System.IO;
namespace JTejero
{
    [XmlRoot("Prospect", Namespace = "http://prospect")]
    public class Customer
    {
        [XmlAttribute("ProspectId")]
        public Guid Id { get; set; }
         [XmlElement("FullName")]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [XmlIgnore]
        public int Tin { get; set; }
    }
    public class Q278
    {
        public void DoWork()
        {
            XmlSerializer ser = new XmlSerializer(typeof(Customer));
            Customer customer = new Customer();
            customer.Id = Guid.NewGuid();
            customer.Name = "Jose Vicente";
            customer.DateOfBirth = DateTime.Now.AddYears(-35);
            customer.Tin = 10;
            TextWriter writer = new StreamWriter("Customer.Xml");
            ser.Serialize(writer,customer);
            writer.Close();
        }
    }
}