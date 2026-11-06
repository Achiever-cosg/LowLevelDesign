namespace ChainOfResponsibility.ApprovalSystem
{
    public abstract class Approver
    {
        protected Approver? nextApprover;

        public Approver(Approver? nextApprover)
        {
            this.nextApprover = nextApprover;
        }

        public abstract void ProcessLeaveRequest(int days);
    }
}
