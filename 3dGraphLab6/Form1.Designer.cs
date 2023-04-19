namespace _3dGraphLab6
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
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.sphere_stacks = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.sphere_slices = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.sphere_radius = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cyl_height = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cyl_stacks = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cyl_slices = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cyl_radius = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cube_size = new System.Windows.Forms.NumericUpDown();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tea_size = new System.Windows.Forms.NumericUpDown();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.con_height = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.con_stacks = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.con_slices = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.con_radius = new System.Windows.Forms.NumericUpDown();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.tor_radius2 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.tor_rings = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.tor_sides = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.tor_radius1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sphere_stacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sphere_slices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sphere_radius)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyl_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyl_stacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyl_slices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyl_radius)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cube_size)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tea_size)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.con_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.con_stacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.con_slices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.con_radius)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tor_radius2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tor_rings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tor_sides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tor_radius1)).BeginInit();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(12, 12);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(515, 426);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 1;
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(533, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Render wire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(533, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(280, 329);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.sphere_stacks);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.sphere_slices);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.sphere_radius);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(272, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сфера";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stacks";
            // 
            // sphere_stacks
            // 
            this.sphere_stacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sphere_stacks.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.sphere_stacks.Location = new System.Drawing.Point(111, 84);
            this.sphere_stacks.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.sphere_stacks.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.sphere_stacks.Name = "sphere_stacks";
            this.sphere_stacks.Size = new System.Drawing.Size(120, 31);
            this.sphere_stacks.TabIndex = 4;
            this.sphere_stacks.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slices";
            // 
            // sphere_slices
            // 
            this.sphere_slices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sphere_slices.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.sphere_slices.Location = new System.Drawing.Point(111, 47);
            this.sphere_slices.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.sphere_slices.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.sphere_slices.Name = "sphere_slices";
            this.sphere_slices.Size = new System.Drawing.Size(120, 31);
            this.sphere_slices.TabIndex = 2;
            this.sphere_slices.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Radius";
            // 
            // sphere_radius
            // 
            this.sphere_radius.DecimalPlaces = 2;
            this.sphere_radius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sphere_radius.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sphere_radius.Location = new System.Drawing.Point(111, 10);
            this.sphere_radius.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sphere_radius.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.sphere_radius.Name = "sphere_radius";
            this.sphere_radius.Size = new System.Drawing.Size(120, 31);
            this.sphere_radius.TabIndex = 0;
            this.sphere_radius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cyl_height);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cyl_stacks);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cyl_slices);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cyl_radius);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(272, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Цилиндр";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Height";
            // 
            // cyl_height
            // 
            this.cyl_height.DecimalPlaces = 2;
            this.cyl_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cyl_height.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.cyl_height.Location = new System.Drawing.Point(111, 48);
            this.cyl_height.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.cyl_height.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.cyl_height.Name = "cyl_height";
            this.cyl_height.Size = new System.Drawing.Size(120, 31);
            this.cyl_height.TabIndex = 12;
            this.cyl_height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stacks";
            // 
            // cyl_stacks
            // 
            this.cyl_stacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cyl_stacks.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.cyl_stacks.Location = new System.Drawing.Point(111, 122);
            this.cyl_stacks.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.cyl_stacks.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.cyl_stacks.Name = "cyl_stacks";
            this.cyl_stacks.Size = new System.Drawing.Size(120, 31);
            this.cyl_stacks.TabIndex = 10;
            this.cyl_stacks.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Slices";
            // 
            // cyl_slices
            // 
            this.cyl_slices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cyl_slices.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.cyl_slices.Location = new System.Drawing.Point(111, 85);
            this.cyl_slices.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.cyl_slices.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.cyl_slices.Name = "cyl_slices";
            this.cyl_slices.Size = new System.Drawing.Size(120, 31);
            this.cyl_slices.TabIndex = 8;
            this.cyl_slices.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Radius";
            // 
            // cyl_radius
            // 
            this.cyl_radius.DecimalPlaces = 2;
            this.cyl_radius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cyl_radius.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.cyl_radius.Location = new System.Drawing.Point(111, 11);
            this.cyl_radius.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cyl_radius.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.cyl_radius.Name = "cyl_radius";
            this.cyl_radius.Size = new System.Drawing.Size(120, 31);
            this.cyl_radius.TabIndex = 6;
            this.cyl_radius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.cube_size);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(272, 303);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Куб";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Size";
            // 
            // cube_size
            // 
            this.cube_size.DecimalPlaces = 2;
            this.cube_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cube_size.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.cube_size.Location = new System.Drawing.Point(111, 12);
            this.cube_size.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.cube_size.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.cube_size.Name = "cube_size";
            this.cube_size.Size = new System.Drawing.Size(120, 31);
            this.cube_size.TabIndex = 14;
            this.cube_size.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.tea_size);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(272, 303);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Чайник";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Size";
            // 
            // tea_size
            // 
            this.tea_size.DecimalPlaces = 2;
            this.tea_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tea_size.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tea_size.Location = new System.Drawing.Point(108, 8);
            this.tea_size.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.tea_size.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.tea_size.Name = "tea_size";
            this.tea_size.Size = new System.Drawing.Size(120, 31);
            this.tea_size.TabIndex = 16;
            this.tea_size.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.con_height);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.con_stacks);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.con_slices);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.con_radius);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(272, 303);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Конус";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Height";
            // 
            // con_height
            // 
            this.con_height.DecimalPlaces = 2;
            this.con_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.con_height.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.con_height.Location = new System.Drawing.Point(108, 47);
            this.con_height.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.con_height.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.con_height.Name = "con_height";
            this.con_height.Size = new System.Drawing.Size(120, 31);
            this.con_height.TabIndex = 20;
            this.con_height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Stacks";
            // 
            // con_stacks
            // 
            this.con_stacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.con_stacks.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.con_stacks.Location = new System.Drawing.Point(108, 121);
            this.con_stacks.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.con_stacks.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.con_stacks.Name = "con_stacks";
            this.con_stacks.Size = new System.Drawing.Size(120, 31);
            this.con_stacks.TabIndex = 18;
            this.con_stacks.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "Slices";
            // 
            // con_slices
            // 
            this.con_slices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.con_slices.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.con_slices.Location = new System.Drawing.Point(108, 84);
            this.con_slices.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.con_slices.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.con_slices.Name = "con_slices";
            this.con_slices.Size = new System.Drawing.Size(120, 31);
            this.con_slices.TabIndex = 16;
            this.con_slices.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(3, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 25);
            this.label13.TabIndex = 15;
            this.label13.Text = "Radius";
            // 
            // con_radius
            // 
            this.con_radius.DecimalPlaces = 2;
            this.con_radius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.con_radius.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.con_radius.Location = new System.Drawing.Point(108, 10);
            this.con_radius.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.con_radius.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.con_radius.Name = "con_radius";
            this.con_radius.Size = new System.Drawing.Size(120, 31);
            this.con_radius.TabIndex = 14;
            this.con_radius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Controls.Add(this.tor_radius2);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.tor_rings);
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.tor_sides);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.tor_radius1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(272, 303);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Тор";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(3, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Radius 2";
            // 
            // tor_radius2
            // 
            this.tor_radius2.DecimalPlaces = 2;
            this.tor_radius2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tor_radius2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tor_radius2.Location = new System.Drawing.Point(108, 45);
            this.tor_radius2.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.tor_radius2.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.tor_radius2.Name = "tor_radius2";
            this.tor_radius2.Size = new System.Drawing.Size(120, 31);
            this.tor_radius2.TabIndex = 28;
            this.tor_radius2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(3, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 25);
            this.label15.TabIndex = 27;
            this.label15.Text = "Rings";
            // 
            // tor_rings
            // 
            this.tor_rings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tor_rings.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.tor_rings.Location = new System.Drawing.Point(108, 119);
            this.tor_rings.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.tor_rings.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.tor_rings.Name = "tor_rings";
            this.tor_rings.Size = new System.Drawing.Size(120, 31);
            this.tor_rings.TabIndex = 26;
            this.tor_rings.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(3, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 25);
            this.label16.TabIndex = 25;
            this.label16.Text = "Sides";
            // 
            // tor_sides
            // 
            this.tor_sides.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tor_sides.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.tor_sides.Location = new System.Drawing.Point(108, 82);
            this.tor_sides.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.tor_sides.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.tor_sides.Name = "tor_sides";
            this.tor_sides.Size = new System.Drawing.Size(120, 31);
            this.tor_sides.TabIndex = 24;
            this.tor_sides.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(3, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 25);
            this.label17.TabIndex = 23;
            this.label17.Text = "Radius 1";
            // 
            // tor_radius1
            // 
            this.tor_radius1.DecimalPlaces = 2;
            this.tor_radius1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tor_radius1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tor_radius1.Location = new System.Drawing.Point(108, 8);
            this.tor_radius1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tor_radius1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.tor_radius1.Name = "tor_radius1";
            this.tor_radius1.Size = new System.Drawing.Size(120, 31);
            this.tor_radius1.TabIndex = 22;
            this.tor_radius1.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(774, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 42);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(533, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "Render solid";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Text = "Лаб 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sphere_stacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sphere_slices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sphere_radius)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyl_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyl_stacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyl_slices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyl_radius)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cube_size)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tea_size)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.con_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.con_stacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.con_slices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.con_radius)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tor_radius2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tor_rings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tor_sides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tor_radius1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sphere_stacks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sphere_slices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sphere_radius;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown cyl_height;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cyl_stacks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown cyl_slices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown cyl_radius;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown cube_size;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown tea_size;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown con_height;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown con_stacks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown con_slices;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown con_radius;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown tor_radius2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown tor_rings;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown tor_sides;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown tor_radius1;
        private System.Windows.Forms.Button button3;
    }
}

