namespace WindowsFormsAppKursova.Forms
{
    partial class Works
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
            System.Windows.Forms.Label статтяLabel;
            System.Windows.Forms.Label судLabel;
            System.Windows.Forms.Label вид_покаранняLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Works));
            this.woTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.пІБTextBox = new System.Windows.Forms.TextBox();
            this.дата_народженняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.адресаTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.статтяTextBox = new System.Windows.Forms.TextBox();
            this.судTextBox = new System.Windows.Forms.TextBox();
            this.вид_покаранняTextBox = new System.Windows.Forms.TextBox();
            this.woTableDataGridView = new System.Windows.Forms.DataGridView();
            this.lblN = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.woTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sample1DataSet = new WindowsFormsAppKursova.Sample1DataSet();
            this.woTableTableAdapter = new WindowsFormsAppKursova.Sample1DataSetTableAdapters.WoTableTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppKursova.Sample1DataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.woTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            пІБLabel = new System.Windows.Forms.Label();
            дата_народженняLabel = new System.Windows.Forms.Label();
            адресаLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            статтяLabel = new System.Windows.Forms.Label();
            судLabel = new System.Windows.Forms.Label();
            вид_покаранняLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.woTableBindingNavigator)).BeginInit();
            this.woTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.woTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sample1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // пІБLabel
            // 
            пІБLabel.AutoSize = true;
            пІБLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            пІБLabel.Location = new System.Drawing.Point(165, 63);
            пІБLabel.Name = "пІБLabel";
            пІБLabel.Size = new System.Drawing.Size(44, 22);
            пІБLabel.TabIndex = 4;
            пІБLabel.Text = "ПІБ:";
            // 
            // дата_народженняLabel
            // 
            дата_народженняLabel.AutoSize = true;
            дата_народженняLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            дата_народженняLabel.Location = new System.Drawing.Point(165, 136);
            дата_народженняLabel.Name = "дата_народженняLabel";
            дата_народженняLabel.Size = new System.Drawing.Size(167, 22);
            дата_народженняLabel.TabIndex = 6;
            дата_народженняLabel.Text = "Дата народження:";
            // 
            // адресаLabel
            // 
            адресаLabel.AutoSize = true;
            адресаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            адресаLabel.Location = new System.Drawing.Point(165, 199);
            адресаLabel.Name = "адресаLabel";
            адресаLabel.Size = new System.Drawing.Size(77, 22);
            адресаLabel.TabIndex = 8;
            адресаLabel.Text = "Адреса:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            телефонLabel.Location = new System.Drawing.Point(563, 50);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(91, 22);
            телефонLabel.TabIndex = 10;
            телефонLabel.Text = "Телефон:";
            // 
            // статтяLabel
            // 
            статтяLabel.AutoSize = true;
            статтяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            статтяLabel.Location = new System.Drawing.Point(563, 104);
            статтяLabel.Name = "статтяLabel";
            статтяLabel.Size = new System.Drawing.Size(72, 22);
            статтяLabel.TabIndex = 12;
            статтяLabel.Text = "Стаття:";
            // 
            // судLabel
            // 
            судLabel.AutoSize = true;
            судLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            судLabel.Location = new System.Drawing.Point(563, 161);
            судLabel.Name = "судLabel";
            судLabel.Size = new System.Drawing.Size(48, 22);
            судLabel.TabIndex = 14;
            судLabel.Text = "Суд:";
            // 
            // вид_покаранняLabel
            // 
            вид_покаранняLabel.AutoSize = true;
            вид_покаранняLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            вид_покаранняLabel.Location = new System.Drawing.Point(563, 216);
            вид_покаранняLabel.Name = "вид_покаранняLabel";
            вид_покаранняLabel.Size = new System.Drawing.Size(142, 22);
            вид_покаранняLabel.TabIndex = 16;
            вид_покаранняLabel.Text = "Вид покарання:";
            // 
            // woTableBindingNavigator
            // 
            this.woTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.woTableBindingNavigator.BindingSource = this.woTableBindingSource;
            this.woTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.woTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.woTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.woTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.woTableBindingNavigatorSaveItem});
            this.woTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.woTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.woTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.woTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.woTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.woTableBindingNavigator.Name = "woTableBindingNavigator";
            this.woTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.woTableBindingNavigator.Size = new System.Drawing.Size(920, 31);
            this.woTableBindingNavigator.TabIndex = 1;
            this.woTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // пІБTextBox
            // 
            this.пІБTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.woTableBindingSource, "ПІБ", true));
            this.пІБTextBox.Location = new System.Drawing.Point(363, 63);
            this.пІБTextBox.Multiline = true;
            this.пІБTextBox.Name = "пІБTextBox";
            this.пІБTextBox.Size = new System.Drawing.Size(179, 39);
            this.пІБTextBox.TabIndex = 0;
            // 
            // дата_народженняDateTimePicker
            // 
            this.дата_народженняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.woTableBindingSource, "Дата народження", true));
            this.дата_народженняDateTimePicker.Location = new System.Drawing.Point(363, 136);
            this.дата_народженняDateTimePicker.Name = "дата_народженняDateTimePicker";
            this.дата_народженняDateTimePicker.Size = new System.Drawing.Size(179, 22);
            this.дата_народженняDateTimePicker.TabIndex = 1;
            // 
            // адресаTextBox
            // 
            this.адресаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.woTableBindingSource, "Адреса", true));
            this.адресаTextBox.Location = new System.Drawing.Point(363, 201);
            this.адресаTextBox.Multiline = true;
            this.адресаTextBox.Name = "адресаTextBox";
            this.адресаTextBox.Size = new System.Drawing.Size(179, 39);
            this.адресаTextBox.TabIndex = 2;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.woTableBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(720, 52);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(200, 22);
            this.телефонTextBox.TabIndex = 3;
            this.телефонTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.телефонTextBox_KeyPress);
            // 
            // статтяTextBox
            // 
            this.статтяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.woTableBindingSource, "Стаття", true));
            this.статтяTextBox.Location = new System.Drawing.Point(720, 106);
            this.статтяTextBox.Name = "статтяTextBox";
            this.статтяTextBox.Size = new System.Drawing.Size(200, 22);
            this.статтяTextBox.TabIndex = 4;
            // 
            // судTextBox
            // 
            this.судTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.woTableBindingSource, "Суд", true));
            this.судTextBox.Location = new System.Drawing.Point(720, 163);
            this.судTextBox.Name = "судTextBox";
            this.судTextBox.Size = new System.Drawing.Size(200, 22);
            this.судTextBox.TabIndex = 5;
            // 
            // вид_покаранняTextBox
            // 
            this.вид_покаранняTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.woTableBindingSource, "Вид покарання", true));
            this.вид_покаранняTextBox.Location = new System.Drawing.Point(720, 218);
            this.вид_покаранняTextBox.Name = "вид_покаранняTextBox";
            this.вид_покаранняTextBox.Size = new System.Drawing.Size(200, 22);
            this.вид_покаранняTextBox.TabIndex = 6;
            // 
            // woTableDataGridView
            // 
            this.woTableDataGridView.AllowUserToAddRows = false;
            this.woTableDataGridView.AutoGenerateColumns = false;
            this.woTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.woTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.woTableDataGridView.DataSource = this.woTableBindingSource;
            this.woTableDataGridView.Location = new System.Drawing.Point(12, 309);
            this.woTableDataGridView.Name = "woTableDataGridView";
            this.woTableDataGridView.RowHeadersWidth = 51;
            this.woTableDataGridView.RowTemplate.Height = 24;
            this.woTableDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.woTableDataGridView.Size = new System.Drawing.Size(894, 203);
            this.woTableDataGridView.TabIndex = 17;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(368, 268);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(115, 30);
            this.lblN.TabIndex = 18;
            this.lblN.Text = "К.строк:0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 268);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 30);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
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
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Стаття";
            this.dataGridViewTextBoxColumn6.HeaderText = "Стаття";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Суд";
            this.dataGridViewTextBoxColumn7.HeaderText = "Суд";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Вид покарання";
            this.dataGridViewTextBoxColumn8.HeaderText = "Вид покарання";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // woTableBindingSource
            // 
            this.woTableBindingSource.DataMember = "WoTable";
            this.woTableBindingSource.DataSource = this.sample1DataSet;
            this.woTableBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.woTableBindingSource_ListChanged);
            // 
            // sample1DataSet
            // 
            this.sample1DataSet.DataSetName = "Sample1DataSet";
            this.sample1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // woTableTableAdapter
            // 
            this.woTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._75TableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BanTableTableAdapter = null;
            this.tableAdapterManager.CenterSocTableAdapter = null;
            this.tableAdapterManager.CourtTableTableAdapter = null;
            this.tableAdapterManager.FineTableTableAdapter = null;
            this.tableAdapterManager.OTGTableTableAdapter = null;
            this.tableAdapterManager.PoliceTableAdapter = null;
            this.tableAdapterManager.StudyTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppKursova.Sample1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WoTableTableAdapter = this.woTableTableAdapter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::WindowsFormsAppKursova.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(21, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 30);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // woTableBindingNavigatorSaveItem
            // 
            this.woTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.woTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("woTableBindingNavigatorSaveItem.Image")));
            this.woTableBindingNavigatorSaveItem.Name = "woTableBindingNavigatorSaveItem";
            this.woTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.woTableBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.woTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.woTableBindingNavigatorSaveItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppKursova.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Works
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(920, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.woTableDataGridView);
            this.Controls.Add(пІБLabel);
            this.Controls.Add(this.пІБTextBox);
            this.Controls.Add(дата_народженняLabel);
            this.Controls.Add(this.дата_народженняDateTimePicker);
            this.Controls.Add(адресаLabel);
            this.Controls.Add(this.адресаTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(статтяLabel);
            this.Controls.Add(this.статтяTextBox);
            this.Controls.Add(судLabel);
            this.Controls.Add(this.судTextBox);
            this.Controls.Add(вид_покаранняLabel);
            this.Controls.Add(this.вид_покаранняTextBox);
            this.Controls.Add(this.woTableBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Works";
            this.Text = "Works";
            this.Load += new System.EventHandler(this.Works_Load);
            ((System.ComponentModel.ISupportInitialize)(this.woTableBindingNavigator)).EndInit();
            this.woTableBindingNavigator.ResumeLayout(false);
            this.woTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.woTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sample1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sample1DataSet sample1DataSet;
        private System.Windows.Forms.BindingSource woTableBindingSource;
        private Sample1DataSetTableAdapters.WoTableTableAdapter woTableTableAdapter;
        private Sample1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator woTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton woTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox пІБTextBox;
        private System.Windows.Forms.DateTimePicker дата_народженняDateTimePicker;
        private System.Windows.Forms.TextBox адресаTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox статтяTextBox;
        private System.Windows.Forms.TextBox судTextBox;
        private System.Windows.Forms.TextBox вид_покаранняTextBox;
        private System.Windows.Forms.DataGridView woTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}