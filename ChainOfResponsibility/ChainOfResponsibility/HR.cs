using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class HR:ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;

        public ILeaveRequestHandler NextHandler 
        { 
            get {return nextHandler; } 
            set {nextHandler=value; } 
        }

        public void HandlerRequest(LeaveRequest leave)
        {
            
            Console.WriteLine("HR Approved" + " leave for " + leave.LeaveDays + " days to " + leave.Employee);
        }
    }
}
