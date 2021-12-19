
namespace EkranskaForma
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_naziv = new System.Windows.Forms.Label();
            this.lbl_izvodjac = new System.Windows.Forms.Label();
            this.lbl_trajanje = new System.Windows.Forms.Label();
            this.lbl_jezik = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.txt_izvodjac = new System.Windows.Forms.TextBox();
            this.txt_trajanje = new System.Windows.Forms.TextBox();
            this.txt_jezik = new System.Windows.Forms.TextBox();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_frst = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edt = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(42, 15);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID: ";
            // 
            // lbl_naziv
            // 
            this.lbl_naziv.AutoSize = true;
            this.lbl_naziv.Location = new System.Drawing.Point(26, 41);
            this.lbl_naziv.Name = "lbl_naziv";
            this.lbl_naziv.Size = new System.Drawing.Size(40, 13);
            this.lbl_naziv.TabIndex = 1;
            this.lbl_naziv.Text = "Naziv: ";
            // 
            // lbl_izvodjac
            // 
            this.lbl_izvodjac.AutoSize = true;
            this.lbl_izvodjac.Location = new System.Drawing.Point(13, 67);
            this.lbl_izvodjac.Name = "lbl_izvodjac";
            this.lbl_izvodjac.Size = new System.Drawing.Size(53, 13);
            this.lbl_izvodjac.TabIndex = 2;
            this.lbl_izvodjac.Text = "Izvodjac: ";
            // 
            // lbl_trajanje
            // 
            this.lbl_trajanje.AutoSize = true;
            this.lbl_trajanje.Location = new System.Drawing.Point(15, 93);
            this.lbl_trajanje.Name = "lbl_trajanje";
            this.lbl_trajanje.Size = new System.Drawing.Size(51, 13);
            this.lbl_trajanje.TabIndex = 3;
            this.lbl_trajanje.Text = "Trajanje: ";
            // 
            // lbl_jezik
            // 
            this.lbl_jezik.AutoSize = true;
            this.lbl_jezik.Location = new System.Drawing.Point(29, 119);
            this.lbl_jezik.Name = "lbl_jezik";
            this.lbl_jezik.Size = new System.Drawing.Size(37, 13);
            this.lbl_jezik.TabIndex = 4;
            this.lbl_jezik.Text = "Jezik: ";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(72, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 5;
            // 
            // txt_naziv
            // 
            this.txt_naziv.Location = new System.Drawing.Point(72, 38);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.Size = new System.Drawing.Size(100, 20);
            this.txt_naziv.TabIndex = 6;
            // 
            // txt_izvodjac
            // 
            this.txt_izvodjac.Location = new System.Drawing.Point(72, 64);
            this.txt_izvodjac.Name = "txt_izvodjac";
            this.txt_izvodjac.Size = new System.Drawing.Size(100, 20);
            this.txt_izvodjac.TabIndex = 7;
            // 
            // txt_trajanje
            // 
            this.txt_trajanje.Location = new System.Drawing.Point(72, 90);
            this.txt_trajanje.Name = "txt_trajanje";
            this.txt_trajanje.Size = new System.Drawing.Size(100, 20);
            this.txt_trajanje.TabIndex = 8;
            // 
            // txt_jezik
            // 
            this.txt_jezik.Location = new System.Drawing.Point(72, 116);
            this.txt_jezik.Name = "txt_jezik";
            this.txt_jezik.Size = new System.Drawing.Size(100, 20);
            this.txt_jezik.TabIndex = 9;
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(72, 142);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(47, 23);
            this.btn_prev.TabIndex = 10;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(125, 142);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(47, 23);
            this.btn_next.TabIndex = 11;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_frst
            // 
            this.btn_frst.Location = new System.Drawing.Point(72, 171);
            this.btn_frst.Name = "btn_frst";
            this.btn_frst.Size = new System.Drawing.Size(47, 23);
            this.btn_frst.TabIndex = 12;
            this.btn_frst.Text = "<<";
            this.btn_frst.UseVisualStyleBackColor = true;
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(125, 171);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(47, 23);
            this.btn_last.TabIndex = 13;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(72, 200);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 23);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Dodaj";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_edt
            // 
            this.btn_edt.Location = new System.Drawing.Point(72, 229);
            this.btn_edt.Name = "btn_edt";
            this.btn_edt.Size = new System.Drawing.Size(100, 23);
            this.btn_edt.TabIndex = 15;
            this.btn_edt.Text = "Izmeni";
            this.btn_edt.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(72, 258);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(100, 23);
            this.btn_del.TabIndex = 16;
            this.btn_del.Text = "Brisi";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 292);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edt);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_frst);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.txt_jezik);
            this.Controls.Add(this.txt_trajanje);
            this.Controls.Add(this.txt_izvodjac);
            this.Controls.Add(this.txt_naziv);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_jezik);
            this.Controls.Add(this.lbl_trajanje);
            this.Controls.Add(this.lbl_izvodjac);
            this.Controls.Add(this.lbl_naziv);
            this.Controls.Add(this.lbl_id);
            this.Name = "Form1";
            this.Text = "Song";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_naziv;
        private System.Windows.Forms.Label lbl_izvodjac;
        private System.Windows.Forms.Label lbl_trajanje;
        private System.Windows.Forms.Label lbl_jezik;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.TextBox txt_izvodjac;
        private System.Windows.Forms.TextBox txt_trajanje;
        private System.Windows.Forms.TextBox txt_jezik;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_frst;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edt;
        private System.Windows.Forms.Button btn_del;
    }
}

