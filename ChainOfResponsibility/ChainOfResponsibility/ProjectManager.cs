using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class ProjectManager:ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;

        public ILeaveRequestHandler NextHandler
        {
            get { return nextHandler; }
            set { nextHandler = value; }
        }

        public void HandlerRequest(LeaveRequest leave)
        {
           
            if (leave.LeaveDays >3 && leave.LeaveDays <=5)
            {
                Console.WriteLine("ProjectManager approved"+ " leave for " + leave.LeaveDays + " days to " + leave.Employee);
            }
            else
            {
                Console.WriteLine("Passed to HR");
                NextHandler = new HR();
                NextHandler.HandlerRequest(leave);
            }
        }
    }
}
