namespace ChainOfResponsibility.ApprovalSystem
{
    public class Supervisor : Approver
    {
        public Supervisor(Approver? approver) : base(approver)
        {
        }

        public override void ProcessLeaveRequest(int days)
        {
            if (days <= 5)
            {
                Console.WriteLine("Supervisor: Approved leaves of " + days + " working days");
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
