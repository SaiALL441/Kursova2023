namespace WindowsFormsAppKursova.Forms
{
    partial class Fine
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
            System.Windows.Forms.Label дата_народженняLabel;
            System.Windows.Forms.Label адресаLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label дата_осудженняLabel;
            System.Windows.Forms.Label дата_вступу_в_законну_силуLabel;
            System.Windows.Forms.Label сумаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fine));
            this.fineTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.fineTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sample1DataSet = new WindowsFormsAppKursova.Sample1DataSet();
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
            this.fineTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.пІБTextBox = new System.Windows.Forms.TextBox();
            this.дата_народженняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.адресаTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.дата_осудженняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_вступу_в_законну_силуDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.сумаTextBox = new System.Windows.Forms.TextBox();
            this.fineTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFineN = new System.Windows.Forms.Label();
            this.fineTableTableAdapter = new WindowsFormsAppKursova.Sample1DataSetTableAdapters.FineTableTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppKursova.Sample1DataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            пІБLabel = new System.Windows.Forms.Label();
            дата_народженняLabel = new System.Windows.Forms.Label();
            адресаLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            дата_осудженняLabel = new System.Windows.Forms.Label();
            дата_вступу_в_законну_силуLabel = new System.Windows.Forms.Label();
            сумаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fineTableBindingNavigator)).BeginInit();
            this.fineTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fineTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sample1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // пІБLabel
            // 
            пІБLabel.AutoSize = true;
            пІБLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            пІБLabel.Location = new System.Drawing.Point(25, 156);
            пІБLabel.Name = "пІБLabel";
            пІБLabel.Size = new System.Drawing.Size(44, 22);
            пІБLabel.TabIndex = 4;
            пІБLabel.Text = "ПІБ:";
            // 
            // дата_народженняLabel
            // 
            дата_народженняLabel.AutoSize = true;
            дата_народженняLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            дата_народженняLabel.Location = new System.Drawing.Point(25, 210);
            дата_народженняLabel.Name = "дата_народженняLabel";
            дата_народженняLabel.Size = new System.Drawing.Size(167, 22);
            дата_народженняLabel.TabIndex = 6;
            дата_народженняLabel.Text = "Дата народження:";
            // 
            // адресаLabel
            // 
            адресаLabel.AutoSize = true;
            адресаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            адресаLabel.Location = new System.Drawing.Point(25, 259);
            адресаLabel.Name = "адресаLabel";
            адресаLabel.Size = new System.Drawing.Size(77, 22);
            адресаLabel.TabIndex = 8;
            адресаLabel.Text = "Адреса:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            телефонLabel.Location = new System.Drawing.Point(25, 327);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(91, 22);
            телефонLabel.TabIndex = 10;
            телефонLabel.Text = "Телефон:";
            // 
            // дата_осудженняLabel
            // 
            дата_осудженняLabel.AutoSize = true;
            дата_осудженняLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            дата_осудженняLabel.Location = new System.Drawing.Point(25, 377);
            дата_осудженняLabel.Name = "дата_осудженняLabel";
            дата_осудженняLabel.Size = new System.Drawing.Size(155, 22);
            дата_осудженняLabel.TabIndex = 12;
            дата_осудженняLabel.Text = "Дата осудження:";
            // 
            // дата_вступу_в_законну_силуLabel
            // 
            дата_вступу_в_законну_силуLabel.AutoSize = true;
            дата_вступу_в_законну_силуLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            дата_вступу_в_законну_силуLabel.Location = new System.Drawing.Point(25, 419);
            дата_вступу_в_законну_силуLabel.Name = "дата_вступу_в_законну_силуLabel";
            дата_вступу_в_законну_силуLabel.Size = new System.Drawing.Size(247, 22);
            дата_вступу_в_законну_силуLabel.TabIndex = 14;
            дата_вступу_в_законну_силуLabel.Text = "Дата вступу в законну силу:";
            // 
            // сумаLabel
            // 
            сумаLabel.AutoSize = true;
            сумаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            сумаLabel.Location = new System.Drawing.Point(25, 469);
            сумаLabel.Name = "сумаLabel";
            сумаLabel.Size = new System.Drawing.Size(60, 22);
            сумаLabel.TabIndex = 16;
            сумаLabel.Text = "Сума:";
            // 
            // fineTableBindingNavigator
            // 
            this.fineTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fineTableBindingNavigator.BindingSource = this.fineTableBindingSource;
            this.fineTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fineTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fineTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fineTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fineTableBindingNavigatorSaveItem});
            this.fineTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fineTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fineTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fineTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fineTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fineTableBindingNavigator.Name = "fineTableBindingNavigator";
            this.fineTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fineTableBindingNavigator.Size = new System.Drawing.Size(1415, 27);
            this.fineTableBindingNavigator.TabIndex = 1;
            this.fineTableBindingNavigator.Text = "bindingNavigator1";
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
            // fineTableBindingSource
            // 
            this.fineTableBindingSource.DataMember = "FineTable";
            this.fineTableBindingSource.DataSource = this.sample1DataSet;
            this.fineTableBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.fineTableBindingSource_ListChanged);
            // 
            // sample1DataSet
            // 
            this.sample1DataSet.DataSetName = "Sample1DataSet";
            this.sample1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // fineTableBindingNavigatorSaveItem
            // 
            this.fineTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fineTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fineTableBindingNavigatorSaveItem.Image")));
            this.fineTableBindingNavigatorSaveItem.Name = "fineTableBindingNavigatorSaveItem";
            this.fineTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.fineTableBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.fineTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.fineTableBindingNavigatorSaveItem_Click);
            // 
            // пІБTextBox
            // 
            this.пІБTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fineTableBindingSource, "ПІБ", true));
            this.пІБTextBox.Location = new System.Drawing.Point(272, 156);
            this.пІБTextBox.Multiline = true;
            this.пІБTextBox.Name = "пІБTextBox";
            this.пІБTextBox.Size = new System.Drawing.Size(215, 34);
            this.пІБTextBox.TabIndex = 0;
            // 
            // дата_народженняDateTimePicker
            // 
            this.дата_народженняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fineTableBindingSource, "Дата народження", true));
            this.дата_народженняDateTimePicker.Location = new System.Drawing.Point(272, 210);
            this.дата_народженняDateTimePicker.Name = "дата_народженняDateTimePicker";
            this.дата_народженняDateTimePicker.Size = new System.Drawing.Size(215, 22);
            this.дата_народженняDateTimePicker.TabIndex = 1;
            // 
            // адресаTextBox
            // 
            this.адресаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fineTableBindingSource, "Адреса", true));
            this.адресаTextBox.Location = new System.Drawing.Point(272, 261);
            this.адресаTextBox.Multiline = true;
            this.адресаTextBox.Name = "адресаTextBox";
            this.адресаTextBox.Size = new System.Drawing.Size(215, 36);
            this.адресаTextBox.TabIndex = 2;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fineTableBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(287, 329);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(200, 22);
            this.телефонTextBox.TabIndex = 3;
            this.телефонTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.телефонTextBox_KeyPress);
            // 
            // дата_осудженняDateTimePicker
            // 
            this.дата_осудженняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fineTableBindingSource, "Дата осудження", true));
            this.дата_осудженняDateTimePicker.Location = new System.Drawing.Point(287, 377);
            this.дата_осудженняDateTimePicker.Name = "дата_осудженняDateTimePicker";
            this.дата_осудженняDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_осудженняDateTimePicker.TabIndex = 4;
            // 
            // дата_вступу_в_законну_силуDateTimePicker
            // 
            this.дата_вступу_в_законну_силуDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fineTableBindingSource, "Дата вступу в законну силу", true));
            this.дата_вступу_в_законну_силуDateTimePicker.Location = new System.Drawing.Point(287, 419);
            this.дата_вступу_в_законну_силуDateTimePicker.Name = "дата_вступу_в_законну_силуDateTimePicker";
            this.дата_вступу_в_законну_силуDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_вступу_в_законну_силуDateTimePicker.TabIndex = 5;
            // 
            // сумаTextBox
            // 
            this.сумаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fineTableBindingSource, "Сума", true));
            this.сумаTextBox.Location = new System.Drawing.Point(287, 471);
            this.сумаTextBox.Name = "сумаTextBox";
            this.сумаTextBox.Size = new System.Drawing.Size(200, 22);
            this.сумаTextBox.TabIndex = 6;
            this.сумаTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.сумаTextBox_KeyPress);
            // 
            // fineTableDataGridView
            // 
            this.fineTableDataGridView.AllowUserToAddRows = false;
            this.fineTableDataGridView.AutoGenerateColumns = false;
            this.fineTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fineTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.fineTableDataGridView.DataSource = this.fineTableBindingSource;
            this.fineTableDataGridView.Location = new System.Drawing.Point(507, 135);
            this.fineTableDataGridView.Name = "fineTableDataGridView";
            this.fineTableDataGridView.RowHeadersWidth = 51;
            this.fineTableDataGridView.RowTemplate.Height = 24;
            this.fineTableDataGridView.Size = new System.Drawing.Size(908, 360);
            this.fineTableDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ПІБ";
            this.dataGridViewTextBoxColumn2.HeaderText = "ПІБ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата народження";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата народження";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Адреса";
            this.dataGridViewTextBoxColumn4.HeaderText = "Адреса";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата осудження";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата осудження";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Дата вступу в законну силу";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата вступу в законну силу";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Сума";
            this.dataGridViewTextBoxColumn8.HeaderText = "Сума";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(517, 69);
            this.txtFine.Multiline = true;
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(375, 38);
            this.txtFine.TabIndex = 7;
            this.txtFine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFine_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(918, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Пошук";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblFineN
            // 
            this.lblFineN.AutoSize = true;
            this.lblFineN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F);
            this.lblFineN.Location = new System.Drawing.Point(1092, 72);
            this.lblFineN.Name = "lblFineN";
            this.lblFineN.Size = new System.Drawing.Size(113, 26);
            this.lblFineN.TabIndex = 20;
            this.lblFineN.Text = "К.строк: 0";
            // 
            // fineTableTableAdapter
            // 
            this.fineTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._75TableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BanTableTableAdapter = null;
            this.tableAdapterManager.FineTableTableAdapter = this.fineTableTableAdapter;
            this.tableAdapterManager.OTGTableTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppKursova.Sample1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WoTableTableAdapter = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppKursova.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(18, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Fine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1415, 541);
            this.Controls.Add(this.lblFineN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.fineTableDataGridView);
            this.Controls.Add(пІБLabel);
            this.Controls.Add(this.пІБTextBox);
            this.Controls.Add(дата_народженняLabel);
            this.Controls.Add(this.дата_народженняDateTimePicker);
            this.Controls.Add(адресаLabel);
            this.Controls.Add(this.адресаTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(дата_осудженняLabel);
            this.Controls.Add(this.дата_осудженняDateTimePicker);
            this.Controls.Add(дата_вступу_в_законну_силуLabel);
            this.Controls.Add(this.дата_вступу_в_законну_силуDateTimePicker);
            this.Controls.Add(сумаLabel);
            this.Controls.Add(this.сумаTextBox);
            this.Controls.Add(this.fineTableBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Fine";
            this.Text = "Fine";
            this.Load += new System.EventHandler(this.Fine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fineTableBindingNavigator)).EndInit();
            this.fineTableBindingNavigator.ResumeLayout(false);
            this.fineTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fineTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sample1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sample1DataSet sample1DataSet;
        private System.Windows.Forms.BindingSource fineTableBindingSource;
        private Sample1DataSetTableAdapters.FineTableTableAdapter fineTableTableAdapter;
        private Sample1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fineTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fineTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox пІБTextBox;
        private System.Windows.Forms.DateTimePicker дата_народженняDateTimePicker;
        private System.Windows.Forms.TextBox адресаTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.DateTimePicker дата_осудженняDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_вступу_в_законну_силуDateTimePicker;
        private System.Windows.Forms.TextBox сумаTextBox;
        private System.Windows.Forms.DataGridView fineTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFineN;
    }
}