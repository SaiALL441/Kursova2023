namespace WindowsFormsAppKursova.Forms
{
    partial class StudyPlace
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
            System.Windows.Forms.Label назва_уч__закладуLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyPlace));
            this.sample1DataSet = new WindowsFormsAppKursova.Sample1DataSet();
            this.studyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studyTableAdapter = new WindowsFormsAppKursova.Sample1DataSetTableAdapters.StudyTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppKursova.Sample1DataSetTableAdapters.TableAdapterManager();
            this.studyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.пІБTextBox = new System.Windows.Forms.TextBox();
            this.посадаTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.назва_уч__закладуTextBox = new System.Windows.Forms.TextBox();
            this.studyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudySearch = new System.Windows.Forms.TextBox();
            пІБLabel = new System.Windows.Forms.Label();
            посадаLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            назва_уч__закладуLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sample1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyBindingNavigator)).BeginInit();
            this.studyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // пІБLabel
            // 
            пІБLabel.AutoSize = true;
            пІБLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            пІБLabel.Location = new System.Drawing.Point(153, 58);
            пІБLabel.Name = "пІБLabel";
            пІБLabel.Size = new System.Drawing.Size(49, 25);
            пІБLabel.TabIndex = 3;
            пІБLabel.Text = "ПІБ:";
            // 
            // посадаLabel
            // 
            посадаLabel.AutoSize = true;
            посадаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            посадаLabel.Location = new System.Drawing.Point(153, 154);
            посадаLabel.Name = "посадаLabel";
            посадаLabel.Size = new System.Drawing.Size(85, 25);
            посадаLabel.TabIndex = 5;
            посадаLabel.Text = "Посада:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.Location = new System.Drawing.Point(467, 64);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(105, 25);
            телефонLabel.TabIndex = 7;
            телефонLabel.Text = "Телефон:";
            // 
            // назва_уч__закладуLabel
            // 
            назва_уч__закладуLabel.AutoSize = true;
            назва_уч__закладуLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            назва_уч__закладуLabel.Location = new System.Drawing.Point(456, 158);
            назва_уч__закладуLabel.Name = "назва_уч__закладуLabel";
            назва_уч__закладуLabel.Size = new System.Drawing.Size(238, 25);
            назва_уч__закладуLabel.TabIndex = 9;
            назва_уч__закладуLabel.Text = "Назва учбового закладу:";
            // 
            // sample1DataSet
            // 
            this.sample1DataSet.DataSetName = "Sample1DataSet";
            this.sample1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studyBindingSource
            // 
            this.studyBindingSource.DataMember = "Study";
            this.studyBindingSource.DataSource = this.sample1DataSet;
            // 
            // studyTableAdapter
            // 
            this.studyTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SSDTableAdapter = null;
            this.tableAdapterManager.StudyTableAdapter = this.studyTableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppKursova.Sample1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WoTableTableAdapter = null;
            // 
            // studyBindingNavigator
            // 
            this.studyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studyBindingNavigator.BindingSource = this.studyBindingSource;
            this.studyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studyBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.studyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studyBindingNavigatorSaveItem});
            this.studyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studyBindingNavigator.Name = "studyBindingNavigator";
            this.studyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studyBindingNavigator.Size = new System.Drawing.Size(930, 27);
            this.studyBindingNavigator.TabIndex = 0;
            this.studyBindingNavigator.Text = "bindingNavigator1";
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
            // studyBindingNavigatorSaveItem
            // 
            this.studyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studyBindingNavigatorSaveItem.Image")));
            this.studyBindingNavigatorSaveItem.Name = "studyBindingNavigatorSaveItem";
            this.studyBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.studyBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.studyBindingNavigatorSaveItem.Click += new System.EventHandler(this.studyBindingNavigatorSaveItem_Click);
            // 
            // пІБTextBox
            // 
            this.пІБTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studyBindingSource, "ПІБ", true));
            this.пІБTextBox.Location = new System.Drawing.Point(253, 58);
            this.пІБTextBox.Multiline = true;
            this.пІБTextBox.Name = "пІБTextBox";
            this.пІБTextBox.Size = new System.Drawing.Size(195, 31);
            this.пІБTextBox.TabIndex = 0;
            // 
            // посадаTextBox
            // 
            this.посадаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studyBindingSource, "Посада", true));
            this.посадаTextBox.Location = new System.Drawing.Point(255, 158);
            this.посадаTextBox.Name = "посадаTextBox";
            this.посадаTextBox.Size = new System.Drawing.Size(195, 22);
            this.посадаTextBox.TabIndex = 1;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studyBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(712, 64);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(206, 22);
            this.телефонTextBox.TabIndex = 2;
            this.телефонTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.телефонTextBox_KeyPress);
            // 
            // назва_уч__закладуTextBox
            // 
            this.назва_уч__закладуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studyBindingSource, "Назва уч_ закладу", true));
            this.назва_уч__закладуTextBox.Location = new System.Drawing.Point(725, 162);
            this.назва_уч__закладуTextBox.Multiline = true;
            this.назва_уч__закладуTextBox.Name = "назва_уч__закладуTextBox";
            this.назва_уч__закладуTextBox.Size = new System.Drawing.Size(193, 49);
            this.назва_уч__закладуTextBox.TabIndex = 3;
            // 
            // studyDataGridView
            // 
            this.studyDataGridView.AllowUserToAddRows = false;
            this.studyDataGridView.AutoGenerateColumns = false;
            this.studyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.studyDataGridView.DataSource = this.studyBindingSource;
            this.studyDataGridView.Location = new System.Drawing.Point(89, 327);
            this.studyDataGridView.Name = "studyDataGridView";
            this.studyDataGridView.RowHeadersWidth = 51;
            this.studyDataGridView.RowTemplate.Height = 24;
            this.studyDataGridView.Size = new System.Drawing.Size(710, 225);
            this.studyDataGridView.TabIndex = 10;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Посада";
            this.dataGridViewTextBoxColumn3.HeaderText = "Посада";
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Назва уч_ закладу";
            this.dataGridViewTextBoxColumn5.HeaderText = "Назва учбового закладу";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppKursova.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(18, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(154, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Пошук:";
            // 
            // txtStudySearch
            // 
            this.txtStudySearch.Location = new System.Drawing.Point(253, 293);
            this.txtStudySearch.Name = "txtStudySearch";
            this.txtStudySearch.Size = new System.Drawing.Size(263, 22);
            this.txtStudySearch.TabIndex = 4;
            this.txtStudySearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudySearch_KeyPress);
            // 
            // StudyPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(930, 564);
            this.Controls.Add(this.txtStudySearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.studyDataGridView);
            this.Controls.Add(пІБLabel);
            this.Controls.Add(this.пІБTextBox);
            this.Controls.Add(посадаLabel);
            this.Controls.Add(this.посадаTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(назва_уч__закладуLabel);
            this.Controls.Add(this.назва_уч__закладуTextBox);
            this.Controls.Add(this.studyBindingNavigator);
            this.Name = "StudyPlace";
            this.Text = "StudyPlace";
            this.Load += new System.EventHandler(this.StudyPlace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sample1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyBindingNavigator)).EndInit();
            this.studyBindingNavigator.ResumeLayout(false);
            this.studyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sample1DataSet sample1DataSet;
        private System.Windows.Forms.BindingSource studyBindingSource;
        private Sample1DataSetTableAdapters.StudyTableAdapter studyTableAdapter;
        private Sample1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox пІБTextBox;
        private System.Windows.Forms.TextBox посадаTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox назва_уч__закладуTextBox;
        private System.Windows.Forms.DataGridView studyDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudySearch;
    }
}