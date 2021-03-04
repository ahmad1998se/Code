namespace Grocery_Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Input = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.intext = new System.Windows.Forms.TextBox();
            this.outtext = new System.Windows.Forms.TextBox();
            this.process = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.expiredGrid1 = new System.Windows.Forms.DataGridView();
            this.soonGrid2 = new System.Windows.Forms.DataGridView();
            this.goodGrid3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expiredGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soonGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodGrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.BackColor = System.Drawing.SystemColors.Control;
            this.Input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Input.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(119, 33);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(138, 19);
            this.Input.TabIndex = 0;
            this.Input.Text = "Input File Path:";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(119, 91);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(150, 19);
            this.output.TabIndex = 1;
            this.output.Text = "Output File Path:";
            // 
            // intext
            // 
            this.intext.Location = new System.Drawing.Point(383, 26);
            this.intext.Name = "intext";
            this.intext.Size = new System.Drawing.Size(252, 20);
            this.intext.TabIndex = 2;
            this.intext.Tag = "hhhhh";
            // 
            // outtext
            // 
            this.outtext.Location = new System.Drawing.Point(383, 91);
            this.outtext.Name = "outtext";
            this.outtext.Size = new System.Drawing.Size(252, 20);
            this.outtext.TabIndex = 3;
            // 
            // process
            // 
            this.process.BackColor = System.Drawing.Color.ForestGreen;
            this.process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.process.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process.ForeColor = System.Drawing.Color.GhostWhite;
            this.process.Location = new System.Drawing.Point(431, 128);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(152, 52);
            this.process.TabIndex = 4;
            this.process.Text = "Process Data";
            this.process.UseVisualStyleBackColor = false;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // read
            // 
            this.read.BackColor = System.Drawing.Color.ForestGreen;
            this.read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read.ForeColor = System.Drawing.Color.GhostWhite;
            this.read.Location = new System.Drawing.Point(710, 21);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(75, 40);
            this.read.TabIndex = 5;
            this.read.Text = "Read";
            this.read.UseVisualStyleBackColor = false;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // write
            // 
            this.write.BackColor = System.Drawing.Color.ForestGreen;
            this.write.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.write.ForeColor = System.Drawing.Color.GhostWhite;
            this.write.Location = new System.Drawing.Point(710, 79);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(75, 40);
            this.write.TabIndex = 6;
            this.write.Text = "Write";
            this.write.UseVisualStyleBackColor = false;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // expiredGrid1
            // 
            this.expiredGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expiredGrid1.Location = new System.Drawing.Point(304, 229);
            this.expiredGrid1.Name = "expiredGrid1";
            this.expiredGrid1.Size = new System.Drawing.Size(443, 97);
            this.expiredGrid1.TabIndex = 7;
            // 
            // soonGrid2
            // 
            this.soonGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soonGrid2.Location = new System.Drawing.Point(304, 366);
            this.soonGrid2.Name = "soonGrid2";
            this.soonGrid2.Size = new System.Drawing.Size(443, 97);
            this.soonGrid2.TabIndex = 8;
            // 
            // goodGrid3
            // 
            this.goodGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodGrid3.Location = new System.Drawing.Point(304, 503);
            this.goodGrid3.Name = "goodGrid3";
            this.goodGrid3.Size = new System.Drawing.Size(443, 97);
            this.goodGrid3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Expired Item :";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.BackColor = System.Drawing.Color.DarkOrange;
            this.label_3.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_3.Location = new System.Drawing.Point(379, 335);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(305, 24);
            this.label_3.TabIndex = 11;
            this.label_3.Text = "Item That Will Expire Soom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Good Item";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1002, 612);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.goodGrid3);
            this.Controls.Add(this.soonGrid2);
            this.Controls.Add(this.expiredGrid1);
            this.Controls.Add(this.write);
            this.Controls.Add(this.read);
            this.Controls.Add(this.process);
            this.Controls.Add(this.outtext);
            this.Controls.Add(this.intext);
            this.Controls.Add(this.output);
            this.MaximumSize = new System.Drawing.Size(1018, 651);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expiredGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soonGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodGrid3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TextBox intext;
        private System.Windows.Forms.TextBox outtext;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView expiredGrid1;
        private System.Windows.Forms.DataGridView soonGrid2;
        private System.Windows.Forms.DataGridView goodGrid3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label3;
    }
}

