namespace TomLabs.OpenSource.WinForms.Utils.Forms
{
	partial class MessageForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
			this.lblMessage = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.panelActionButtons = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// lblMessage
			// 
			this.lblMessage.BackColor = System.Drawing.Color.White;
			this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblMessage.Location = new System.Drawing.Point(1, 0);
			this.lblMessage.Margin = new System.Windows.Forms.Padding(0);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Padding = new System.Windows.Forms.Padding(5);
			this.lblMessage.Size = new System.Drawing.Size(378, 90);
			this.lblMessage.TabIndex = 0;
			this.lblMessage.Text = "label1";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(283, 93);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 33);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// panelActionButtons
			// 
			this.panelActionButtons.Location = new System.Drawing.Point(14, 93);
			this.panelActionButtons.Name = "panelActionButtons";
			this.panelActionButtons.Size = new System.Drawing.Size(256, 32);
			this.panelActionButtons.TabIndex = 3;
			// 
			// MessageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 138);
			this.Controls.Add(this.panelActionButtons);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lblMessage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MessageForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MessageForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Panel panelActionButtons;
	}
}