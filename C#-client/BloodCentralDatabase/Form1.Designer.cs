namespace BloodCentralDatabase
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label areaLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label contactDetailsLabel;
            System.Windows.Forms.Label inchargeLabel;
            System.Windows.Forms.Label a1_veLabel;
            System.Windows.Forms.Label a1_veLabel1;
            System.Windows.Forms.Label a1B_veLabel;
            System.Windows.Forms.Label a1B_veLabel1;
            System.Windows.Forms.Label a2_veLabel;
            System.Windows.Forms.Label a2_veLabel1;
            System.Windows.Forms.Label a2B_veLabel;
            System.Windows.Forms.Label a2B_veLabel1;
            System.Windows.Forms.Label b_veLabel;
            System.Windows.Forms.Label b_veLabel1;
            System.Windows.Forms.Label b1_veLabel;
            System.Windows.Forms.Label o_veLabel;
            System.Windows.Forms.Label o_veLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bloodcentraldatabaseDataSet = new BloodCentralDatabase.bloodcentraldatabaseDataSet();
            this.bloodbanksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodbanksTableAdapter = new BloodCentralDatabase.bloodcentraldatabaseDataSetTableAdapters.bloodbanksTableAdapter();
            this.tableAdapterManager = new BloodCentralDatabase.bloodcentraldatabaseDataSetTableAdapters.TableAdapterManager();
            this.bloodbanksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bloodbanksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.contactDetailsTextBox = new System.Windows.Forms.TextBox();
            this.inchargeTextBox = new System.Windows.Forms.TextBox();
            this.a1_veTextBox = new System.Windows.Forms.TextBox();
            this.a1_veTextBox1 = new System.Windows.Forms.TextBox();
            this.a1B_veTextBox = new System.Windows.Forms.TextBox();
            this.a1B_veTextBox1 = new System.Windows.Forms.TextBox();
            this.a2_veTextBox = new System.Windows.Forms.TextBox();
            this.a2_veTextBox1 = new System.Windows.Forms.TextBox();
            this.a2B_veTextBox = new System.Windows.Forms.TextBox();
            this.a2B_veTextBox1 = new System.Windows.Forms.TextBox();
            this.b_veTextBox = new System.Windows.Forms.TextBox();
            this.b_veTextBox1 = new System.Windows.Forms.TextBox();
            this.b1_veTextBox = new System.Windows.Forms.TextBox();
            this.o_veTextBox = new System.Windows.Forms.TextBox();
            this.o_veTextBox1 = new System.Windows.Forms.TextBox();
            this.serverResponse = new System.Windows.Forms.Label();
            this.responseBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            areaLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            contactDetailsLabel = new System.Windows.Forms.Label();
            inchargeLabel = new System.Windows.Forms.Label();
            a1_veLabel = new System.Windows.Forms.Label();
            a1_veLabel1 = new System.Windows.Forms.Label();
            a1B_veLabel = new System.Windows.Forms.Label();
            a1B_veLabel1 = new System.Windows.Forms.Label();
            a2_veLabel = new System.Windows.Forms.Label();
            a2_veLabel1 = new System.Windows.Forms.Label();
            a2B_veLabel = new System.Windows.Forms.Label();
            a2B_veLabel1 = new System.Windows.Forms.Label();
            b_veLabel = new System.Windows.Forms.Label();
            b_veLabel1 = new System.Windows.Forms.Label();
            b1_veLabel = new System.Windows.Forms.Label();
            o_veLabel = new System.Windows.Forms.Label();
            o_veLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bloodcentraldatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodbanksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodbanksBindingNavigator)).BeginInit();
            this.bloodbanksBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(30, 70);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(290, 70);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(47, 13);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "address:";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Location = new System.Drawing.Point(30, 115);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new System.Drawing.Size(31, 13);
            areaLabel.TabIndex = 5;
            areaLabel.Text = "area:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(311, 115);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(26, 13);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "city:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(30, 158);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(33, 13);
            stateLabel.TabIndex = 9;
            stateLabel.Text = "state:";
            // 
            // contactDetailsLabel
            // 
            contactDetailsLabel.AutoSize = true;
            contactDetailsLabel.Location = new System.Drawing.Point(256, 158);
            contactDetailsLabel.Name = "contactDetailsLabel";
            contactDetailsLabel.Size = new System.Drawing.Size(81, 13);
            contactDetailsLabel.TabIndex = 11;
            contactDetailsLabel.Text = "contact Details:";
            // 
            // inchargeLabel
            // 
            inchargeLabel.AutoSize = true;
            inchargeLabel.Location = new System.Drawing.Point(30, 197);
            inchargeLabel.Name = "inchargeLabel";
            inchargeLabel.Size = new System.Drawing.Size(51, 13);
            inchargeLabel.TabIndex = 13;
            inchargeLabel.Text = "incharge:";
            // 
            // a1_veLabel
            // 
            a1_veLabel.AutoSize = true;
            a1_veLabel.Location = new System.Drawing.Point(296, 197);
            a1_veLabel.Name = "a1_veLabel";
            a1_veLabel.Size = new System.Drawing.Size(38, 13);
            a1_veLabel.TabIndex = 15;
            a1_veLabel.Text = "A1-ve:";
            // 
            // a1_veLabel1
            // 
            a1_veLabel1.AutoSize = true;
            a1_veLabel1.Location = new System.Drawing.Point(30, 235);
            a1_veLabel1.Name = "a1_veLabel1";
            a1_veLabel1.Size = new System.Drawing.Size(41, 13);
            a1_veLabel1.TabIndex = 17;
            a1_veLabel1.Text = "A1+ve:";
            // 
            // a1B_veLabel
            // 
            a1B_veLabel.AutoSize = true;
            a1B_veLabel.Location = new System.Drawing.Point(296, 239);
            a1B_veLabel.Name = "a1B_veLabel";
            a1B_veLabel.Size = new System.Drawing.Size(45, 13);
            a1B_veLabel.TabIndex = 19;
            a1B_veLabel.Text = "A1B-ve:";
            // 
            // a1B_veLabel1
            // 
            a1B_veLabel1.AutoSize = true;
            a1B_veLabel1.Location = new System.Drawing.Point(30, 282);
            a1B_veLabel1.Name = "a1B_veLabel1";
            a1B_veLabel1.Size = new System.Drawing.Size(48, 13);
            a1B_veLabel1.TabIndex = 21;
            a1B_veLabel1.Text = "A1B+ve:";
            // 
            // a2_veLabel
            // 
            a2_veLabel.AutoSize = true;
            a2_veLabel.Location = new System.Drawing.Point(296, 282);
            a2_veLabel.Name = "a2_veLabel";
            a2_veLabel.Size = new System.Drawing.Size(38, 13);
            a2_veLabel.TabIndex = 23;
            a2_veLabel.Text = "A2-ve:";
            // 
            // a2_veLabel1
            // 
            a2_veLabel1.AutoSize = true;
            a2_veLabel1.Location = new System.Drawing.Point(30, 326);
            a2_veLabel1.Name = "a2_veLabel1";
            a2_veLabel1.Size = new System.Drawing.Size(41, 13);
            a2_veLabel1.TabIndex = 25;
            a2_veLabel1.Text = "A2+ve:";
            // 
            // a2B_veLabel
            // 
            a2B_veLabel.AutoSize = true;
            a2B_veLabel.Location = new System.Drawing.Point(292, 326);
            a2B_veLabel.Name = "a2B_veLabel";
            a2B_veLabel.Size = new System.Drawing.Size(45, 13);
            a2B_veLabel.TabIndex = 27;
            a2B_veLabel.Text = "A2B-ve:";
            // 
            // a2B_veLabel1
            // 
            a2B_veLabel1.AutoSize = true;
            a2B_veLabel1.Location = new System.Drawing.Point(23, 375);
            a2B_veLabel1.Name = "a2B_veLabel1";
            a2B_veLabel1.Size = new System.Drawing.Size(48, 13);
            a2B_veLabel1.TabIndex = 29;
            a2B_veLabel1.Text = "A2B+ve:";
            // 
            // b_veLabel
            // 
            b_veLabel.AutoSize = true;
            b_veLabel.Location = new System.Drawing.Point(305, 375);
            b_veLabel.Name = "b_veLabel";
            b_veLabel.Size = new System.Drawing.Size(32, 13);
            b_veLabel.TabIndex = 31;
            b_veLabel.Text = "B-ve:";
            // 
            // b_veLabel1
            // 
            b_veLabel1.AutoSize = true;
            b_veLabel1.Location = new System.Drawing.Point(31, 415);
            b_veLabel1.Name = "b_veLabel1";
            b_veLabel1.Size = new System.Drawing.Size(35, 13);
            b_veLabel1.TabIndex = 33;
            b_veLabel1.Text = "B+ve:";
            // 
            // b1_veLabel
            // 
            b1_veLabel.AutoSize = true;
            b1_veLabel.Location = new System.Drawing.Point(296, 415);
            b1_veLabel.Name = "b1_veLabel";
            b1_veLabel.Size = new System.Drawing.Size(41, 13);
            b1_veLabel.TabIndex = 35;
            b1_veLabel.Text = "B1+ve:";
            // 
            // o_veLabel
            // 
            o_veLabel.AutoSize = true;
            o_veLabel.Location = new System.Drawing.Point(38, 454);
            o_veLabel.Name = "o_veLabel";
            o_veLabel.Size = new System.Drawing.Size(33, 13);
            o_veLabel.TabIndex = 37;
            o_veLabel.Text = "O-ve:";
            // 
            // o_veLabel1
            // 
            o_veLabel1.AutoSize = true;
            o_veLabel1.Location = new System.Drawing.Point(301, 454);
            o_veLabel1.Name = "o_veLabel1";
            o_veLabel1.Size = new System.Drawing.Size(36, 13);
            o_veLabel1.TabIndex = 39;
            o_veLabel1.Text = "O+ve:";
            // 
            // bloodcentraldatabaseDataSet
            // 
            this.bloodcentraldatabaseDataSet.DataSetName = "bloodcentraldatabaseDataSet";
            this.bloodcentraldatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bloodbanksBindingSource
            // 
            this.bloodbanksBindingSource.DataMember = "bloodbanks";
            this.bloodbanksBindingSource.DataSource = this.bloodcentraldatabaseDataSet;
            // 
            // bloodbanksTableAdapter
            // 
            this.bloodbanksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bloodbanksTableAdapter = this.bloodbanksTableAdapter;
            this.tableAdapterManager.UpdateOrder = BloodCentralDatabase.bloodcentraldatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bloodbanksBindingNavigator
            // 
            this.bloodbanksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bloodbanksBindingNavigator.BindingSource = this.bloodbanksBindingSource;
            this.bloodbanksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bloodbanksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bloodbanksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bloodbanksBindingNavigatorSaveItem});
            this.bloodbanksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bloodbanksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bloodbanksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bloodbanksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bloodbanksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bloodbanksBindingNavigator.Name = "bloodbanksBindingNavigator";
            this.bloodbanksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bloodbanksBindingNavigator.Size = new System.Drawing.Size(591, 25);
            this.bloodbanksBindingNavigator.TabIndex = 0;
            this.bloodbanksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bloodbanksBindingNavigatorSaveItem
            // 
            this.bloodbanksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bloodbanksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bloodbanksBindingNavigatorSaveItem.Image")));
            this.bloodbanksBindingNavigatorSaveItem.Name = "bloodbanksBindingNavigatorSaveItem";
            this.bloodbanksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bloodbanksBindingNavigatorSaveItem.Text = "Save Data";
            this.bloodbanksBindingNavigatorSaveItem.Click += new System.EventHandler(this.bloodbanksBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(85, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(343, 67);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 4;
            // 
            // areaTextBox
            // 
            this.areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "area", true));
            this.areaTextBox.Location = new System.Drawing.Point(85, 112);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(100, 20);
            this.areaTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(343, 108);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 8;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(85, 158);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 10;
            // 
            // contactDetailsTextBox
            // 
            this.contactDetailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "contactDetails", true));
            this.contactDetailsTextBox.Location = new System.Drawing.Point(343, 158);
            this.contactDetailsTextBox.Name = "contactDetailsTextBox";
            this.contactDetailsTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactDetailsTextBox.TabIndex = 12;
            // 
            // inchargeTextBox
            // 
            this.inchargeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "incharge", true));
            this.inchargeTextBox.Location = new System.Drawing.Point(87, 194);
            this.inchargeTextBox.Name = "inchargeTextBox";
            this.inchargeTextBox.Size = new System.Drawing.Size(100, 20);
            this.inchargeTextBox.TabIndex = 14;
            // 
            // a1_veTextBox
            // 
            this.a1_veTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "A1-ve", true));
            this.a1_veTextBox.Location = new System.Drawing.Point(343, 194);
            this.a1_veTextBox.Name = "a1_veTextBox";
            this.a1_veTextBox.Size = new System.Drawing.Size(100, 20);
            this.a1_veTextBox.TabIndex = 16;
            // 
            // a1_veTextBox1
            // 
            this.a1_veTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "A1+ve", true));
            this.a1_veTextBox1.Location = new System.Drawing.Point(87, 232);
            this.a1_veTextBox1.Name = "a1_veTextBox1";
            this.a1_veTextBox1.Size = new System.Drawing.Size(100, 20);
            this.a1_veTextBox1.TabIndex = 18;
            // 
            // a1B_veTextBox
            // 
            this.a1B_veTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "A1B-ve", true));
            this.a1B_veTextBox.Location = new System.Drawing.Point(343, 232);
            this.a1B_veTextBox.Name = "a1B_veTextBox";
            this.a1B_veTextBox.Size = new System.Drawing.Size(100, 20);
            this.a1B_veTextBox.TabIndex = 20;
            // 
            // a1B_veTextBox1
            // 
            this.a1B_veTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "A1B+ve", true));
            this.a1B_veTextBox1.Location = new System.Drawing.Point(87, 279);
            this.a1B_veTextBox1.Name = "a1B_veTextBox1";
            this.a1B_veTextBox1.Size = new System.Drawing.Size(100, 20);
            this.a1B_veTextBox1.TabIndex = 22;
            // 
            // a2_veTextBox
            // 
            this.a2_veTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "A2-ve", true));
            this.a2_veTextBox.Location = new System.Drawing.Point(343, 279);
            this.a2_veTextBox.Name = "a2_veTextBox";
            this.a2_veTextBox.Size = new System.Drawing.Size(100, 20);
            this.a2_veTextBox.TabIndex = 24;
            // 
            // a2_veTextBox1
            // 
            this.a2_veTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "A2+ve", true));
            this.a2_veTextBox1.Location = new System.Drawing.Point(85, 323);
            this.a2_veTextBox1.Name = "a2_veTextBox1";
            this.a2_veTextBox1.Size = new System.Drawing.Size(100, 20);
            this.a2_veTextBox1.TabIndex = 26;
            // 
            // a2B_veTextBox
            // 
            this.a2B_veTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "A2B-ve", true));
            this.a2B_veTextBox.Location = new System.Drawing.Point(343, 323);
            this.a2B_veTextBox.Name = "a2B_veTextBox";
            this.a2B_veTextBox.Size = new System.Drawing.Size(100, 20);
            this.a2B_veTextBox.TabIndex = 28;
            // 
            // a2B_veTextBox1
            // 
            this.a2B_veTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "A2B+ve", true));
            this.a2B_veTextBox1.Location = new System.Drawing.Point(87, 372);
            this.a2B_veTextBox1.Name = "a2B_veTextBox1";
            this.a2B_veTextBox1.Size = new System.Drawing.Size(100, 20);
            this.a2B_veTextBox1.TabIndex = 30;
            // 
            // b_veTextBox
            // 
            this.b_veTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "B-ve", true));
            this.b_veTextBox.Location = new System.Drawing.Point(343, 372);
            this.b_veTextBox.Name = "b_veTextBox";
            this.b_veTextBox.Size = new System.Drawing.Size(100, 20);
            this.b_veTextBox.TabIndex = 32;
            // 
            // b_veTextBox1
            // 
            this.b_veTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "B+ve", true));
            this.b_veTextBox1.Location = new System.Drawing.Point(87, 412);
            this.b_veTextBox1.Name = "b_veTextBox1";
            this.b_veTextBox1.Size = new System.Drawing.Size(100, 20);
            this.b_veTextBox1.TabIndex = 34;
            // 
            // b1_veTextBox
            // 
            this.b1_veTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "B1+ve", true));
            this.b1_veTextBox.Location = new System.Drawing.Point(343, 412);
            this.b1_veTextBox.Name = "b1_veTextBox";
            this.b1_veTextBox.Size = new System.Drawing.Size(100, 20);
            this.b1_veTextBox.TabIndex = 36;
            // 
            // o_veTextBox
            // 
            this.o_veTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "O-ve", true));
            this.o_veTextBox.Location = new System.Drawing.Point(87, 451);
            this.o_veTextBox.Name = "o_veTextBox";
            this.o_veTextBox.Size = new System.Drawing.Size(100, 20);
            this.o_veTextBox.TabIndex = 38;
            // 
            // o_veTextBox1
            // 
            this.o_veTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodbanksBindingSource, "O+ve", true));
            this.o_veTextBox1.Location = new System.Drawing.Point(343, 451);
            this.o_veTextBox1.Name = "o_veTextBox1";
            this.o_veTextBox1.Size = new System.Drawing.Size(100, 20);
            this.o_veTextBox1.TabIndex = 40;
            // 
            // serverResponse
            // 
            this.serverResponse.AutoSize = true;
            this.serverResponse.Location = new System.Drawing.Point(33, 524);
            this.serverResponse.Name = "serverResponse";
            this.serverResponse.Size = new System.Drawing.Size(92, 13);
            this.serverResponse.TabIndex = 41;
            this.serverResponse.Text = "Server Response:";
            // 
            // responseBox
            // 
            this.responseBox.Location = new System.Drawing.Point(146, 516);
            this.responseBox.Name = "responseBox";
            this.responseBox.Size = new System.Drawing.Size(100, 20);
            this.responseBox.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Send Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Local Database - Currently synced with Blood Central Bank";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "Get Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 586);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.serverResponse);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(areaLabel);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(contactDetailsLabel);
            this.Controls.Add(this.contactDetailsTextBox);
            this.Controls.Add(inchargeLabel);
            this.Controls.Add(this.inchargeTextBox);
            this.Controls.Add(a1_veLabel);
            this.Controls.Add(this.a1_veTextBox);
            this.Controls.Add(a1_veLabel1);
            this.Controls.Add(this.a1_veTextBox1);
            this.Controls.Add(a1B_veLabel);
            this.Controls.Add(this.a1B_veTextBox);
            this.Controls.Add(a1B_veLabel1);
            this.Controls.Add(this.a1B_veTextBox1);
            this.Controls.Add(a2_veLabel);
            this.Controls.Add(this.a2_veTextBox);
            this.Controls.Add(a2_veLabel1);
            this.Controls.Add(this.a2_veTextBox1);
            this.Controls.Add(a2B_veLabel);
            this.Controls.Add(this.a2B_veTextBox);
            this.Controls.Add(a2B_veLabel1);
            this.Controls.Add(this.a2B_veTextBox1);
            this.Controls.Add(b_veLabel);
            this.Controls.Add(this.b_veTextBox);
            this.Controls.Add(b_veLabel1);
            this.Controls.Add(this.b_veTextBox1);
            this.Controls.Add(b1_veLabel);
            this.Controls.Add(this.b1_veTextBox);
            this.Controls.Add(o_veLabel);
            this.Controls.Add(this.o_veTextBox);
            this.Controls.Add(o_veLabel1);
            this.Controls.Add(this.o_veTextBox1);
            this.Controls.Add(this.bloodbanksBindingNavigator);
            this.Name = "Form1";
            this.Text = "Local Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bloodcentraldatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodbanksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodbanksBindingNavigator)).EndInit();
            this.bloodbanksBindingNavigator.ResumeLayout(false);
            this.bloodbanksBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bloodcentraldatabaseDataSet bloodcentraldatabaseDataSet;
        private System.Windows.Forms.BindingSource bloodbanksBindingSource;
        private bloodcentraldatabaseDataSetTableAdapters.bloodbanksTableAdapter bloodbanksTableAdapter;
        private bloodcentraldatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bloodbanksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bloodbanksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox contactDetailsTextBox;
        private System.Windows.Forms.TextBox inchargeTextBox;
        private System.Windows.Forms.TextBox a1_veTextBox;
        private System.Windows.Forms.TextBox a1_veTextBox1;
        private System.Windows.Forms.TextBox a1B_veTextBox;
        private System.Windows.Forms.TextBox a1B_veTextBox1;
        private System.Windows.Forms.TextBox a2_veTextBox;
        private System.Windows.Forms.TextBox a2_veTextBox1;
        private System.Windows.Forms.TextBox a2B_veTextBox;
        private System.Windows.Forms.TextBox a2B_veTextBox1;
        private System.Windows.Forms.TextBox b_veTextBox;
        private System.Windows.Forms.TextBox b_veTextBox1;
        private System.Windows.Forms.TextBox b1_veTextBox;
        private System.Windows.Forms.TextBox o_veTextBox;
        private System.Windows.Forms.TextBox o_veTextBox1;
        private System.Windows.Forms.Label serverResponse;
        private System.Windows.Forms.TextBox responseBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

