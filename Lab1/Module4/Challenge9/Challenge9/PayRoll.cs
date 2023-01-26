using System.Text;

//oop interface student teacher portal
namespace SchoolTracker
{
    interface IPayee
    {
        void Pay();
    }
    public class PayRoll
    {
        private List<IPayee> payees = new List<IPayee>();

        public PayRoll()
        {
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }
        
        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }
        }
    
    } 
    
}

