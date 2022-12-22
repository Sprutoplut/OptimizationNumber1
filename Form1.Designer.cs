namespace OptimizationNumber1
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.bStart = new Telerik.WinControls.UI.CommandBarButton();
            this.radPanorama1 = new Telerik.WinControls.UI.RadPanorama();
            this.bRefresh = new Telerik.WinControls.UI.RadButton();
            this.ddStart = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.ddFinish = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.gvTable = new Telerik.WinControls.UI.RadGridView();
            this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).BeginInit();
            this.radPanorama1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTable.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(792, 33);
            this.radCommandBar1.TabIndex = 12;
            this.radCommandBar1.ThemeName = "Office2010Silver";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Name = "commandBarRowElement1";
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1,
            this.commandBarStripElement2});
            this.commandBarRowElement1.Text = "";
            this.commandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.UseCompatibleTextRendering = false;
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.EnableFocusBorderAnimation = true;
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.bStart});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.UseCompatibleTextRendering = false;
            // 
            // bStart
            // 
            this.bStart.DisplayName = "commandBarButton1";
            this.bStart.DrawText = true;
            this.bStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.Image = ((System.Drawing.Image)(resources.GetObject("bStart.Image")));
            this.bStart.Name = "bStart";
            this.bStart.Text = "Рассчет";
            this.bStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radPanorama1
            // 
            this.radPanorama1.Controls.Add(this.radGridView1);
            this.radPanorama1.Controls.Add(this.bRefresh);
            this.radPanorama1.Controls.Add(this.ddStart);
            this.radPanorama1.Controls.Add(this.radLabel2);
            this.radPanorama1.Controls.Add(this.ddFinish);
            this.radPanorama1.Controls.Add(this.radLabel1);
            this.radPanorama1.Controls.Add(this.gvTable);
            this.radPanorama1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanorama1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radPanorama1.Location = new System.Drawing.Point(0, 33);
            this.radPanorama1.Name = "radPanorama1";
            this.radPanorama1.Size = new System.Drawing.Size(792, 730);
            this.radPanorama1.TabIndex = 13;
            this.radPanorama1.ThemeName = "Office2010Silver";
            // 
            // bRefresh
            // 
            this.bRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRefresh.Location = new System.Drawing.Point(361, 14);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(110, 24);
            this.bRefresh.TabIndex = 10;
            this.bRefresh.Text = "Обновить";
            this.bRefresh.ThemeName = "Office2010Silver";
            this.bRefresh.Click += new System.EventHandler(this.BRefresh_Click);
            // 
            // ddStart
            // 
            this.ddStart.DropDownAnimationEnabled = true;
            this.ddStart.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ddStart.Location = new System.Drawing.Point(148, 246);
            this.ddStart.Name = "ddStart";
            this.ddStart.Size = new System.Drawing.Size(323, 23);
            this.ddStart.TabIndex = 9;
            this.ddStart.ThemeName = "Office2010Silver";
            this.ddStart.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.DdStart_SelectedIndexChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel2.Location = new System.Drawing.Point(31, 246);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(111, 21);
            this.radLabel2.TabIndex = 8;
            this.radLabel2.Text = "Начальная точка";
            this.radLabel2.ThemeName = "Office2010Silver";
            // 
            // ddFinish
            // 
            this.ddFinish.DropDownAnimationEnabled = true;
            this.ddFinish.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddFinish.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ddFinish.Location = new System.Drawing.Point(141, 213);
            this.ddFinish.Name = "ddFinish";
            this.ddFinish.Size = new System.Drawing.Size(330, 23);
            this.ddFinish.TabIndex = 7;
            this.ddFinish.ThemeName = "Office2010Silver";
            this.ddFinish.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.DdFinish_SelectedIndexChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel1.Location = new System.Drawing.Point(31, 213);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(104, 21);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Конечная точка";
            this.radLabel1.ThemeName = "Office2010Silver";
            // 
            // gvTable
            // 
            this.gvTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gvTable.Location = new System.Drawing.Point(31, 44);
            // 
            // 
            // 
            this.gvTable.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            gridViewTextBoxColumn2.HeaderText = "Точка выхода";
            gridViewTextBoxColumn2.Name = "column1";
            gridViewTextBoxColumn2.Width = 150;
            gridViewDecimalColumn2.DecimalPlaces = 0;
            gridViewDecimalColumn2.HeaderText = "Продолжительность";
            gridViewDecimalColumn2.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            gridViewDecimalColumn2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            gridViewDecimalColumn2.Name = "column2";
            gridViewDecimalColumn2.Width = 100;
            gridViewTextBoxColumn3.HeaderText = "Точка входа";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 150;
            this.gvTable.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3});
            this.gvTable.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gvTable.Name = "gvTable";
            this.gvTable.ShowGroupPanel = false;
            this.gvTable.Size = new System.Drawing.Size(440, 150);
            this.gvTable.TabIndex = 5;
            this.gvTable.ThemeName = "Office2010Silver";
            this.gvTable.Click += new System.EventHandler(this.GvTable_Click);
            // 
            // commandBarStripElement2
            // 
            this.commandBarStripElement2.DisplayName = "commandBarStripElement2";
            this.commandBarStripElement2.Name = "commandBarStripElement2";
            // 
            // radGridView1
            // 
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radGridView1.Location = new System.Drawing.Point(31, 273);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            gridViewTextBoxColumn1.HeaderText = "Работа";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 150;
            gridViewDecimalColumn1.DecimalPlaces = 0;
            gridViewDecimalColumn1.HeaderText = "Продолжительность";
            gridViewDecimalColumn1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            gridViewDecimalColumn1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            gridViewDecimalColumn1.Name = "column2";
            gridViewDecimalColumn1.Width = 250;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(440, 431);
            this.radGridView1.TabIndex = 11;
            this.radGridView1.ThemeName = "Office2010Silver";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 763);
            this.Controls.Add(this.radPanorama1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).EndInit();
            this.radPanorama1.ResumeLayout(false);
            this.radPanorama1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTable.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton bStart;
        private Telerik.WinControls.UI.RadPanorama radPanorama1;
        private Telerik.WinControls.UI.RadDropDownList ddStart;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList ddFinish;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGridView gvTable;
        private Telerik.WinControls.UI.RadButton bRefresh;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}

