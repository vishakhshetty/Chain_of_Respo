using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Supervisor:ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;

        public ILeaveRequestHandler NextHandler
        {
            get { return nextHandler; }
            set { nextHandler = value; }
        }

        public void HandlerRequest(LeaveRequest leave)
        {
            
            if (leave.LeaveDays >= 1 && leave.LeaveDays < 3)
            {
                Console.WriteLine("Supervisor approved" + " leave for " + leave.LeaveDays + " days to " + leave.Employee);
            }
            else 
            {
                Console.WriteLine("Passed to ProjectManager");
                NextHandler = new ProjectManager();
                NextHandler.HandlerRequest(leave);
            }
        }
    }
}
