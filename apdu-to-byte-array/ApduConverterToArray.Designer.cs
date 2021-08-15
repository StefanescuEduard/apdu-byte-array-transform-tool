
namespace ApduToByteArray
{
    partial class ApduConverterToArray
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblApdu = new System.Windows.Forms.Label();
            this.rtbApdu = new System.Windows.Forms.RichTextBox();
            this.rtbApduArray = new System.Windows.Forms.RichTextBox();
            this.lblApduArray = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApdu
            // 
            this.lblApdu.AutoSize = true;
            this.lblApdu.Location = new System.Drawing.Point(22, 26);
            this.lblApdu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApdu.Name = "lblApdu";
            this.lblApdu.Size = new System.Drawing.Size(73, 30);
            this.lblApdu.TabIndex = 1;
            this.lblApdu.Text = "APDU:";
            // 
            // rtbApdu
            // 
            this.rtbApdu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbApdu.Location = new System.Drawing.Point(22, 62);
            this.rtbApdu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rtbApdu.Name = "rtbApdu";
            this.rtbApdu.Size = new System.Drawing.Size(1326, 248);
            this.rtbApdu.TabIndex = 2;
            this.rtbApdu.Text = "";
            // 
            // rtbApduArray
            // 
            this.rtbApduArray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbApduArray.Location = new System.Drawing.Point(21, 376);
            this.rtbApduArray.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rtbApduArray.Name = "rtbApduArray";
            this.rtbApduArray.Size = new System.Drawing.Size(1326, 714);
            this.rtbApduArray.TabIndex = 4;
            this.rtbApduArray.Text = "";
            // 
            // lblApduArray
            // 
            this.lblApduArray.AutoSize = true;
            this.lblApduArray.Location = new System.Drawing.Point(21, 340);
            this.lblApduArray.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApduArray.Name = "lblApduArray";
            this.lblApduArray.Size = new System.Drawing.Size(171, 30);
            this.lblApduArray.TabIndex = 3;
            this.lblApduArray.Text = "APDU byte array:";
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(1079, 1108);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(129, 46);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.OnButtonConvertClicked);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(1218, 1108);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(129, 46);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.OnButtonCopyClicked);
            // 
            // ApduConverterToArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 1178);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.rtbApduArray);
            this.Controls.Add(this.lblApduArray);
            this.Controls.Add(this.rtbApdu);
            this.Controls.Add(this.lblApdu);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ApduConverterToArray";
            this.Text = "APDU to APDU byte array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApdu;
        private System.Windows.Forms.RichTextBox rtbApdu;
        private System.Windows.Forms.RichTextBox rtbApduArray;
        private System.Windows.Forms.Label lblApduArray;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnCopy;
    }
}

