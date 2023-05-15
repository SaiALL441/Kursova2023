namespace WindowsFormsAppKursova.Forms
{
    partial class Form75
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
            System.Windows.Forms.Label дата_оцінкиLabel;
            System.Windows.Forms.Label дата_засудженняLabel;
            System.Windows.Forms.Label дата_зняттяLabel;
            System.Windows.Forms.Label дата_народженняLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form75));
            this.sample1DataSet = new WindowsFormsAppKursova.Sample1DataSet();
            this._75TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._75TableTableAdapter = new WindowsFormsAppKursova.Sample1DataSetTableAdapters._75TableTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppKursova.Sample1DataSetTableAdapters.TableAdapterManager();
            this._75TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this._75TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.пІБTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.дата_оцінкиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_засудженняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_зняттяDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_народженняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пІБDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОцінкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗасудженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗняттяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНародженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            пІБLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            дата_оцінкиLabel = new System.Windows.Forms.Label();
            дата_засудженняLabel = new System.Windows.Forms.Label();
            дата_зняттяLabel = new System.Windows.Forms.Label();
            дата_народженняLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sample1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._75TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._75TableBindingNavigator)).BeginInit();
            this._75TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // пІБLabel
            // 
            пІБLabel.AutoSize = true;
            пІБLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            пІБLabel.Location = new System.Drawing.Point(26, 306);
            пІБLabel.Name = "пІБLabel";
            пІБLabel.Size = new System.Drawing.Size(44, 22);
            пІБLabel.TabIndex = 3;
            пІБLabel.Text = "ПІБ:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            телефонLabel.Location = new System.Drawing.Point(26, 356);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(91, 22);
            телефонLabel.TabIndex = 5;
            телефонLabel.Text = "Телефон:";
            // 
            // дата_оцінкиLabel
            // 
            дата_оцінкиLabel.AutoSize = true;
            дата_оцінкиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            дата_оцінкиLabel.Location = new System.Drawing.Point(26, 403);
            дата_оцінкиLabel.Name = "дата_оцінкиLabel";
            дата_оцінкиLabel.Size = new System.Drawing.Size(116, 22);
            дата_оцінкиLabel.TabIndex = 7;
            дата_оцінкиLabel.Text = "Дата оцінки:";
            // 
            // дата_засудженняLabel
            // 
            дата_засудженняLabel.AutoSize = true;
            дата_засудженняLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            дата_засудженняLabel.Location = new System.Drawing.Point(26, 453);
            дата_засудженняLabel.Name = "дата_засудженняLabel";
            дата_засудженняLabel.Size = new System.Drawing.Size(164, 22);
            дата_засудженняLabel.TabIndex = 9;
            дата_засудженняLabel.Text = "Дата засудження:";
            // 
            // дата_зняттяLabel
            // 
            дата_зняттяLabel.AutoSize = true;
            дата_зняттяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            дата_зняттяLabel.Location = new System.Drawing.Point(26, 501);
            дата_зняттяLabel.Name = "дата_зняттяLabel";
            дата_зняттяLabel.Size = new System.Drawing.Size(117, 22);
            дата_зняттяLabel.TabIndex = 11;
            дата_зняттяLabel.Text = "Дата зняття:";
            // 
            // дата_народженняLabel
            // 
            дата_народженняLabel.AutoSize = true;
            дата_народженняLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            дата_народженняLabel.Location = new System.Drawing.Point(26, 546);
            дата_народженняLabel.Name = "дата_народженняLabel";
            дата_народженняLabel.Size = new System.Drawing.Size(167, 22);
            дата_народженняLabel.TabIndex = 13;
            дата_народженняLabel.Text = "Дата народження:";
            // 
            // sample1DataSet
            // 
            this.sample1DataSet.DataSetName = "Sample1DataSet";
            this.sample1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _75TableBindingSource
            // 
            this._75TableBindingSource.DataMember = "75Table";
            this._75TableBindingSource.DataSource = this.sample1DataSet;
            this._75TableBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this._75TableBindingSource_ListChanged);
            // 
            // _75TableTableAdapter
            // 
            this._75TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._75TableTableAdapter = this._75TableTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BanTableTableAdapter = null;
            this.tableAdapterManager.CenterSocTableAdapter = null;
            this.tableAdapterManager.CourtTableTableAdapter = null;
            this.tableAdapterManager.FineTableTableAdapter = null;
            this.tableAdapterManager.OTGTableTableAdapter = null;
            this.tableAdapterManager.PoliceTableAdapter = null;
            this.tableAdapterManager.SSDTableAdapter = null;
            this.tableAdapterManager.StudyTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppKursova.Sample1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WoTableTableAdapter = null;
            // 
            // _75TableBindingNavigator
            // 
            this._75TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this._75TableBindingNavigator.BindingSource = this._75TableBindingSource;
            this._75TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this._75TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this._75TableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._75TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this._75TableBindingNavigatorSaveItem});
            this._75TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this._75TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._75TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._75TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._75TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._75TableBindingNavigator.Name = "_75TableBindingNavigator";
            this._75TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this._75TableBindingNavigator.Size = new System.Drawing.Size(1260, 27);
            this._75TableBindingNavigator.TabIndex = 0;
            this._75TableBindingNavigator.Text = "bindingNavigator1";
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
            // _75TableBindingNavigatorSaveItem
            // 
            this._75TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._75TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("_75TableBindingNavigatorSaveItem.Image")));
            this._75TableBindingNavigatorSaveItem.Name = "_75TableBindingNavigatorSaveItem";
            this._75TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this._75TableBindingNavigatorSaveItem.Text = "Сохранить данные";
            this._75TableBindingNavigatorSaveItem.Click += new System.EventHandler(this._75TableBindingNavigatorSaveItem_Click);
            // 
            // пІБTextBox
            // 
            this.пІБTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._75TableBindingSource, "ПІБ", true));
            this.пІБTextBox.Location = new System.Drawing.Point(221, 298);
            this.пІБTextBox.Multiline = true;
            this.пІБTextBox.Name = "пІБTextBox";
            this.пІБTextBox.Size = new System.Drawing.Size(210, 30);
            this.пІБTextBox.TabIndex = 0;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._75TableBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(221, 346);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(210, 22);
            this.телефонTextBox.TabIndex = 1;
            this.телефонTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.телефонTextBox_KeyPress);
            // 
            // дата_оцінкиDateTimePicker
            // 
            this.дата_оцінкиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._75TableBindingSource, "Дата оцінки", true));
            this.дата_оцінкиDateTimePicker.Location = new System.Drawing.Point(221, 394);
            this.дата_оцінкиDateTimePicker.Name = "дата_оцінкиDateTimePicker";
            this.дата_оцінкиDateTimePicker.Size = new System.Drawing.Size(187, 22);
            this.дата_оцінкиDateTimePicker.TabIndex = 2;
            // 
            // дата_засудженняDateTimePicker
            // 
            this.дата_засудженняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._75TableBindingSource, "Дата засудження", true));
            this.дата_засудженняDateTimePicker.Location = new System.Drawing.Point(221, 453);
            this.дата_засудженняDateTimePicker.Name = "дата_засудженняDateTimePicker";
            this.дата_засудженняDateTimePicker.Size = new System.Drawing.Size(187, 22);
            this.дата_засудженняDateTimePicker.TabIndex = 3;
            // 
            // дата_зняттяDateTimePicker
            // 
            this.дата_зняттяDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._75TableBindingSource, "Дата зняття", true));
            this.дата_зняттяDateTimePicker.Location = new System.Drawing.Point(221, 501);
            this.дата_зняттяDateTimePicker.Name = "дата_зняттяDateTimePicker";
            this.дата_зняттяDateTimePicker.Size = new System.Drawing.Size(187, 22);
            this.дата_зняттяDateTimePicker.TabIndex = 4;
            // 
            // дата_народженняDateTimePicker
            // 
            this.дата_народженняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._75TableBindingSource, "Дата народження", true));
            this.дата_народженняDateTimePicker.Location = new System.Drawing.Point(221, 546);
            this.дата_народженняDateTimePicker.Name = "дата_народженняDateTimePicker";
            this.дата_народженняDateTimePicker.Size = new System.Drawing.Size(187, 22);
            this.дата_народженняDateTimePicker.TabIndex = 5;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            this.advancedDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.пІБDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.датаОцінкиDataGridViewTextBoxColumn,
            this.датаЗасудженняDataGridViewTextBoxColumn,
            this.датаЗняттяDataGridViewTextBoxColumn,
            this.датаНародженняDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this._75TableBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(447, 154);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(801, 361);
            this.advancedDataGridView1.TabIndex = 15;
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
            // датаОцінкиDataGridViewTextBoxColumn
            // 
            this.датаОцінкиDataGridViewTextBoxColumn.DataPropertyName = "Дата оцінки";
            this.датаОцінкиDataGridViewTextBoxColumn.HeaderText = "Дата оцінки";
            this.датаОцінкиDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.датаОцінкиDataGridViewTextBoxColumn.Name = "датаОцінкиDataGridViewTextBoxColumn";
            this.датаОцінкиDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.датаОцінкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаЗасудженняDataGridViewTextBoxColumn
            // 
            this.датаЗасудженняDataGridViewTextBoxColumn.DataPropertyName = "Дата засудження";
            this.датаЗасудженняDataGridViewTextBoxColumn.HeaderText = "Дата засудження";
            this.датаЗасудженняDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.датаЗасудженняDataGridViewTextBoxColumn.Name = "датаЗасудженняDataGridViewTextBoxColumn";
            this.датаЗасудженняDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.датаЗасудженняDataGridViewTextBoxColumn.Width = 125;
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
            // датаНародженняDataGridViewTextBoxColumn
            // 
            this.датаНародженняDataGridViewTextBoxColumn.DataPropertyName = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.датаНародженняDataGridViewTextBoxColumn.Name = "датаНародженняDataGridViewTextBoxColumn";
            this.датаНародженняDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.датаНародженняDataGridViewTextBoxColumn.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppKursova.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(1107, 524);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(113, 26);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "К.строк: 0";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(221, 67);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 23;
            // 
            // Form75
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1260, 589);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(пІБLabel);
            this.Controls.Add(this.пІБTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(дата_оцінкиLabel);
            this.Controls.Add(this.дата_оцінкиDateTimePicker);
            this.Controls.Add(дата_засудженняLabel);
            this.Controls.Add(this.дата_засудженняDateTimePicker);
            this.Controls.Add(дата_зняттяLabel);
            this.Controls.Add(this.дата_зняттяDateTimePicker);
            this.Controls.Add(дата_народженняLabel);
            this.Controls.Add(this.дата_народженняDateTimePicker);
            this.Controls.Add(this._75TableBindingNavigator);
            this.Name = "Form75";
            this.Text = "Form75";
            this.Load += new System.EventHandler(this.Form75_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sample1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._75TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._75TableBindingNavigator)).EndInit();
            this._75TableBindingNavigator.ResumeLayout(false);
            this._75TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sample1DataSet sample1DataSet;
        private System.Windows.Forms.BindingSource _75TableBindingSource;
        private Sample1DataSetTableAdapters._75TableTableAdapter _75TableTableAdapter;
        private Sample1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator _75TableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton _75TableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox пІБTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.DateTimePicker дата_оцінкиDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_засудженняDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_зняттяDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_народженняDateTimePicker;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пІБDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОцінкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗасудженняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗняттяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНародженняDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}