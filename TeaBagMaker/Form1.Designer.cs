namespace TeaBagMaker
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ChoiceTea = new System.Windows.Forms.ComboBox();
            this.MakeTea = new System.Windows.Forms.Button();
            this.TeaTimer = new System.Windows.Forms.Timer(this.components);
            this.TCountDown = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans CJK KR Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "티를 선택하세요.";
            // 
            // ChoiceTea
            // 
            this.ChoiceTea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoiceTea.FormattingEnabled = true;
            this.ChoiceTea.Location = new System.Drawing.Point(18, 57);
            this.ChoiceTea.Name = "ChoiceTea";
            this.ChoiceTea.Size = new System.Drawing.Size(246, 20);
            this.ChoiceTea.TabIndex = 1;
            // 
            // MakeTea
            // 
            this.MakeTea.Font = new System.Drawing.Font("Noto Sans CJK KR Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MakeTea.Location = new System.Drawing.Point(18, 83);
            this.MakeTea.Name = "MakeTea";
            this.MakeTea.Size = new System.Drawing.Size(246, 65);
            this.MakeTea.TabIndex = 2;
            this.MakeTea.Text = "담그기!";
            this.MakeTea.UseVisualStyleBackColor = true;
            this.MakeTea.Click += new System.EventHandler(this.MakeTea_Click);
            // 
            // TeaTimer
            // 
            this.TeaTimer.Interval = 1000;
            // 
            // TCountDown
            // 
            this.TCountDown.Font = new System.Drawing.Font("Noto Sans CJK KR Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TCountDown.Location = new System.Drawing.Point(18, 155);
            this.TCountDown.Name = "TCountDown";
            this.TCountDown.Size = new System.Drawing.Size(246, 47);
            this.TCountDown.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 209);
            this.Controls.Add(this.TCountDown);
            this.Controls.Add(this.MakeTea);
            this.Controls.Add(this.ChoiceTea);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChoiceTea;
        private System.Windows.Forms.Button MakeTea;
        private System.Windows.Forms.Timer TeaTimer;
        private System.Windows.Forms.TextBox TCountDown;
    }
}

