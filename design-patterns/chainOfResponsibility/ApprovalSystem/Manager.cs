namespace ChainOfResponsibility.ApprovalSystem
{
    public class Manager : Approver
    {
        public Manager(Approver? approver) : base(approver)
        {
        }

        public override void ProcessLeaveRequest(int days)
        {
            if (days <= 10)
            {
                Console.WriteLine("Manager: Approved leaves of " + days + " working days");
            }
            else
            {
                if (nextApprover != null)
                {
                    nextApprover.ProcessLeaveRequest(days);
                }
            }
        }
    }
}
