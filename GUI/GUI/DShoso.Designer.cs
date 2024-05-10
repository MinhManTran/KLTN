namespace GUI
{
    partial class frmDShoso
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            dtgHosott = new DataGridView();
            btnXoa = new Button();
            btnChitiet = new Button();
            btnThem = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgHosott).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label1.Location = new Point(299, 35);
            label1.Name = "label1";
            label1.Size = new Size(199, 24);
            label1.TabIndex = 1;
            label1.Text = "Danh sách giảng viên";
            // 
            // dtgHosott
            // 
            dtgHosott.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgHosott.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgHosott.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgHosott.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtgHosott.DefaultCellStyle = dataGridViewCellStyle1;
            dtgHosott.Location = new Point(12, 142);
            dtgHosott.MultiSelect = false;
            dtgHosott.Name = "dtgHosott";
            dtgHosott.RowTemplate.Height = 30;
            dtgHosott.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgHosott.Size = new Size(776, 347);
            dtgHosott.TabIndex = 2;
            dtgHosott.CellContentClick += dtgHosott_CellContentClick;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.Tan;
            btnXoa.Location = new Point(699, 100);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(88, 24);
            btnXoa.TabIndex = 34;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnChitiet
            // 
            btnChitiet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChitiet.BackColor = Color.Tan;
            btnChitiet.Location = new Point(586, 100);
            btnChitiet.Name = "btnChitiet";
            btnChitiet.Size = new Size(88, 24);
            btnChitiet.TabIndex = 33;
            btnChitiet.Text = "Chi tiết";
            btnChitiet.UseVisualStyleBackColor = false;
            btnChitiet.Click += btnChitiet_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnThem.BackColor = Color.Tan;
            btnThem.Location = new Point(478, 100);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(88, 24);
            btnThem.TabIndex = 32;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.Tan;
            button1.Location = new Point(3, 12);
            button1.Name = "button1";
            button1.Size = new Size(88, 24);
            button1.TabIndex = 35;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmDShoso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 497);
            Controls.Add(button1);
            Controls.Add(btnXoa);
            Controls.Add(btnChitiet);
            Controls.Add(btnThem);
            Controls.Add(dtgHosott);
            Controls.Add(label1);
            Name = "frmDShoso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách hồ sơ";
            WindowState = FormWindowState.Maximized;
            Load += DShoso_Load;
            ((System.ComponentModel.ISupportInitialize)dtgHosott).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgHosott;
        private DataGridViewTextBoxColumn Hoten;
        private Button btnXoa;
        private Button btnChitiet;
        private Button btnThem;
        private Button button1;
    }
}