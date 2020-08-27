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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Notes = new System.Windows.Forms.ToolStripMenuItem();
            this.NewNote = new System.Windows.Forms.ToolStripMenuItem();
            this.Format = new System.Windows.Forms.ToolStripMenuItem();
            this.Font = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Location = new System.Windows.Forms.Label();
            this.NewConnectedNote = new System.Windows.Forms.ToolStripMenuItem();
            this.OnLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.OnRight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Notes,
            this.Format});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1295, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.ToolStripMenuItem2,
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
            this.NewConnectedNote});
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
            // Format
            // 
            this.Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Font});
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(84, 28);
            this.Format.Text = "Format";
            // 
            // Font
            // 
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(131, 30);
            this.Font.Text = "Font";
            this.Font.Click += new System.EventHandler(this.Font_Click);
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
            // NewConnectedNote
            // 
            this.NewConnectedNote.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnLeft,
            this.OnRight});
            this.NewConnectedNote.Name = "NewConnectedNote";
            this.NewConnectedNote.Size = new System.Drawing.Size(277, 30);
            this.NewConnectedNote.Text = "New Connected Note";
            // 
            // OnLeft
            // 
            this.OnLeft.Name = "OnLeft";
            this.OnLeft.Size = new System.Drawing.Size(252, 30);
            this.OnLeft.Text = "On Left";
            this.OnLeft.Click += new System.EventHandler(this.OnLeft_Click);
            // 
            // OnRight
            // 
            this.OnRight.Name = "OnRight";
            this.OnRight.Size = new System.Drawing.Size(252, 30);
            this.OnRight.Text = "On Right";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 735);
            this.Controls.Add(this.label_Location);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Scapple";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
    }
}

