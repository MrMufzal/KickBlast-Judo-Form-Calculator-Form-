
using System;
using System.Windows.Forms;

namespace KickBlast_Judo_Form
{
    public partial class ResultForm : Form
    {
        private TextBox txtResult; // Changed from 'object' to 'TextBox'

        public ResultForm(string resultText)
        {
            InitializeComponent();
            txtResult.Text = resultText;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.DarkSlateGray;
            txtResult.ForeColor = SystemColors.ButtonHighlight;
            txtResult.Location = new Point(27, 30);
            txtResult.Margin = new Padding(4, 5, 4, 5);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(561, 442);
            txtResult.TabIndex = 0;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(633, 498);
            Controls.Add(txtResult);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "ResultForm";
            Text = "Result Calculations";
            Load += ResultForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }
    }
}