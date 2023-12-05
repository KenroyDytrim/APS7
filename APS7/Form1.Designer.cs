namespace APS7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NizPalitlabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Palitlabel = new System.Windows.Forms.Label();
            this.Figure = new System.Windows.Forms.Panel();
            this.FigB = new System.Windows.Forms.Button();
            this.DelB = new System.Windows.Forms.Button();
            this.RepB = new System.Windows.Forms.Button();
            this.MoveB = new System.Windows.Forms.Button();
            this.CancelB = new System.Windows.Forms.Button();
            this.textX = new System.Windows.Forms.TextBox();
            this.textY = new System.Windows.Forms.TextBox();
            this.FigX = new System.Windows.Forms.Label();
            this.FigY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionB = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NizPalitlabel
            // 
            this.NizPalitlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NizPalitlabel.BackColor = System.Drawing.Color.White;
            this.NizPalitlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NizPalitlabel.Location = new System.Drawing.Point(1148, 104);
            this.NizPalitlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NizPalitlabel.Name = "NizPalitlabel";
            this.NizPalitlabel.Size = new System.Drawing.Size(53, 49);
            this.NizPalitlabel.TabIndex = 12;
            this.NizPalitlabel.BackColorChanged += new System.EventHandler(this.NizPalitlabel_BackColorChanged);
            this.NizPalitlabel.Click += new System.EventHandler(this.Palitlabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(36, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 634);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Холст";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 613);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Palitlabel
            // 
            this.Palitlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Palitlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Palitlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Palitlabel.Location = new System.Drawing.Point(1109, 76);
            this.Palitlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Palitlabel.Name = "Palitlabel";
            this.Palitlabel.Size = new System.Drawing.Size(53, 49);
            this.Palitlabel.TabIndex = 14;
            this.Palitlabel.BackColorChanged += new System.EventHandler(this.Palitlabel_BackColorChanged);
            this.Palitlabel.Click += new System.EventHandler(this.Palitlabel_Click);
            // 
            // Figure
            // 
            this.Figure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Figure.BackColor = System.Drawing.Color.Transparent;
            this.Figure.Location = new System.Drawing.Point(1039, 201);
            this.Figure.Name = "Figure";
            this.Figure.Size = new System.Drawing.Size(200, 100);
            this.Figure.TabIndex = 15;
            this.Figure.Paint += new System.Windows.Forms.PaintEventHandler(this.Figure_Paint);
            this.Figure.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Figure_MouseDown);
            // 
            // FigB
            // 
            this.FigB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FigB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FigB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FigB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FigB.Location = new System.Drawing.Point(1039, 320);
            this.FigB.Name = "FigB";
            this.FigB.Size = new System.Drawing.Size(200, 42);
            this.FigB.TabIndex = 16;
            this.FigB.Text = "Фигура";
            this.FigB.UseVisualStyleBackColor = false;
            this.FigB.Click += new System.EventHandler(this.FigB_Click);
            // 
            // DelB
            // 
            this.DelB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DelB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelB.Location = new System.Drawing.Point(1039, 385);
            this.DelB.Name = "DelB";
            this.DelB.Size = new System.Drawing.Size(200, 42);
            this.DelB.TabIndex = 17;
            this.DelB.Text = "Удалить";
            this.DelB.UseVisualStyleBackColor = false;
            this.DelB.Click += new System.EventHandler(this.DelB_Click);
            // 
            // RepB
            // 
            this.RepB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RepB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RepB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RepB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepB.Location = new System.Drawing.Point(1039, 446);
            this.RepB.Name = "RepB";
            this.RepB.Size = new System.Drawing.Size(200, 42);
            this.RepB.TabIndex = 18;
            this.RepB.Text = "Перекрас";
            this.RepB.UseVisualStyleBackColor = false;
            this.RepB.Click += new System.EventHandler(this.RepB_Click);
            // 
            // MoveB
            // 
            this.MoveB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MoveB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveB.Location = new System.Drawing.Point(1039, 514);
            this.MoveB.Name = "MoveB";
            this.MoveB.Size = new System.Drawing.Size(200, 42);
            this.MoveB.TabIndex = 19;
            this.MoveB.Text = "Передвижение";
            this.MoveB.UseVisualStyleBackColor = false;
            this.MoveB.Click += new System.EventHandler(this.MoveB_Click);
            // 
            // CancelB
            // 
            this.CancelB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelB.BackColor = System.Drawing.Color.Red;
            this.CancelB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelB.Location = new System.Drawing.Point(1074, 601);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(263, 57);
            this.CancelB.TabIndex = 20;
            this.CancelB.Text = "Назад";
            this.CancelB.UseVisualStyleBackColor = false;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // textX
            // 
            this.textX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textX.Location = new System.Drawing.Point(1278, 107);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(109, 30);
            this.textX.TabIndex = 21;
            // 
            // textY
            // 
            this.textY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textY.Location = new System.Drawing.Point(1278, 156);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(109, 30);
            this.textY.TabIndex = 22;
            // 
            // FigX
            // 
            this.FigX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FigX.AutoSize = true;
            this.FigX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FigX.Location = new System.Drawing.Point(1246, 110);
            this.FigX.Name = "FigX";
            this.FigX.Size = new System.Drawing.Size(26, 25);
            this.FigX.TabIndex = 23;
            this.FigX.Text = "X";
            // 
            // FigY
            // 
            this.FigY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FigY.AutoSize = true;
            this.FigY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FigY.Location = new System.Drawing.Point(1247, 161);
            this.FigY.Name = "FigY";
            this.FigY.Size = new System.Drawing.Size(25, 25);
            this.FigY.TabIndex = 24;
            this.FigY.Text = "Y";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1248, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Информация";
            // 
            // ActionB
            // 
            this.ActionB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ActionB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActionB.Enabled = false;
            this.ActionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionB.Location = new System.Drawing.Point(1267, 201);
            this.ActionB.Name = "ActionB";
            this.ActionB.Size = new System.Drawing.Size(131, 42);
            this.ActionB.TabIndex = 26;
            this.ActionB.Text = "Действие";
            this.ActionB.UseVisualStyleBackColor = false;
            this.ActionB.Click += new System.EventHandler(this.ActionB_Click);
            // 
            // textId
            // 
            this.textId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textId.Location = new System.Drawing.Point(1278, 67);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(109, 30);
            this.textId.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1241, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1399, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.ActionB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FigY);
            this.Controls.Add(this.FigX);
            this.Controls.Add(this.textY);
            this.Controls.Add(this.textX);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.MoveB);
            this.Controls.Add(this.RepB);
            this.Controls.Add(this.DelB);
            this.Controls.Add(this.FigB);
            this.Controls.Add(this.Figure);
            this.Controls.Add(this.Palitlabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NizPalitlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "Paint";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NizPalitlabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Palitlabel;
        private System.Windows.Forms.Panel Figure;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FigB;
        private System.Windows.Forms.Button DelB;
        private System.Windows.Forms.Button RepB;
        private System.Windows.Forms.Button MoveB;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Label FigX;
        private System.Windows.Forms.Label FigY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ActionB;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textX;
        public System.Windows.Forms.TextBox textY;
        public System.Windows.Forms.TextBox textId;
    }
}

