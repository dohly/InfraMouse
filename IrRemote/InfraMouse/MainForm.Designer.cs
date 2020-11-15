namespace InfraMouse
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComPortsList = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.portOutput = new System.Windows.Forms.ListBox();
            this.actions = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.apply = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeSubscription = new System.Windows.Forms.Button();
            this.actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComPortsList
            // 
            this.ComPortsList.FormattingEnabled = true;
            this.ComPortsList.Location = new System.Drawing.Point(31, 28);
            this.ComPortsList.Name = "ComPortsList";
            this.ComPortsList.Size = new System.Drawing.Size(121, 21);
            this.ComPortsList.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(173, 26);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // portOutput
            // 
            this.portOutput.FormattingEnabled = true;
            this.portOutput.Location = new System.Drawing.Point(31, 55);
            this.portOutput.Name = "portOutput";
            this.portOutput.Size = new System.Drawing.Size(217, 173);
            this.portOutput.TabIndex = 2;
            // 
            // actions
            // 
            this.actions.Controls.Add(this.tabPage1);
            this.actions.Controls.Add(this.tabPage2);
            this.actions.Location = new System.Drawing.Point(400, 26);
            this.actions.Name = "actions";
            this.actions.SelectedIndex = 0;
            this.actions.Size = new System.Drawing.Size(484, 210);
            this.actions.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 184);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 184);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(286, 79);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(52, 23);
            this.apply.TabIndex = 4;
            this.apply.Text = ">>>";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(805, 256);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(286, 120);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(52, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "X";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeSubscription
            // 
            this.changeSubscription.Location = new System.Drawing.Point(173, 234);
            this.changeSubscription.Name = "changeSubscription";
            this.changeSubscription.Size = new System.Drawing.Size(75, 23);
            this.changeSubscription.TabIndex = 7;
            this.changeSubscription.Text = "Unsubscribe";
            this.changeSubscription.UseVisualStyleBackColor = true;
            this.changeSubscription.Click += new System.EventHandler(this.changeSubscription_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 303);
            this.Controls.Add(this.changeSubscription);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.actions);
            this.Controls.Add(this.portOutput);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.ComPortsList);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.actions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComPortsList;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ListBox portOutput;
        private System.Windows.Forms.TabControl actions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeSubscription;
    }
}

