namespace WindowsFormsAppKursova.Forms
{
    partial class Ban
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
            System.Windows.Forms.Label пІБLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label адресаLabel;
            System.Windows.Forms.Label дата_народженняLabel;
            System.Windows.Forms.Label місце_роботиLabel;
            System.Windows.Forms.Label дата_осудженняLabel;
            System.Windows.Forms.Label дата_зняттяLabel;
            System.Windows.Forms.Label дата_оцінкиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ban));
            this.sample1DataSet = new WindowsFormsAppKursova.Sample1DataSet();
            this.banTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banTableTableAdapter = new WindowsFormsAppKursova.Sample1DataSetTableAdapters.BanTableTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppKursova.Sample1DataSetTableAdapters.TableAdapterManager();
            this.banTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.banTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.пІБTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.адресаTextBox = new System.Windows.Forms.TextBox();
            this.дата_народженняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.місце_роботиTextBox = new System.Windows.Forms.TextBox();
            this.дата_осудженняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_зняттяDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_оцінкиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пІБDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНародженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.місцеРоботиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОсудженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗняттяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОцінкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBanN = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            пІБLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            адресаLabel = new System.Windows.Forms.Label();
            дата_народженняLabel = new System.Windows.Forms.Label();
            місце_роботиLabel = new System.Windows.Forms.Label();
            дата_осудженняLabel = new System.Windows.Forms.Label();
            дата_зняттяLabel = new System.Windows.Forms.Label();
            дата_оцінкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sample1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banTableBindingNavigator)).BeginInit();
            this.banTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // пІБLabel
            // 
            пІБLabel.AutoSize = true;
            пІБLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            пІБLabel.Location = new System.Drawing.Point(38, 180);
            пІБLabel.Name = "пІБLabel";
            пІБLabel.Size = new System.Drawing.Size(44, 22);
            пІБLabel.TabIndex = 3;
            пІБLabel.Text = "ПІБ:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            телефонLabel.Location = new System.Drawing.Point(38, 239);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(91, 22);
            телефонLabel.TabIndex = 5;
            телефонLabel.Text = "Телефон:";
            // 
            // адресаLabel
            // 
            адресаLabel.AutoSize = true;
            адресаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            адресаLabel.Location = new System.Drawing.Point(38, 284);
            адресаLabel.Name = "адресаLabel";
            адресаLabel.Size = new System.Drawing.Size(77, 22);
            адресаLabel.TabIndex = 7;
            адресаLabel.Text = "Адреса:";
            // 
            // дата_народженняLabel
            // 
            дата_народженняLabel.AutoSize = true;
            дата_народженняLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            дата_народженняLabel.Location = new System.Drawing.Point(38, 352);
            дата_народженняLabel.Name = "дата_народженняLabel";
            дата_народженняLabel.Size = new System.Drawing.Size(167, 22);
            дата_народженняLabel.TabIndex = 9;
            дата_народженняLabel.Text = "Дата народження:";
            // 
            // місце_роботиLabel
            // 
            місце_роботиLabel.AutoSize = true;
            місце_роботиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            місце_роботиLabel.Location = new System.Drawing.Point(38, 401);
            місце_роботиLabel.Name = "місце_роботиLabel";
            місце_роботиLabel.Size = new System.Drawing.Size(126, 22);
            місце_роботиLabel.TabIndex = 11;
            місце_роботиLabel.Text = "Місце роботи:";
            // 
            // дата_осудженняLabel
            // 
            дата_осудженняLabel.AutoSize = true;
            дата_осудженняLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            дата_осудженняLabel.Location = new System.Drawing.Point(38, 453);
            дата_осудженняLabel.Name = "дата_осудженняLabel";
            дата_осудженняLabel.Size = new System.Drawing.Size(155, 22);
            дата_осудженняLabel.TabIndex = 13;
            дата_осудженняLabel.Text = "Дата осудження:";
            // 
            // дата_зняттяLabel
            // 
            дата_зняттяLabel.AutoSize = true;
            дата_зняттяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            дата_зняттяLabel.Location = new System.Drawing.Point(38, 495);
            дата_зняттяLabel.Name = "дата_зняттяLabel";
            дата_зняттяLabel.Size = new System.Drawing.Size(117, 22);
            дата_зняттяLabel.TabIndex = 15;
            дата_зняттяLabel.Text = "Дата зняття:";
            // 
            // дата_оцінкиLabel
            // 
            дата_оцінкиLabel.AutoSize = true;
            дата_оцінкиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            дата_оцінкиLabel.Location = new System.Drawing.Point(38, 545);
            дата_оцінкиLabel.Name = "дата_оцінкиLabel";
            дата_оцінкиLabel.Size = new System.Drawing.Size(116, 22);
            дата_оцінкиLabel.TabIndex = 17;
            дата_оцінкиLabel.Text = "Дата оцінки:";
            // 
            // sample1DataSet
            // 
            this.sample1DataSet.DataSetName = "Sample1DataSet";
            this.sample1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banTableBindingSource
            // 
            this.banTableBindingSource.DataMember = "BanTable";
            this.banTableBindingSource.DataSource = this.sample1DataSet;
            this.banTableBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.banTableBindingSource_ListChanged);
            // 
            // banTableTableAdapter
            // 
            this.banTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._75TableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BanTableTableAdapter = this.banTableTableAdapter;
            this.tableAdapterManager.FineTableTableAdapter = null;
            this.tableAdapterManager.OTGTableTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppKursova.Sample1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WoTableTableAdapter = null;
            // 
            // banTableBindingNavigator
            // 
            this.banTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.banTableBindingNavigator.BindingSource = this.banTableBindingSource;
            this.banTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.banTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.banTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.banTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.banTableBindingNavigatorSaveItem});
            this.banTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.banTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.banTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.banTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.banTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.banTableBindingNavigator.Name = "banTableBindingNavigator";
            this.banTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.banTableBindingNavigator.Size = new System.Drawing.Size(1260, 27);
            this.banTableBindingNavigator.TabIndex = 0;
            this.banTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // banTableBindingNavigatorSaveItem
            // 
            this.banTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.banTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("banTableBindingNavigatorSaveItem.Image")));
            this.banTableBindingNavigatorSaveItem.Name = "banTableBindingNavigatorSaveItem";
            this.banTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.banTableBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.banTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.banTableBindingNavigatorSaveItem_Click);
            // 
            // пІБTextBox
            // 
            this.пІБTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.banTableBindingSource, "ПІБ", true));
            this.пІБTextBox.Location = new System.Drawing.Point(199, 182);
            this.пІБTextBox.Multiline = true;
            this.пІБTextBox.Name = "пІБTextBox";
            this.пІБTextBox.Size = new System.Drawing.Size(232, 30);
            this.пІБTextBox.TabIndex = 0;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.banTableBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(199, 241);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(232, 22);
            this.телефонTextBox.TabIndex = 1;
            this.телефонTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.телефонTextBox_KeyPress);
            // 
            // адресаTextBox
            // 
            this.адресаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.banTableBindingSource, "Адреса", true));
            this.адресаTextBox.Location = new System.Drawing.Point(199, 286);
            this.адресаTextBox.Multiline = true;
            this.адресаTextBox.Name = "адресаTextBox";
            this.адресаTextBox.Size = new System.Drawing.Size(232, 34);
            this.адресаTextBox.TabIndex = 2;
            // 
            // дата_народженняDateTimePicker
            // 
            this.дата_народженняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.banTableBindingSource, "Дата народження", true));
            this.дата_народженняDateTimePicker.Location = new System.Drawing.Point(231, 352);
            this.дата_народженняDateTimePicker.Name = "дата_народженняDateTimePicker";
            this.дата_народженняDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_народженняDateTimePicker.TabIndex = 3;
            // 
            // місце_роботиTextBox
            // 
            this.місце_роботиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.banTableBindingSource, "Місце роботи", true));
            this.місце_роботиTextBox.Location = new System.Drawing.Point(231, 401);
            this.місце_роботиTextBox.Name = "місце_роботиTextBox";
            this.місце_роботиTextBox.Size = new System.Drawing.Size(200, 22);
            this.місце_роботиTextBox.TabIndex = 4;
            // 
            // дата_осудженняDateTimePicker
            // 
            this.дата_осудженняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.banTableBindingSource, "Дата осудження", true));
            this.дата_осудженняDateTimePicker.Location = new System.Drawing.Point(231, 443);
            this.дата_осудженняDateTimePicker.Name = "дата_осудженняDateTimePicker";
            this.дата_осудженняDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_осудженняDateTimePicker.TabIndex = 5;
            // 
            // дата_зняттяDateTimePicker
            // 
            this.дата_зняттяDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.banTableBindingSource, "Дата зняття", true));
            this.дата_зняттяDateTimePicker.Location = new System.Drawing.Point(231, 495);
            this.дата_зняттяDateTimePicker.Name = "дата_зняттяDateTimePicker";
            this.дата_зняттяDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_зняттяDateTimePicker.TabIndex = 6;
            // 
            // дата_оцінкиDateTimePicker
            // 
            this.дата_оцінкиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.banTableBindingSource, "Дата оцінки", true));
            this.дата_оцінкиDateTimePicker.Location = new System.Drawing.Point(231, 545);
            this.дата_оцінкиDateTimePicker.Name = "дата_оцінкиDateTimePicker";
            this.дата_оцінкиDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_оцінкиDateTimePicker.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppKursova.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.пІБDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.адресаDataGridViewTextBoxColumn,
            this.датаНародженняDataGridViewTextBoxColumn,
            this.місцеРоботиDataGridViewTextBoxColumn,
            this.датаОсудженняDataGridViewTextBoxColumn,
            this.датаЗняттяDataGridViewTextBoxColumn,
            this.датаОцінкиDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.banTableBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(458, 182);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(802, 401);
            this.advancedDataGridView1.TabIndex = 20;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // пІБDataGridViewTextBoxColumn
            // 
            this.пІБDataGridViewTextBoxColumn.DataPropertyName = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.пІБDataGridViewTextBoxColumn.Name = "пІБDataGridViewTextBoxColumn";
            this.пІБDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.пІБDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресаDataGridViewTextBoxColumn
            // 
            this.адресаDataGridViewTextBoxColumn.DataPropertyName = "Адреса";
            this.адресаDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.адресаDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.адресаDataGridViewTextBoxColumn.Name = "адресаDataGridViewTextBoxColumn";
            this.адресаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.адресаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаНародженняDataGridViewTextBoxColumn
            // 
            this.датаНародженняDataGridViewTextBoxColumn.DataPropertyName = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.датаНародженняDataGridViewTextBoxColumn.Name = "датаНародженняDataGridViewTextBoxColumn";
            this.датаНародженняDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.датаНародженняDataGridViewTextBoxColumn.Width = 125;
            // 
            // місцеРоботиDataGridViewTextBoxColumn
            // 
            this.місцеРоботиDataGridViewTextBoxColumn.DataPropertyName = "Місце роботи";
            this.місцеРоботиDataGridViewTextBoxColumn.HeaderText = "Місце роботи";
            this.місцеРоботиDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.місцеРоботиDataGridViewTextBoxColumn.Name = "місцеРоботиDataGridViewTextBoxColumn";
            this.місцеРоботиDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.місцеРоботиDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаОсудженняDataGridViewTextBoxColumn
            // 
            this.датаОсудженняDataGridViewTextBoxColumn.DataPropertyName = "Дата осудження";
            this.датаОсудженняDataGridViewTextBoxColumn.HeaderText = "Дата осудження";
            this.датаОсудженняDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.датаОсудженняDataGridViewTextBoxColumn.Name = "датаОсудженняDataGridViewTextBoxColumn";
            this.датаОсудженняDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.датаОсудженняDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаЗняттяDataGridViewTextBoxColumn
            // 
            this.датаЗняттяDataGridViewTextBoxColumn.DataPropertyName = "Дата зняття";
            this.датаЗняттяDataGridViewTextBoxColumn.HeaderText = "Дата зняття";
            this.датаЗняттяDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.датаЗняттяDataGridViewTextBoxColumn.Name = "датаЗняттяDataGridViewTextBoxColumn";
            this.датаЗняттяDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.датаЗняттяDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаОцінкиDataGridViewTextBoxColumn
            // 
            this.датаОцінкиDataGridViewTextBoxColumn.DataPropertyName = "Дата оцінки";
            this.датаОцінкиDataGridViewTextBoxColumn.HeaderText = "Дата оцінки";
            this.датаОцінкиDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.датаОцінкиDataGridViewTextBoxColumn.Name = "датаОцінкиDataGridViewTextBoxColumn";
            this.датаОцінкиDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.датаОцінкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // lblBanN
            // 
            this.lblBanN.AutoSize = true;
            this.lblBanN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F);
            this.lblBanN.Location = new System.Drawing.Point(1025, 135);
            this.lblBanN.Name = "lblBanN";
            this.lblBanN.Size = new System.Drawing.Size(119, 26);
            this.lblBanN.TabIndex = 21;
            this.lblBanN.Text = "К. строк: 0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(608, 135);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 31);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(484, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Пошук:";
            // 
            // Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(1260, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBanN);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(пІБLabel);
            this.Controls.Add(this.пІБTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресаLabel);
            this.Controls.Add(this.адресаTextBox);
            this.Controls.Add(дата_народженняLabel);
            this.Controls.Add(this.дата_народженняDateTimePicker);
            this.Controls.Add(місце_роботиLabel);
            this.Controls.Add(this.місце_роботиTextBox);
            this.Controls.Add(дата_осудженняLabel);
            this.Controls.Add(this.дата_осудженняDateTimePicker);
            this.Controls.Add(дата_зняттяLabel);
            this.Controls.Add(this.дата_зняттяDateTimePicker);
            this.Controls.Add(дата_оцінкиLabel);
            this.Controls.Add(this.дата_оцінкиDateTimePicker);
            this.Controls.Add(this.banTableBindingNavigator);
            this.Name = "Ban";
            this.Text = "Ban";
            this.Load += new System.EventHandler(this.Ban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sample1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banTableBindingNavigator)).EndInit();
            this.banTableBindingNavigator.ResumeLayout(false);
            this.banTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sample1DataSet sample1DataSet;
        private System.Windows.Forms.BindingSource banTableBindingSource;
        private Sample1DataSetTableAdapters.BanTableTableAdapter banTableTableAdapter;
        private Sample1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator banTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton banTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox пІБTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox адресаTextBox;
        private System.Windows.Forms.DateTimePicker дата_народженняDateTimePicker;
        private System.Windows.Forms.TextBox місце_роботиTextBox;
        private System.Windows.Forms.DateTimePicker дата_осудженняDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_зняттяDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_оцінкиDateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пІБDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНародженняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn місцеРоботиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОсудженняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗняттяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОцінкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblBanN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}