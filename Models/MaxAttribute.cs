using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaxAttributeMVC.Models
{
    public class MaxAttribute
    {
        public int ID { get; set; }
        public string Description { get; set; }
         [Display(Name = "Maximo Table")]
        public string ObjectName {get; set;}
         
         [Display(Name = "Attribute Name")]
        public string AttributeName {get; set;}
        public string Type {get; set;}
        public int Size {get; set;}
        public string Purpose {get; set;}
        public string RequirementId {get; set;}
        public bool Approved {get; set;}
        public string DataSource {get; set;}
        public bool HaveData {get; set;}

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Date Approved")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ApprovedDate { get; set; }
    }
}

