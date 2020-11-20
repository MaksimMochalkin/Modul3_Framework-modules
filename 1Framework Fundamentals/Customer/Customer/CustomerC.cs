using System;
using System.Collections.Generic;
using System.Text;

namespace Customer
{
    public class CustomerC : IFormattable
    {
        /// <summary>
        /// Private fields
        /// </summary>
        private string _Name;
        private string _ContactPhone;
        private decimal _Revenue;

        /// <summary>
        /// Public properties
        /// </summary>
        public string Name
        {
            get => _Name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("The entry must have a Name.");
                _Name = value;
            }

        }
        public string ContactPhone
        {
            get => _ContactPhone;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("The entry must have a ContactPhone.");
                _ContactPhone = value;
            }
        }
        public decimal Revenue
        {
            get => _Revenue;
            set
            {
                if (value == 0)
                    throw new ArgumentNullException("The object must have a Revenue.");
                _Revenue = value;
            }
        }

        public CustomerC(string name, string contactPhone, decimal revenue)
        {
            Name = name;
            ContactPhone = contactPhone;
            Revenue = revenue;
        }

        /// <summary>
        /// Override ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ToString("8", null);
        }

        /// <summary>
        /// Output options
        /// </summary>
        /// <param name="format"></param>
        /// <param name="formatProvider"></param>
        /// <returns></returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format)) format = "7";

            switch (format)
            {
                case "1": return "Customer record name: " + Name;
                case "2": return "Customer record contact phone: " + ContactPhone;
                case "3": return "Customer record revenue: " + Revenue;
                case "4": return "Customer record name: " + Name + " contact phone: " + ContactPhone;
                case "5": return "Customer record name: " + Name + " revenue: " + Revenue;
                case "6": return "Customer record contact phone: " + ContactPhone + " revenue: " + Revenue;
                case "7": return "Customer record name: " + Name + " contact phone: " + ContactPhone + " revenue: " + Revenue;
                default: throw new FormatException(String.Format("The {0} format string is not supported.", format));

            }
        }
    }
}
