namespace TetrisView
{
    partial class GameWindow
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TimerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.PointsStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StartButton = new System.Windows.Forms.Button();
            this.TableSizeLabel = new System.Windows.Forms.Label();
            this.RadioButtonSize1 = new System.Windows.Forms.RadioButton();
            this.RadioButtonSize2 = new System.Windows.Forms.RadioButton();
            this.RadioButtonSize3 = new System.Windows.Forms.RadioButton();
            this.gameSpace = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gameTick = new System.Windows.Forms.Timer(this.components);
            this.PauseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimerStatus,
            this.PointsStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 671);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1482, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TimerStatus
            // 
            this.TimerStatus.Name = "TimerStatus";
            this.TimerStatus.Size = new System.Drawing.Size(107, 20);
            this.TimerStatus.Text = "Time passed: 0";
            // 
            // PointsStripLabel
            // 
            this.PointsStripLabel.Name = "PointsStripLabel";
            this.PointsStripLabel.Size = new System.Drawing.Size(63, 20);
            this.PointsStripLabel.Text = "Points: 0";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(28, 380);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 77);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            this.StartButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // TableSizeLabel
            // 
            this.TableSizeLabel.AutoSize = true;
            this.TableSizeLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableSizeLabel.Location = new System.Drawing.Point(28, 9);
            this.TableSizeLabel.Name = "TableSizeLabel";
            this.TableSizeLabel.Size = new System.Drawing.Size(297, 38);
            this.TableSizeLabel.TabIndex = 2;
            this.TableSizeLabel.Text = "Welcome to Tetris 0.12";
            // 
            // RadioButtonSize1
            // 
            this.RadioButtonSize1.AutoSize = true;
            this.RadioButtonSize1.Location = new System.Drawing.Point(28, 134);
            this.RadioButtonSize1.Name = "RadioButtonSize1";
            this.RadioButtonSize1.Size = new System.Drawing.Size(61, 24);
            this.RadioButtonSize1.TabIndex = 3;
            this.RadioButtonSize1.TabStop = true;
            this.RadioButtonSize1.Text = "4x16";
            this.RadioButtonSize1.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSize2
            // 
            this.RadioButtonSize2.AutoSize = true;
            this.RadioButtonSize2.Location = new System.Drawing.Point(28, 218);
            this.RadioButtonSize2.Name = "RadioButtonSize2";
            this.RadioButtonSize2.Size = new System.Drawing.Size(61, 24);
            this.RadioButtonSize2.TabIndex = 4;
            this.RadioButtonSize2.TabStop = true;
            this.RadioButtonSize2.Text = "8x16";
            this.RadioButtonSize2.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSize3
            // 
            this.RadioButtonSize3.AutoSize = true;
            this.RadioButtonSize3.Location = new System.Drawing.Point(28, 300);
            this.RadioButtonSize3.Name = "RadioButtonSize3";
            this.RadioButtonSize3.Size = new System.Drawing.Size(69, 24);
            this.RadioButtonSize3.TabIndex = 5;
            this.RadioButtonSize3.TabStop = true;
            this.RadioButtonSize3.Text = "12x16";
            this.RadioButtonSize3.UseVisualStyleBackColor = true;
            // 
            // gameSpace
            // 
            this.gameSpace.Location = new System.Drawing.Point(149, 70);
            this.gameSpace.Name = "gameSpace";
            this.gameSpace.Size = new System.Drawing.Size(1299, 598);
            this.gameSpace.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 269);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 161);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "12x16";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 101);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "8x16";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "4x16";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // gameTick
            // 
            this.gameTick.Interval = 500;
            this.gameTick.Tick += new System.EventHandler(this.gameTick_Tick);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(27, 476);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(94, 29);
            this.PauseButton.TabIndex = 8;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(27, 511);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 29);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(27, 606);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(94, 29);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(27, 561);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(94, 29);
            this.LoadButton.TabIndex = 11;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 697);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gameSpace);
            this.Controls.Add(this.RadioButtonSize3);
            this.Controls.Add(this.RadioButtonSize2);
            this.Controls.Add(this.RadioButtonSize1);
            this.Controls.Add(this.TableSizeLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.statusStrip1);
            this.Name = "GameWindow";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel TimerStatus;
        private ToolStripStatusLabel PointsStripLabel;
        private Button StartButton;
        private Label TableSizeLabel;
        private RadioButton RadioButtonSize1;
        private RadioButton RadioButtonSize2;
        private RadioButton RadioButtonSize3;
        private Panel gameSpace;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private System.Windows.Forms.Timer gameTick;
        private Button PauseButton;
        private Button SaveButton;
        private Button ResetButton;
        private Button LoadButton;
    }
}