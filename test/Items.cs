using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Items
    {
        [Category("属性"), DisplayName("1")]
        public int DeliverNumber { get; set; }
        [Category("属性"), DisplayName("2")]
        public string SaleType { get; set; }
        [Category("属性"), DisplayName("3")]
        public string CustomerName { get; set; }
        [Category("属性"), DisplayName("4")]
        public string DeliverAddress { get; set; }
        [Category("属性"), DisplayName("5")]
        public double TaxRate { get; set; }
        [Category("属性"), DisplayName("6")]
        public string Info { get; set; }
        [Category("属性"), DisplayName("7")]
        public DateTime DeliverTime { get; set; }
        [Category("属性"), DisplayName("8")]
        public int OrderNumber { get; set; }
        [Category("属性"), DisplayName("9")]
        public string SaleDepartment { get; set; }
        [Category("属性"), DisplayName("10")]
        public string TansportWays { get; set; }
        [Category("属性"), DisplayName("11")]
        public string Currency { get; set; }
        [Category("属性"), DisplayName("12")]
        public string BusinessType { get; set; }
        [Category("属性"), DisplayName("13")]
        public int RepcepitNumber { get; set; }
        [Category("属性"), DisplayName("14")]
        public string Salesman { get; set; }
        [Category("属性"), DisplayName("15")]
        public string PaymentCondition { get; set; }
        [Category("属性"), DisplayName("16")]
        public double ExchangeRate { get; set; }


    }
}
