namespace WindowsFormsAppKursova.Forms
{
    partial class OTG
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
            System.Windows.Forms.Label посадаLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label наслений_пунктLabel;
            System.Windows.Forms.Label дільничнийLabel;
            System.Windows.Forms.Label адресаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTG));
            this.panel1 = new System.Windows.Forms.Panel();
            this.otgList1 = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.oTGTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.пІБTextBox = new System.Windows.Forms.TextBox();
            this.посадаTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.наслений_пунктTextBox = new System.Windows.Forms.TextBox();
            this.дільничнийTextBox = new System.Windows.Forms.TextBox();
            this.адресаTextBox = new System.Windows.Forms.TextBox();
            this.oTGTableDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пІБDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.посадаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.насленийПунктDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дільничнийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTGTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sample1DataSet = new WindowsFormsAppKursova.Sample1DataSet();
            this.oTGTableTableAdapter = new WindowsFormsAppKursova.Sample1DataSetTableAdapters.OTGTableTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppKursova.Sample1DataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.oTGTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            пІБLabel = new System.Windows.Forms.Label();
            посадаLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            наслений_пунктLabel = new System.Windows.Forms.Label();
            дільничнийLabel = new System.Windows.Forms.Label();
            адресаLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oTGTableBindingNavigator)).BeginInit();
            this.oTGTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oTGTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTGTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sample1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // пІБLabel
            // 
            пІБLabel.AutoSize = true;
            пІБLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            пІБLabel.Location = new System.Drawing.Point(466, 56);
            пІБLabel.Name = "пІБLabel";
            пІБLabel.Size = new System.Drawing.Size(44, 22);
            пІБLabel.TabIndex = 4;
            пІБLabel.Text = "ПІБ:";
            // 
            // посадаLabel
            // 
            посадаLabel.AutoSize = true;
            посадаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            посадаLabel.Location = new System.Drawing.Point(466, 109);
            посадаLabel.Name = "посадаLabel";
            посадаLabel.Size = new System.Drawing.Size(78, 22);
            посадаLabel.TabIndex = 6;
            посадаLabel.Text = "Посада:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.Location = new System.Drawing.Point(820, 56);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(91, 22);
            телефонLabel.TabIndex = 8;
            телефонLabel.Text = "Телефон:";
            // 
            // наслений_пунктLabel
            // 
            наслений_пунктLabel.AutoSize = true;
            наслений_пунктLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наслений_пунктLabel.Location = new System.Drawing.Point(820, 107);
            наслений_пунктLabel.Name = "наслений_пунктLabel";
            наслений_пунктLabel.Size = new System.Drawing.Size(148, 22);
            наслений_пунктLabel.TabIndex = 10;
            наслений_пунктLabel.Text = "Наслений пункт:";
            // 
            // дільничнийLabel
            // 
            дільничнийLabel.AutoSize = true;
            дільничнийLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дільничнийLabel.Location = new System.Drawing.Point(820, 167);
            дільничнийLabel.Name = "дільничнийLabel";
            дільничнийLabel.Size = new System.Drawing.Size(112, 22);
            дільничнийLabel.TabIndex = 12;
            дільничнийLabel.Text = "Дільничний:";
            // 
            // адресаLabel
            // 
            адресаLabel.AutoSize = true;
            адресаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адресаLabel.Location = new System.Drawing.Point(467, 169);
            адресаLabel.Name = "адресаLabel";
            адресаLabel.Size = new System.Drawing.Size(77, 22);
            адресаLabel.TabIndex = 14;
            адресаLabel.Text = "Адреса:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.otgList1);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 578);
            this.panel1.TabIndex = 0;
            // 
            // otgList1
            // 
            this.otgList1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otgList1.FormattingEnabled = true;
            this.otgList1.Items.AddRange(new object[] {
            "Шабівська ОТГ",
            "Маразліївська ОТГ",
            "Мологівська ОТГ",
            "Старокозацька ОТГ",
            "Караліно-Бугазька ОТГ",
            "Сергіївська ОТГ"});
            this.otgList1.Location = new System.Drawing.Point(3, 115);
            this.otgList1.Name = "otgList1";
            this.otgList1.Size = new System.Drawing.Size(212, 30);
            this.otgList1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 22;
            this.listBox2.Location = new System.Drawing.Point(3, 171);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(227, 400);
            this.listBox2.TabIndex = 2;
            // 
            // oTGTableBindingNavigator
            // 
            this.oTGTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oTGTableBindingNavigator.BindingSource = this.oTGTableBindingSource;
            this.oTGTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oTGTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oTGTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.oTGTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oTGTableBindingNavigatorSaveItem});
            this.oTGTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.oTGTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oTGTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oTGTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oTGTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oTGTableBindingNavigator.Name = "oTGTableBindingNavigator";
            this.oTGTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oTGTableBindingNavigator.Size = new System.Drawing.Size(1194, 31);
            this.oTGTableBindingNavigator.TabIndex = 1;
            this.oTGTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // пІБTextBox
            // 
            this.пІБTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oTGTableBindingSource, "ПІБ", true));
            this.пІБTextBox.Location = new System.Drawing.Point(566, 58);
            this.пІБTextBox.Name = "пІБTextBox";
            this.пІБTextBox.Size = new System.Drawing.Size(219, 22);
            this.пІБTextBox.TabIndex = 0;
            // 
            // посадаTextBox
            // 
            this.посадаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oTGTableBindingSource, "Посада", true));
            this.посадаTextBox.Location = new System.Drawing.Point(566, 111);
            this.посадаTextBox.Name = "посадаTextBox";
            this.посадаTextBox.Size = new System.Drawing.Size(219, 22);
            this.посадаTextBox.TabIndex = 1;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oTGTableBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(987, 56);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(186, 22);
            this.телефонTextBox.TabIndex = 2;
            this.телефонTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.телефонTextBox_KeyPress_1);
            // 
            // наслений_пунктTextBox
            // 
            this.наслений_пунктTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oTGTableBindingSource, "Наслений пункт", true));
            this.наслений_пунктTextBox.Location = new System.Drawing.Point(987, 111);
            this.наслений_пунктTextBox.Name = "наслений_пунктTextBox";
            this.наслений_пунктTextBox.Size = new System.Drawing.Size(186, 22);
            this.наслений_пунктTextBox.TabIndex = 3;
            // 
            // дільничнийTextBox
            // 
            this.дільничнийTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oTGTableBindingSource, "Дільничний", true));
            this.дільничнийTextBox.Location = new System.Drawing.Point(954, 169);
            this.дільничнийTextBox.Name = "дільничнийTextBox";
            this.дільничнийTextBox.Size = new System.Drawing.Size(219, 22);
            this.дільничнийTextBox.TabIndex = 4;
            // 
            // адресаTextBox
            // 
            this.адресаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oTGTableBindingSource, "Адреса", true));
            this.адресаTextBox.Location = new System.Drawing.Point(566, 169);
            this.адресаTextBox.Name = "адресаTextBox";
            this.адресаTextBox.Size = new System.Drawing.Size(219, 22);
            this.адресаTextBox.TabIndex = 5;
            // 
            // oTGTableDataGridView
            // 
            this.oTGTableDataGridView.AllowUserToAddRows = false;
            this.oTGTableDataGridView.AutoGenerateColumns = false;
            this.oTGTableDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.oTGTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oTGTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.пІБDataGridViewTextBoxColumn,
            this.посадаDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.насленийПунктDataGridViewTextBoxColumn,
            this.дільничнийDataGridViewTextBoxColumn,
            this.адресаDataGridViewTextBoxColumn});
            this.oTGTableDataGridView.DataSource = this.oTGTableBindingSource;
            this.oTGTableDataGridView.Location = new System.Drawing.Point(383, 280);
            this.oTGTableDataGridView.Name = "oTGTableDataGridView";
            this.oTGTableDataGridView.RowHeadersWidth = 51;
            this.oTGTableDataGridView.RowTemplate.Height = 24;
            this.oTGTableDataGridView.Size = new System.Drawing.Size(790, 322);
            this.oTGTableDataGridView.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(455, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Пошук:";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(548, 242);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(264, 22);
            this.txtboxSearch.TabIndex = 6;
            
            this.txtboxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxSearch_KeyPress);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // пІБDataGridViewTextBoxColumn
            // 
            this.пІБDataGridViewTextBoxColumn.DataPropertyName = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.пІБDataGridViewTextBoxColumn.Name = "пІБDataGridViewTextBoxColumn";
            this.пІБDataGridViewTextBoxColumn.Width = 125;
            // 
            // посадаDataGridViewTextBoxColumn
            // 
            this.посадаDataGridViewTextBoxColumn.DataPropertyName = "Посада";
            this.посадаDataGridViewTextBoxColumn.HeaderText = "Посада";
            this.посадаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.посадаDataGridViewTextBoxColumn.Name = "посадаDataGridViewTextBoxColumn";
            this.посадаDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // насленийПунктDataGridViewTextBoxColumn
            // 
            this.насленийПунктDataGridViewTextBoxColumn.DataPropertyName = "Наслений пункт";
            this.насленийПунктDataGridViewTextBoxColumn.HeaderText = "Наслений пункт";
            this.насленийПунктDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.насленийПунктDataGridViewTextBoxColumn.Name = "насленийПунктDataGridViewTextBoxColumn";
            this.насленийПунктDataGridViewTextBoxColumn.Width = 125;
            // 
            // дільничнийDataGridViewTextBoxColumn
            // 
            this.дільничнийDataGridViewTextBoxColumn.DataPropertyName = "Дільничний";
            this.дільничнийDataGridViewTextBoxColumn.HeaderText = "Дільничний";
            this.дільничнийDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.дільничнийDataGridViewTextBoxColumn.Name = "дільничнийDataGridViewTextBoxColumn";
            this.дільничнийDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресаDataGridViewTextBoxColumn
            // 
            this.адресаDataGridViewTextBoxColumn.DataPropertyName = "Адреса";
            this.адресаDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.адресаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресаDataGridViewTextBoxColumn.Name = "адресаDataGridViewTextBoxColumn";
            this.адресаDataGridViewTextBoxColumn.Width = 125;
            // 
            // oTGTableBindingSource
            // 
            this.oTGTableBindingSource.DataMember = "OTGTable";
            this.oTGTableBindingSource.DataSource = this.sample1DataSet;
            // 
            // sample1DataSet
            // 
            this.sample1DataSet.DataSetName = "Sample1DataSet";
            this.sample1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oTGTableTableAdapter
            // 
            this.oTGTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._75TableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OTGTableTableAdapter = this.oTGTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppKursova.Sample1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
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
            // oTGTableBindingNavigatorSaveItem
            // 
            this.oTGTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oTGTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oTGTableBindingNavigatorSaveItem.Image")));
            this.oTGTableBindingNavigatorSaveItem.Name = "oTGTableBindingNavigatorSaveItem";
            this.oTGTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.oTGTableBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.oTGTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.oTGTableBindingNavigatorSaveItem_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsAppKursova.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(237, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 34);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppKursova.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(1194, 639);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oTGTableDataGridView);
            this.Controls.Add(пІБLabel);
            this.Controls.Add(this.пІБTextBox);
            this.Controls.Add(посадаLabel);
            this.Controls.Add(this.посадаTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(наслений_пунктLabel);
            this.Controls.Add(this.наслений_пунктTextBox);
            this.Controls.Add(дільничнийLabel);
            this.Controls.Add(this.дільничнийTextBox);
            this.Controls.Add(адресаLabel);
            this.Controls.Add(this.адресаTextBox);
            this.Controls.Add(this.oTGTableBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "OTG";
            this.Text = "OTG";
            this.Load += new System.EventHandler(this.OTG_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oTGTableBindingNavigator)).EndInit();
            this.oTGTableBindingNavigator.ResumeLayout(false);
            this.oTGTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oTGTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTGTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sample1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox otgList1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private Sample1DataSet sample1DataSet;
        private System.Windows.Forms.BindingSource oTGTableBindingSource;
        private Sample1DataSetTableAdapters.OTGTableTableAdapter oTGTableTableAdapter;
        private Sample1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator oTGTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oTGTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox пІБTextBox;
        private System.Windows.Forms.TextBox посадаTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox наслений_пунктTextBox;
        private System.Windows.Forms.TextBox дільничнийTextBox;
        private System.Windows.Forms.TextBox адресаTextBox;
        private System.Windows.Forms.DataGridView oTGTableDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пІБDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn посадаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn насленийПунктDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дільничнийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресаDataGridViewTextBoxColumn;
    }
}