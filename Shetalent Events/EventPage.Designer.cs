namespace Shetalent_Events
{
    partial class EventPage
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
            this.customerNameComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eventTypeComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.displayAllEventButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bakeryButton = new System.Windows.Forms.Button();
            this.jewelryButton = new System.Windows.Forms.Button();
            this.wearsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editEventButton = new System.Windows.Forms.Button();
            this.createNewButton = new System.Windows.Forms.Button();
            this.upcomingEventButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.eventDataGridView = new System.Windows.Forms.DataGridView();
            this.lotNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeOfEventDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfGuestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeBookedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookedEventTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shetalentEventDataDataSet1 = new Shetalent_Events.ShetalentEventDataDataSet1();
            this.signOutButton = new System.Windows.Forms.Button();
            this.bookedEventTableTableAdapter = new Shetalent_Events.ShetalentEventDataDataSet1TableAdapters.BookedEventTableTableAdapter();
            this.PrintButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedEventTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shetalentEventDataDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameComboBox
            // 
            this.customerNameComboBox.DisplayMember = "Last_Name";
            this.customerNameComboBox.FormattingEnabled = true;
            this.customerNameComboBox.Location = new System.Drawing.Point(992, 183);
            this.customerNameComboBox.Name = "customerNameComboBox";
            this.customerNameComboBox.Size = new System.Drawing.Size(121, 28);
            this.customerNameComboBox.TabIndex = 26;
            this.customerNameComboBox.ValueMember = "Lot_Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(773, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "CustomerName";
            // 
            // eventTypeComboBox
            // 
            this.eventTypeComboBox.FormattingEnabled = true;
            this.eventTypeComboBox.Items.AddRange(new object[] {
            "Wedding",
            "Birthday",
            "Bridal Shower",
            "BabyShower",
            "Anniversary"});
            this.eventTypeComboBox.Location = new System.Drawing.Point(992, 106);
            this.eventTypeComboBox.Name = "eventTypeComboBox";
            this.eventTypeComboBox.Size = new System.Drawing.Size(164, 28);
            this.eventTypeComboBox.TabIndex = 24;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1215, 114);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(99, 34);
            this.searchButton.TabIndex = 22;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(843, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Search event by:";
            // 
            // displayAllEventButton
            // 
            this.displayAllEventButton.Location = new System.Drawing.Point(1215, 191);
            this.displayAllEventButton.Name = "displayAllEventButton";
            this.displayAllEventButton.Size = new System.Drawing.Size(139, 36);
            this.displayAllEventButton.TabIndex = 23;
            this.displayAllEventButton.Text = "Display all Events";
            this.displayAllEventButton.UseVisualStyleBackColor = true;
            this.displayAllEventButton.Click += new System.EventHandler(this.displayAllEventButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(783, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Type of Event:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Linen;
            this.groupBox2.Controls.Add(this.bakeryButton);
            this.groupBox2.Controls.Add(this.jewelryButton);
            this.groupBox2.Controls.Add(this.wearsButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(367, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 184);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "sales";
            // 
            // bakeryButton
            // 
            this.bakeryButton.Location = new System.Drawing.Point(146, 112);
            this.bakeryButton.Name = "bakeryButton";
            this.bakeryButton.Size = new System.Drawing.Size(98, 49);
            this.bakeryButton.TabIndex = 2;
            this.bakeryButton.Text = "Bakery";
            this.bakeryButton.UseVisualStyleBackColor = true;
            this.bakeryButton.Click += new System.EventHandler(this.bakeryButton_Click);
            // 
            // jewelryButton
            // 
            this.jewelryButton.Location = new System.Drawing.Point(17, 112);
            this.jewelryButton.Name = "jewelryButton";
            this.jewelryButton.Size = new System.Drawing.Size(96, 49);
            this.jewelryButton.TabIndex = 1;
            this.jewelryButton.Text = "Jewelries";
            this.jewelryButton.UseVisualStyleBackColor = true;
            this.jewelryButton.Click += new System.EventHandler(this.jewelryButton_Click);
            // 
            // wearsButton
            // 
            this.wearsButton.Location = new System.Drawing.Point(77, 26);
            this.wearsButton.Name = "wearsButton";
            this.wearsButton.Size = new System.Drawing.Size(97, 41);
            this.wearsButton.TabIndex = 0;
            this.wearsButton.Text = "Wears";
            this.wearsButton.UseVisualStyleBackColor = true;
            this.wearsButton.Click += new System.EventHandler(this.wearsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.editEventButton);
            this.groupBox1.Controls.Add(this.createNewButton);
            this.groupBox1.Controls.Add(this.upcomingEventButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 184);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Event";
            // 
            // editEventButton
            // 
            this.editEventButton.Location = new System.Drawing.Point(15, 101);
            this.editEventButton.Name = "editEventButton";
            this.editEventButton.Size = new System.Drawing.Size(104, 60);
            this.editEventButton.TabIndex = 1;
            this.editEventButton.Text = "Edit Event";
            this.editEventButton.UseVisualStyleBackColor = true;
            this.editEventButton.Visible = false;
            this.editEventButton.Click += new System.EventHandler(this.editEventButton_Click);
            // 
            // createNewButton
            // 
            this.createNewButton.Location = new System.Drawing.Point(113, 26);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(117, 40);
            this.createNewButton.TabIndex = 0;
            this.createNewButton.Text = "create new";
            this.createNewButton.UseVisualStyleBackColor = true;
            this.createNewButton.Click += new System.EventHandler(this.createNewButton_Click);
            // 
            // upcomingEventButton
            // 
            this.upcomingEventButton.Location = new System.Drawing.Point(155, 101);
            this.upcomingEventButton.Name = "upcomingEventButton";
            this.upcomingEventButton.Size = new System.Drawing.Size(146, 60);
            this.upcomingEventButton.TabIndex = 0;
            this.upcomingEventButton.Text = "Upcoming Events";
            this.upcomingEventButton.UseVisualStyleBackColor = true;
            this.upcomingEventButton.Click += new System.EventHandler(this.upcomingEventButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infoLabel.Location = new System.Drawing.Point(197, 239);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(597, 31);
            this.infoLabel.TabIndex = 27;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventDataGridView
            // 
            this.eventDataGridView.AutoGenerateColumns = false;
            this.eventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lotNumberDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.eventTypeDataGridViewTextBoxColumn,
            this.dateTimeOfEventDataGridViewTextBoxColumn,
            this.numberOfGuestDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.statesDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn,
            this.salesAmountDataGridViewTextBoxColumn,
            this.dateTimeBookedDataGridViewTextBoxColumn});
            this.eventDataGridView.DataSource = this.gridViewResultBindingSource;
            this.eventDataGridView.Location = new System.Drawing.Point(12, 304);
            this.eventDataGridView.Name = "eventDataGridView";
            this.eventDataGridView.RowTemplate.Height = 24;
            this.eventDataGridView.Size = new System.Drawing.Size(1451, 401);
            this.eventDataGridView.TabIndex = 28;
            this.eventDataGridView.DoubleClick += new System.EventHandler(this.eventDataGridView_DoubleClick);
            // 
            // lotNumberDataGridViewTextBoxColumn
            // 
            this.lotNumberDataGridViewTextBoxColumn.DataPropertyName = "LotNumber";
            this.lotNumberDataGridViewTextBoxColumn.HeaderText = "LotNumber";
            this.lotNumberDataGridViewTextBoxColumn.Name = "lotNumberDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // eventTypeDataGridViewTextBoxColumn
            // 
            this.eventTypeDataGridViewTextBoxColumn.DataPropertyName = "EventType";
            this.eventTypeDataGridViewTextBoxColumn.HeaderText = "EventType";
            this.eventTypeDataGridViewTextBoxColumn.Name = "eventTypeDataGridViewTextBoxColumn";
            // 
            // dateTimeOfEventDataGridViewTextBoxColumn
            // 
            this.dateTimeOfEventDataGridViewTextBoxColumn.DataPropertyName = "DateTimeOfEvent";
            this.dateTimeOfEventDataGridViewTextBoxColumn.HeaderText = "DateTimeOfEvent";
            this.dateTimeOfEventDataGridViewTextBoxColumn.Name = "dateTimeOfEventDataGridViewTextBoxColumn";
            // 
            // numberOfGuestDataGridViewTextBoxColumn
            // 
            this.numberOfGuestDataGridViewTextBoxColumn.DataPropertyName = "NumberOfGuest";
            this.numberOfGuestDataGridViewTextBoxColumn.HeaderText = "NumberOfGuest";
            this.numberOfGuestDataGridViewTextBoxColumn.Name = "numberOfGuestDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // statesDataGridViewTextBoxColumn
            // 
            this.statesDataGridViewTextBoxColumn.DataPropertyName = "States";
            this.statesDataGridViewTextBoxColumn.HeaderText = "States";
            this.statesDataGridViewTextBoxColumn.Name = "statesDataGridViewTextBoxColumn";
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            // 
            // salesAmountDataGridViewTextBoxColumn
            // 
            this.salesAmountDataGridViewTextBoxColumn.DataPropertyName = "SalesAmount";
            this.salesAmountDataGridViewTextBoxColumn.HeaderText = "SalesAmount";
            this.salesAmountDataGridViewTextBoxColumn.Name = "salesAmountDataGridViewTextBoxColumn";
            this.salesAmountDataGridViewTextBoxColumn.Width = 120;
            // 
            // dateTimeBookedDataGridViewTextBoxColumn
            // 
            this.dateTimeBookedDataGridViewTextBoxColumn.DataPropertyName = "DateTimeBooked";
            this.dateTimeBookedDataGridViewTextBoxColumn.HeaderText = "DateTimeBooked";
            this.dateTimeBookedDataGridViewTextBoxColumn.Name = "dateTimeBookedDataGridViewTextBoxColumn";
            this.dateTimeBookedDataGridViewTextBoxColumn.Width = 130;
            // 
            // gridViewResultBindingSource
            // 
            this.gridViewResultBindingSource.DataSource = typeof(Shetalent_Events.GridView_Result);
            // 
            // bookedEventTableBindingSource
            // 
            this.bookedEventTableBindingSource.DataMember = "BookedEventTable";
            this.bookedEventTableBindingSource.DataSource = this.shetalentEventDataDataSet1;
            // 
            // shetalentEventDataDataSet1
            // 
            this.shetalentEventDataDataSet1.DataSetName = "ShetalentEventDataDataSet1";
            this.shetalentEventDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(1364, 27);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(99, 42);
            this.signOutButton.TabIndex = 29;
            this.signOutButton.Text = "Sign out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // bookedEventTableTableAdapter
            // 
            this.bookedEventTableTableAdapter.ClearBeforeFill = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(1037, 246);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(87, 35);
            this.PrintButton.TabIndex = 30;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Visible = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // EventPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 735);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.eventDataGridView);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.customerNameComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eventTypeComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.displayAllEventButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EventPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventPage_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedEventTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shetalentEventDataDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox customerNameComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox eventTypeComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button displayAllEventButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bakeryButton;
        private System.Windows.Forms.Button jewelryButton;
        private System.Windows.Forms.Button wearsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editEventButton;
        private System.Windows.Forms.Button createNewButton;
        private System.Windows.Forms.Button upcomingEventButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.DataGridView eventDataGridView;
        private ShetalentEventDataDataSet1 shetalentEventDataDataSet1;
        private System.Windows.Forms.BindingSource bookedEventTableBindingSource;
        private ShetalentEventDataDataSet1TableAdapters.BookedEventTableTableAdapter bookedEventTableTableAdapter;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeOfEventDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfGuestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeBookedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gridViewResultBindingSource;
        private System.Windows.Forms.Button PrintButton;
    }
}