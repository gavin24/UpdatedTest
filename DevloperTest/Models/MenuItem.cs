namespace DevloperTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MenuItem")]
    public partial class MenuItem
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public int? ItemOrder { get; set; }

        public string Title { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public bool? Enabled { get; set; }

        public string URL { get; set; }

        public int? ItemLevel { get; set; }

        public int? TopLevelNode { get; set; }
    }
}
