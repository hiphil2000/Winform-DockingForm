namespace WindowDockTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Parent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_ParentCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_MyName = new System.Windows.Forms.Label();
            this.Label_Width = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label_Point = new System.Windows.Forms.Label();
            this.labl = new System.Windows.Forms.Label();
            this.Label_Height = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Create
            // 
            this.Button_Create.Location = new System.Drawing.Point(12, 12);
            this.Button_Create.Name = "Button_Create";
            this.Button_Create.Size = new System.Drawing.Size(171, 23);
            this.Button_Create.TabIndex = 0;
            this.Button_Create.Text = "Create new DockWindow";
            this.Button_Create.UseVisualStyleBackColor = true;
            this.Button_Create.Click += new System.EventHandler(this.Button_Create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Parent:";
            // 
            // Label_Parent
            // 
            this.Label_Parent.AutoSize = true;
            this.Label_Parent.Location = new System.Drawing.Point(85, 70);
            this.Label_Parent.Name = "Label_Parent";
            this.Label_Parent.Size = new System.Drawing.Size(17, 12);
            this.Label_Parent.TabIndex = 2;
            this.Label_Parent.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "ParentCount:";
            // 
            // Label_ParentCount
            // 
            this.Label_ParentCount.AutoSize = true;
            this.Label_ParentCount.Location = new System.Drawing.Point(96, 96);
            this.Label_ParentCount.Name = "Label_ParentCount";
            this.Label_ParentCount.Size = new System.Drawing.Size(17, 12);
            this.Label_ParentCount.TabIndex = 2;
            this.Label_ParentCount.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "My Name:";
            // 
            // Label_MyName
            // 
            this.Label_MyName.AutoSize = true;
            this.Label_MyName.Location = new System.Drawing.Point(85, 45);
            this.Label_MyName.Name = "Label_MyName";
            this.Label_MyName.Size = new System.Drawing.Size(17, 12);
            this.Label_MyName.TabIndex = 2;
            this.Label_MyName.Text = "...";
            // 
            // Label_Width
            // 
            this.Label_Width.AutoSize = true;
            this.Label_Width.Location = new System.Drawing.Point(57, 120);
            this.Label_Width.Name = "Label_Width";
            this.Label_Width.Size = new System.Drawing.Size(17, 12);
            this.Label_Width.TabIndex = 2;
            this.Label_Width.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Width:";
            // 
            // Label_Point
            // 
            this.Label_Point.AutoSize = true;
            this.Label_Point.Location = new System.Drawing.Point(55, 143);
            this.Label_Point.Name = "Label_Point";
            this.Label_Point.Size = new System.Drawing.Size(17, 12);
            this.Label_Point.TabIndex = 2;
            this.Label_Point.Text = "...";
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Location = new System.Drawing.Point(12, 143);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(37, 12);
            this.labl.TabIndex = 3;
            this.labl.Text = "Point:";
            // 
            // Label_Height
            // 
            this.Label_Height.AutoSize = true;
            this.Label_Height.Location = new System.Drawing.Point(141, 120);
            this.Label_Height.Name = "Label_Height";
            this.Label_Height.Size = new System.Drawing.Size(17, 12);
            this.Label_Height.TabIndex = 2;
            this.Label_Height.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Height:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 168);
            this.Controls.Add(this.labl);
            this.Controls.Add(this.Label_Point);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label_Height);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Label_Width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_ParentCount);
            this.Controls.Add(this.Label_MyName);
            this.Controls.Add(this.Label_Parent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Parent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_ParentCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_MyName;
        private System.Windows.Forms.Label Label_Width;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Label_Point;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.Label Label_Height;
        private System.Windows.Forms.Label label6;
    }
}

