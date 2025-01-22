
namespace kontor
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.digerchk = new Guna.UI2.WinForms.Guna2RadioButton();
            this.onbinchk = new Guna.UI2.WinForms.Guna2RadioButton();
            this.besbinchk = new Guna.UI2.WinForms.Guna2RadioButton();
            this.ucbinchk = new Guna.UI2.WinForms.Guna2RadioButton();
            this.ikibinchk = new Guna.UI2.WinForms.Guna2RadioButton();
            this.binchk = new Guna.UI2.WinForms.Guna2RadioButton();
            this.yuzkontorchk = new Guna.UI2.WinForms.Guna2RadioButton();
            this.ıkıyuzellichk = new Guna.UI2.WinForms.Guna2RadioButton();
            this.besyuzchk = new Guna.UI2.WinForms.Guna2RadioButton();
            this.kontoryuklebtn = new Guna.UI2.WinForms.Guna2Button();
            this.kontorsayitxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vnotxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kayitsayilbl = new System.Windows.Forms.Label();
            this.firmaisimtxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // digerchk
            // 
            this.digerchk.AutoSize = true;
            this.digerchk.Checked = true;
            this.digerchk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.digerchk.CheckedState.BorderThickness = 0;
            this.digerchk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.digerchk.CheckedState.InnerColor = System.Drawing.Color.White;
            this.digerchk.CheckedState.InnerOffset = -4;
            this.digerchk.Location = new System.Drawing.Point(300, 107);
            this.digerchk.Name = "digerchk";
            this.digerchk.Size = new System.Drawing.Size(50, 17);
            this.digerchk.TabIndex = 41;
            this.digerchk.TabStop = true;
            this.digerchk.Text = "Diğer";
            this.digerchk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.digerchk.UncheckedState.BorderThickness = 2;
            this.digerchk.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.digerchk.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.digerchk.CheckedChanged += new System.EventHandler(this.yuzkontorchk_CheckedChanged);
            // 
            // onbinchk
            // 
            this.onbinchk.AutoSize = true;
            this.onbinchk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.onbinchk.CheckedState.BorderThickness = 0;
            this.onbinchk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.onbinchk.CheckedState.InnerColor = System.Drawing.Color.White;
            this.onbinchk.CheckedState.InnerOffset = -4;
            this.onbinchk.Location = new System.Drawing.Point(300, 84);
            this.onbinchk.Name = "onbinchk";
            this.onbinchk.Size = new System.Drawing.Size(89, 17);
            this.onbinchk.TabIndex = 40;
            this.onbinchk.Text = "10000 Kontör";
            this.onbinchk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.onbinchk.UncheckedState.BorderThickness = 2;
            this.onbinchk.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.onbinchk.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.onbinchk.CheckedChanged += new System.EventHandler(this.yuzkontorchk_CheckedChanged);
            // 
            // besbinchk
            // 
            this.besbinchk.AutoSize = true;
            this.besbinchk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.besbinchk.CheckedState.BorderThickness = 0;
            this.besbinchk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.besbinchk.CheckedState.InnerColor = System.Drawing.Color.White;
            this.besbinchk.CheckedState.InnerOffset = -4;
            this.besbinchk.Location = new System.Drawing.Point(300, 61);
            this.besbinchk.Name = "besbinchk";
            this.besbinchk.Size = new System.Drawing.Size(83, 17);
            this.besbinchk.TabIndex = 39;
            this.besbinchk.Text = "5000 Kontör";
            this.besbinchk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.besbinchk.UncheckedState.BorderThickness = 2;
            this.besbinchk.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.besbinchk.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.besbinchk.CheckedChanged += new System.EventHandler(this.yuzkontorchk_CheckedChanged);
            // 
            // ucbinchk
            // 
            this.ucbinchk.AutoSize = true;
            this.ucbinchk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ucbinchk.CheckedState.BorderThickness = 0;
            this.ucbinchk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ucbinchk.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ucbinchk.CheckedState.InnerOffset = -4;
            this.ucbinchk.Location = new System.Drawing.Point(300, 38);
            this.ucbinchk.Name = "ucbinchk";
            this.ucbinchk.Size = new System.Drawing.Size(83, 17);
            this.ucbinchk.TabIndex = 38;
            this.ucbinchk.Text = "3000 Kontör";
            this.ucbinchk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ucbinchk.UncheckedState.BorderThickness = 2;
            this.ucbinchk.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ucbinchk.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.ucbinchk.CheckedChanged += new System.EventHandler(this.yuzkontorchk_CheckedChanged);
            // 
            // ikibinchk
            // 
            this.ikibinchk.AutoSize = true;
            this.ikibinchk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ikibinchk.CheckedState.BorderThickness = 0;
            this.ikibinchk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ikibinchk.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ikibinchk.CheckedState.InnerOffset = -4;
            this.ikibinchk.Location = new System.Drawing.Point(300, 15);
            this.ikibinchk.Name = "ikibinchk";
            this.ikibinchk.Size = new System.Drawing.Size(83, 17);
            this.ikibinchk.TabIndex = 37;
            this.ikibinchk.Text = "2000 Kontör";
            this.ikibinchk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ikibinchk.UncheckedState.BorderThickness = 2;
            this.ikibinchk.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ikibinchk.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.ikibinchk.CheckedChanged += new System.EventHandler(this.yuzkontorchk_CheckedChanged);
            // 
            // binchk
            // 
            this.binchk.AutoSize = true;
            this.binchk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.binchk.CheckedState.BorderThickness = 0;
            this.binchk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.binchk.CheckedState.InnerColor = System.Drawing.Color.White;
            this.binchk.CheckedState.InnerOffset = -4;
            this.binchk.Location = new System.Drawing.Point(207, 83);
            this.binchk.Name = "binchk";
            this.binchk.Size = new System.Drawing.Size(83, 17);
            this.binchk.TabIndex = 36;
            this.binchk.Text = "1000 Kontör";
            this.binchk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.binchk.UncheckedState.BorderThickness = 2;
            this.binchk.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.binchk.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.binchk.CheckedChanged += new System.EventHandler(this.yuzkontorchk_CheckedChanged);
            // 
            // yuzkontorchk
            // 
            this.yuzkontorchk.AutoSize = true;
            this.yuzkontorchk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yuzkontorchk.CheckedState.BorderThickness = 0;
            this.yuzkontorchk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yuzkontorchk.CheckedState.InnerColor = System.Drawing.Color.White;
            this.yuzkontorchk.CheckedState.InnerOffset = -4;
            this.yuzkontorchk.Location = new System.Drawing.Point(207, 15);
            this.yuzkontorchk.Name = "yuzkontorchk";
            this.yuzkontorchk.Size = new System.Drawing.Size(77, 17);
            this.yuzkontorchk.TabIndex = 35;
            this.yuzkontorchk.Text = "100 Kontör";
            this.yuzkontorchk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.yuzkontorchk.UncheckedState.BorderThickness = 2;
            this.yuzkontorchk.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.yuzkontorchk.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.yuzkontorchk.CheckedChanged += new System.EventHandler(this.yuzkontorchk_CheckedChanged);
            // 
            // ıkıyuzellichk
            // 
            this.ıkıyuzellichk.AutoSize = true;
            this.ıkıyuzellichk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ıkıyuzellichk.CheckedState.BorderThickness = 0;
            this.ıkıyuzellichk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ıkıyuzellichk.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ıkıyuzellichk.CheckedState.InnerOffset = -4;
            this.ıkıyuzellichk.Location = new System.Drawing.Point(207, 38);
            this.ıkıyuzellichk.Name = "ıkıyuzellichk";
            this.ıkıyuzellichk.Size = new System.Drawing.Size(77, 17);
            this.ıkıyuzellichk.TabIndex = 34;
            this.ıkıyuzellichk.Text = "250 Kontör";
            this.ıkıyuzellichk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ıkıyuzellichk.UncheckedState.BorderThickness = 2;
            this.ıkıyuzellichk.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ıkıyuzellichk.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.ıkıyuzellichk.CheckedChanged += new System.EventHandler(this.yuzkontorchk_CheckedChanged);
            // 
            // besyuzchk
            // 
            this.besyuzchk.AutoSize = true;
            this.besyuzchk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.besyuzchk.CheckedState.BorderThickness = 0;
            this.besyuzchk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.besyuzchk.CheckedState.InnerColor = System.Drawing.Color.White;
            this.besyuzchk.CheckedState.InnerOffset = -4;
            this.besyuzchk.Location = new System.Drawing.Point(207, 60);
            this.besyuzchk.Name = "besyuzchk";
            this.besyuzchk.Size = new System.Drawing.Size(77, 17);
            this.besyuzchk.TabIndex = 33;
            this.besyuzchk.Text = "500 Kontör";
            this.besyuzchk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.besyuzchk.UncheckedState.BorderThickness = 2;
            this.besyuzchk.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.besyuzchk.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.besyuzchk.CheckedChanged += new System.EventHandler(this.yuzkontorchk_CheckedChanged);
            // 
            // kontoryuklebtn
            // 
            this.kontoryuklebtn.Animated = true;
            this.kontoryuklebtn.AutoRoundedCorners = true;
            this.kontoryuklebtn.BorderRadius = 16;
            this.kontoryuklebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kontoryuklebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kontoryuklebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kontoryuklebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kontoryuklebtn.Enabled = false;
            this.kontoryuklebtn.FillColor = System.Drawing.Color.Black;
            this.kontoryuklebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kontoryuklebtn.ForeColor = System.Drawing.Color.White;
            this.kontoryuklebtn.Location = new System.Drawing.Point(545, 38);
            this.kontoryuklebtn.Name = "kontoryuklebtn";
            this.kontoryuklebtn.Size = new System.Drawing.Size(175, 34);
            this.kontoryuklebtn.TabIndex = 32;
            this.kontoryuklebtn.Text = "Yükle";
            this.kontoryuklebtn.Click += new System.EventHandler(this.kontoryuklebtn_Click);
            this.kontoryuklebtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kontorsayitxt_KeyDown);
            // 
            // kontorsayitxt
            // 
            this.kontorsayitxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kontorsayitxt.DefaultText = "";
            this.kontorsayitxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kontorsayitxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kontorsayitxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kontorsayitxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kontorsayitxt.Enabled = false;
            this.kontorsayitxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kontorsayitxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kontorsayitxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kontorsayitxt.Location = new System.Drawing.Point(402, 38);
            this.kontorsayitxt.MaxLength = 11;
            this.kontorsayitxt.Name = "kontorsayitxt";
            this.kontorsayitxt.PasswordChar = '\0';
            this.kontorsayitxt.PlaceholderText = "Kontör Sayısı";
            this.kontorsayitxt.SelectedText = "";
            this.kontorsayitxt.Size = new System.Drawing.Size(127, 34);
            this.kontorsayitxt.TabIndex = 31;
            this.kontorsayitxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kontorsayitxt.TextChanged += new System.EventHandler(this.vnotxt_TextChanged);
            this.kontorsayitxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kontorsayitxt_KeyDown);
            this.kontorsayitxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vnotxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Kontör Sayısı;";
            // 
            // vnotxt
            // 
            this.vnotxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vnotxt.DefaultText = "";
            this.vnotxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.vnotxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.vnotxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vnotxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vnotxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vnotxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vnotxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vnotxt.Location = new System.Drawing.Point(57, 38);
            this.vnotxt.MaxLength = 11;
            this.vnotxt.Name = "vnotxt";
            this.vnotxt.PasswordChar = '\0';
            this.vnotxt.PlaceholderText = "Vergi no/Tc giriniz.";
            this.vnotxt.SelectedText = "";
            this.vnotxt.Size = new System.Drawing.Size(127, 34);
            this.vnotxt.TabIndex = 29;
            this.vnotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vnotxt.TextChanged += new System.EventHandler(this.vnotxt_TextChanged);
            this.vnotxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kontorsayitxt_KeyDown);
            this.vnotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vnotxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Vergi Numarası/TC kimlik No;";
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 558);
            this.dataGridView1.TabIndex = 42;
            // 
            // kayitsayilbl
            // 
            this.kayitsayilbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kayitsayilbl.AutoSize = true;
            this.kayitsayilbl.Location = new System.Drawing.Point(12, 107);
            this.kayitsayilbl.Name = "kayitsayilbl";
            this.kayitsayilbl.Size = new System.Drawing.Size(87, 13);
            this.kayitsayilbl.TabIndex = 43;
            this.kayitsayilbl.Text = "KAYIT SAYISI: 0";
            // 
            // firmaisimtxt
            // 
            this.firmaisimtxt.AutoSize = true;
            this.firmaisimtxt.Location = new System.Drawing.Point(2, 2);
            this.firmaisimtxt.Name = "firmaisimtxt";
            this.firmaisimtxt.Size = new System.Drawing.Size(53, 13);
            this.firmaisimtxt.TabIndex = 45;
            this.firmaisimtxt.Text = "Firma Adı:";
            this.firmaisimtxt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 129);
            this.Controls.Add(this.firmaisimtxt);
            this.Controls.Add(this.kayitsayilbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.digerchk);
            this.Controls.Add(this.onbinchk);
            this.Controls.Add(this.besbinchk);
            this.Controls.Add(this.ucbinchk);
            this.Controls.Add(this.ikibinchk);
            this.Controls.Add(this.binchk);
            this.Controls.Add(this.yuzkontorchk);
            this.Controls.Add(this.ıkıyuzellichk);
            this.Controls.Add(this.besyuzchk);
            this.Controls.Add(this.kontoryuklebtn);
            this.Controls.Add(this.kontorsayitxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vnotxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontür Yükleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2RadioButton digerchk;
        private Guna.UI2.WinForms.Guna2RadioButton onbinchk;
        private Guna.UI2.WinForms.Guna2RadioButton besbinchk;
        private Guna.UI2.WinForms.Guna2RadioButton ucbinchk;
        private Guna.UI2.WinForms.Guna2RadioButton ikibinchk;
        private Guna.UI2.WinForms.Guna2RadioButton binchk;
        private Guna.UI2.WinForms.Guna2RadioButton yuzkontorchk;
        private Guna.UI2.WinForms.Guna2RadioButton ıkıyuzellichk;
        private Guna.UI2.WinForms.Guna2RadioButton besyuzchk;
        private Guna.UI2.WinForms.Guna2Button kontoryuklebtn;
        private Guna.UI2.WinForms.Guna2TextBox kontorsayitxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        public Guna.UI2.WinForms.Guna2TextBox vnotxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label kayitsayilbl;
        private System.Windows.Forms.Label firmaisimtxt;
    }
}

