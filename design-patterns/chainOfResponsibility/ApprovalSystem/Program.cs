namespace ChainOfResponsibility.ApprovalSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Approver approver = new Supervisor(new Manager(new Director(new DefaultApproval(null))));

            approver.ProcessLeaveRequest(2);
            approver.ProcessLeaveRequest(8);
            approver.ProcessLeaveRequest(16);
            approver.ProcessLeaveRequest(30);
        }
    }
}
