using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner
{
    public partial class Form1 : Form
    {
        DinnerParty oDinnerParty;
        BirthdayParty oBirthdayParty;
        public Form1()
        {
            InitializeComponent();
            oDinnerParty = new DinnerParty(5, m_HealthyPartyBox.Checked, m_FancyCheckBox.Checked);            
            DisplayDinnerPartyCost();
            oBirthdayParty = new BirthdayParty((int)m_NumberOfPeopleBDay.Value, m_FancyDecorationsBDay.Checked);
            DisplayBirtdayPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {           
            decimal cost = oDinnerParty.TotalCost(m_HealthyPartyBox.Checked);
            m_TotalCostLabel.Text = cost.ToString("c");
        }

        private void DisplayBirtdayPartyCost()
        {
            decimal cost = oBirthdayParty.TotalCostOfParty();
            m_BirthdayPartyCost.Text = cost.ToString("c");
        }

        #region Control Functions for Dinner Party
        private void m_PeopleNumberBox_ValueChanged(object sender, EventArgs e)
        {
            oDinnerParty.NumberOfPeople = (int)m_PeopleNumberBox.Value;
            oDinnerParty.CalculateDecorationsCost(m_FancyCheckBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void m_FancyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            oDinnerParty.CalculateDecorationsCost(m_FancyCheckBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void m_HealthyPartyBox_CheckedChanged(object sender, EventArgs e)
        {
            oDinnerParty.SetHealthyOption(m_HealthyPartyBox.Checked);
            DisplayDinnerPartyCost();
        } 
        #endregion

        #region Control Functions for BirtdayParty
        private void m_NumberOfPeopleBDay_ValueChanged(object sender, EventArgs e)
        {
            oBirthdayParty.NumberOfPeople = (int)m_NumberOfPeopleBDay.Value;
            oBirthdayParty.CalculateCostOfDecorations(m_FancyDecorationsBDay.Checked);
            if (m_NumberOfPeopleBDay.Value <= 4) m_CakeWritingBox.MaxLength = 16; // Not very well encapsulated, this should be handled by the object itself
            else m_CakeWritingBox.MaxLength = 40; // same as above comment. However, on the other hand, this was far easier to do than to handle it via the BDay object...
            DisplayBirtdayPartyCost();
        }

        private void m_FancyDecorationsBDay_CheckedChanged(object sender, EventArgs e)
        {
            oBirthdayParty.CalculateCostOfDecorations(m_FancyDecorationsBDay.Checked);
            DisplayBirtdayPartyCost();
        }

        private void m_CakeWritingBox_TextChanged(object sender, EventArgs e)
        {
            oBirthdayParty.WriteOnCake(this.m_CakeWritingBox.TextLength);
            DisplayBirtdayPartyCost();
        }
        #endregion

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        

    }
}
