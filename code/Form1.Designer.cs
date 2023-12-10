namespace pkglab62
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bResetPicture = new System.Windows.Forms.Button();
            this.bResetAffine = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OOx = new System.Windows.Forms.NumericUpDown();
            this.OOy = new System.Windows.Forms.NumericUpDown();
            this.OOz = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bTranslate = new System.Windows.Forms.Button();
            this.bDist = new System.Windows.Forms.Button();
            this.numUDDist = new System.Windows.Forms.NumericUpDown();
            this.bScale = new System.Windows.Forms.Button();
            this.numUDScale = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numUDTranslateOx = new System.Windows.Forms.NumericUpDown();
            this.numUDTranslateOy = new System.Windows.Forms.NumericUpDown();
            this.numUDTranslateOz = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.rbh = new System.Windows.Forms.RadioButton();
            this.rbp = new System.Windows.Forms.RadioButton();
            this.rbn = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tb00 = new System.Windows.Forms.TextBox();
            this.tb01 = new System.Windows.Forms.TextBox();
            this.tb02 = new System.Windows.Forms.TextBox();
            this.tb03 = new System.Windows.Forms.TextBox();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.tb11 = new System.Windows.Forms.TextBox();
            this.tb12 = new System.Windows.Forms.TextBox();
            this.tb13 = new System.Windows.Forms.TextBox();
            this.tb20 = new System.Windows.Forms.TextBox();
            this.tb21 = new System.Windows.Forms.TextBox();
            this.tb22 = new System.Windows.Forms.TextBox();
            this.tb23 = new System.Windows.Forms.TextBox();
            this.tb30 = new System.Windows.Forms.TextBox();
            this.tb31 = new System.Windows.Forms.TextBox();
            this.tb32 = new System.Windows.Forms.TextBox();
            this.tb33 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GOx = new System.Windows.Forms.NumericUpDown();
            this.GOy = new System.Windows.Forms.NumericUpDown();
            this.GOz = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OOx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OOy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OOz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDScale)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTranslateOx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTranslateOy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTranslateOz)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GOx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GOy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GOz)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.bResetPicture);
            this.panel1.Controls.Add(this.bResetAffine);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.bTranslate);
            this.panel1.Controls.Add(this.bDist);
            this.panel1.Controls.Add(this.numUDDist);
            this.panel1.Controls.Add(this.bScale);
            this.panel1.Controls.Add(this.numUDScale);
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(547, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 450);
            this.panel1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(147, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 30);
            this.label12.TabIndex = 13;
            this.label12.Text = "Вращение системы \r\n         координат";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(9, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Вращение объекта";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(201, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Проекция";
            // 
            // bResetPicture
            // 
            this.bResetPicture.BackColor = System.Drawing.Color.LightGreen;
            this.bResetPicture.Location = new System.Drawing.Point(3, 424);
            this.bResetPicture.Name = "bResetPicture";
            this.bResetPicture.Size = new System.Drawing.Size(148, 23);
            this.bResetPicture.TabIndex = 10;
            this.bResetPicture.Text = "Начальный набдюдатель";
            this.bResetPicture.UseVisualStyleBackColor = false;
            this.bResetPicture.Click += new System.EventHandler(this.bResetPicture_Click);
            // 
            // bResetAffine
            // 
            this.bResetAffine.BackColor = System.Drawing.Color.LightGreen;
            this.bResetAffine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bResetAffine.Location = new System.Drawing.Point(150, 424);
            this.bResetAffine.Name = "bResetAffine";
            this.bResetAffine.Size = new System.Drawing.Size(142, 23);
            this.bResetAffine.TabIndex = 9;
            this.bResetAffine.Text = "Начальный объект";
            this.bResetAffine.UseVisualStyleBackColor = false;
            this.bResetAffine.Click += new System.EventHandler(this.bResetAffine_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.33334F));
            this.tableLayoutPanel1.Controls.Add(this.OOx, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.OOy, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.OOz, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 183);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(121, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // OOx
            // 
            this.OOx.Location = new System.Drawing.Point(29, 3);
            this.OOx.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.OOx.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.OOx.Name = "OOx";
            this.OOx.Size = new System.Drawing.Size(89, 20);
            this.OOx.TabIndex = 0;
            this.OOx.ValueChanged += new System.EventHandler(this.tbObjectAngles_ValueChanged);
            // 
            // OOy
            // 
            this.OOy.Location = new System.Drawing.Point(29, 36);
            this.OOy.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.OOy.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.OOy.Name = "OOy";
            this.OOy.Size = new System.Drawing.Size(89, 20);
            this.OOy.TabIndex = 1;
            this.OOy.ValueChanged += new System.EventHandler(this.tbObjectAngles_ValueChanged);
            // 
            // OOz
            // 
            this.OOz.Location = new System.Drawing.Point(29, 69);
            this.OOz.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.OOz.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.OOz.Name = "OOz";
            this.OOz.Size = new System.Drawing.Size(89, 20);
            this.OOz.TabIndex = 2;
            this.OOz.ValueChanged += new System.EventHandler(this.tbObjectAngles_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oz";
            // 
            // bTranslate
            // 
            this.bTranslate.BackColor = System.Drawing.Color.OliveDrab;
            this.bTranslate.Location = new System.Drawing.Point(6, 395);
            this.bTranslate.Name = "bTranslate";
            this.bTranslate.Size = new System.Drawing.Size(88, 23);
            this.bTranslate.TabIndex = 8;
            this.bTranslate.Text = "Перенести";
            this.bTranslate.UseVisualStyleBackColor = false;
            this.bTranslate.Click += new System.EventHandler(this.bTranslate_Click);
            // 
            // bDist
            // 
            this.bDist.BackColor = System.Drawing.Color.OliveDrab;
            this.bDist.Location = new System.Drawing.Point(204, 357);
            this.bDist.Name = "bDist";
            this.bDist.Size = new System.Drawing.Size(68, 23);
            this.bDist.TabIndex = 7;
            this.bDist.Text = "Изменить";
            this.bDist.UseVisualStyleBackColor = false;
            this.bDist.Click += new System.EventHandler(this.bDist_Click);
            // 
            // numUDDist
            // 
            this.numUDDist.Location = new System.Drawing.Point(204, 331);
            this.numUDDist.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUDDist.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDDist.Name = "numUDDist";
            this.numUDDist.Size = new System.Drawing.Size(66, 20);
            this.numUDDist.TabIndex = 6;
            this.numUDDist.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bScale
            // 
            this.bScale.BackColor = System.Drawing.Color.OliveDrab;
            this.bScale.Location = new System.Drawing.Point(119, 357);
            this.bScale.Name = "bScale";
            this.bScale.Size = new System.Drawing.Size(66, 23);
            this.bScale.TabIndex = 5;
            this.bScale.Text = "Изменить";
            this.bScale.UseVisualStyleBackColor = false;
            this.bScale.Click += new System.EventHandler(this.bScale_Click);
            // 
            // numUDScale
            // 
            this.numUDScale.DecimalPlaces = 2;
            this.numUDScale.Location = new System.Drawing.Point(119, 331);
            this.numUDScale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUDScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numUDScale.Name = "numUDScale";
            this.numUDScale.Size = new System.Drawing.Size(66, 20);
            this.numUDScale.TabIndex = 4;
            this.numUDScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.numUDTranslateOx, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.numUDTranslateOy, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.numUDTranslateOz, 1, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 307);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(88, 82);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "z";
            // 
            // numUDTranslateOx
            // 
            this.numUDTranslateOx.Location = new System.Drawing.Point(21, 3);
            this.numUDTranslateOx.Name = "numUDTranslateOx";
            this.numUDTranslateOx.Size = new System.Drawing.Size(58, 20);
            this.numUDTranslateOx.TabIndex = 3;
            // 
            // numUDTranslateOy
            // 
            this.numUDTranslateOy.Location = new System.Drawing.Point(21, 29);
            this.numUDTranslateOy.Name = "numUDTranslateOy";
            this.numUDTranslateOy.Size = new System.Drawing.Size(58, 20);
            this.numUDTranslateOy.TabIndex = 4;
            // 
            // numUDTranslateOz
            // 
            this.numUDTranslateOz.Location = new System.Drawing.Point(21, 55);
            this.numUDTranslateOz.Name = "numUDTranslateOz";
            this.numUDTranslateOz.Size = new System.Drawing.Size(58, 20);
            this.numUDTranslateOz.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.rbf, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rbh, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.rbp, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.rbn, 0, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(194, 28);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(86, 94);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbf.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbf.Location = new System.Drawing.Point(3, 3);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(61, 17);
            this.rbf.TabIndex = 0;
            this.rbf.Text = "frontal";
            this.rbf.UseVisualStyleBackColor = true;
            this.rbf.CheckedChanged += new System.EventHandler(this.rbf_CheckedChanged);
            // 
            // rbh
            // 
            this.rbh.AutoSize = true;
            this.rbh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbh.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbh.Location = new System.Drawing.Point(3, 26);
            this.rbh.Name = "rbh";
            this.rbh.Size = new System.Drawing.Size(80, 17);
            this.rbh.TabIndex = 2;
            this.rbh.Text = "horizontal";
            this.rbh.UseVisualStyleBackColor = true;
            this.rbh.CheckedChanged += new System.EventHandler(this.rbh_CheckedChanged);
            // 
            // rbp
            // 
            this.rbp.AutoSize = true;
            this.rbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbp.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbp.Location = new System.Drawing.Point(3, 49);
            this.rbp.Name = "rbp";
            this.rbp.Size = new System.Drawing.Size(60, 17);
            this.rbp.TabIndex = 1;
            this.rbp.Text = "profile";
            this.rbp.UseVisualStyleBackColor = true;
            this.rbp.CheckedChanged += new System.EventHandler(this.rbp_CheckedChanged);
            // 
            // rbn
            // 
            this.rbn.AutoSize = true;
            this.rbn.Checked = true;
            this.rbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbn.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbn.Location = new System.Drawing.Point(3, 72);
            this.rbn.Name = "rbn";
            this.rbn.Size = new System.Drawing.Size(53, 17);
            this.rbn.TabIndex = 3;
            this.rbn.TabStop = true;
            this.rbn.Text = "none";
            this.rbn.UseVisualStyleBackColor = true;
            this.rbn.CheckedChanged += new System.EventHandler(this.rbn_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.tb00, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb01, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb02, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb03, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb11, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb12, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb13, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb20, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb21, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb22, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb23, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb30, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb31, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb32, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb33, 3, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(182, 130);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tb00
            // 
            this.tb00.Location = new System.Drawing.Point(3, 3);
            this.tb00.Name = "tb00";
            this.tb00.Size = new System.Drawing.Size(39, 20);
            this.tb00.TabIndex = 0;
            // 
            // tb01
            // 
            this.tb01.Location = new System.Drawing.Point(48, 3);
            this.tb01.Name = "tb01";
            this.tb01.Size = new System.Drawing.Size(39, 20);
            this.tb01.TabIndex = 1;
            // 
            // tb02
            // 
            this.tb02.Location = new System.Drawing.Point(93, 3);
            this.tb02.Name = "tb02";
            this.tb02.Size = new System.Drawing.Size(39, 20);
            this.tb02.TabIndex = 2;
            // 
            // tb03
            // 
            this.tb03.Location = new System.Drawing.Point(138, 3);
            this.tb03.Name = "tb03";
            this.tb03.Size = new System.Drawing.Size(41, 20);
            this.tb03.TabIndex = 3;
            // 
            // tb10
            // 
            this.tb10.Location = new System.Drawing.Point(3, 35);
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(39, 20);
            this.tb10.TabIndex = 4;
            // 
            // tb11
            // 
            this.tb11.Location = new System.Drawing.Point(48, 35);
            this.tb11.Name = "tb11";
            this.tb11.Size = new System.Drawing.Size(39, 20);
            this.tb11.TabIndex = 5;
            // 
            // tb12
            // 
            this.tb12.Location = new System.Drawing.Point(93, 35);
            this.tb12.Name = "tb12";
            this.tb12.Size = new System.Drawing.Size(39, 20);
            this.tb12.TabIndex = 6;
            // 
            // tb13
            // 
            this.tb13.Location = new System.Drawing.Point(138, 35);
            this.tb13.Name = "tb13";
            this.tb13.Size = new System.Drawing.Size(41, 20);
            this.tb13.TabIndex = 7;
            // 
            // tb20
            // 
            this.tb20.Location = new System.Drawing.Point(3, 67);
            this.tb20.Name = "tb20";
            this.tb20.Size = new System.Drawing.Size(39, 20);
            this.tb20.TabIndex = 8;
            // 
            // tb21
            // 
            this.tb21.Location = new System.Drawing.Point(48, 67);
            this.tb21.Name = "tb21";
            this.tb21.Size = new System.Drawing.Size(39, 20);
            this.tb21.TabIndex = 9;
            // 
            // tb22
            // 
            this.tb22.Location = new System.Drawing.Point(93, 67);
            this.tb22.Name = "tb22";
            this.tb22.Size = new System.Drawing.Size(39, 20);
            this.tb22.TabIndex = 10;
            // 
            // tb23
            // 
            this.tb23.Location = new System.Drawing.Point(138, 67);
            this.tb23.Name = "tb23";
            this.tb23.Size = new System.Drawing.Size(41, 20);
            this.tb23.TabIndex = 11;
            // 
            // tb30
            // 
            this.tb30.Location = new System.Drawing.Point(3, 99);
            this.tb30.Name = "tb30";
            this.tb30.Size = new System.Drawing.Size(39, 20);
            this.tb30.TabIndex = 12;
            // 
            // tb31
            // 
            this.tb31.Location = new System.Drawing.Point(48, 99);
            this.tb31.Name = "tb31";
            this.tb31.Size = new System.Drawing.Size(39, 20);
            this.tb31.TabIndex = 13;
            // 
            // tb32
            // 
            this.tb32.Location = new System.Drawing.Point(93, 99);
            this.tb32.Name = "tb32";
            this.tb32.Size = new System.Drawing.Size(39, 20);
            this.tb32.TabIndex = 14;
            // 
            // tb33
            // 
            this.tb33.Location = new System.Drawing.Point(138, 99);
            this.tb33.Name = "tb33";
            this.tb33.Size = new System.Drawing.Size(41, 20);
            this.tb33.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0339F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.9661F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.GOx, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.GOy, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.GOz, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(152, 183);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.09836F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.90164F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(118, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ox";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Oy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Oz";
            // 
            // GOx
            // 
            this.GOx.Location = new System.Drawing.Point(29, 3);
            this.GOx.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.GOx.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.GOx.Name = "GOx";
            this.GOx.Size = new System.Drawing.Size(86, 20);
            this.GOx.TabIndex = 3;
            this.GOx.ValueChanged += new System.EventHandler(this.tbGlobalAngles_ValueChanged);
            // 
            // GOy
            // 
            this.GOy.Location = new System.Drawing.Point(29, 38);
            this.GOy.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.GOy.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.GOy.Name = "GOy";
            this.GOy.Size = new System.Drawing.Size(86, 20);
            this.GOy.TabIndex = 4;
            this.GOy.ValueChanged += new System.EventHandler(this.tbGlobalAngles_ValueChanged);
            // 
            // GOz
            // 
            this.GOz.Location = new System.Drawing.Point(29, 68);
            this.GOz.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.GOz.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.GOz.Name = "GOz";
            this.GOz.Size = new System.Drawing.Size(86, 20);
            this.GOz.TabIndex = 5;
            this.GOz.ValueChanged += new System.EventHandler(this.tbGlobalAngles_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(18, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Перенос";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(116, 307);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "Масштаб";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(186, 307);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 15);
            this.label15.TabIndex = 16;
            this.label15.Text = "Наблюдатель";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Lab6";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OOx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OOy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OOz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDScale)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTranslateOx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTranslateOy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTranslateOz)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GOx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GOy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GOz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown OOx;
        private System.Windows.Forms.NumericUpDown OOy;
        private System.Windows.Forms.NumericUpDown OOz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tb00;
        private System.Windows.Forms.TextBox tb01;
        private System.Windows.Forms.TextBox tb02;
        private System.Windows.Forms.TextBox tb03;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb11;
        private System.Windows.Forms.TextBox tb12;
        private System.Windows.Forms.TextBox tb13;
        private System.Windows.Forms.TextBox tb20;
        private System.Windows.Forms.TextBox tb21;
        private System.Windows.Forms.TextBox tb22;
        private System.Windows.Forms.TextBox tb23;
        private System.Windows.Forms.TextBox tb30;
        private System.Windows.Forms.TextBox tb31;
        private System.Windows.Forms.TextBox tb32;
        private System.Windows.Forms.TextBox tb33;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown GOx;
        private System.Windows.Forms.NumericUpDown GOy;
        private System.Windows.Forms.NumericUpDown GOz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.RadioButton rbp;
        private System.Windows.Forms.RadioButton rbh;
        private System.Windows.Forms.RadioButton rbn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numUDTranslateOx;
        private System.Windows.Forms.NumericUpDown numUDTranslateOy;
        private System.Windows.Forms.NumericUpDown numUDTranslateOz;
        private System.Windows.Forms.NumericUpDown numUDScale;
        private System.Windows.Forms.Button bScale;
        private System.Windows.Forms.NumericUpDown numUDDist;
        private System.Windows.Forms.Button bDist;
        private System.Windows.Forms.Button bTranslate;
        private System.Windows.Forms.Button bResetPicture;
        private System.Windows.Forms.Button bResetAffine;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

