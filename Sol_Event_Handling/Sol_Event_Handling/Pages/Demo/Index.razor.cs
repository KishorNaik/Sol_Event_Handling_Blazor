using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Event_Handling.Pages.Demo
{
    public partial class Index
    {
        public Index()
        {
            OnSubmit = (mouseEventArgs) =>
            {
                Message = $"X Mouse Pointer {mouseEventArgs.ClientX} | Y Mouse Pointer {mouseEventArgs.ClientY}";
            };
        }

        private string Message { get; set; }

        private void OnButton(MouseEventArgs e, int buttonNumber)
        {
            Message = $"You selected Button #{buttonNumber} at mouse position: {e.ClientX} X {e.ClientY}.";
        }

        private Task UpdateMessage()
        {
            Message = "Method Event";
            return Task.CompletedTask;
        }

        private Action<MouseEventArgs> OnSubmit { get; set; }
    }
}