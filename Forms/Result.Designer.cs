namespace Autism_Prediction_System.Forms
{
    partial class Result
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PredictionProgressBar = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PredictionProgressBar);
            this.panel1.Location = new System.Drawing.Point(24, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 674);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(447, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 115);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Result";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PredictionProgressBar
            // 
            this.PredictionProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PredictionProgressBar.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("PredictionProgressBar.AnimationFunction")));
            this.PredictionProgressBar.AnimationSpeed = 500;
            this.PredictionProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.PredictionProgressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.PredictionProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.PredictionProgressBar.ForeColor = System.Drawing.Color.Black;
            this.PredictionProgressBar.InnerColor = System.Drawing.Color.Transparent;
            this.PredictionProgressBar.InnerMargin = 0;
            this.PredictionProgressBar.InnerWidth = -20;
            this.PredictionProgressBar.Location = new System.Drawing.Point(371, 15);
            this.PredictionProgressBar.MarqueeAnimationSpeed = 2000;
            this.PredictionProgressBar.Name = "PredictionProgressBar";
            this.PredictionProgressBar.OuterColor = System.Drawing.SystemColors.ControlDark;
            this.PredictionProgressBar.OuterMargin = -1;
            this.PredictionProgressBar.OuterWidth = -20;
            this.PredictionProgressBar.ProgressColor = System.Drawing.SystemColors.Highlight;
            this.PredictionProgressBar.ProgressWidth = 20;
            this.PredictionProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.PredictionProgressBar.Size = new System.Drawing.Size(508, 472);
            this.PredictionProgressBar.StartAngle = 270;
            this.PredictionProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.PredictionProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.PredictionProgressBar.SubscriptText = "";
            this.PredictionProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.PredictionProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.PredictionProgressBar.SuperscriptText = "";
            this.PredictionProgressBar.TabIndex = 0;
            this.PredictionProgressBar.Text = "Predicting";
            this.PredictionProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.PredictionProgressBar.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Autism Detected : T/f";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "True Percentage : T/f";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1234, 1050);
            this.Controls.Add(this.panel1);
            this.Name = "Result";
            this.Padding = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CircularProgressBar.CircularProgressBar PredictionProgressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}