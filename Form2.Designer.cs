namespace WindowsFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label код_заказаLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label код_специалистаLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label код_клиентаLabel;
            System.Windows.Forms.Label статусLabel;
            this.заказыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.заказыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_заказаTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_специалистаTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.код_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.статусTextBox = new System.Windows.Forms.TextBox();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoDataSet = new WindowsFormsApp2.autoDataSet();
            this.заказыTableAdapter = new WindowsFormsApp2.autoDataSetTableAdapters.ЗаказыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.autoDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            код_заказаLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            код_специалистаLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            код_клиентаLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingNavigator)).BeginInit();
            this.заказыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // заказыBindingNavigator
            // 
            this.заказыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заказыBindingNavigator.BindingSource = this.заказыBindingSource;
            this.заказыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заказыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заказыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заказыBindingNavigatorSaveItem});
            this.заказыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заказыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заказыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заказыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заказыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заказыBindingNavigator.Name = "заказыBindingNavigator";
            this.заказыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заказыBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.заказыBindingNavigator.TabIndex = 0;
            this.заказыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // заказыBindingNavigatorSaveItem
            // 
            this.заказыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказыBindingNavigatorSaveItem.Image")));
            this.заказыBindingNavigatorSaveItem.Name = "заказыBindingNavigatorSaveItem";
            this.заказыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заказыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказыBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказыBindingNavigatorSaveItem_Click);
            // 
            // код_заказаLabel
            // 
            код_заказаLabel.AutoSize = true;
            код_заказаLabel.Location = new System.Drawing.Point(287, 97);
            код_заказаLabel.Name = "код_заказаLabel";
            код_заказаLabel.Size = new System.Drawing.Size(68, 13);
            код_заказаLabel.TabIndex = 1;
            код_заказаLabel.Text = "Код заказа:";
            // 
            // код_заказаTextBox
            // 
            this.код_заказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Код_заказа", true));
            this.код_заказаTextBox.Location = new System.Drawing.Point(361, 94);
            this.код_заказаTextBox.Name = "код_заказаTextBox";
            this.код_заказаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_заказаTextBox.TabIndex = 2;
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(319, 129);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(36, 13);
            датаLabel.TabIndex = 3;
            датаLabel.Text = "Дата:";
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(361, 125);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаDateTimePicker.TabIndex = 4;
            // 
            // код_специалистаLabel
            // 
            код_специалистаLabel.AutoSize = true;
            код_специалистаLabel.Location = new System.Drawing.Point(258, 167);
            код_специалистаLabel.Name = "код_специалистаLabel";
            код_специалистаLabel.Size = new System.Drawing.Size(97, 13);
            код_специалистаLabel.TabIndex = 5;
            код_специалистаLabel.Text = "Код специалиста:";
            // 
            // код_специалистаTextBox
            // 
            this.код_специалистаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Код_специалиста", true));
            this.код_специалистаTextBox.Location = new System.Drawing.Point(361, 164);
            this.код_специалистаTextBox.Name = "код_специалистаTextBox";
            this.код_специалистаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_специалистаTextBox.TabIndex = 6;
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(296, 205);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 7;
            фамилияLabel.Text = "Фамилия:";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(361, 202);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(100, 20);
            this.фамилияTextBox.TabIndex = 8;
            // 
            // код_клиентаLabel
            // 
            код_клиентаLabel.AutoSize = true;
            код_клиентаLabel.Location = new System.Drawing.Point(282, 240);
            код_клиентаLabel.Name = "код_клиентаLabel";
            код_клиентаLabel.Size = new System.Drawing.Size(73, 13);
            код_клиентаLabel.TabIndex = 9;
            код_клиентаLabel.Text = "Код клиента:";
            // 
            // код_клиентаTextBox
            // 
            this.код_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Код_клиента", true));
            this.код_клиентаTextBox.Location = new System.Drawing.Point(361, 237);
            this.код_клиентаTextBox.Name = "код_клиентаTextBox";
            this.код_клиентаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_клиентаTextBox.TabIndex = 10;
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(311, 279);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(44, 13);
            статусLabel.TabIndex = 11;
            статусLabel.Text = "Статус:";
            // 
            // статусTextBox
            // 
            this.статусTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Статус", true));
            this.статусTextBox.Location = new System.Drawing.Point(361, 276);
            this.статусTextBox.Name = "статусTextBox";
            this.статусTextBox.Size = new System.Drawing.Size(100, 20);
            this.статусTextBox.TabIndex = 12;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.autoDataSet;
            // 
            // autoDataSet
            // 
            this.autoDataSet.DataSetName = "autoDataSet";
            this.autoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.autoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Заказанные_товарыTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = this.заказыTableAdapter;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.СпециалистыTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(348, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Заказы";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(361, 412);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(485, 366);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(361, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(485, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(статусLabel);
            this.Controls.Add(this.статусTextBox);
            this.Controls.Add(код_клиентаLabel);
            this.Controls.Add(this.код_клиентаTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(код_специалистаLabel);
            this.Controls.Add(this.код_специалистаTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(код_заказаLabel);
            this.Controls.Add(this.код_заказаTextBox);
            this.Controls.Add(this.заказыBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingNavigator)).EndInit();
            this.заказыBindingNavigator.ResumeLayout(false);
            this.заказыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private autoDataSet autoDataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private autoDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private autoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заказыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заказыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_заказаTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox код_специалистаTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox код_клиентаTextBox;
        private System.Windows.Forms.TextBox статусTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}