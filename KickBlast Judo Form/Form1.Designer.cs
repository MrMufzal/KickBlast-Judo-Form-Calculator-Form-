
namespace KickBlast_Judo_Form
{
    partial class Judo_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Judo_form));
            lblName = new Label();
            lblPlan = new Label();
            lblWeight = new Label();
            lblPrivate = new Label();
            lblCompetitions = new Label();
            txtName = new TextBox();
            txtWeight = new TextBox();
            cmbPlan = new ComboBox();
            numPrivate = new NumericUpDown();
            numCompetitions = new NumericUpDown();
            title = new Label();
            btnCalculate = new Button();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrivate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCompetitions).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Indigo;
            lblName.ForeColor = SystemColors.ButtonHighlight;
            lblName.Location = new Point(41, 198);
            lblName.Name = "lblName";
            lblName.Size = new Size(101, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Athlete Name";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.BackColor = Color.Indigo;
            lblPlan.ForeColor = SystemColors.ButtonHighlight;
            lblPlan.Location = new Point(41, 276);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(94, 20);
            lblPlan.TabIndex = 1;
            lblPlan.Text = "Training Plan";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.BackColor = Color.Indigo;
            lblWeight.ForeColor = SystemColors.ButtonHighlight;
            lblWeight.Location = new Point(41, 349);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(138, 20);
            lblWeight.TabIndex = 2;
            lblWeight.Text = "Current Weight (kg)";
            // 
            // lblPrivate
            // 
            lblPrivate.AutoSize = true;
            lblPrivate.BackColor = Color.Indigo;
            lblPrivate.ForeColor = SystemColors.ButtonHighlight;
            lblPrivate.Location = new Point(397, 191);
            lblPrivate.Name = "lblPrivate";
            lblPrivate.Size = new Size(193, 20);
            lblPrivate.TabIndex = 3;
            lblPrivate.Text = "Private Coaching (hrs/week)";
            // 
            // lblCompetitions
            // 
            lblCompetitions.AutoSize = true;
            lblCompetitions.BackColor = Color.Indigo;
            lblCompetitions.ForeColor = SystemColors.ButtonHighlight;
            lblCompetitions.Location = new Point(397, 268);
            lblCompetitions.Name = "lblCompetitions";
            lblCompetitions.Size = new Size(175, 20);
            lblCompetitions.TabIndex = 4;
            lblCompetitions.Text = "Competitions This Month";
            // 
            // txtName
            // 
            txtName.BackColor = Color.DarkSlateGray;
            txtName.ForeColor = SystemColors.ButtonHighlight;
            txtName.Location = new Point(196, 191);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 27);
            txtName.TabIndex = 5;
            // 
            // txtWeight
            // 
            txtWeight.BackColor = Color.DarkSlateGray;
            txtWeight.ForeColor = SystemColors.ButtonHighlight;
            txtWeight.Location = new Point(196, 346);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(151, 27);
            txtWeight.TabIndex = 6;
            // 
            // cmbPlan
            // 
            cmbPlan.AllowDrop = true;
            cmbPlan.BackColor = Color.DarkSlateGray;
            cmbPlan.ForeColor = SystemColors.ButtonHighlight;
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced" });
            cmbPlan.Location = new Point(196, 268);
            cmbPlan.MaxDropDownItems = 3;
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(151, 28);
            cmbPlan.TabIndex = 8;
            // 
            // numPrivate
            // 
            numPrivate.BackColor = Color.DarkSlateGray;
            numPrivate.ForeColor = SystemColors.ButtonHighlight;
            numPrivate.Location = new Point(618, 191);
            numPrivate.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numPrivate.Name = "numPrivate";
            numPrivate.Size = new Size(150, 27);
            numPrivate.TabIndex = 9;
            // 
            // numCompetitions
            // 
            numCompetitions.BackColor = Color.DarkSlateGray;
            numCompetitions.ForeColor = SystemColors.ButtonHighlight;
            numCompetitions.Location = new Point(618, 261);
            numCompetitions.Name = "numCompetitions";
            numCompetitions.Size = new Size(150, 27);
            numCompetitions.TabIndex = 10;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = SystemColors.ControlDarkDark;
            title.Font = new Font("Segoe UI Variable Display", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.ButtonHighlight;
            title.Location = new Point(11, 45);
            title.Name = "title";
            title.Size = new Size(777, 37);
            title.TabIndex = 11;
            title.Text = "KickBlast Judo Monthly Cost Calculator and Application Form";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Navy;
            btnCalculate.ForeColor = SystemColors.ButtonHighlight;
            btnCalculate.Location = new Point(581, 116);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(187, 29);
            btnCalculate.TabIndex = 12;
            btnCalculate.Text = "Calculate and Submit";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Navy;
            clearButton.ForeColor = SystemColors.ButtonHighlight;
            clearButton.Location = new Point(478, 116);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 13;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // Judo_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 436);
            Controls.Add(clearButton);
            Controls.Add(btnCalculate);
            Controls.Add(title);
            Controls.Add(numCompetitions);
            Controls.Add(numPrivate);
            Controls.Add(cmbPlan);
            Controls.Add(txtWeight);
            Controls.Add(txtName);
            Controls.Add(lblCompetitions);
            Controls.Add(lblPrivate);
            Controls.Add(lblWeight);
            Controls.Add(lblPlan);
            Controls.Add(lblName);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Judo_form";
            Text = "KickBlast Judo Application Form and Calculator";
            Load += KickBlast_Judo_form_Load;
            ((System.ComponentModel.ISupportInitialize)numPrivate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCompetitions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void KickBlast_Judo_form_Load(object sender, EventArgs e)
        {
            
        }


        #endregion

        private Label lblName;
        private Label lblPlan;
        private Label lblWeight;
        private Label lblPrivate;
        private Label lblCompetitions;
        private TextBox txtName;
        private TextBox txtWeight;
        private ComboBox cmbPlan;
        private NumericUpDown numPrivate;
        private NumericUpDown numCompetitions;
        private Label title;
        private Button btnCalculate;
        private Button clearButton;
    }
}
