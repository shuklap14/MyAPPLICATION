using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Recall
    {
        public string country { get; set; }
        public string city { get; set; }
        public string reason_for_recall { get; set; }
        public string address_1 { get; set; }

        public string code_info { get; set; }
        public string product_quantity { get; set; }
        public string center_classification_date { get; set; }
        public string distribution_pattern { get; set; }
        public string state { get; set; }
        public string product_description { get; set; }
        public string report_date { get; set; }
        [Key]
        public string search_id { get; set; }
    }
}
