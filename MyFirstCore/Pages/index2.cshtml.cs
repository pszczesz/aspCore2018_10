using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstCore.Pages
{
    public class index2Model : PageModel {
        public string Message { get; private set; } = "Page model in C#";
        public void OnGet() {
            Message += $"Server time is {DateTime.Now}";
        }
    }
}