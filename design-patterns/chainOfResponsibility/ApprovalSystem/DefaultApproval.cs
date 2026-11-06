namespace ChainOfResponsibility.ApprovalSystem
{
    public class DefaultApproval : Approver
    {
        public DefaultApproval(Approver? approver) : base(approver)
        {
        }

        public override void ProcessLeaveRequest(int days)
        {
            Console.WriteLine("Default Approval of " + days + " working days");
        }
    }
}
