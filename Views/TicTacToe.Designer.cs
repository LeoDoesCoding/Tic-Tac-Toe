namespace TicTacToe {
    partial class TicTacToe {
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent() {
            gridLayout = new TableLayoutPanel();
            //Grid spaces. Buttons are no good here, as the Button's automatic style invalidations mess with the line drawing in controls.
            space1 = new PictureBox();
            space2 = new PictureBox();
            space3 = new PictureBox();
            space4 = new PictureBox();
            space5 = new PictureBox();
            space6 = new PictureBox();
            space7 = new PictureBox();
            space8 = new PictureBox();
            space9 = new PictureBox();
            commentary = new Label();
            gridLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)space1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)space2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)space3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)space4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)space5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)space6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)space7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)space8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)space9).BeginInit();
            SuspendLayout();
            // 
            // gridLayout
            // 
            gridLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            gridLayout.ColumnCount = 3;
            gridLayout.ColumnStyles.Add(new ColumnStyle());
            gridLayout.ColumnStyles.Add(new ColumnStyle());
            gridLayout.ColumnStyles.Add(new ColumnStyle());
            gridLayout.Controls.Add(space1, 0, 0);
            gridLayout.Controls.Add(space2, 1, 0);
            gridLayout.Controls.Add(space3, 2, 0);
            gridLayout.Controls.Add(space4, 0, 1);
            gridLayout.Controls.Add(space5, 1, 1);
            gridLayout.Controls.Add(space6, 2, 1);
            gridLayout.Controls.Add(space7, 0, 2);
            gridLayout.Controls.Add(space8, 1, 2);
            gridLayout.Controls.Add(space9, 2, 2);
            gridLayout.Location = new Point(222, 67);
            gridLayout.Name = "gridLayout";
            gridLayout.RowCount = 4;
            gridLayout.RowStyles.Add(new RowStyle());
            gridLayout.RowStyles.Add(new RowStyle());
            gridLayout.RowStyles.Add(new RowStyle());
            gridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            gridLayout.Size = new Size(370, 368); //It's painful, but trust me, it is correct.
            gridLayout.TabIndex = 0;
            gridLayout.Paint += gridLayout_Paint;
            // 
            // space1
            // 
            space1.BackColor = Color.Transparent;
            space1.BackgroundImageLayout = ImageLayout.Center;
            space1.Location = new Point(2, 2);
            space1.Margin = new Padding(0);
            space1.Name = "space1";
            space1.Size = new Size(120, 120);
            space1.TabIndex = 1;
            space1.TabStop = false;
            space1.Click += Space_Click;
            space1.Paint += Space_Paint;
            // 
            // space2
            // 
            space2.BackColor = Color.Transparent;
            space2.BackgroundImageLayout = ImageLayout.Center;
            space2.Location = new Point(124, 2);
            space2.Margin = new Padding(0);
            space2.Name = "space2";
            space2.Size = new Size(120, 120);
            space2.TabIndex = 1;
            space2.TabStop = false;
            space2.Click += Space_Click;
            space2.Paint += Space_Paint;
            // 
            // space3
            // 
            space3.BackColor = Color.Transparent;
            space3.BackgroundImageLayout = ImageLayout.Center;
            space3.Location = new Point(246, 2);
            space3.Margin = new Padding(0);
            space3.Name = "space3";
            space3.Size = new Size(120, 120);
            space3.TabIndex = 1;
            space3.TabStop = false;
            space3.Click += Space_Click;
            space3.Paint += Space_Paint;
            // 
            // space4
            // 
            space4.BackColor = Color.Transparent;
            space4.BackgroundImageLayout = ImageLayout.Center;
            space4.Location = new Point(2, 124);
            space4.Margin = new Padding(0);
            space4.Name = "space4";
            space4.Size = new Size(120, 120);
            space4.TabIndex = 1;
            space4.TabStop = false;
            space4.Click += Space_Click;
            space4.Paint += Space_Paint;
            // 
            // space5
            // 
            space5.BackColor = Color.Transparent;
            space5.BackgroundImageLayout = ImageLayout.Center;
            space5.Location = new Point(124, 124);
            space5.Margin = new Padding(0);
            space5.Name = "space5";
            space5.Size = new Size(120, 120);
            space5.TabIndex = 1;
            space5.TabStop = false;
            space5.Click += Space_Click;
            space5.Paint += Space_Paint;
            // 
            // space6
            // 
            space6.BackColor = Color.Transparent;
            space6.BackgroundImageLayout = ImageLayout.Center;
            space6.Location = new Point(246, 124);
            space6.Margin = new Padding(0);
            space6.Name = "space6";
            space6.Size = new Size(120, 120);
            space6.TabIndex = 1;
            space6.TabStop = false;
            space6.Click += Space_Click;
            space6.Paint += Space_Paint;
            // 
            // space7
            // 
            space7.BackColor = Color.Transparent;
            space7.BackgroundImageLayout = ImageLayout.Center;
            space7.Location = new Point(2, 246);
            space7.Margin = new Padding(0);
            space7.Name = "space7";
            space7.Size = new Size(120, 120);
            space7.TabIndex = 1;
            space7.TabStop = false;
            space7.Click += Space_Click;
            space7.Paint += Space_Paint;
            // 
            // space8
            // 
            space8.BackColor = Color.Transparent;
            space8.BackgroundImageLayout = ImageLayout.Center;
            space8.Location = new Point(124, 246);
            space8.Margin = new Padding(0);
            space8.Name = "space8";
            space8.Size = new Size(120, 120);
            space8.TabIndex = 1;
            space8.TabStop = false;
            space8.Click += Space_Click;
            space8.Paint += Space_Paint;
            // 
            // space9
            // 
            space9.BackColor = Color.Transparent;
            space9.BackgroundImageLayout = ImageLayout.Center;
            space9.Location = new Point(246, 246);
            space9.Margin = new Padding(0);
            space9.Name = "space9";
            space9.Size = new Size(120, 120);
            space9.TabIndex = 1;
            space9.TabStop = false;
            space9.Click += Space_Click;
            space9.Paint += Space_Paint;
            // 
            // commentary
            // 
            commentary.AutoSize = true;
            commentary.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            commentary.Location = new Point(12, 11);
            commentary.Name = "commentary";
            commentary.Size = new Size(143, 38);
            commentary.TabIndex = 2;
            commentary.Text = "It is Xs go.";
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(commentary);
            Controls.Add(gridLayout);
            Name = "TicTacToe";
            Text = "TicTacToe";
            Load += TicTacToe_Load;
            gridLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)space1).EndInit();
            ((System.ComponentModel.ISupportInitialize)space2).EndInit();
            ((System.ComponentModel.ISupportInitialize)space3).EndInit();
            ((System.ComponentModel.ISupportInitialize)space4).EndInit();
            ((System.ComponentModel.ISupportInitialize)space5).EndInit();
            ((System.ComponentModel.ISupportInitialize)space6).EndInit();
            ((System.ComponentModel.ISupportInitialize)space7).EndInit();
            ((System.ComponentModel.ISupportInitialize)space8).EndInit();
            ((System.ComponentModel.ISupportInitialize)space9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox space1;
        private PictureBox space2;
        private PictureBox space3;
        private PictureBox space4;
        private PictureBox space5;
        private PictureBox space6;
        private PictureBox space7;
        private PictureBox space8;
        private PictureBox space9;
        private TableLayoutPanel gridLayout;
        private Label commentary;
    }
}