namespace WindowsFormsAppKursova.Forms
{
    partial class Court
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
            System.Windows.Forms.Label пІБ_суддіLabel;
            System.Windows.Forms.Label канцеляріяLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label помічники_суддіLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Court));
            this.sample1DataSet = new WindowsFormsAppKursova.Sample1DataSet();
            this.courtTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courtTableTableAdapter = new WindowsFormsAppKursova.Sample1DataSetTableAdapters.CourtTableTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppKursova.Sample1DataSetTableAdapters.TableAdapterManager();
            this.courtTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.пІБ_суддіTextBox = new System.Windows.Forms.TextBox();
            this.канцеляріяTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.помічники_суддіTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.courtTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.courtTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            пІБ_суддіLabel = new System.Windows.Forms.Label();
            канцеляріяLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            помічники_суддіLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sample1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtTableBindingNavigator)).BeginInit();
            this.courtTableBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courtTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // пІБ_суддіLabel
            // 
            пІБ_суддіLabel.AutoSize = true;
            пІБ_суддіLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            пІБ_суддіLabel.Location = new System.Drawing.Point(-5, 29);
            пІБ_суддіLabel.Name = "пІБ_суддіLabel";
            пІБ_суддіLabel.Size = new System.Drawing.Size(101, 25);
            пІБ_суддіLabel.TabIndex = 4;
            пІБ_суддіLabel.Text = "ПІБ судді:";
            // 
            // канцеляріяLabel
            // 
            канцеляріяLabel.AutoSize = true;
            канцеляріяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            канцеляріяLabel.Location = new System.Drawing.Point(-5, 117);
            канцеляріяLabel.Name = "канцеляріяLabel";
            канцеляріяLabel.Size = new System.Drawing.Size(123, 25);
            канцеляріяLabel.TabIndex = 6;
            канцеляріяLabel.Text = "Канцелярія:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.Location = new System.Drawing.Point(304, 27);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(105, 25);
            телефонLabel.TabIndex = 8;
            телефонLabel.Text = "Телефон:";
            // 
            // помічники_суддіLabel
            // 
            помічники_суддіLabel.AutoSize = true;
            помічники_суддіLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            помічники_суддіLabel.Location = new System.Drawing.Point(304, 117);
            помічники_суддіLabel.Name = "помічники_суддіLabel";
            помічники_суддіLabel.Size = new System.Drawing.Size(170, 25);
            помічники_суддіLabel.TabIndex = 10;
            помічники_суддіLabel.Text = "Помічники судді:";
            // 
            // sample1DataSet
            // 
            this.sample1DataSet.DataSetName = "Sample1DataSet";
            this.sample1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courtTableBindingSource
            // 
            this.courtTableBindingSource.DataMember = "CourtTable";
            this.courtTableBindingSource.DataSource = this.sample1DataSet;
            // 
            // courtTableTableAdapter
            // 
            this.courtTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._75TableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BanTableTableAdapter = null;
            this.tableAdapterManager.CenterSocTableAdapter = null;
            this.tableAdapterManager.CourtTableTableAdapter = this.courtTableTableAdapter;
            this.tableAdapterManager.FineTableTableAdapter = null;
            this.tableAdapterManager.OTGTableTableAdapter = null;
            this.tableAdapterManager.PoliceTableAdapter = null;
            this.tableAdapterManager.SSDTableAdapter = null;
            this.tableAdapterManager.StudyTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppKursova.Sample1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WoTableTableAdapter = null;
            // 
            // courtTableBindingNavigator
            // 
            this.courtTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.courtTableBindingNavigator.BindingSource = this.courtTableBindingSource;
            this.courtTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.courtTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.courtTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.courtTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.courtTableBindingNavigatorSaveItem});
            this.courtTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.courtTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.courtTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.courtTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.courtTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.courtTableBindingNavigator.Name = "courtTableBindingNavigator";
            this.courtTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.courtTableBindingNavigator.Size = new System.Drawing.Size(822, 27);
            this.courtTableBindingNavigator.TabIndex = 1;
            this.courtTableBindingNavigator.Text = "bindingNavigator1";
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
            // пІБ_суддіTextBox
            // 
            this.пІБ_суддіTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courtTableBindingSource, "ПІБ судді", true));
            this.пІБ_суддіTextBox.Location = new System.Drawing.Point(132, 27);
            this.пІБ_суддіTextBox.Multiline = true;
            this.пІБ_суддіTextBox.Name = "пІБ_суддіTextBox";
            this.пІБ_суддіTextBox.Size = new System.Drawing.Size(155, 48);
            this.пІБ_суддіTextBox.TabIndex = 5;
            // 
            // канцеляріяTextBox
            // 
            this.канцеляріяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courtTableBindingSource, "Канцелярія", true));
            this.канцеляріяTextBox.Location = new System.Drawing.Point(132, 117);
            this.канцеляріяTextBox.Multiline = true;
            this.канцеляріяTextBox.Name = "канцеляріяTextBox";
            this.канцеляріяTextBox.Size = new System.Drawing.Size(155, 48);
            this.канцеляріяTextBox.TabIndex = 7;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courtTableBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(483, 32);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(152, 22);
            this.телефонTextBox.TabIndex = 9;
            this.телефонTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.телефонTextBox_KeyPress);
            // 
            // помічники_суддіTextBox
            // 
            this.помічники_суддіTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courtTableBindingSource, "Помічники судді", true));
            this.помічники_суддіTextBox.Location = new System.Drawing.Point(483, 117);
            this.помічники_суддіTextBox.Multiline = true;
            this.помічники_суддіTextBox.Name = "помічники_суддіTextBox";
            this.помічники_суддіTextBox.Size = new System.Drawing.Size(155, 48);
            this.помічники_суддіTextBox.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.телефонTextBox);
            this.panel1.Controls.Add(пІБ_суддіLabel);
            this.panel1.Controls.Add(this.помічники_суддіTextBox);
            this.panel1.Controls.Add(this.пІБ_суддіTextBox);
            this.panel1.Controls.Add(помічники_суддіLabel);
            this.panel1.Controls.Add(канцеляріяLabel);
            this.panel1.Controls.Add(телефонLabel);
            this.panel1.Controls.Add(this.канцеляріяTextBox);
            this.panel1.Location = new System.Drawing.Point(137, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 178);
            this.panel1.TabIndex = 12;
            // 
            // courtTableDataGridView
            // 
            this.courtTableDataGridView.AllowUserToAddRows = false;
            this.courtTableDataGridView.AutoGenerateColumns = false;
            this.courtTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courtTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.courtTableDataGridView.DataSource = this.courtTableBindingSource;
            this.courtTableDataGridView.Location = new System.Drawing.Point(44, 303);
            this.courtTableDataGridView.Name = "courtTableDataGridView";
            this.courtTableDataGridView.RowHeadersWidth = 51;
            this.courtTableDataGridView.RowTemplate.Height = 24;
            this.courtTableDataGridView.Size = new System.Drawing.Size(733, 220);
            this.courtTableDataGridView.TabIndex = 12;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ПІБ судді";
            this.dataGridViewTextBoxColumn2.HeaderText = "ПІБ судді";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Канцелярія";
            this.dataGridViewTextBoxColumn3.HeaderText = "Канцелярія";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn4.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Помічники судді";
            this.dataGridViewTextBoxColumn5.HeaderText = "Помічники судді";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Пошук:";
            // 
            // txtCourt
            // 
            this.txtCourt.Location = new System.Drawing.Point(241, 268);
            this.txtCourt.Name = "txtCourt";
            this.txtCourt.Size = new System.Drawing.Size(284, 22);
            this.txtCourt.TabIndex = 14;
            this.txtCourt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCourt_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsAppKursova.Properties.Resources.court;
            this.pictureBox2.Location = new System.Drawing.Point(5, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
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
            // courtTableBindingNavigatorSaveItem
            // 
            this.courtTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.courtTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("courtTableBindingNavigatorSaveItem.Image")));
            this.courtTableBindingNavigatorSaveItem.Name = "courtTableBindingNavigatorSaveItem";
            this.courtTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.courtTableBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.courtTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.courtTableBindingNavigatorSaveItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppKursova.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Court
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(822, 536);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtCourt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courtTableDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.courtTableBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Court";
            this.Text = "Court";
            this.Load += new System.EventHandler(this.Court_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sample1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtTableBindingNavigator)).EndInit();
            this.courtTableBindingNavigator.ResumeLayout(false);
            this.courtTableBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courtTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sample1DataSet sample1DataSet;
        private System.Windows.Forms.BindingSource courtTableBindingSource;
        private Sample1DataSetTableAdapters.CourtTableTableAdapter courtTableTableAdapter;
        private Sample1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator courtTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton courtTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox пІБ_суддіTextBox;
        private System.Windows.Forms.TextBox канцеляріяTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox помічники_суддіTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView courtTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourt;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}