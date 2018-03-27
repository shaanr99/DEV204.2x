using System;
namespace Mod2_OOPS
{
    public class InterfaceClass
    {
        public InterfaceClass()
        {
        }
        public interface IBeverage
        {
            // methods, props, events, indexers go here
            // To define a method, you specify the name of the method, the return type, and any parameters:
            int GetServingTemperature(bool includesMilk);

            // To define a property, you specify the name of the property, the type of the property, 
            // and the property accessors:
            bool isFairTrade { get; set; }

            // To define an event, you use the event keyword, followed by the event handler delegate, 
            // followed by the name of the event:
            event EventHandler OnSoldOut;

            // To define an indexer, you specify the return type and the accessors:
            string this[int index] { get; set; }

        }

        // defining an interface
        public interface ILoyaltyCardHolder
        {
            int TotalPoints { get; }
            int AddPoints(decimal transactionValue);
            void ResetPoints();
        }

        // implementing an interface
        public class Customer : ILoyaltyCardHolder
        {
            private int totalPoints;
            public int TotalPoints
            {
                get { return totalPoints; }
            }
            public int AddPoints(decimal transactionValue)
            {
                int points = Decimal.ToInt32(transactionValue);
                totalPoints += points;
                return totalPoints;
            }
            public void ResetPoints()
            {
                totalPoints = 0;
            }
        }
    }
}
