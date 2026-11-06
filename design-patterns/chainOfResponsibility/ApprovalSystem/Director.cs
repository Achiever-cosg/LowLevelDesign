namespace ChainOfResponsibility.ApprovalSystem
{
    public class Director : Approver
    {
        public Director(Approver? approver) : base(approver)
        {
        }

        public override void ProcessLeaveRequest(int days)
        {
            if (days <= 20)
            {
                Console.WriteLine("Director: Approved leaves of " + days + " working days");
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
