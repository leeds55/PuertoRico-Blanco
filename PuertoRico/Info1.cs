using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Info1 : Form
	{
		[AccessedThroughProperty("info_label1")]
		private Label _info_label1;

		[AccessedThroughProperty("ok_button")]
		private Button _ok_button;

		[AccessedThroughProperty("info_label2")]
		private Label _info_label2;

		private IContainer components;

		internal virtual Label info_label1
		{
			get
			{
				return this._info_label1;
			}
			set
			{
				this._info_label1 = null;
				this._info_label1 = value;
				this._info_label1 = null;
			}
		}

		internal virtual Label info_label2
		{
			get
			{
				return this._info_label2;
			}
			set
			{
				this._info_label2 = null;
				this._info_label2 = value;
				this._info_label2 = null;
			}
		}

		internal virtual Button ok_button
		{
			get
			{
				return this._ok_button;
			}
			set
			{
				if (this._ok_button != null)
				{
					Info1 info1 = this;
					this._ok_button.Click -=new EventHandler(info1.ok_button_Click);
				}
				this._ok_button = value;
				if (this._ok_button != null)
				{
					Info1 info11 = this;
					this._ok_button.Click +=new EventHandler(info11.ok_button_Click);
				}
			}
		}

		public Info1()
		{
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.ok_button = new Button();
			this.info_label1 = new Label();
			this.info_label2 = new Label();
			this.SuspendLayout();
			Button okButton = this.ok_button;
			Point point = new Point(160, 312);
			okButton.Location = point;
			this.ok_button.Name = "ok_button";
			Button button = this.ok_button;
			Size size = new Size(104, 40);
			button.Size = size;
			this.ok_button.TabIndex=0;
			this.ok_button.Text = "OK";
			this.info_label1.BorderStyle = BorderStyle.Fixed3D;
			this.info_label1.Font = new Font("Comic Sans MS", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label infoLabel1 = this.info_label1;
			point = new Point(40, 40);
			infoLabel1.Location = point;
			this.info_label1.Name = "info_label1";
			Label label = this.info_label1;
			size = new Size(368, 120);
			label.Size = size;
			this.info_label1.TabIndex=1;
			this.info_label1.Text = "Text will go here.";
			this.info_label2.BorderStyle = BorderStyle.Fixed3D;
			this.info_label2.Font = new Font("Comic Sans MS", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label infoLabel2 = this.info_label2;
			point = new Point(40, 168);
			infoLabel2.Location = point;
			this.info_label2.Name = "info_label2";
			Label infoLabel21 = this.info_label2;
			size = new Size(368, 120);
			infoLabel21.Size = size;
			this.info_label2.TabIndex=2;
			this.info_label2.Text = "Text will go here.";
			size = new Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new Size(440, 386);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.info_label2);
			this.Controls.Add(this.info_label1);
			this.Controls.Add(this.ok_button);
			size = new Size(448, 424);
			this.MaximumSize = size;
			size = new Size(448, 424);
			this.MinimumSize = size;
			this.Name = "Info1";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Information";
			this.ResumeLayout(false);
		}

		private void ok_button_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
