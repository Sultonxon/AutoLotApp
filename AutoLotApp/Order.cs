namespace AutoLotApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int OrderId { get; set; }

        public int CustId { get; set; }

        public int CarId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Invertory Invertory { get; set; }
    }
}
