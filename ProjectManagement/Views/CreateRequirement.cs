﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementTool {
    public partial class CreateRequirement : Form
    {
		/* This class will need the current project that we are working with on hand.
		 * The easiest way to do that is to bring it in the constructor.
		 * 
		 * CreateRequirement(Project p)
		 * 
		 * Then you can use that project and update stuff in there (like adding the requirement).
		 * 
		 * Please read all comments in "AddTeamMember.cs" for more clarification
		*/
		Project currentProject;
        DataManagement data;

        public CreateRequirement(Project p)
        {
            InitializeComponent();

			currentProject = p;
        }

        private void comboBoxReqType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonReqSave_Click(object sender, EventArgs e)
        {
            data = new DataManagement();
            //Parses the text from the Requirements Category text box into an enum
            string reqCatText = this.comboBoxReqType.Text;
            RequirementCategory reqCat;
            if (string.Compare(reqCatText,"Functional") == 0)
            {
                reqCat = (RequirementCategory)Enum.Parse(typeof(RequirementCategory), "FUNCTIONAL");
            }else
            {
                reqCat = (RequirementCategory)Enum.Parse(typeof(RequirementCategory), "NONFUNCTIONAL");
            }
            //Creates the requirement object
            Requirement reqOut = new ProjectManagementTool.Requirement(this.reqDescription.Text, Convert.ToInt32(this.comboBoxReqPriority.Text), reqCat);
            //Adds new requirement to the project and updates the save file
            currentProject.addRequirement(reqOut);
			data.updateProject(currentProject);
            this.Close();
        }

    }
}
