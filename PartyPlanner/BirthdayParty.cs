using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner
{
    class BirthdayParty
    {
        private int mNumberOfPeople;
        public int NumberOfPeople { get { return mNumberOfPeople; } set { mNumberOfPeople = value; } }
        private int mNumberOfLettersOnCake;

        private const decimal mCostOfFoodPerPerson = 25M;
        private decimal mCostOfCake;
        private decimal mCostOfDecorations;

        public BirthdayParty(int pNumberOfPeople, bool pFancyDecorations)
        {
            this.mNumberOfPeople = pNumberOfPeople;
            if (pFancyDecorations) mCostOfDecorations = 15M * mNumberOfPeople + 50M;
            else mCostOfDecorations = 7.50M * mNumberOfPeople + 30M;

            if (pNumberOfPeople <= 4) mCostOfCake = 40M;
            else mCostOfCake = 75M;
        }

        public void WriteOnCake(int pNumberOfCakeLetters)
        {
            this.mNumberOfLettersOnCake = pNumberOfCakeLetters;            
        }

        public void CalculateCostOfDecorations(bool pFancyDecorations)
        {
            if (pFancyDecorations) mCostOfDecorations = 15M * mNumberOfPeople + 50M;
            else mCostOfDecorations = 7.50M * mNumberOfPeople + 30M;
        }

        public decimal TotalCostOfParty()
        {
           decimal totalCost = (mNumberOfLettersOnCake * .25M) + ((mNumberOfPeople * mCostOfDecorations) + (mNumberOfPeople * mCostOfFoodPerPerson)) + mCostOfCake;
           return totalCost;       
        }
        
    }
}
