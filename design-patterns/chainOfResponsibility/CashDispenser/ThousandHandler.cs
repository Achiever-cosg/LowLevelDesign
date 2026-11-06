namespace ChainOfResponsibility.CashDispenser
{
    public class ThousandHandler : MoneyHandler
    {
        public ThousandHandler(int notes, MoneyHandler? next) : base(notes, next)
        {
        }

        public override void Dispense(int money)
        {
            int notesNeeded = money / 1000;
            if (notesNeeded > notes)
            {
                notesNeeded = notes;
                notes = 0;
            }
            else
            {
                notes -= notesNeeded;
            }
            if (notesNeeded > 0)
            {
                Console.WriteLine("Dispensing " + notesNeeded + " $1000");
            }

            int remaining = money - (1000 * notesNeeded);
            if (remaining > 0)
            {
                if (nextHandler != null)
                {
                    nextHandler.Dispense(remaining);
                }
                else
                {
                    Console.WriteLine("Remaining amount of " + remaining + " cannot be fulfilled");
                }
            }
        }
    }
}
