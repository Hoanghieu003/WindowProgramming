namespace ProjectManagementTool {
	partial class AddTeamMember {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.UI_newPersonBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_personDataGrid = new System.Windows.Forms.DataGridView();
            this.UI_addMemberButton = new System.Windows.Forms.Button();
            this.UI_delete_TeamMem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UI_personDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_newPersonBtn
            // 
            this.UI_newPersonBtn.Location = new System.Drawing.Point(301, 173);
            this.UI_newPersonBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_newPersonBtn.Name = "UI_newPersonBtn";
            this.UI_newPersonBtn.Size = new System.Drawing.Size(73, 26);
            this.UI_newPersonBtn.TabIndex = 10;
            this.UI_newPersonBtn.Text = "New Person";
            this.UI_newPersonBtn.UseVisualStyleBackColor = true;
            this.UI_newPersonBtn.Click += new System.EventHandler(this.UI_newPersonBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Team Member";
            // 
            // UI_personDataGrid
            // 
            this.UI_personDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UI_personDataGrid.Location = new System.Drawing.Point(11, 24);
            this.UI_personDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_personDataGrid.Name = "UI_personDataGrid";
            this.UI_personDataGrid.RowTemplate.Height = 24;
            this.UI_personDataGrid.Size = new System.Drawing.Size(365, 145);
            this.UI_personDataGrid.TabIndex = 8;
            // 
            // UI_addMemberButton
            // 
            this.UI_addMemberButton.Location = new System.Drawing.Point(147, 173);
            this.UI_addMemberButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_addMemberButton.Name = "UI_addMemberButton";
            this.UI_addMemberButton.Size = new System.Drawing.Size(73, 26);
            this.UI_addMemberButton.TabIndex = 13;
            this.UI_addMemberButton.Text = "Add ";
            this.UI_addMemberButton.UseVisualStyleBackColor = true;
            this.UI_addMemberButton.Click += new System.EventHandler(this.addMember_Click);
            // 
            // UI_delete_TeamMem
            // 
            this.UI_delete_TeamMem.Location = new System.Drawing.Point(224, 173);
            this.UI_delete_TeamMem.Margin = new System.Windows.Forms.Padding(2);
            this.UI_delete_TeamMem.Name = "UI_delete_TeamMem";
            this.UI_delete_TeamMem.Size = new System.Drawing.Size(73, 26);
            this.UI_delete_TeamMem.TabIndex = 14;
            this.UI_delete_TeamMem.Text = "Delete";
            this.UI_delete_TeamMem.UseVisualStyleBackColor = true;
            this.UI_delete_TeamMem.Click += new System.EventHandler(this.UI_delete_TeamMem_Click);
            // 
            // AddTeamMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 207);
            this.Controls.Add(this.UI_delete_TeamMem);
            this.Controls.Add(this.UI_addMemberButton);
            this.Controls.Add(this.UI_newPersonBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_personDataGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddTeamMember";
            this.Text = "AddTeamMember";
            ((System.ComponentModel.ISupportInitialize)(this.UI_personDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button UI_newPersonBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView UI_personDataGrid;
		private System.Windows.Forms.Button UI_addMemberButton;
        private System.Windows.Forms.Button UI_delete_TeamMem;
    }
}