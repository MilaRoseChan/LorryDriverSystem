using System;
namespace DriverDepot
{
    public class History
    {
        private DateTime serviceDate;
        private string serviceType;
        private string comments;

        public History(DateTime newServiceDate, string newServiceType, string newComments)
        {
            this.serviceDate = newServiceDate;
            this.serviceType = newServiceType;
            this.comments = newComments;
            
        }

        public string getComments()
        {
            return this.comments;
        }
    }
}
