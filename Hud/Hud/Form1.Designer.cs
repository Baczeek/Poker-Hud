namespace Hud
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.seat3Table1 = new System.Windows.Forms.TextBox();
            this.seat2Table1 = new System.Windows.Forms.TextBox();
            this.seat4Table1 = new System.Windows.Forms.TextBox();
            this.seat5Table1 = new System.Windows.Forms.TextBox();
            this.seat6Table1 = new System.Windows.Forms.TextBox();
            this.table1Name = new System.Windows.Forms.Label();
            this.table2Name = new System.Windows.Forms.Label();
            this.seat1Table2 = new System.Windows.Forms.TextBox();
            this.seat6Table2 = new System.Windows.Forms.TextBox();
            this.seat5Table2 = new System.Windows.Forms.TextBox();
            this.seat4Table2 = new System.Windows.Forms.TextBox();
            this.seat2Table2 = new System.Windows.Forms.TextBox();
            this.seat3Table2 = new System.Windows.Forms.TextBox();
            this.table3Name = new System.Windows.Forms.Label();
            this.seat1Table3 = new System.Windows.Forms.TextBox();
            this.seat6Table3 = new System.Windows.Forms.TextBox();
            this.seat5Table3 = new System.Windows.Forms.TextBox();
            this.seat4Table3 = new System.Windows.Forms.TextBox();
            this.seat2Table3 = new System.Windows.Forms.TextBox();
            this.seat3Table3 = new System.Windows.Forms.TextBox();
            this.table4Name = new System.Windows.Forms.Label();
            this.seat1Table4 = new System.Windows.Forms.TextBox();
            this.seat6Table4 = new System.Windows.Forms.TextBox();
            this.seat5Table4 = new System.Windows.Forms.TextBox();
            this.seat4Table4 = new System.Windows.Forms.TextBox();
            this.seat2Table4 = new System.Windows.Forms.TextBox();
            this.seat3Table4 = new System.Windows.Forms.TextBox();
            this.closeTable1 = new System.Windows.Forms.Button();
            this.closeTable2 = new System.Windows.Forms.Button();
            this.closeTable3 = new System.Windows.Forms.Button();
            this.closeTable4 = new System.Windows.Forms.Button();
            this.groupTable1 = new System.Windows.Forms.GroupBox();
            this.saveTable1 = new System.Windows.Forms.Button();
            this.seat1Table1 = new System.Windows.Forms.TextBox();
            this.groupTable2 = new System.Windows.Forms.GroupBox();
            this.saveTable2 = new System.Windows.Forms.Button();
            this.groupTable3 = new System.Windows.Forms.GroupBox();
            this.saveTable3 = new System.Windows.Forms.Button();
            this.groupTable4 = new System.Windows.Forms.GroupBox();
            this.saveTable4 = new System.Windows.Forms.Button();
            this.analyzeAllButton = new System.Windows.Forms.Button();
            this.playerButton = new System.Windows.Forms.Button();
            this.playerName = new System.Windows.Forms.TextBox();
            this.playerStats = new System.Windows.Forms.TextBox();
            this.historyPathButton = new System.Windows.Forms.Button();
            this.setupNickButton = new System.Windows.Forms.Button();
            this.mainPlayerNickname = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataPathButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hoverButton = new System.Windows.Forms.Button();
            this.controlGroup = new System.Windows.Forms.GroupBox();
            this.tableToSwap1 = new System.Windows.Forms.NumericUpDown();
            this.tableToSwap2 = new System.Windows.Forms.NumericUpDown();
            this.changeTables = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hudOnButton = new System.Windows.Forms.Button();
            this.createHud = new System.Windows.Forms.Button();
            this.groupTable1.SuspendLayout();
            this.groupTable2.SuspendLayout();
            this.groupTable3.SuspendLayout();
            this.groupTable4.SuspendLayout();
            this.controlGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableToSwap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableToSwap2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // seat3Table1
            // 
            this.seat3Table1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat3Table1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat3Table1.ForeColor = System.Drawing.Color.White;
            this.seat3Table1.Location = new System.Drawing.Point(25, 120);
            this.seat3Table1.Multiline = true;
            this.seat3Table1.Name = "seat3Table1";
            this.seat3Table1.Size = new System.Drawing.Size(175, 73);
            this.seat3Table1.TabIndex = 10;
            this.seat3Table1.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat2Table1
            // 
            this.seat2Table1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat2Table1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat2Table1.ForeColor = System.Drawing.Color.White;
            this.seat2Table1.Location = new System.Drawing.Point(25, 210);
            this.seat2Table1.Multiline = true;
            this.seat2Table1.Name = "seat2Table1";
            this.seat2Table1.Size = new System.Drawing.Size(175, 73);
            this.seat2Table1.TabIndex = 11;
            this.seat2Table1.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat4Table1
            // 
            this.seat4Table1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat4Table1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat4Table1.ForeColor = System.Drawing.Color.White;
            this.seat4Table1.Location = new System.Drawing.Point(133, 30);
            this.seat4Table1.Multiline = true;
            this.seat4Table1.Name = "seat4Table1";
            this.seat4Table1.Size = new System.Drawing.Size(175, 73);
            this.seat4Table1.TabIndex = 12;
            this.seat4Table1.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat5Table1
            // 
            this.seat5Table1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat5Table1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat5Table1.ForeColor = System.Drawing.Color.White;
            this.seat5Table1.Location = new System.Drawing.Point(253, 120);
            this.seat5Table1.Multiline = true;
            this.seat5Table1.Name = "seat5Table1";
            this.seat5Table1.Size = new System.Drawing.Size(175, 73);
            this.seat5Table1.TabIndex = 13;
            this.seat5Table1.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat6Table1
            // 
            this.seat6Table1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat6Table1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat6Table1.ForeColor = System.Drawing.Color.White;
            this.seat6Table1.Location = new System.Drawing.Point(253, 210);
            this.seat6Table1.Multiline = true;
            this.seat6Table1.Name = "seat6Table1";
            this.seat6Table1.Size = new System.Drawing.Size(175, 73);
            this.seat6Table1.TabIndex = 14;
            this.seat6Table1.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // table1Name
            // 
            this.table1Name.AutoSize = true;
            this.table1Name.ForeColor = System.Drawing.Color.White;
            this.table1Name.Location = new System.Drawing.Point(25, 33);
            this.table1Name.Name = "table1Name";
            this.table1Name.Size = new System.Drawing.Size(43, 13);
            this.table1Name.TabIndex = 17;
            this.table1Name.Text = "Table 1";
            // 
            // table2Name
            // 
            this.table2Name.AutoSize = true;
            this.table2Name.ForeColor = System.Drawing.Color.White;
            this.table2Name.Location = new System.Drawing.Point(25, 33);
            this.table2Name.Name = "table2Name";
            this.table2Name.Size = new System.Drawing.Size(43, 13);
            this.table2Name.TabIndex = 30;
            this.table2Name.Text = "Table 2";
            // 
            // seat1Table2
            // 
            this.seat1Table2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat1Table2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat1Table2.ForeColor = System.Drawing.Color.White;
            this.seat1Table2.Location = new System.Drawing.Point(133, 300);
            this.seat1Table2.Multiline = true;
            this.seat1Table2.Name = "seat1Table2";
            this.seat1Table2.Size = new System.Drawing.Size(175, 73);
            this.seat1Table2.TabIndex = 29;
            this.seat1Table2.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat6Table2
            // 
            this.seat6Table2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat6Table2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat6Table2.ForeColor = System.Drawing.Color.White;
            this.seat6Table2.Location = new System.Drawing.Point(253, 210);
            this.seat6Table2.Multiline = true;
            this.seat6Table2.Name = "seat6Table2";
            this.seat6Table2.Size = new System.Drawing.Size(175, 73);
            this.seat6Table2.TabIndex = 28;
            this.seat6Table2.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat5Table2
            // 
            this.seat5Table2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat5Table2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat5Table2.ForeColor = System.Drawing.Color.White;
            this.seat5Table2.Location = new System.Drawing.Point(253, 120);
            this.seat5Table2.Multiline = true;
            this.seat5Table2.Name = "seat5Table2";
            this.seat5Table2.Size = new System.Drawing.Size(175, 73);
            this.seat5Table2.TabIndex = 27;
            this.seat5Table2.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat4Table2
            // 
            this.seat4Table2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat4Table2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat4Table2.ForeColor = System.Drawing.Color.White;
            this.seat4Table2.Location = new System.Drawing.Point(133, 30);
            this.seat4Table2.Multiline = true;
            this.seat4Table2.Name = "seat4Table2";
            this.seat4Table2.Size = new System.Drawing.Size(175, 73);
            this.seat4Table2.TabIndex = 26;
            this.seat4Table2.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat2Table2
            // 
            this.seat2Table2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat2Table2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat2Table2.ForeColor = System.Drawing.Color.White;
            this.seat2Table2.Location = new System.Drawing.Point(25, 210);
            this.seat2Table2.Multiline = true;
            this.seat2Table2.Name = "seat2Table2";
            this.seat2Table2.Size = new System.Drawing.Size(175, 73);
            this.seat2Table2.TabIndex = 25;
            this.seat2Table2.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat3Table2
            // 
            this.seat3Table2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat3Table2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat3Table2.ForeColor = System.Drawing.Color.White;
            this.seat3Table2.Location = new System.Drawing.Point(25, 120);
            this.seat3Table2.Multiline = true;
            this.seat3Table2.Name = "seat3Table2";
            this.seat3Table2.Size = new System.Drawing.Size(175, 73);
            this.seat3Table2.TabIndex = 24;
            this.seat3Table2.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // table3Name
            // 
            this.table3Name.AutoSize = true;
            this.table3Name.ForeColor = System.Drawing.Color.White;
            this.table3Name.Location = new System.Drawing.Point(25, 33);
            this.table3Name.Name = "table3Name";
            this.table3Name.Size = new System.Drawing.Size(43, 13);
            this.table3Name.TabIndex = 43;
            this.table3Name.Text = "Table 3";
            // 
            // seat1Table3
            // 
            this.seat1Table3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat1Table3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat1Table3.ForeColor = System.Drawing.Color.White;
            this.seat1Table3.Location = new System.Drawing.Point(133, 300);
            this.seat1Table3.Multiline = true;
            this.seat1Table3.Name = "seat1Table3";
            this.seat1Table3.Size = new System.Drawing.Size(175, 73);
            this.seat1Table3.TabIndex = 42;
            this.seat1Table3.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat6Table3
            // 
            this.seat6Table3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat6Table3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat6Table3.ForeColor = System.Drawing.Color.White;
            this.seat6Table3.Location = new System.Drawing.Point(253, 210);
            this.seat6Table3.Multiline = true;
            this.seat6Table3.Name = "seat6Table3";
            this.seat6Table3.Size = new System.Drawing.Size(175, 73);
            this.seat6Table3.TabIndex = 41;
            this.seat6Table3.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat5Table3
            // 
            this.seat5Table3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat5Table3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat5Table3.ForeColor = System.Drawing.Color.White;
            this.seat5Table3.Location = new System.Drawing.Point(253, 120);
            this.seat5Table3.Multiline = true;
            this.seat5Table3.Name = "seat5Table3";
            this.seat5Table3.Size = new System.Drawing.Size(175, 73);
            this.seat5Table3.TabIndex = 40;
            this.seat5Table3.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat4Table3
            // 
            this.seat4Table3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat4Table3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat4Table3.ForeColor = System.Drawing.Color.White;
            this.seat4Table3.Location = new System.Drawing.Point(133, 30);
            this.seat4Table3.Multiline = true;
            this.seat4Table3.Name = "seat4Table3";
            this.seat4Table3.Size = new System.Drawing.Size(175, 73);
            this.seat4Table3.TabIndex = 39;
            this.seat4Table3.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat2Table3
            // 
            this.seat2Table3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat2Table3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat2Table3.ForeColor = System.Drawing.Color.White;
            this.seat2Table3.Location = new System.Drawing.Point(25, 210);
            this.seat2Table3.Multiline = true;
            this.seat2Table3.Name = "seat2Table3";
            this.seat2Table3.Size = new System.Drawing.Size(175, 73);
            this.seat2Table3.TabIndex = 38;
            this.seat2Table3.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat3Table3
            // 
            this.seat3Table3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat3Table3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat3Table3.ForeColor = System.Drawing.Color.White;
            this.seat3Table3.Location = new System.Drawing.Point(25, 120);
            this.seat3Table3.Multiline = true;
            this.seat3Table3.Name = "seat3Table3";
            this.seat3Table3.Size = new System.Drawing.Size(175, 73);
            this.seat3Table3.TabIndex = 37;
            this.seat3Table3.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // table4Name
            // 
            this.table4Name.AutoSize = true;
            this.table4Name.ForeColor = System.Drawing.Color.White;
            this.table4Name.Location = new System.Drawing.Point(25, 33);
            this.table4Name.Name = "table4Name";
            this.table4Name.Size = new System.Drawing.Size(43, 13);
            this.table4Name.TabIndex = 56;
            this.table4Name.Text = "Table 4";
            // 
            // seat1Table4
            // 
            this.seat1Table4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat1Table4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat1Table4.ForeColor = System.Drawing.Color.White;
            this.seat1Table4.Location = new System.Drawing.Point(133, 300);
            this.seat1Table4.Multiline = true;
            this.seat1Table4.Name = "seat1Table4";
            this.seat1Table4.Size = new System.Drawing.Size(175, 73);
            this.seat1Table4.TabIndex = 55;
            this.seat1Table4.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat6Table4
            // 
            this.seat6Table4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat6Table4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat6Table4.ForeColor = System.Drawing.Color.White;
            this.seat6Table4.Location = new System.Drawing.Point(253, 210);
            this.seat6Table4.Multiline = true;
            this.seat6Table4.Name = "seat6Table4";
            this.seat6Table4.Size = new System.Drawing.Size(175, 73);
            this.seat6Table4.TabIndex = 54;
            this.seat6Table4.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat5Table4
            // 
            this.seat5Table4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat5Table4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat5Table4.ForeColor = System.Drawing.Color.White;
            this.seat5Table4.Location = new System.Drawing.Point(253, 120);
            this.seat5Table4.Multiline = true;
            this.seat5Table4.Name = "seat5Table4";
            this.seat5Table4.Size = new System.Drawing.Size(175, 73);
            this.seat5Table4.TabIndex = 53;
            this.seat5Table4.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat4Table4
            // 
            this.seat4Table4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat4Table4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat4Table4.ForeColor = System.Drawing.Color.White;
            this.seat4Table4.Location = new System.Drawing.Point(133, 30);
            this.seat4Table4.Multiline = true;
            this.seat4Table4.Name = "seat4Table4";
            this.seat4Table4.Size = new System.Drawing.Size(175, 73);
            this.seat4Table4.TabIndex = 52;
            this.seat4Table4.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat2Table4
            // 
            this.seat2Table4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat2Table4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat2Table4.ForeColor = System.Drawing.Color.White;
            this.seat2Table4.Location = new System.Drawing.Point(25, 210);
            this.seat2Table4.Multiline = true;
            this.seat2Table4.Name = "seat2Table4";
            this.seat2Table4.Size = new System.Drawing.Size(175, 73);
            this.seat2Table4.TabIndex = 51;
            this.seat2Table4.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // seat3Table4
            // 
            this.seat3Table4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat3Table4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat3Table4.ForeColor = System.Drawing.Color.White;
            this.seat3Table4.Location = new System.Drawing.Point(25, 120);
            this.seat3Table4.Multiline = true;
            this.seat3Table4.Name = "seat3Table4";
            this.seat3Table4.Size = new System.Drawing.Size(175, 73);
            this.seat3Table4.TabIndex = 50;
            this.seat3Table4.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // closeTable1
            // 
            this.closeTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.closeTable1.ForeColor = System.Drawing.Color.White;
            this.closeTable1.Location = new System.Drawing.Point(25, 58);
            this.closeTable1.Name = "closeTable1";
            this.closeTable1.Size = new System.Drawing.Size(85, 23);
            this.closeTable1.TabIndex = 57;
            this.closeTable1.Text = "Zamknij stół";
            this.closeTable1.UseVisualStyleBackColor = false;
            this.closeTable1.Click += new System.EventHandler(this.ClearTableClick);
            // 
            // closeTable2
            // 
            this.closeTable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.closeTable2.ForeColor = System.Drawing.Color.White;
            this.closeTable2.Location = new System.Drawing.Point(25, 58);
            this.closeTable2.Name = "closeTable2";
            this.closeTable2.Size = new System.Drawing.Size(85, 23);
            this.closeTable2.TabIndex = 58;
            this.closeTable2.Text = "Zamknij stół";
            this.closeTable2.UseVisualStyleBackColor = false;
            this.closeTable2.Click += new System.EventHandler(this.ClearTableClick);
            // 
            // closeTable3
            // 
            this.closeTable3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.closeTable3.ForeColor = System.Drawing.Color.White;
            this.closeTable3.Location = new System.Drawing.Point(25, 58);
            this.closeTable3.Name = "closeTable3";
            this.closeTable3.Size = new System.Drawing.Size(85, 23);
            this.closeTable3.TabIndex = 59;
            this.closeTable3.Text = "Zamknij stół";
            this.closeTable3.UseVisualStyleBackColor = false;
            this.closeTable3.Click += new System.EventHandler(this.ClearTableClick);
            // 
            // closeTable4
            // 
            this.closeTable4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.closeTable4.ForeColor = System.Drawing.Color.White;
            this.closeTable4.Location = new System.Drawing.Point(25, 58);
            this.closeTable4.Name = "closeTable4";
            this.closeTable4.Size = new System.Drawing.Size(85, 23);
            this.closeTable4.TabIndex = 60;
            this.closeTable4.Text = "Zamknij stół";
            this.closeTable4.UseVisualStyleBackColor = false;
            this.closeTable4.Click += new System.EventHandler(this.ClearTableClick);
            // 
            // groupTable1
            // 
            this.groupTable1.Controls.Add(this.saveTable1);
            this.groupTable1.Controls.Add(this.seat6Table1);
            this.groupTable1.Controls.Add(this.closeTable1);
            this.groupTable1.Controls.Add(this.seat3Table1);
            this.groupTable1.Controls.Add(this.seat2Table1);
            this.groupTable1.Controls.Add(this.seat4Table1);
            this.groupTable1.Controls.Add(this.seat5Table1);
            this.groupTable1.Controls.Add(this.seat1Table1);
            this.groupTable1.Controls.Add(this.table1Name);
            this.groupTable1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupTable1.Location = new System.Drawing.Point(23, 16);
            this.groupTable1.Name = "groupTable1";
            this.groupTable1.Size = new System.Drawing.Size(452, 393);
            this.groupTable1.TabIndex = 61;
            this.groupTable1.TabStop = false;
            this.groupTable1.Text = "1";
            // 
            // saveTable1
            // 
            this.saveTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.saveTable1.ForeColor = System.Drawing.Color.White;
            this.saveTable1.Location = new System.Drawing.Point(342, 35);
            this.saveTable1.Name = "saveTable1";
            this.saveTable1.Size = new System.Drawing.Size(104, 23);
            this.saveTable1.TabIndex = 59;
            this.saveTable1.Text = "Zapisz rozdanie";
            this.saveTable1.UseVisualStyleBackColor = false;
            this.saveTable1.Visible = false;
            this.saveTable1.Click += new System.EventHandler(this.SaveLastHand);
            // 
            // seat1Table1
            // 
            this.seat1Table1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.seat1Table1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seat1Table1.ForeColor = System.Drawing.Color.White;
            this.seat1Table1.Location = new System.Drawing.Point(133, 300);
            this.seat1Table1.Multiline = true;
            this.seat1Table1.Name = "seat1Table1";
            this.seat1Table1.Size = new System.Drawing.Size(175, 73);
            this.seat1Table1.TabIndex = 15;
            this.seat1Table1.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // groupTable2
            // 
            this.groupTable2.Controls.Add(this.saveTable2);
            this.groupTable2.Controls.Add(this.seat4Table2);
            this.groupTable2.Controls.Add(this.closeTable2);
            this.groupTable2.Controls.Add(this.seat3Table2);
            this.groupTable2.Controls.Add(this.seat2Table2);
            this.groupTable2.Controls.Add(this.seat5Table2);
            this.groupTable2.Controls.Add(this.seat6Table2);
            this.groupTable2.Controls.Add(this.seat1Table2);
            this.groupTable2.Controls.Add(this.table2Name);
            this.groupTable2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupTable2.Location = new System.Drawing.Point(481, 16);
            this.groupTable2.Name = "groupTable2";
            this.groupTable2.Size = new System.Drawing.Size(452, 393);
            this.groupTable2.TabIndex = 62;
            this.groupTable2.TabStop = false;
            this.groupTable2.Text = "2";
            // 
            // saveTable2
            // 
            this.saveTable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.saveTable2.ForeColor = System.Drawing.Color.White;
            this.saveTable2.Location = new System.Drawing.Point(342, 35);
            this.saveTable2.Name = "saveTable2";
            this.saveTable2.Size = new System.Drawing.Size(104, 23);
            this.saveTable2.TabIndex = 60;
            this.saveTable2.Text = "Zapisz rozdanie";
            this.saveTable2.UseVisualStyleBackColor = false;
            this.saveTable2.Visible = false;
            this.saveTable2.Click += new System.EventHandler(this.SaveLastHand);
            // 
            // groupTable3
            // 
            this.groupTable3.Controls.Add(this.saveTable3);
            this.groupTable3.Controls.Add(this.seat5Table3);
            this.groupTable3.Controls.Add(this.closeTable3);
            this.groupTable3.Controls.Add(this.seat3Table3);
            this.groupTable3.Controls.Add(this.seat2Table3);
            this.groupTable3.Controls.Add(this.seat4Table3);
            this.groupTable3.Controls.Add(this.seat6Table3);
            this.groupTable3.Controls.Add(this.seat1Table3);
            this.groupTable3.Controls.Add(this.table3Name);
            this.groupTable3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupTable3.Location = new System.Drawing.Point(23, 415);
            this.groupTable3.Name = "groupTable3";
            this.groupTable3.Size = new System.Drawing.Size(452, 393);
            this.groupTable3.TabIndex = 63;
            this.groupTable3.TabStop = false;
            this.groupTable3.Text = "3";
            // 
            // saveTable3
            // 
            this.saveTable3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.saveTable3.ForeColor = System.Drawing.Color.White;
            this.saveTable3.Location = new System.Drawing.Point(342, 35);
            this.saveTable3.Name = "saveTable3";
            this.saveTable3.Size = new System.Drawing.Size(104, 23);
            this.saveTable3.TabIndex = 71;
            this.saveTable3.Text = "Zapisz rozdanie";
            this.saveTable3.UseVisualStyleBackColor = false;
            this.saveTable3.Visible = false;
            this.saveTable3.Click += new System.EventHandler(this.SaveLastHand);
            // 
            // groupTable4
            // 
            this.groupTable4.Controls.Add(this.saveTable4);
            this.groupTable4.Controls.Add(this.seat5Table4);
            this.groupTable4.Controls.Add(this.closeTable4);
            this.groupTable4.Controls.Add(this.table4Name);
            this.groupTable4.Controls.Add(this.seat1Table4);
            this.groupTable4.Controls.Add(this.seat6Table4);
            this.groupTable4.Controls.Add(this.seat3Table4);
            this.groupTable4.Controls.Add(this.seat2Table4);
            this.groupTable4.Controls.Add(this.seat4Table4);
            this.groupTable4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupTable4.Location = new System.Drawing.Point(481, 415);
            this.groupTable4.Name = "groupTable4";
            this.groupTable4.Size = new System.Drawing.Size(452, 393);
            this.groupTable4.TabIndex = 64;
            this.groupTable4.TabStop = false;
            this.groupTable4.Text = "4";
            // 
            // saveTable4
            // 
            this.saveTable4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.saveTable4.ForeColor = System.Drawing.Color.White;
            this.saveTable4.Location = new System.Drawing.Point(342, 35);
            this.saveTable4.Name = "saveTable4";
            this.saveTable4.Size = new System.Drawing.Size(104, 23);
            this.saveTable4.TabIndex = 72;
            this.saveTable4.Text = "Zapisz rozdanie";
            this.saveTable4.UseVisualStyleBackColor = false;
            this.saveTable4.Visible = false;
            this.saveTable4.Click += new System.EventHandler(this.SaveLastHand);
            // 
            // analyzeAllButton
            // 
            this.analyzeAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.analyzeAllButton.ForeColor = System.Drawing.Color.White;
            this.analyzeAllButton.Location = new System.Drawing.Point(10, 91);
            this.analyzeAllButton.Name = "analyzeAllButton";
            this.analyzeAllButton.Size = new System.Drawing.Size(140, 41);
            this.analyzeAllButton.TabIndex = 68;
            this.analyzeAllButton.Text = "Analizuj Pliki";
            this.analyzeAllButton.UseVisualStyleBackColor = false;
            this.analyzeAllButton.Click += new System.EventHandler(this.AnalyzeAllButton_Click);
            // 
            // playerButton
            // 
            this.playerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.playerButton.ForeColor = System.Drawing.Color.White;
            this.playerButton.Location = new System.Drawing.Point(6, 39);
            this.playerButton.Name = "playerButton";
            this.playerButton.Size = new System.Drawing.Size(175, 41);
            this.playerButton.TabIndex = 69;
            this.playerButton.Text = "Wyświetl gracza";
            this.playerButton.UseVisualStyleBackColor = false;
            this.playerButton.Click += new System.EventHandler(this.PlayerButton_Click);
            // 
            // playerName
            // 
            this.playerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.playerName.ForeColor = System.Drawing.Color.White;
            this.playerName.Location = new System.Drawing.Point(6, 13);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(175, 20);
            this.playerName.TabIndex = 70;
            // 
            // playerStats
            // 
            this.playerStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.playerStats.ForeColor = System.Drawing.Color.White;
            this.playerStats.Location = new System.Drawing.Point(6, 86);
            this.playerStats.Multiline = true;
            this.playerStats.Name = "playerStats";
            this.playerStats.Size = new System.Drawing.Size(175, 73);
            this.playerStats.TabIndex = 59;
            this.playerStats.DoubleClick += new System.EventHandler(this.PlayerFishChange);
            // 
            // historyPathButton
            // 
            this.historyPathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.historyPathButton.ForeColor = System.Drawing.Color.White;
            this.historyPathButton.Location = new System.Drawing.Point(156, 91);
            this.historyPathButton.Name = "historyPathButton";
            this.historyPathButton.Size = new System.Drawing.Size(140, 41);
            this.historyPathButton.TabIndex = 71;
            this.historyPathButton.Text = "Historia Rąk";
            this.historyPathButton.UseVisualStyleBackColor = false;
            this.historyPathButton.Click += new System.EventHandler(this.HistoryPathButton_Click);
            // 
            // setupNickButton
            // 
            this.setupNickButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.setupNickButton.ForeColor = System.Drawing.Color.White;
            this.setupNickButton.Location = new System.Drawing.Point(10, 44);
            this.setupNickButton.Name = "setupNickButton";
            this.setupNickButton.Size = new System.Drawing.Size(140, 41);
            this.setupNickButton.TabIndex = 72;
            this.setupNickButton.Text = "Ustaw swój nick";
            this.setupNickButton.UseVisualStyleBackColor = false;
            this.setupNickButton.Click += new System.EventHandler(this.SetupNickButton_Click);
            // 
            // mainPlayerNickname
            // 
            this.mainPlayerNickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mainPlayerNickname.ForeColor = System.Drawing.Color.White;
            this.mainPlayerNickname.Location = new System.Drawing.Point(10, 18);
            this.mainPlayerNickname.Name = "mainPlayerNickname";
            this.mainPlayerNickname.Size = new System.Drawing.Size(140, 20);
            this.mainPlayerNickname.TabIndex = 73;
            this.mainPlayerNickname.Text = "Twój nick";
            // 
            // dataPathButton
            // 
            this.dataPathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dataPathButton.ForeColor = System.Drawing.Color.White;
            this.dataPathButton.Location = new System.Drawing.Point(156, 44);
            this.dataPathButton.Name = "dataPathButton";
            this.dataPathButton.Size = new System.Drawing.Size(140, 41);
            this.dataPathButton.TabIndex = 74;
            this.dataPathButton.Text = "Ścieżka do zapisu danych";
            this.dataPathButton.UseVisualStyleBackColor = false;
            this.dataPathButton.Click += new System.EventHandler(this.DataPathButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // hoverButton
            // 
            this.hoverButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.hoverButton.ForeColor = System.Drawing.Color.White;
            this.hoverButton.Location = new System.Drawing.Point(1174, 602);
            this.hoverButton.Name = "hoverButton";
            this.hoverButton.Size = new System.Drawing.Size(72, 52);
            this.hoverButton.TabIndex = 75;
            this.hoverButton.Text = "Tryb nakładki BETA";
            this.hoverButton.UseVisualStyleBackColor = false;
            this.hoverButton.Click += new System.EventHandler(this.HoverButton_Click);
            // 
            // controlGroup
            // 
            this.controlGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlGroup.Controls.Add(this.historyPathButton);
            this.controlGroup.Controls.Add(this.analyzeAllButton);
            this.controlGroup.Controls.Add(this.dataPathButton);
            this.controlGroup.Controls.Add(this.setupNickButton);
            this.controlGroup.Controls.Add(this.mainPlayerNickname);
            this.controlGroup.Location = new System.Drawing.Point(939, 660);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Size = new System.Drawing.Size(313, 148);
            this.controlGroup.TabIndex = 76;
            this.controlGroup.TabStop = false;
            // 
            // tableToSwap1
            // 
            this.tableToSwap1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tableToSwap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableToSwap1.ForeColor = System.Drawing.Color.White;
            this.tableToSwap1.Location = new System.Drawing.Point(113, 246);
            this.tableToSwap1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.tableToSwap1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tableToSwap1.Name = "tableToSwap1";
            this.tableToSwap1.Size = new System.Drawing.Size(47, 38);
            this.tableToSwap1.TabIndex = 79;
            this.tableToSwap1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableToSwap2
            // 
            this.tableToSwap2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tableToSwap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableToSwap2.ForeColor = System.Drawing.Color.White;
            this.tableToSwap2.Location = new System.Drawing.Point(26, 246);
            this.tableToSwap2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.tableToSwap2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tableToSwap2.Name = "tableToSwap2";
            this.tableToSwap2.Size = new System.Drawing.Size(47, 38);
            this.tableToSwap2.TabIndex = 80;
            this.tableToSwap2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // changeTables
            // 
            this.changeTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.changeTables.ForeColor = System.Drawing.Color.White;
            this.changeTables.Location = new System.Drawing.Point(6, 199);
            this.changeTables.Name = "changeTables";
            this.changeTables.Size = new System.Drawing.Size(175, 41);
            this.changeTables.TabIndex = 78;
            this.changeTables.Text = "Zamień stoły";
            this.changeTables.UseVisualStyleBackColor = false;
            this.changeTables.Click += new System.EventHandler(this.ChangeTables_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tableToSwap1);
            this.groupBox1.Controls.Add(this.playerStats);
            this.groupBox1.Controls.Add(this.playerButton);
            this.groupBox1.Controls.Add(this.playerName);
            this.groupBox1.Controls.Add(this.tableToSwap2);
            this.groupBox1.Controls.Add(this.changeTables);
            this.groupBox1.Location = new System.Drawing.Point(1065, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 302);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 31);
            this.label1.TabIndex = 61;
            this.label1.Text = "z";
            // 
            // hudOnButton
            // 
            this.hudOnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.hudOnButton.ForeColor = System.Drawing.Color.White;
            this.hudOnButton.Location = new System.Drawing.Point(1174, 428);
            this.hudOnButton.Name = "hudOnButton";
            this.hudOnButton.Size = new System.Drawing.Size(72, 52);
            this.hudOnButton.TabIndex = 78;
            this.hudOnButton.Text = "Nakładka nowa";
            this.hudOnButton.UseVisualStyleBackColor = false;
            this.hudOnButton.Click += new System.EventHandler(this.HudOnButton_Click);
            // 
            // createHud
            // 
            this.createHud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.createHud.ForeColor = System.Drawing.Color.White;
            this.createHud.Location = new System.Drawing.Point(1095, 428);
            this.createHud.Name = "createHud";
            this.createHud.Size = new System.Drawing.Size(72, 52);
            this.createHud.TabIndex = 79;
            this.createHud.Text = "Stwórz HUDa";
            this.createHud.UseVisualStyleBackColor = false;
            this.createHud.Click += new System.EventHandler(this.CreateHud_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.createHud);
            this.Controls.Add(this.hudOnButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hoverButton);
            this.Controls.Add(this.controlGroup);
            this.Controls.Add(this.groupTable4);
            this.Controls.Add(this.groupTable3);
            this.Controls.Add(this.groupTable2);
            this.Controls.Add(this.groupTable1);
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Puzzle";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupTable1.ResumeLayout(false);
            this.groupTable1.PerformLayout();
            this.groupTable2.ResumeLayout(false);
            this.groupTable2.PerformLayout();
            this.groupTable3.ResumeLayout(false);
            this.groupTable3.PerformLayout();
            this.groupTable4.ResumeLayout(false);
            this.groupTable4.PerformLayout();
            this.controlGroup.ResumeLayout(false);
            this.controlGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableToSwap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableToSwap2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox seat3Table1;
        private System.Windows.Forms.TextBox seat2Table1;
        private System.Windows.Forms.TextBox seat4Table1;
        private System.Windows.Forms.TextBox seat5Table1;
        private System.Windows.Forms.TextBox seat6Table1;
        private System.Windows.Forms.Label table1Name;
        private System.Windows.Forms.Label table2Name;
        private System.Windows.Forms.TextBox seat1Table2;
        private System.Windows.Forms.TextBox seat6Table2;
        private System.Windows.Forms.TextBox seat5Table2;
        private System.Windows.Forms.TextBox seat4Table2;
        private System.Windows.Forms.TextBox seat2Table2;
        private System.Windows.Forms.TextBox seat3Table2;
        private System.Windows.Forms.Label table3Name;
        private System.Windows.Forms.TextBox seat1Table3;
        private System.Windows.Forms.TextBox seat6Table3;
        private System.Windows.Forms.TextBox seat5Table3;
        private System.Windows.Forms.TextBox seat4Table3;
        private System.Windows.Forms.TextBox seat2Table3;
        private System.Windows.Forms.TextBox seat3Table3;
        private System.Windows.Forms.Label table4Name;
        private System.Windows.Forms.TextBox seat1Table4;
        private System.Windows.Forms.TextBox seat6Table4;
        private System.Windows.Forms.TextBox seat5Table4;
        private System.Windows.Forms.TextBox seat4Table4;
        private System.Windows.Forms.TextBox seat2Table4;
        private System.Windows.Forms.TextBox seat3Table4;
        private System.Windows.Forms.Button closeTable1;
        private System.Windows.Forms.Button closeTable2;
        private System.Windows.Forms.Button closeTable3;
        private System.Windows.Forms.Button closeTable4;
        private System.Windows.Forms.GroupBox groupTable1;
        private System.Windows.Forms.GroupBox groupTable2;
        private System.Windows.Forms.GroupBox groupTable3;
        private System.Windows.Forms.GroupBox groupTable4;
        private System.Windows.Forms.Button analyzeAllButton;
        private System.Windows.Forms.Button playerButton;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.TextBox playerStats;
        private System.Windows.Forms.Button saveTable1;
        private System.Windows.Forms.Button saveTable2;
        private System.Windows.Forms.Button saveTable3;
        private System.Windows.Forms.Button saveTable4;
        private System.Windows.Forms.Button historyPathButton;
        private System.Windows.Forms.Button setupNickButton;
        private System.Windows.Forms.TextBox mainPlayerNickname;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button dataPathButton;
        private System.Windows.Forms.TextBox seat1Table1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button hoverButton;
        private System.Windows.Forms.GroupBox controlGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button changeTables;
        private System.Windows.Forms.NumericUpDown tableToSwap1;
        private System.Windows.Forms.NumericUpDown tableToSwap2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hudOnButton;
        private System.Windows.Forms.Button createHud;
    }
}

