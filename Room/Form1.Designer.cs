namespace Room
{
    partial class fomMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fomMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBedOccupancy = new System.Windows.Forms.Button();
            this.btnRoomOccupancy = new System.Windows.Forms.Button();
            this.btnOccupancyByType = new System.Windows.Forms.Button();
            this.btnDischarging = new System.Windows.Forms.Button();
            this.btnEmptyRoom = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(472, 107);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBedOccupancy
            // 
            this.btnBedOccupancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBedOccupancy.Location = new System.Drawing.Point(31, 72);
            this.btnBedOccupancy.Name = "btnBedOccupancy";
            this.btnBedOccupancy.Size = new System.Drawing.Size(130, 71);
            this.btnBedOccupancy.TabIndex = 1;
            this.btnBedOccupancy.Text = "Bed Occupancy";
            this.btnBedOccupancy.UseVisualStyleBackColor = true;
            this.btnBedOccupancy.Click += new System.EventHandler(this.btnBedOccupancy_Click);
            // 
            // btnRoomOccupancy
            // 
            this.btnRoomOccupancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomOccupancy.Location = new System.Drawing.Point(522, 72);
            this.btnRoomOccupancy.Name = "btnRoomOccupancy";
            this.btnRoomOccupancy.Size = new System.Drawing.Size(148, 71);
            this.btnRoomOccupancy.TabIndex = 1;
            this.btnRoomOccupancy.Text = "Room Occupancy";
            this.btnRoomOccupancy.UseVisualStyleBackColor = true;
            this.btnRoomOccupancy.Click += new System.EventHandler(this.btnRoomOccupancy_Click);
            // 
            // btnOccupancyByType
            // 
            this.btnOccupancyByType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOccupancyByType.Location = new System.Drawing.Point(638, 323);
            this.btnOccupancyByType.Name = "btnOccupancyByType";
            this.btnOccupancyByType.Size = new System.Drawing.Size(175, 71);
            this.btnOccupancyByType.TabIndex = 1;
            this.btnOccupancyByType.Text = "Occupancy by Room Type";
            this.btnOccupancyByType.UseVisualStyleBackColor = true;
            this.btnOccupancyByType.Click += new System.EventHandler(this.btnOccupancyByType_Click);
            // 
            // btnDischarging
            // 
            this.btnDischarging.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDischarging.Location = new System.Drawing.Point(1009, 59);
            this.btnDischarging.Name = "btnDischarging";
            this.btnDischarging.Size = new System.Drawing.Size(179, 84);
            this.btnDischarging.TabIndex = 1;
            this.btnDischarging.Text = " # of Discharging today";
            this.btnDischarging.UseVisualStyleBackColor = true;
            this.btnDischarging.Click += new System.EventHandler(this.btnDischarging_Click);
            // 
            // btnEmptyRoom
            // 
            this.btnEmptyRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmptyRoom.Location = new System.Drawing.Point(31, 323);
            this.btnEmptyRoom.Name = "btnEmptyRoom";
            this.btnEmptyRoom.Size = new System.Drawing.Size(164, 71);
            this.btnEmptyRoom.TabIndex = 1;
            this.btnEmptyRoom.Text = "# of Empty Rooms";
            this.btnEmptyRoom.UseVisualStyleBackColor = true;
            this.btnEmptyRoom.Click += new System.EventHandler(this.btnEmptyRoom_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(522, 149);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(476, 107);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(638, 400);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(607, 218);
            this.dataGridView3.TabIndex = 3;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(1009, 149);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(197, 107);
            this.dataGridView4.TabIndex = 4;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(31, 400);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(587, 218);
            this.dataGridView5.TabIndex = 5;
            // 
            // fomMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 713);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnEmptyRoom);
            this.Controls.Add(this.btnDischarging);
            this.Controls.Add(this.btnOccupancyByType);
            this.Controls.Add(this.btnRoomOccupancy);
            this.Controls.Add(this.btnBedOccupancy);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fomMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Utilization Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBedOccupancy;
        private System.Windows.Forms.Button btnRoomOccupancy;
        private System.Windows.Forms.Button btnOccupancyByType;
        private System.Windows.Forms.Button btnDischarging;
        private System.Windows.Forms.Button btnEmptyRoom;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
    }
}

