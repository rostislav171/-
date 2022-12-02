namespace WindowsFormsApp2
{
    partial class Form3
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
            System.Windows.Forms.Label код_заказаLabel;
            System.Windows.Forms.Label код_товараLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label скидкаLabel;
            System.Windows.Forms.Label итогоLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.autoDataSet = new WindowsFormsApp2.autoDataSet();
            this.заказанные_товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказанные_товарыTableAdapter = new WindowsFormsApp2.autoDataSetTableAdapters.Заказанные_товарыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.autoDataSetTableAdapters.TableAdapterManager();
            this.заказанные_товарыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.заказанные_товарыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_заказаTextBox = new System.Windows.Forms.TextBox();
            this.код_товараTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.скидкаTextBox = new System.Windows.Forms.TextBox();
            this.итогоTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            код_заказаLabel = new System.Windows.Forms.Label();
            код_товараLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            скидкаLabel = new System.Windows.Forms.Label();
            итогоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказанные_товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказанные_товарыBindingNavigator)).BeginInit();
            this.заказанные_товарыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_заказаLabel
            // 
            код_заказаLabel.AutoSize = true;
            код_заказаLabel.Location = new System.Drawing.Point(296, 117);
            код_заказаLabel.Name = "код_заказаLabel";
            код_заказаLabel.Size = new System.Drawing.Size(68, 13);
            код_заказаLabel.TabIndex = 1;
            код_заказаLabel.Text = "Код заказа:";
            // 
            // код_товараLabel
            // 
            код_товараLabel.AutoSize = true;
            код_товараLabel.Location = new System.Drawing.Point(296, 152);
            код_товараLabel.Name = "код_товараLabel";
            код_товараLabel.Size = new System.Drawing.Size(67, 13);
            код_товараLabel.TabIndex = 3;
            код_товараLabel.Text = "Код товара:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(294, 189);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(69, 13);
            количествоLabel.TabIndex = 5;
            количествоLabel.Text = "Количество:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(327, 226);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(36, 13);
            ценаLabel.TabIndex = 7;
            ценаLabel.Text = "Цена:";
            // 
            // скидкаLabel
            // 
            скидкаLabel.AutoSize = true;
            скидкаLabel.Location = new System.Drawing.Point(316, 265);
            скидкаLabel.Name = "скидкаLabel";
            скидкаLabel.Size = new System.Drawing.Size(47, 13);
            скидкаLabel.TabIndex = 9;
            скидкаLabel.Text = "Скидка:";
            // 
            // итогоLabel
            // 
            итогоLabel.AutoSize = true;
            итогоLabel.Location = new System.Drawing.Point(323, 306);
            итогоLabel.Name = "итогоLabel";
            итогоLabel.Size = new System.Drawing.Size(40, 13);
            итогоLabel.TabIndex = 11;
            итогоLabel.Text = "Итого:";
            // 
            // autoDataSet
            // 
            this.autoDataSet.DataSetName = "autoDataSet";
            this.autoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказанные_товарыBindingSource
            // 
            this.заказанные_товарыBindingSource.DataMember = "Заказанные_товары";
            this.заказанные_товарыBindingSource.DataSource = this.autoDataSet;
            // 
            // заказанные_товарыTableAdapter
            // 
            this.заказанные_товарыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.autoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Заказанные_товарыTableAdapter = this.заказанные_товарыTableAdapter;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.СпециалистыTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // заказанные_товарыBindingNavigator
            // 
            this.заказанные_товарыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заказанные_товарыBindingNavigator.BindingSource = this.заказанные_товарыBindingSource;
            this.заказанные_товарыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заказанные_товарыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заказанные_товарыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заказанные_товарыBindingNavigatorSaveItem});
            this.заказанные_товарыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заказанные_товарыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заказанные_товарыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заказанные_товарыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заказанные_товарыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заказанные_товарыBindingNavigator.Name = "заказанные_товарыBindingNavigator";
            this.заказанные_товарыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заказанные_товарыBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.заказанные_товарыBindingNavigator.TabIndex = 0;
            this.заказанные_товарыBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // заказанные_товарыBindingNavigatorSaveItem
            // 
            this.заказанные_товарыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказанные_товарыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказанные_товарыBindingNavigatorSaveItem.Image")));
            this.заказанные_товарыBindingNavigatorSaveItem.Name = "заказанные_товарыBindingNavigatorSaveItem";
            this.заказанные_товарыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заказанные_товарыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказанные_товарыBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказанные_товарыBindingNavigatorSaveItem_Click);
            // 
            // код_заказаTextBox
            // 
            this.код_заказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказанные_товарыBindingSource, "Код_заказа", true));
            this.код_заказаTextBox.Location = new System.Drawing.Point(370, 114);
            this.код_заказаTextBox.Name = "код_заказаTextBox";
            this.код_заказаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_заказаTextBox.TabIndex = 2;
            // 
            // код_товараTextBox
            // 
            this.код_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказанные_товарыBindingSource, "Код_товара", true));
            this.код_товараTextBox.Location = new System.Drawing.Point(369, 149);
            this.код_товараTextBox.Name = "код_товараTextBox";
            this.код_товараTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_товараTextBox.TabIndex = 4;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказанные_товарыBindingSource, "Количество", true));
            this.количествоTextBox.Location = new System.Drawing.Point(369, 186);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(100, 20);
            this.количествоTextBox.TabIndex = 6;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказанные_товарыBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(369, 223);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(100, 20);
            this.ценаTextBox.TabIndex = 8;
            // 
            // скидкаTextBox
            // 
            this.скидкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказанные_товарыBindingSource, "Скидка", true));
            this.скидкаTextBox.Location = new System.Drawing.Point(369, 262);
            this.скидкаTextBox.Name = "скидкаTextBox";
            this.скидкаTextBox.Size = new System.Drawing.Size(100, 20);
            this.скидкаTextBox.TabIndex = 10;
            // 
            // итогоTextBox
            // 
            this.итогоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказанные_товарыBindingSource, "Итого", true));
            this.итогоTextBox.Location = new System.Drawing.Point(369, 303);
            this.итогоTextBox.Name = "итогоTextBox";
            this.итогоTextBox.Size = new System.Drawing.Size(100, 20);
            this.итогоTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(339, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Заказанные услуги";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(итогоLabel);
            this.Controls.Add(this.итогоTextBox);
            this.Controls.Add(скидкаLabel);
            this.Controls.Add(this.скидкаTextBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(код_товараLabel);
            this.Controls.Add(this.код_товараTextBox);
            this.Controls.Add(код_заказаLabel);
            this.Controls.Add(this.код_заказаTextBox);
            this.Controls.Add(this.заказанные_товарыBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказанные_товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказанные_товарыBindingNavigator)).EndInit();
            this.заказанные_товарыBindingNavigator.ResumeLayout(false);
            this.заказанные_товарыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private autoDataSet autoDataSet;
        private System.Windows.Forms.BindingSource заказанные_товарыBindingSource;
        private autoDataSetTableAdapters.Заказанные_товарыTableAdapter заказанные_товарыTableAdapter;
        private autoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заказанные_товарыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заказанные_товарыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_заказаTextBox;
        private System.Windows.Forms.TextBox код_товараTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox скидкаTextBox;
        private System.Windows.Forms.TextBox итогоTextBox;
        private System.Windows.Forms.Label label1;
    }
}