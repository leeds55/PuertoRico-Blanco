using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Infopurchase1 : Form
	{
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		private IContainer components;

		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			set
			{
				if (this._Button1 != null)
				{
					Infopurchase1 infopurchase1 = this;
					this._Button1.Click -=new EventHandler(infopurchase1.Button1_Click);
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					Infopurchase1 infopurchase11 = this;
					this._Button1.Click +=new EventHandler(infopurchase11.Button1_Click);
				}
			}
		}

		internal virtual GroupBox GroupBox1
		{
			get
			{
				return this._GroupBox1;
			}
			set
			{
				this._GroupBox1 = null;
				this._GroupBox1 = value;
				this._GroupBox1 = null;
			}
		}

		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			set
			{
				this._Label1 = null;
				this._Label1 = value;
				this._Label1 = null;
			}
		}

		internal virtual Label Label10
		{
			get
			{
				return this._Label10;
			}
			set
			{
				this._Label10 = null;
				this._Label10 = value;
				this._Label10 = null;
			}
		}

		internal virtual Label Label11
		{
			get
			{
				return this._Label11;
			}
			set
			{
				this._Label11 = null;
				this._Label11 = value;
				this._Label11 = null;
			}
		}

		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			set
			{
				this._Label2 = null;
				this._Label2 = value;
				this._Label2 = null;
			}
		}

		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			set
			{
				this._Label3 = null;
				this._Label3 = value;
				this._Label3 = null;
			}
		}

		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			set
			{
				this._Label4 = null;
				this._Label4 = value;
				this._Label4 = null;
			}
		}

		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			set
			{
				this._Label5 = null;
				this._Label5 = value;
				this._Label5 = null;
			}
		}

		internal virtual Label Label6
		{
			get
			{
				return this._Label6;
			}
			set
			{
				this._Label6 = null;
				this._Label6 = value;
				this._Label6 = null;
			}
		}

		internal virtual Label Label7
		{
			get
			{
				return this._Label7;
			}
			set
			{
				this._Label7 = null;
				this._Label7 = value;
				this._Label7 = null;
			}
		}

		internal virtual Label Label8
		{
			get
			{
				return this._Label8;
			}
			set
			{
				this._Label8 = null;
				this._Label8 = value;
				this._Label8 = null;
			}
		}

		internal virtual Label Label9
		{
			get
			{
				return this._Label9;
			}
			set
			{
				this._Label9 = null;
				this._Label9 = value;
				this._Label9 = null;
			}
		}

		internal virtual PictureBox PictureBox1
		{
			get
			{
				return this._PictureBox1;
			}
			set
			{
				this._PictureBox1 = null;
				this._PictureBox1 = value;
				this._PictureBox1 = null;
			}
		}

		public Infopurchase1()
		{
			this.InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
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
			this.Button1 = new Button();
			this.PictureBox1 = new PictureBox();
			this.Label1 = new Label();
			this.Label2 = new Label();
			this.Label3 = new Label();
			this.Label4 = new Label();
			this.Label5 = new Label();
			this.Label6 = new Label();
			this.Label7 = new Label();
			this.Label8 = new Label();
			this.Label9 = new Label();
			this.Label10 = new Label();
			this.Label11 = new Label();
			this.GroupBox1 = new GroupBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			Button button1 = this.Button1;
			Point point = new Point(40, 344);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			Size size = new Size(112, 32);
			button.Size = size;
			this.Button1.TabIndex=7;
			this.Button1.Text = "OK";
			PictureBox pictureBox1 = this.PictureBox1;
			point = new Point(32, 101);
			pictureBox1.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = this.PictureBox1;
			size = new Size(160, 80);
			pictureBox.Size = size;
			this.PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex=6;
			this.PictureBox1.TabStop = false;
			this.Label1.BorderStyle = BorderStyle.Fixed3D;
			this.Label1.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label1 = this.Label1;
			point = new Point(240, 48);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			size = new Size(224, 32);
			label.Size = size;
			this.Label1.TabIndex=8;
			this.Label1.Text = "title";
			this.Label1.TextAlign = ContentAlignment.MiddleCenter;
			this.Label2.BorderStyle = BorderStyle.Fixed3D;
			this.Label2.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label2 = this.Label2;
			point = new Point(240, 88);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new Size(224, 120);
			label21.Size = size;
			this.Label2.TabIndex=9;
			this.Label2.Text = "function";
			this.Label2.TextAlign = ContentAlignment.MiddleCenter;
			this.Label3.BorderStyle = BorderStyle.Fixed3D;
			this.Label3.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label3 = this.Label3;
			point = new Point(344, 216);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new Size(120, 32);
			label31.Size = size;
			this.Label3.TabIndex = 10;
			this.Label3.Text = "Victory Points";
			this.Label3.TextAlign = ContentAlignment.MiddleCenter;
			this.Label4.BorderStyle = BorderStyle.Fixed3D;
			this.Label4.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label4 = this.Label4;
			point = new Point(344, 256);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label41 = this.Label4;
			size = new Size(120, 32);
			label41.Size = size;
			this.Label4.TabIndex = 11;
			this.Label4.Text = "Base Cost";
			this.Label4.TextAlign = ContentAlignment.MiddleCenter;
			this.Label5.BorderStyle = BorderStyle.Fixed3D;
			this.Label5.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label5 = this.Label5;
			point = new Point(344, 296);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label51 = this.Label5;
			size = new Size(120, 32);
			label51.Size = size;
			this.Label5.TabIndex = 12;
			this.Label5.Text = "Cost with Quarries";
			this.Label5.TextAlign = ContentAlignment.MiddleCenter;
			this.Label6.BorderStyle = BorderStyle.Fixed3D;
			this.Label6.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label6 = this.Label6;
			point = new Point(152, 16);
			label6.Location = point;
			this.Label6.Name = "Label6";
			Label label61 = this.Label6;
			size = new Size(120, 32);
			label61.Size = size;
			this.Label6.TabIndex = 13;
			this.Label6.Text = "Cost with Builder Bonus";
			this.Label6.TextAlign = ContentAlignment.MiddleCenter;
			this.Label7.BorderStyle = BorderStyle.Fixed3D;
			this.Label7.Font = new Font("Comic Sans MS", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label7 = this.Label7;
			point = new Point(8, 16);
			label7.Location = point;
			this.Label7.Name = "Label7";
			Label label71 = this.Label7;
			size = new Size(136, 32);
			label71.Size = size;
			this.Label7.TabIndex = 17;
			this.Label7.Text = "Cost with Builder Bonus";
			this.Label7.TextAlign = ContentAlignment.MiddleCenter;
			this.Label8.BorderStyle = BorderStyle.Fixed3D;
			this.Label8.Font = new Font("Comic Sans MS", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label8 = this.Label8;
			point = new Point(200, 296);
			label8.Location = point;
			this.Label8.Name = "Label8";
			Label label81 = this.Label8;
			size = new Size(136, 32);
			label81.Size = size;
			this.Label8.TabIndex = 16;
			this.Label8.Text = "Cost w/your manned Quarries";
			this.Label8.TextAlign = ContentAlignment.MiddleCenter;
			this.Label9.BorderStyle = BorderStyle.Fixed3D;
			this.Label9.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label9 = this.Label9;
			point = new Point(200, 256);
			label9.Location = point;
			this.Label9.Name = "Label9";
			Label label91 = this.Label9;
			size = new Size(136, 32);
			label91.Size = size;
			this.Label9.TabIndex = 15;
			this.Label9.Text = "Base Cost";
			this.Label9.TextAlign = ContentAlignment.MiddleCenter;
			this.Label10.BorderStyle = BorderStyle.Fixed3D;
			this.Label10.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label10 = this.Label10;
			point = new Point(200, 216);
			label10.Location = point;
			this.Label10.Name = "Label10";
			Label label101 = this.Label10;
			size = new Size(136, 32);
			label101.Size = size;
			this.Label10.TabIndex = 14;
			this.Label10.Text = "Victory Points";
			this.Label10.TextAlign = ContentAlignment.MiddleCenter;
			this.Label11.BorderStyle = BorderStyle.Fixed3D;
			this.Label11.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label11 = this.Label11;
			point = new Point(40, 208);
			label11.Location = point;
			this.Label11.Name = "Label11";
			Label label111 = this.Label11;
			size = new Size(128, 56);
			label111.Size = size;
			this.Label11.TabIndex = 18;
			this.Label11.Text = "99 Remaining";
			this.Label11.TextAlign = ContentAlignment.MiddleCenter;
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label7);
			GroupBox groupBox1 = this.GroupBox1;
			point = new Point(192, 328);
			groupBox1.Location = point;
			this.GroupBox1.Name = "GroupBox1";
			GroupBox groupBox = this.GroupBox1;
			size = new Size(280, 56);
			groupBox.Size = size;
			this.GroupBox1.TabIndex = 19;
			this.GroupBox1.TabStop = false;
			size = new Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new Size(488, 402);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Label11);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.PictureBox1);
			size = new Size(496, 440);
			this.MaximumSize = size;
			size = new Size(496, 440);
			this.MinimumSize = size;
			this.Name = "Infopurchase1";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Building Info";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
