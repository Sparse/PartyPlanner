using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class DinnerParty
    {
        private int mNumberOfPeople;
        public int NumberOfPeople { get { return mNumberOfPeople; } set { mNumberOfPeople = value; } }


        private const int mFoodCostPerPerson = 25;
        private decimal mBeverageCostPerPerson;
        private decimal mCostOfDecorations;
        


        public DinnerParty(int pNumberOfPeople, bool pHealthyChecked, bool pFancyChecked)
        {
            this.mNumberOfPeople = pNumberOfPeople;
            SetHealthyOption(pHealthyChecked);
            CalculateDecorationsCost(pFancyChecked);
        }

        public void SetHealthyOption(bool pHealthySelected)
        {
            if (pHealthySelected) mBeverageCostPerPerson = 20.00M;
            else mBeverageCostPerPerson = 5.00M;
        }       

        public void CalculateDecorationsCost(bool pFancySelected)
        {
            if (pFancySelected) mCostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else mCostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        }

        public decimal TotalCost(bool pHealthySelected)
        {
            decimal totalcost = mCostOfDecorations + ((mBeverageCostPerPerson + mFoodCostPerPerson) * NumberOfPeople);
            if (!pHealthySelected) return totalcost * .95M;
            else return totalcost;
        }
    }
}
