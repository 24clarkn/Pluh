namespace DoorAttendance
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002258 File Offset: 0x00000458
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002290 File Offset: 0x00000490
		private void InitializeComponent()
		{
            this.CodeInputBox = new System.Windows.Forms.TextBox();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.UserAttendanceList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CodeInputBox
            // 
            this.CodeInputBox.Location = new System.Drawing.Point(32, 122);
            this.CodeInputBox.MaxLength = 6;
            this.CodeInputBox.Name = "CodeInputBox";
            this.CodeInputBox.Size = new System.Drawing.Size(176, 20);
            this.CodeInputBox.TabIndex = 0;
            // 
            // ButtonOne
            // 
            this.ButtonOne.Location = new System.Drawing.Point(32, 150);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(55, 35);
            this.ButtonOne.TabIndex = 1;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = true;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.Location = new System.Drawing.Point(93, 150);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(55, 35);
            this.ButtonTwo.TabIndex = 2;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = true;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.Location = new System.Drawing.Point(154, 150);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(54, 35);
            this.ButtonThree.TabIndex = 3;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = true;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.Location = new System.Drawing.Point(154, 191);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(54, 35);
            this.ButtonSix.TabIndex = 6;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = true;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonSix_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.Location = new System.Drawing.Point(93, 191);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(55, 35);
            this.ButtonFive.TabIndex = 5;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = true;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.Location = new System.Drawing.Point(32, 191);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(55, 35);
            this.ButtonFour.TabIndex = 4;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = true;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.Location = new System.Drawing.Point(154, 232);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(54, 35);
            this.ButtonNine.TabIndex = 9;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = true;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.Location = new System.Drawing.Point(93, 232);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(55, 35);
            this.ButtonEight.TabIndex = 8;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = true;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonEight_Click);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.Location = new System.Drawing.Point(32, 232);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(55, 35);
            this.ButtonSeven.TabIndex = 7;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = true;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.Location = new System.Drawing.Point(93, 273);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(55, 35);
            this.ButtonZero.TabIndex = 10;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = true;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter Student ID";
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(32, 273);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(55, 35);
            this.ButtonRemove.TabIndex = 12;
            this.ButtonRemove.Text = "DEL";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(154, 273);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(54, 35);
            this.ButtonSubmit.TabIndex = 13;
            this.ButtonSubmit.Text = "LOG";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // UserAttendanceList
            // 
            this.UserAttendanceList.FormattingEnabled = true;
            this.UserAttendanceList.Location = new System.Drawing.Point(224, 122);
            this.UserAttendanceList.Name = "UserAttendanceList";
            this.UserAttendanceList.Size = new System.Drawing.Size(156, 186);
            this.UserAttendanceList.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Attendance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserAttendanceList);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonZero);
            this.Controls.Add(this.ButtonNine);
            this.Controls.Add(this.ButtonEight);
            this.Controls.Add(this.ButtonSeven);
            this.Controls.Add(this.ButtonSix);
            this.Controls.Add(this.ButtonFive);
            this.Controls.Add(this.ButtonFour);
            this.Controls.Add(this.ButtonThree);
            this.Controls.Add(this.ButtonTwo);
            this.Controls.Add(this.ButtonOne);
            this.Controls.Add(this.CodeInputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		public System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.TextBox CodeInputBox;
        public System.Windows.Forms.Button ButtonOne;
        public System.Windows.Forms.Button ButtonTwo;
        public System.Windows.Forms.Button ButtonThree;
        public System.Windows.Forms.Button ButtonSix;
        public System.Windows.Forms.Button ButtonFive;
        public System.Windows.Forms.Button ButtonFour;
        public System.Windows.Forms.Button ButtonNine;
        public System.Windows.Forms.Button ButtonEight;
        public System.Windows.Forms.Button ButtonSeven;
        public System.Windows.Forms.Button ButtonZero;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button ButtonRemove;
        public System.Windows.Forms.Button ButtonSubmit;
        public System.Windows.Forms.ListBox UserAttendanceList;
        public System.Windows.Forms.Label label2;
    }
}
