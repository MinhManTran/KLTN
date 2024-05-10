namespace GUI
{
    partial class frmLuongthuongphucap
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
            dtgLuong = new DataGridView();
            btnXoa = new Button();
            btnChitiet = new Button();
            btnThem = new Button();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgLuong).BeginInit();
            SuspendLayout();
            // 
            // dtgLuong
            // 
            dtgLuong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgLuong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtgLuong.DefaultCellStyle = dataGridViewCellStyle1;
            dtgLuong.Location = new Point(12, 103);
            dtgLuong.MultiSelect = false;
            dtgLuong.Name = "dtgLuong";
            dtgLuong.RowTemplate.Height = 30;
            dtgLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgLuong.Size = new Size(776, 347);
            dtgLuong.TabIndex = 3;
            dtgLuong.CellContentClick += dtgHosott_CellContentClick;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.Tan;
            btnXoa.Location = new Point(699, 60);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(88, 24);
            btnXoa.TabIndex = 37;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnChitiet
            // 
            btnChitiet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChitiet.BackColor = Color.Tan;
            btnChitiet.Location = new Point(586, 60);
            btnChitiet.Name = "btnChitiet";
            btnChitiet.Size = new Size(88, 24);
            btnChitiet.TabIndex = 36;
            btnChitiet.Text = "Chi tiết";
            btnChitiet.UseVisualStyleBackColor = false;
            btnChitiet.Click += btnChitiet_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnThem.BackColor = Color.Tan;
            btnThem.Location = new Point(478, 60);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(88, 24);
            btnThem.TabIndex = 35;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label1.Location = new Point(288, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 24);
            label1.TabIndex = 38;
            label1.Text = "Danh sách lương";
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.Tan;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(88, 24);
            button1.TabIndex = 39;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmLuongthuongphucap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnXoa);
            Controls.Add(btnChitiet);
            Controls.Add(btnThem);
            Controls.Add(dtgLuong);
            Name = "frmLuongthuongphucap";
            Text = "Lương thưởng phụ cấp";
            Load += frmLuongthuongphucap_Load;
            ((System.ComponentModel.ISupportInitialize)dtgLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgLuong;
        private Button btnXoa;
        private Button btnChitiet;
        private Button btnThem;
        private Label label1;
        private Button button1;
    }
}