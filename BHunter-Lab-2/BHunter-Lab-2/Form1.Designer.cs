namespace BHunter_Lab_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityDBDataSet = new BHunter_Lab_2.CityDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cityDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxSort = new System.Windows.Forms.ComboBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.cityTableAdapter = new BHunter_Lab_2.CityDBDataSetTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new BHunter_Lab_2.CityDBDataSetTableAdapters.TableAdapterManager();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnHighest = new System.Windows.Forms.Button();
            this.btnLowest = new System.Windows.Forms.Button();
            this.btnHideHighest = new System.Windows.Forms.Button();
            this.btnHideLowest = new System.Windows.Forms.Button();
            this.btnHideAverage = new System.Windows.Forms.Button();
            this.btnHideTotal = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtLowest = new System.Windows.Forms.TextBox();
            this.lblLowest = new System.Windows.Forms.Label();
            this.txtHighest = new System.Windows.Forms.TextBox();
            this.lblHighest = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.popToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).BeginInit();
            this.cityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBindingNavigator
            // 
            this.cityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cityBindingNavigator.BackColor = System.Drawing.Color.Navy;
            this.cityBindingNavigator.BindingSource = this.cityBindingSource;
            this.cityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cityBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cityBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cityBindingNavigatorSaveItem});
            this.cityBindingNavigator.Location = new System.Drawing.Point(0, 417);
            this.cityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cityBindingNavigator.Name = "cityBindingNavigator";
            this.cityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cityBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.cityBindingNavigator.TabIndex = 0;
            this.cityBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.cityDBDataSet;
            // 
            // cityDBDataSet
            // 
            this.cityDBDataSet.DataSetName = "CityDBDataSet";
            this.cityDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // cityBindingNavigatorSaveItem
            // 
            this.cityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cityBindingNavigatorSaveItem.Image")));
            this.cityBindingNavigatorSaveItem.Name = "cityBindingNavigatorSaveItem";
            this.cityBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.cityBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // cityDataGridView
            // 
            this.cityDataGridView.AutoGenerateColumns = false;
            this.cityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cityDataGridView.DataSource = this.cityBindingSource;
            this.cityDataGridView.Location = new System.Drawing.Point(43, 93);
            this.cityDataGridView.Name = "cityDataGridView";
            this.cityDataGridView.RowHeadersWidth = 62;
            this.cityDataGridView.RowTemplate.Height = 28;
            this.cityDataGridView.Size = new System.Drawing.Size(715, 264);
            this.cityDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CityID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn2.HeaderText = "City";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn3.HeaderText = "State";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn4.HeaderText = "Population";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // cbxSort
            // 
            this.cbxSort.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbxSort.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxSort.FormattingEnabled = true;
            this.cbxSort.Items.AddRange(new object[] {
            "Population (ascending)",
            "Population (descending)",
            "Name"});
            this.cbxSort.Location = new System.Drawing.Point(0, 3);
            this.cbxSort.Name = "cbxSort";
            this.cbxSort.Size = new System.Drawing.Size(121, 28);
            this.cbxSort.TabIndex = 3;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTotal.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.Color.White;
            this.btnTotal.Location = new System.Drawing.Point(43, 46);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(154, 40);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "&Total Population";
            this.popToolTip.SetToolTip(this.btnTotal, "Click to see the sum of all the populations");
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.UpdateOrder = BHunter_Lab_2.CityDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnAverage
            // 
            this.btnAverage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAverage.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverage.ForeColor = System.Drawing.Color.White;
            this.btnAverage.Location = new System.Drawing.Point(203, 46);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(185, 40);
            this.btnAverage.TabIndex = 5;
            this.btnAverage.Text = "&Average Population";
            this.popToolTip.SetToolTip(this.btnAverage, "Click to see the Average of all the populations");
            this.btnAverage.UseVisualStyleBackColor = false;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnHighest
            // 
            this.btnHighest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHighest.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighest.ForeColor = System.Drawing.Color.White;
            this.btnHighest.Location = new System.Drawing.Point(575, 47);
            this.btnHighest.Name = "btnHighest";
            this.btnHighest.Size = new System.Drawing.Size(183, 40);
            this.btnHighest.TabIndex = 6;
            this.btnHighest.Text = "&Highest Population";
            this.popToolTip.SetToolTip(this.btnHighest, "Click to see the Highest Population");
            this.btnHighest.UseVisualStyleBackColor = false;
            this.btnHighest.Click += new System.EventHandler(this.btnHighest_Click);
            // 
            // btnLowest
            // 
            this.btnLowest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLowest.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowest.ForeColor = System.Drawing.Color.White;
            this.btnLowest.Location = new System.Drawing.Point(394, 47);
            this.btnLowest.Name = "btnLowest";
            this.btnLowest.Size = new System.Drawing.Size(175, 40);
            this.btnLowest.TabIndex = 7;
            this.btnLowest.Text = "&Lowest Population";
            this.popToolTip.SetToolTip(this.btnLowest, "Click to see the Lowest Population");
            this.btnLowest.UseVisualStyleBackColor = false;
            this.btnLowest.Click += new System.EventHandler(this.btnLowest_Click);
            // 
            // btnHideHighest
            // 
            this.btnHideHighest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHideHighest.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideHighest.ForeColor = System.Drawing.Color.White;
            this.btnHideHighest.Location = new System.Drawing.Point(575, 47);
            this.btnHideHighest.Name = "btnHideHighest";
            this.btnHideHighest.Size = new System.Drawing.Size(183, 40);
            this.btnHideHighest.TabIndex = 8;
            this.btnHideHighest.Text = "Hide Highest";
            this.btnHideHighest.UseVisualStyleBackColor = false;
            this.btnHideHighest.Visible = false;
            this.btnHideHighest.Click += new System.EventHandler(this.btnHideHighest_Click_1);
            // 
            // btnHideLowest
            // 
            this.btnHideLowest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHideLowest.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideLowest.ForeColor = System.Drawing.Color.White;
            this.btnHideLowest.Location = new System.Drawing.Point(394, 47);
            this.btnHideLowest.Name = "btnHideLowest";
            this.btnHideLowest.Size = new System.Drawing.Size(175, 40);
            this.btnHideLowest.TabIndex = 9;
            this.btnHideLowest.Text = "Hide Lowest";
            this.btnHideLowest.UseVisualStyleBackColor = false;
            this.btnHideLowest.Visible = false;
            this.btnHideLowest.Click += new System.EventHandler(this.btnHideLowest_Click_1);
            // 
            // btnHideAverage
            // 
            this.btnHideAverage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHideAverage.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideAverage.ForeColor = System.Drawing.Color.White;
            this.btnHideAverage.Location = new System.Drawing.Point(203, 47);
            this.btnHideAverage.Name = "btnHideAverage";
            this.btnHideAverage.Size = new System.Drawing.Size(185, 40);
            this.btnHideAverage.TabIndex = 10;
            this.btnHideAverage.Text = "Hide Average";
            this.btnHideAverage.UseVisualStyleBackColor = false;
            this.btnHideAverage.Visible = false;
            this.btnHideAverage.Click += new System.EventHandler(this.btnHideAverage_Click_1);
            // 
            // btnHideTotal
            // 
            this.btnHideTotal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHideTotal.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideTotal.ForeColor = System.Drawing.Color.White;
            this.btnHideTotal.Location = new System.Drawing.Point(43, 47);
            this.btnHideTotal.Name = "btnHideTotal";
            this.btnHideTotal.Size = new System.Drawing.Size(154, 40);
            this.btnHideTotal.TabIndex = 11;
            this.btnHideTotal.Text = "Hide Total";
            this.btnHideTotal.UseVisualStyleBackColor = false;
            this.btnHideTotal.Visible = false;
            this.btnHideTotal.Click += new System.EventHandler(this.btnHideTotal_Click_1);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSort.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.Location = new System.Drawing.Point(127, 3);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(84, 34);
            this.btnSort.TabIndex = 12;
            this.btnSort.Text = "--&Sort--";
            this.popToolTip.SetToolTip(this.btnSort, "Select the sorting criteria from the dropdown menu on the left, then click Sort t" +
        "o apply it.");
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Enabled = false;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotal.Location = new System.Drawing.Point(52, 366);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(107, 363);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.Visible = false;
            // 
            // txtAverage
            // 
            this.txtAverage.BackColor = System.Drawing.SystemColors.Window;
            this.txtAverage.Enabled = false;
            this.txtAverage.ForeColor = System.Drawing.Color.White;
            this.txtAverage.Location = new System.Drawing.Point(293, 363);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 26);
            this.txtAverage.TabIndex = 16;
            this.txtAverage.Visible = false;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Enabled = false;
            this.lblAverage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAverage.Location = new System.Drawing.Point(214, 366);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(72, 20);
            this.lblAverage.TabIndex = 15;
            this.lblAverage.Text = "Average:";
            this.lblAverage.Visible = false;
            // 
            // txtLowest
            // 
            this.txtLowest.BackColor = System.Drawing.SystemColors.Window;
            this.txtLowest.Enabled = false;
            this.txtLowest.ForeColor = System.Drawing.Color.White;
            this.txtLowest.Location = new System.Drawing.Point(471, 363);
            this.txtLowest.Name = "txtLowest";
            this.txtLowest.Size = new System.Drawing.Size(100, 26);
            this.txtLowest.TabIndex = 18;
            this.txtLowest.Visible = false;
            // 
            // lblLowest
            // 
            this.lblLowest.AutoSize = true;
            this.lblLowest.Enabled = false;
            this.lblLowest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLowest.Location = new System.Drawing.Point(400, 366);
            this.lblLowest.Name = "lblLowest";
            this.lblLowest.Size = new System.Drawing.Size(64, 20);
            this.lblLowest.TabIndex = 17;
            this.lblLowest.Text = "Lowest:";
            this.lblLowest.Visible = false;
            // 
            // txtHighest
            // 
            this.txtHighest.BackColor = System.Drawing.SystemColors.Window;
            this.txtHighest.Enabled = false;
            this.txtHighest.ForeColor = System.Drawing.Color.White;
            this.txtHighest.Location = new System.Drawing.Point(649, 363);
            this.txtHighest.Name = "txtHighest";
            this.txtHighest.Size = new System.Drawing.Size(100, 26);
            this.txtHighest.TabIndex = 20;
            this.txtHighest.Visible = false;
            // 
            // lblHighest
            // 
            this.lblHighest.AutoSize = true;
            this.lblHighest.Enabled = false;
            this.lblHighest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHighest.Location = new System.Drawing.Point(578, 366);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(64, 20);
            this.lblHighest.TabIndex = 19;
            this.lblHighest.Text = "Highest";
            this.lblHighest.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(704, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 34);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "--E&xit--";
            this.popToolTip.SetToolTip(this.btnExit, "Click to exit the program");
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtHighest);
            this.Controls.Add(this.lblHighest);
            this.Controls.Add(this.txtLowest);
            this.Controls.Add(this.lblLowest);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnLowest);
            this.Controls.Add(this.btnHighest);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.cbxSort);
            this.Controls.Add(this.cityDataGridView);
            this.Controls.Add(this.cityBindingNavigator);
            this.Controls.Add(this.btnHideTotal);
            this.Controls.Add(this.btnHideAverage);
            this.Controls.Add(this.btnHideLowest);
            this.Controls.Add(this.btnHideHighest);
            this.Name = "Form1";
            this.Text = "Brieana Hunter Population Lab 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).EndInit();
            this.cityBindingNavigator.ResumeLayout(false);
            this.cityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityDBDataSet cityDBDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private CityDBDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private CityDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cityBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox cbxSort;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnHighest;
        private System.Windows.Forms.Button btnLowest;
        private System.Windows.Forms.Button btnHideHighest;
        private System.Windows.Forms.Button btnHideLowest;
        private System.Windows.Forms.Button btnHideAverage;
        private System.Windows.Forms.Button btnHideTotal;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtLowest;
        private System.Windows.Forms.Label lblLowest;
        private System.Windows.Forms.TextBox txtHighest;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip popToolTip;
    }
}

