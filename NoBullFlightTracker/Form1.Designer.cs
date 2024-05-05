namespace NoBullFlightTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSearch = new Button();
            calDepart = new MonthCalendar();
            calReturn = new MonthCalendar();
            label1 = new Label();
            label2 = new Label();
            chkFlexible = new CheckBox();
            chkBasicEconomy = new CheckBox();
            ddlAirlines = new ComboBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 274);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // calDepart
            // 
            calDepart.AllowDrop = true;
            calDepart.Location = new Point(12, 33);
            calDepart.MinDate = new DateTime(2024, 5, 5, 0, 0, 0, 0);
            calDepart.Name = "calDepart";
            calDepart.TabIndex = 2;
            // 
            // calReturn
            // 
            calReturn.Location = new Point(281, 33);
            calReturn.Name = "calReturn";
            calReturn.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Depart";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 9);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Return";
            // 
            // chkFlexible
            // 
            chkFlexible.AutoSize = true;
            chkFlexible.Location = new Point(281, 235);
            chkFlexible.Name = "chkFlexible";
            chkFlexible.Size = new Size(71, 19);
            chkFlexible.TabIndex = 6;
            chkFlexible.Text = "Flexible?";
            chkFlexible.UseVisualStyleBackColor = true;
            // 
            // chkBasicEconomy
            // 
            chkBasicEconomy.AutoSize = true;
            chkBasicEconomy.Location = new Point(281, 210);
            chkBasicEconomy.Name = "chkBasicEconomy";
            chkBasicEconomy.Size = new Size(152, 19);
            chkBasicEconomy.TabIndex = 7;
            chkBasicEconomy.Text = "Remove Basic Economy";
            chkBasicEconomy.UseVisualStyleBackColor = true;
            // 
            // ddlAirlines
            // 
            ddlAirlines.FormattingEnabled = true;
            ddlAirlines.Items.AddRange(new object[] { "American", "Delta", "Oneworld", "SkyTeam", "Southwest", "Star Alliance", "United" });
            ddlAirlines.Location = new Point(12, 208);
            ddlAirlines.Name = "ddlAirlines";
            ddlAirlines.Size = new Size(121, 23);
            ddlAirlines.TabIndex = 8;
            ddlAirlines.Text = "Select an Airline";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(433, 274);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 310);
            Controls.Add(btnExit);
            Controls.Add(ddlAirlines);
            Controls.Add(chkBasicEconomy);
            Controls.Add(chkFlexible);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(calReturn);
            Controls.Add(calDepart);
            Controls.Add(btnSearch);
            Name = "Form1";
            Text = "No Bull Flight Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private MonthCalendar calDepart;
        private MonthCalendar calReturn;
        private Label label1;
        private Label label2;
        private CheckBox chkFlexible;
        private CheckBox chkBasicEconomy;
        private ComboBox ddlAirlines;
        private Button btnExit;
    }
}
