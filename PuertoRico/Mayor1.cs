using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Mayor1 : Form
	{
		[AccessedThroughProperty("p4_name_label")]
		private Label _p4_name_label;

		[AccessedThroughProperty("p2_total_label")]
		private Label _p2_total_label;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("p3_total_label")]
		private Label _p3_total_label;

		[AccessedThroughProperty("p1_mayor_label")]
		private Label _p1_mayor_label;

		[AccessedThroughProperty("p3_mayor_label")]
		private Label _p3_mayor_label;

		[AccessedThroughProperty("p1_name_label")]
		private Label _p1_name_label;

		[AccessedThroughProperty("p2_mayor_label")]
		private Label _p2_mayor_label;

		[AccessedThroughProperty("p2_name_label")]
		private Label _p2_name_label;

		[AccessedThroughProperty("p4_mayor_label")]
		private Label _p4_mayor_label;

		[AccessedThroughProperty("p3_name_label")]
		private Label _p3_name_label;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("p4_total_label")]
		private Label _p4_total_label;

		[AccessedThroughProperty("p5_name_label")]
		private Label _p5_name_label;

		[AccessedThroughProperty("p5_total_label")]
		private Label _p5_total_label;

		[AccessedThroughProperty("p5_mayor_label")]
		private Label _p5_mayor_label;

		[AccessedThroughProperty("p1_total_label")]
		private Label _p1_total_label;

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
					Mayor1 mayor1 = this;
					this._Button1.Click -=new EventHandler(mayor1.Button1_Click);
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					Mayor1 mayor11 = this;
					this._Button1.Click +=new EventHandler(mayor11.Button1_Click);
				}
			}
		}

		internal virtual Label p1_mayor_label
		{
			get
			{
				return this._p1_mayor_label;
			}
			set
			{
				this._p1_mayor_label = null;
				this._p1_mayor_label = value;
				this._p1_mayor_label = null;
			}
		}

		internal virtual Label p1_name_label
		{
			get
			{
				return this._p1_name_label;
			}
			set
			{
				this._p1_name_label = null;
				this._p1_name_label = value;
				this._p1_name_label = null;
			}
		}

		internal virtual Label p1_total_label
		{
			get
			{
				return this._p1_total_label;
			}
			set
			{
				this._p1_total_label = null;
				this._p1_total_label = value;
				this._p1_total_label = null;
			}
		}

		internal virtual Label p2_mayor_label
		{
			get
			{
				return this._p2_mayor_label;
			}
			set
			{
				this._p2_mayor_label = null;
				this._p2_mayor_label = value;
				this._p2_mayor_label = null;
			}
		}

		internal virtual Label p2_name_label
		{
			get
			{
				return this._p2_name_label;
			}
			set
			{
				this._p2_name_label = null;
				this._p2_name_label = value;
				this._p2_name_label = null;
			}
		}

		internal virtual Label p2_total_label
		{
			get
			{
				return this._p2_total_label;
			}
			set
			{
				this._p2_total_label = null;
				this._p2_total_label = value;
				this._p2_total_label = null;
			}
		}

		internal virtual Label p3_mayor_label
		{
			get
			{
				return this._p3_mayor_label;
			}
			set
			{
				this._p3_mayor_label = null;
				this._p3_mayor_label = value;
				this._p3_mayor_label = null;
			}
		}

		internal virtual Label p3_name_label
		{
			get
			{
				return this._p3_name_label;
			}
			set
			{
				this._p3_name_label = null;
				this._p3_name_label = value;
				this._p3_name_label = null;
			}
		}

		internal virtual Label p3_total_label
		{
			get
			{
				return this._p3_total_label;
			}
			set
			{
				this._p3_total_label = null;
				this._p3_total_label = value;
				this._p3_total_label = null;
			}
		}

		internal virtual Label p4_mayor_label
		{
			get
			{
				return this._p4_mayor_label;
			}
			set
			{
				this._p4_mayor_label = null;
				this._p4_mayor_label = value;
				this._p4_mayor_label = null;
			}
		}

		internal virtual Label p4_name_label
		{
			get
			{
				return this._p4_name_label;
			}
			set
			{
				this._p4_name_label = null;
				this._p4_name_label = value;
				this._p4_name_label = null;
			}
		}

		internal virtual Label p4_total_label
		{
			get
			{
				return this._p4_total_label;
			}
			set
			{
				this._p4_total_label = null;
				this._p4_total_label = value;
				this._p4_total_label = null;
			}
		}

		internal virtual Label p5_mayor_label
		{
			get
			{
				return this._p5_mayor_label;
			}
			set
			{
				this._p5_mayor_label = null;
				this._p5_mayor_label = value;
				this._p5_mayor_label = null;
			}
		}

		internal virtual Label p5_name_label
		{
			get
			{
				return this._p5_name_label;
			}
			set
			{
				this._p5_name_label = null;
				this._p5_name_label = value;
				this._p5_name_label = null;
			}
		}

		internal virtual Label p5_total_label
		{
			get
			{
				return this._p5_total_label;
			}
			set
			{
				this._p5_total_label = null;
				this._p5_total_label = value;
				this._p5_total_label = null;
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

		public Mayor1()
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
			ResourceManager resourceManager = new ResourceManager(typeof(Mayor1));
			this.p1_name_label = new Label();
			this.p1_total_label = new Label();
			this.p2_total_label = new Label();
			this.p2_name_label = new Label();
			this.p3_total_label = new Label();
			this.p3_name_label = new Label();
			this.p4_total_label = new Label();
			this.p4_name_label = new Label();
			this.p5_total_label = new Label();
			this.p5_name_label = new Label();
			this.p5_mayor_label = new Label();
			this.p4_mayor_label = new Label();
			this.p2_mayor_label = new Label();
			this.p3_mayor_label = new Label();
			this.p1_mayor_label = new Label();
			this.PictureBox1 = new PictureBox();
			this.Button1 = new Button();
			this.SuspendLayout();
			this.p1_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p1_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p1NameLabel = this.p1_name_label;
			Point point = new Point(184, 40);
			p1NameLabel.Location = point;
			this.p1_name_label.Name = "p1_name_label";
			Label label = this.p1_name_label;
			Size size = new Size(120, 23);
			label.Size = size;
			this.p1_name_label.TabIndex=0;
			this.p1_name_label.Text = "Player1";
			this.p1_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_total_label.BorderStyle = BorderStyle.Fixed3D;
			this.p1_total_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p1TotalLabel = this.p1_total_label;
			point = new Point(312, 40);
			p1TotalLabel.Location = point;
			this.p1_total_label.Name = "p1_total_label";
			Label p1TotalLabel1 = this.p1_total_label;
			size = new Size(32, 23);
			p1TotalLabel1.Size = size;
			this.p1_total_label.TabIndex=1;
			this.p1_total_label.Text = "99";
			this.p1_total_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_total_label.BorderStyle = BorderStyle.Fixed3D;
			this.p2_total_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p2TotalLabel = this.p2_total_label;
			point = new Point(312, 72);
			p2TotalLabel.Location = point;
			this.p2_total_label.Name = "p2_total_label";
			Label p2TotalLabel1 = this.p2_total_label;
			size = new Size(32, 23);
			p2TotalLabel1.Size = size;
			this.p2_total_label.TabIndex=3;
			this.p2_total_label.Text = "99";
			this.p2_total_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p2_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p2NameLabel = this.p2_name_label;
			point = new Point(184, 72);
			p2NameLabel.Location = point;
			this.p2_name_label.Name = "p2_name_label";
			Label p2NameLabel1 = this.p2_name_label;
			size = new Size(120, 23);
			p2NameLabel1.Size = size;
			this.p2_name_label.TabIndex=2;
			this.p2_name_label.Text = "Player2";
			this.p2_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_total_label.BorderStyle = BorderStyle.Fixed3D;
			this.p3_total_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p3TotalLabel = this.p3_total_label;
			point = new Point(312, 104);
			p3TotalLabel.Location = point;
			this.p3_total_label.Name = "p3_total_label";
			Label p3TotalLabel1 = this.p3_total_label;
			size = new Size(32, 23);
			p3TotalLabel1.Size = size;
			this.p3_total_label.TabIndex=5;
			this.p3_total_label.Text = "99";
			this.p3_total_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p3_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p3NameLabel = this.p3_name_label;
			point = new Point(184, 104);
			p3NameLabel.Location = point;
			this.p3_name_label.Name = "p3_name_label";
			Label p3NameLabel1 = this.p3_name_label;
			size = new Size(120, 23);
			p3NameLabel1.Size = size;
			this.p3_name_label.TabIndex=4;
			this.p3_name_label.Text = "Player3";
			this.p3_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_total_label.BorderStyle = BorderStyle.Fixed3D;
			this.p4_total_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p4TotalLabel = this.p4_total_label;
			point = new Point(312, 136);
			p4TotalLabel.Location = point;
			this.p4_total_label.Name = "p4_total_label";
			Label p4TotalLabel1 = this.p4_total_label;
			size = new Size(32, 23);
			p4TotalLabel1.Size = size;
			this.p4_total_label.TabIndex=7;
			this.p4_total_label.Text = "99";
			this.p4_total_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p4_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p4NameLabel = this.p4_name_label;
			point = new Point(184, 136);
			p4NameLabel.Location = point;
			this.p4_name_label.Name = "p4_name_label";
			Label p4NameLabel1 = this.p4_name_label;
			size = new Size(120, 23);
			p4NameLabel1.Size = size;
			this.p4_name_label.TabIndex=6;
			this.p4_name_label.Text = "Player4";
			this.p4_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p5_total_label.BorderStyle = BorderStyle.Fixed3D;
			this.p5_total_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p5TotalLabel = this.p5_total_label;
			point = new Point(312, 168);
			p5TotalLabel.Location = point;
			this.p5_total_label.Name = "p5_total_label";
			Label p5TotalLabel1 = this.p5_total_label;
			size = new Size(32, 23);
			p5TotalLabel1.Size = size;
			this.p5_total_label.TabIndex=9;
			this.p5_total_label.Text = "99";
			this.p5_total_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p5_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p5_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p5NameLabel = this.p5_name_label;
			point = new Point(184, 168);
			p5NameLabel.Location = point;
			this.p5_name_label.Name = "p5_name_label";
			Label p5NameLabel1 = this.p5_name_label;
			size = new Size(120, 23);
			p5NameLabel1.Size = size;
			this.p5_name_label.TabIndex=8;
			this.p5_name_label.Text = "Player5";
			this.p5_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p5_mayor_label.BorderStyle = BorderStyle.Fixed3D;
			this.p5_mayor_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p5MayorLabel = this.p5_mayor_label;
			point = new Point(112, 168);
			p5MayorLabel.Location = point;
			this.p5_mayor_label.Name = "p5_mayor_label";
			Label p5MayorLabel1 = this.p5_mayor_label;
			size = new Size(64, 23);
			p5MayorLabel1.Size = size;
			this.p5_mayor_label.TabIndex = 10;
			this.p5_mayor_label.Text = "Mayor";
			this.p5_mayor_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_mayor_label.BorderStyle = BorderStyle.Fixed3D;
			this.p4_mayor_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p4MayorLabel = this.p4_mayor_label;
			point = new Point(112, 136);
			p4MayorLabel.Location = point;
			this.p4_mayor_label.Name = "p4_mayor_label";
			Label p4MayorLabel1 = this.p4_mayor_label;
			size = new Size(64, 23);
			p4MayorLabel1.Size = size;
			this.p4_mayor_label.TabIndex = 11;
			this.p4_mayor_label.Text = "Mayor";
			this.p4_mayor_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_mayor_label.BorderStyle = BorderStyle.Fixed3D;
			this.p2_mayor_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p2MayorLabel = this.p2_mayor_label;
			point = new Point(112, 72);
			p2MayorLabel.Location = point;
			this.p2_mayor_label.Name = "p2_mayor_label";
			Label p2MayorLabel1 = this.p2_mayor_label;
			size = new Size(64, 23);
			p2MayorLabel1.Size = size;
			this.p2_mayor_label.TabIndex = 13;
			this.p2_mayor_label.Text = "Mayor";
			this.p2_mayor_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_mayor_label.BorderStyle = BorderStyle.Fixed3D;
			this.p3_mayor_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p3MayorLabel = this.p3_mayor_label;
			point = new Point(112, 104);
			p3MayorLabel.Location = point;
			this.p3_mayor_label.Name = "p3_mayor_label";
			Label p3MayorLabel1 = this.p3_mayor_label;
			size = new Size(64, 23);
			p3MayorLabel1.Size = size;
			this.p3_mayor_label.TabIndex = 12;
			this.p3_mayor_label.Text = "Mayor";
			this.p3_mayor_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_mayor_label.BorderStyle = BorderStyle.Fixed3D;
			this.p1_mayor_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p1MayorLabel = this.p1_mayor_label;
			point = new Point(112, 40);
			p1MayorLabel.Location = point;
			this.p1_mayor_label.Name = "p1_mayor_label";
			Label p1MayorLabel1 = this.p1_mayor_label;
			size = new Size(64, 23);
			p1MayorLabel1.Size = size;
			this.p1_mayor_label.TabIndex = 14;
			this.p1_mayor_label.Text = "Mayor";
			this.p1_mayor_label.TextAlign = ContentAlignment.MiddleCenter;
			this.PictureBox1.Image = (Image)resourceManager.GetObject("PictureBox1.Image");
			PictureBox pictureBox1 = this.PictureBox1;
			point = new Point(24, 64);
			pictureBox1.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = this.PictureBox1;
			size = new Size(72, 104);
			pictureBox.Size = size;
			this.PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 15;
			this.PictureBox1.TabStop = false;
			Button button1 = this.Button1;
			point = new Point(152, 216);
			button1.Location = point;
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 16;
			this.Button1.Text = "OK";
			size = new Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new Size(368, 258);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.p1_mayor_label);
			this.Controls.Add(this.p2_mayor_label);
			this.Controls.Add(this.p3_mayor_label);
			this.Controls.Add(this.p4_mayor_label);
			this.Controls.Add(this.p5_mayor_label);
			this.Controls.Add(this.p5_total_label);
			this.Controls.Add(this.p5_name_label);
			this.Controls.Add(this.p4_total_label);
			this.Controls.Add(this.p4_name_label);
			this.Controls.Add(this.p3_total_label);
			this.Controls.Add(this.p3_name_label);
			this.Controls.Add(this.p2_total_label);
			this.Controls.Add(this.p2_name_label);
			this.Controls.Add(this.p1_total_label);
			this.Controls.Add(this.p1_name_label);
			size = new Size(376, 296);
			this.MaximumSize = size;
			size = new Size(376, 296);
			this.MinimumSize = size;
			this.Name = "Mayor1";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Where the Colonists went";
			this.ResumeLayout(false);
		}
	}
}
