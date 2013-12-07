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
        public Form1()
        {
            InitializeComponent();
            oDinnerParty = new DinnerParty(5, m_HealthyPartyBox.Checked, m_FancyCheckBox.Checked);            
            DisplayDinnerPartyCost();           
        }

        private void DisplayDinnerPartyCost()
        {           
            decimal cost = oDinnerParty.TotalCost(m_HealthyPartyBox.Checked);
            m_TotalCostLabel.Text = cost.ToString("c");
        }

        #region Control Functions
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


    }
}
