using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ILeaveRequestHandler leaves = new Supervisor();
            LeaveRequest leave = new LeaveRequest(){LeaveDays = 1,Employee = "Mani"};
            Console.WriteLine("Leave Request status: " + leave.Employee);
            leaves.HandlerRequest(leave);
            Console.WriteLine();

            leave = new LeaveRequest(){LeaveDays = 5,Employee = "Raghul"};
            Console.WriteLine("Leave Request status: " + leave.Employee);
            leaves.HandlerRequest(leave);
            Console.WriteLine();
            
            leave = new LeaveRequest(){LeaveDays = 11,Employee = "Arjun"};
            Console.WriteLine("Leave Request status: " + leave.Employee);
            leaves.HandlerRequest(leave);
            Console.ReadLine();
        }
    }
}
