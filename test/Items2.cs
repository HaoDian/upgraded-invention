using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace test
{
    public class Items2
    {
        [Category("属性"), DisplayName("发货单号")]        
        public int DeliverNumber { get; set; }
        [Category("属性"), DisplayName("销售类型")]
        public string SaleType { get; set; }
        [Category("属性"), DisplayName("客户简称")]
        public string CustomerName { get; set; }
        [Category("属性"), DisplayName("发货地址")]
        public string DeliverAddress { get; set; }
        [Category("属性"), DisplayName("税率")]
        public double TaxRate { get; set; }
        [Category("属性"), DisplayName("备注")]
        public string Info { get; set; }
        [Category("属性"), DisplayName("发货时间")]       
        public DateTime DeliverTime { get; set; }
        [Category("属性"), DisplayName("订单号")]
        public int OrderNumber { get; set; }
        [Category("属性"), DisplayName("销售部门")]
        public string SaleDepartment { get; set; }
        [Category("属性"), DisplayName("发运方式")]
        public string TansportWays { get; set; }
        [Category("属性"), DisplayName("币种")]
        public string Currency { get; set; }
        [Category("属性"), DisplayName("业务类型")]
        public string BusinessType { get; set; }
        [Category("属性"), DisplayName("发票号")]
        public int RepcepitNumber { get; set; }
        [Category("属性"), DisplayName("业务员")]
        public string Salesman{ get; set; }
        [Category("属性"), DisplayName("付款条件")]
        public string PaymentCondition { get; set; }
        [Category("属性"), DisplayName("汇率")]
        public double ExchangeRate { get; set; }
    }
}
