namespace Scapple_Real_Final
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Notes = new System.Windows.Forms.ToolStripMenuItem();
            this.NewNote = new System.Windows.Forms.ToolStripMenuItem();
            this.NewConnectedNote = new System.Windows.Forms.ToolStripMenuItem();
            this.OnLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.OnRight = new System.Windows.Forms.ToolStripMenuItem();
            this.Above = new System.Windows.Forms.ToolStripMenuItem();
            this.Below = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.Format = new System.Windows.Forms.ToolStripMenuItem();
            this.Font = new System.Windows.Forms.ToolStripMenuItem();
            this.Bigger = new System.Windows.Forms.ToolStripMenuItem();
            this.Smaller = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Colors = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeTextColor = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTextColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.ChangeFillColor = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFillColor = new System.Windows.Forms.ToolStripMenuItem();
            this.Alignment = new System.Windows.Forms.ToolStripMenuItem();
            this.AlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.Center = new System.Windows.Forms.ToolStripMenuItem();
            this.AlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Location = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.Bold = new System.Windows.Forms.ToolStripMenuItem();
            this.Italic = new System.Windows.Forms.ToolStripMenuItem();
            this.UnderLine = new System.Windows.Forms.ToolStripMenuItem();
            this.StrikeThrough = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Notes,
            this.Format});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1320, 32);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.ToolStripMenuItem2,
            this.toolStripMenuItem5,
            this.ToolStripMenuItem3,
            this.Save,
            this.SaveAs});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(52, 28);
            this.File.Text = "File";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(157, 30);
            this.New.Text = "New";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(157, 30);
            this.ToolStripMenuItem2.Text = "Open";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(154, 6);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(157, 30);
            this.ToolStripMenuItem3.Text = "Close";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(157, 30);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(157, 30);
            this.SaveAs.Text = "Save As";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Notes
            // 
            this.Notes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewNote,
            this.NewConnectedNote,
            this.toolStripMenuItem6,
            this.Connect,
            this.Disconnect});
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(73, 28);
            this.Notes.Text = "Notes";
            // 
            // NewNote
            // 
            this.NewNote.Name = "NewNote";
            this.NewNote.Size = new System.Drawing.Size(277, 30);
            this.NewNote.Text = "New Note";
            this.NewNote.Click += new System.EventHandler(this.NewNote_Click);
            // 
            // NewConnectedNote
            // 
            this.NewConnectedNote.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnLeft,
            this.OnRight,
            this.Above,
            this.Below});
            this.NewConnectedNote.Name = "NewConnectedNote";
            this.NewConnectedNote.Size = new System.Drawing.Size(277, 30);
            this.NewConnectedNote.Text = "New Connected Note";
            // 
            // OnLeft
            // 
            this.OnLeft.Name = "OnLeft";
            this.OnLeft.Size = new System.Drawing.Size(170, 30);
            this.OnLeft.Text = "On Left";
            this.OnLeft.Click += new System.EventHandler(this.OnLeft_Click);
            // 
            // OnRight
            // 
            this.OnRight.Name = "OnRight";
            this.OnRight.Size = new System.Drawing.Size(170, 30);
            this.OnRight.Text = "On Right";
            this.OnRight.Click += new System.EventHandler(this.OnRight_Click);
            // 
            // Above
            // 
            this.Above.Name = "Above";
            this.Above.Size = new System.Drawing.Size(170, 30);
            this.Above.Text = "Above";
            this.Above.Click += new System.EventHandler(this.Above_Click);
            // 
            // Below
            // 
            this.Below.Name = "Below";
            this.Below.Size = new System.Drawing.Size(170, 30);
            this.Below.Text = "Below";
            this.Below.Click += new System.EventHandler(this.Below_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(274, 6);
            // 
            // Connect
            // 
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(277, 30);
            this.Connect.Text = "Connect";
            // 
            // Disconnect
            // 
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(277, 30);
            this.Disconnect.Text = "Disconnect";
            // 
            // Format
            // 
            this.Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Font,
            this.Colors,
            this.Alignment});
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(84, 28);
            this.Format.Text = "Format";
            // 
            // Font
            // 
            this.Font.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bigger,
            this.Smaller,
            this.toolStripMenuItem1,
            this.Bold,
            this.Italic,
            this.UnderLine,
            this.StrikeThrough});
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(252, 30);
            this.Font.Text = "Font";
            // 
            // Bigger
            // 
            this.Bigger.Name = "Bigger";
            this.Bigger.Size = new System.Drawing.Size(252, 30);
            this.Bigger.Text = "Bigger";
            this.Bigger.Click += new System.EventHandler(this.Bigger_Click);
            // 
            // Smaller
            // 
            this.Smaller.Name = "Smaller";
            this.Smaller.Size = new System.Drawing.Size(252, 30);
            this.Smaller.Text = "Smaller";
            this.Smaller.Click += new System.EventHandler(this.Smaller_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(249, 6);
            // 
            // Colors
            // 
            this.Colors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeTextColor,
            this.clearTextColor,
            this.toolStripMenuItem4,
            this.ChangeFillColor,
            this.clearFillColor});
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(252, 30);
            this.Colors.Text = "Colors";
            // 
            // ChangeTextColor
            // 
            this.ChangeTextColor.Name = "ChangeTextColor";
            this.ChangeTextColor.Size = new System.Drawing.Size(250, 30);
            this.ChangeTextColor.Text = "Change Text Color";
            this.ChangeTextColor.Click += new System.EventHandler(this.ChangeTextColor_Click);
            // 
            // clearTextColor
            // 
            this.clearTextColor.Name = "clearTextColor";
            this.clearTextColor.Size = new System.Drawing.Size(250, 30);
            this.clearTextColor.Text = "Clear Text Color";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(247, 6);
            // 
            // ChangeFillColor
            // 
            this.ChangeFillColor.Name = "ChangeFillColor";
            this.ChangeFillColor.Size = new System.Drawing.Size(250, 30);
            this.ChangeFillColor.Text = "Change Fill Color";
            this.ChangeFillColor.Click += new System.EventHandler(this.ChangeFillColor_Click);
            // 
            // clearFillColor
            // 
            this.clearFillColor.Name = "clearFillColor";
            this.clearFillColor.Size = new System.Drawing.Size(250, 30);
            this.clearFillColor.Text = "Clear Fill Color";
            // 
            // Alignment
            // 
            this.Alignment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlignLeft,
            this.Center,
            this.AlignRight});
            this.Alignment.Name = "Alignment";
            this.Alignment.Size = new System.Drawing.Size(252, 30);
            this.Alignment.Text = "Alignment";
            // 
            // AlignLeft
            // 
            this.AlignLeft.Name = "AlignLeft";
            this.AlignLeft.Size = new System.Drawing.Size(190, 30);
            this.AlignLeft.Text = "Align Left";
            this.AlignLeft.Click += new System.EventHandler(this.AlignLeft_Click);
            // 
            // Center
            // 
            this.Center.Name = "Center";
            this.Center.Size = new System.Drawing.Size(190, 30);
            this.Center.Text = "Center";
            this.Center.Click += new System.EventHandler(this.Center_Click);
            // 
            // AlignRight
            // 
            this.AlignRight.Name = "AlignRight";
            this.AlignRight.Size = new System.Drawing.Size(190, 30);
            this.AlignRight.Text = "Align Right";
            this.AlignRight.Click += new System.EventHandler(this.AlignRight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1071, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location";
            // 
            // label_Location
            // 
            this.label_Location.AutoSize = true;
            this.label_Location.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_Location.Location = new System.Drawing.Point(1160, 49);
            this.label_Location.Name = "label_Location";
            this.label_Location.Size = new System.Drawing.Size(89, 18);
            this.label_Location.TabIndex = 3;
            this.label_Location.Text = "         ";
            // 
            // Bold
            // 
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(252, 30);
            this.Bold.Text = "Bold";
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italic
            // 
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(252, 30);
            this.Italic.Text = "Italic";
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // UnderLine
            // 
            this.UnderLine.Name = "UnderLine";
            this.UnderLine.Size = new System.Drawing.Size(252, 30);
            this.UnderLine.Text = "UnderLine";
            this.UnderLine.Click += new System.EventHandler(this.UnderLine_Click);
            // 
            // StrikeThrough
            // 
            this.StrikeThrough.Name = "StrikeThrough";
            this.StrikeThrough.Size = new System.Drawing.Size(252, 30);
            this.StrikeThrough.Text = "StrikeThrough";
            this.StrikeThrough.Click += new System.EventHandler(this.StrikeThrough_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 748);
            this.Controls.Add(this.label_Location);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "Scapple";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripMenuItem Notes;
        private System.Windows.Forms.ToolStripMenuItem NewNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Location;
        private System.Windows.Forms.ToolStripMenuItem Format;
        private System.Windows.Forms.ToolStripMenuItem Font;
        private System.Windows.Forms.ToolStripMenuItem NewConnectedNote;
        private System.Windows.Forms.ToolStripMenuItem OnLeft;
        private System.Windows.Forms.ToolStripMenuItem OnRight;
        private System.Windows.Forms.ToolStripMenuItem Colors;
        private System.Windows.Forms.ToolStripMenuItem ChangeTextColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripMenuItem clearTextColor;
        private System.Windows.Forms.ToolStripMenuItem ChangeFillColor;
        private System.Windows.Forms.ToolStripMenuItem clearFillColor;
        private System.Windows.Forms.ToolStripMenuItem Bigger;
        private System.Windows.Forms.ToolStripMenuItem Smaller;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem Above;
        private System.Windows.Forms.ToolStripMenuItem Below;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem Connect;
        private System.Windows.Forms.ToolStripMenuItem Disconnect;
        private System.Windows.Forms.ToolStripMenuItem Alignment;
        private System.Windows.Forms.ToolStripMenuItem AlignLeft;
        private System.Windows.Forms.ToolStripMenuItem Center;
        private System.Windows.Forms.ToolStripMenuItem AlignRight;
        private System.Windows.Forms.ToolStripMenuItem Bold;
        private System.Windows.Forms.ToolStripMenuItem Italic;
        private System.Windows.Forms.ToolStripMenuItem UnderLine;
        private System.Windows.Forms.ToolStripMenuItem StrikeThrough;
    }
}

