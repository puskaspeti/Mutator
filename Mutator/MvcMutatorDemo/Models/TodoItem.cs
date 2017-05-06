using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MvcMutatorDemo.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Todo title")]
        public string Title { get; set; }

        public bool Completed { get; set; }
    }
}