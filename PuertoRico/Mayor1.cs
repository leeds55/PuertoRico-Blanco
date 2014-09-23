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
				return _Button1;
			}
			set
			{
				if (_Button1 != null)
				{
					Mayor1 mayor1 = this;
					_Button1.Click -=new EventHandler(mayor1.Button1_Click);
				}
				_Button1 = value;
				if (_Button1 != null)
				{
					Mayor1 mayor11 = this;
					_Button1.Click +=new EventHandler(mayor11.Button1_Click);
				}
			}
		}

		internal virtual Label p1_mayor_label
		{
			get
			{
				return _p1_mayor_label;
			}
			set
			{
				_p1_mayor_label = value;
			}
		}

		internal virtual Label p1_name_label
		{
			get
			{
				return _p1_name_label;
			}
			set
			{
				_p1_name_label = value;
			}
		}

		internal virtual Label p1_total_label
		{
			get
			{
				return _p1_total_label;
			}
			set
			{
				_p1_total_label = value;
			}
		}

		internal virtual Label p2_mayor_label
		{
			get
			{
				return _p2_mayor_label;
			}
			set
			{
				_p2_mayor_label = value;
			}
		}

		internal virtual Label p2_name_label
		{
			get
			{
				return _p2_name_label;
			}
			set
			{
				_p2_name_label = value;
			}
		}

		internal virtual Label p2_total_label
		{
			get
			{
				return _p2_total_label;
			}
			set
			{
				_p2_total_label = value;
			}
		}

		internal virtual Label p3_mayor_label
		{
			get
			{
				return _p3_mayor_label;
			}
			set
			{
				_p3_mayor_label = value;
			}
		}

		internal virtual Label p3_name_label
		{
			get
			{
				return _p3_name_label;
			}
			set
			{
				_p3_name_label = value;
			}
		}

		internal virtual Label p3_total_label
		{
			get
			{
				return _p3_total_label;
			}
			set
			{
				_p3_total_label = value;
			}
		}

		internal virtual Label p4_mayor_label
		{
			get
			{
				return _p4_mayor_label;
			}
			set
			{
				_p4_mayor_label = value;
			}
		}

		internal virtual Label p4_name_label
		{
			get
			{
				return _p4_name_label;
			}
			set
			{
				_p4_name_label = value;
			}
		}

		internal virtual Label p4_total_label
		{
			get
			{
				return _p4_total_label;
			}
			set
			{
				_p4_total_label = value;
			}
		}

		internal virtual Label p5_mayor_label
		{
			get
			{
				return _p5_mayor_label;
			}
			set
			{
				_p5_mayor_label = value;
			}
		}

		internal virtual Label p5_name_label
		{
			get
			{
				return _p5_name_label;
			}
			set
			{
				_p5_name_label = value;
			}
		}

		internal virtual Label p5_total_label
		{
			get
			{
				return _p5_total_label;
			}
			set
			{
				_p5_total_label = value;
			}
		}

		internal virtual PictureBox PictureBox1
		{
			get
			{
				return _PictureBox1;
			}
			set
			{
				_PictureBox1 = value;
			}
		}

		public Mayor1()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ResourceManager resourceManager = new ResourceManager(typeof(Mayor1));
			p1_name_label = new Label();
			p1_total_label = new Label();
			p2_total_label = new Label();
			p2_name_label = new Label();
			p3_total_label = new Label();
			p3_name_label = new Label();
			p4_total_label = new Label();
			p4_name_label = new Label();
			p5_total_label = new Label();
			p5_name_label = new Label();
			p5_mayor_label = new Label();
			p4_mayor_label = new Label();
			p2_mayor_label = new Label();
			p3_mayor_label = new Label();
			p1_mayor_label = new Label();
			PictureBox1 = new PictureBox();
			Button1 = new Button();
			SuspendLayout();
			p1_name_label.BorderStyle = BorderStyle.Fixed3D;
			p1_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p1NameLabel = p1_name_label;
			Point point = new Point(184, 40);
			p1NameLabel.Location = point;
			p1_name_label.Name = "p1_name_label";
			Label label = p1_name_label;
			Size size = new Size(120, 23);
			label.Size = size;
			p1_name_label.TabIndex=0;
			p1_name_label.Text = "Player1";
			p1_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p1_total_label.BorderStyle = BorderStyle.Fixed3D;
			p1_total_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p1TotalLabel = p1_total_label;
			point = new Point(312, 40);
			p1TotalLabel.Location = point;
			p1_total_label.Name = "p1_total_label";
			Label p1TotalLabel1 = p1_total_label;
			size = new Size(32, 23);
			p1TotalLabel1.Size = size;
			p1_total_label.TabIndex=1;
			p1_total_label.Text = "99";
			p1_total_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_total_label.BorderStyle = BorderStyle.Fixed3D;
			p2_total_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p2TotalLabel = p2_total_label;
			point = new Point(312, 72);
			p2TotalLabel.Location = point;
			p2_total_label.Name = "p2_total_label";
			Label p2TotalLabel1 = p2_total_label;
			size = new Size(32, 23);
			p2TotalLabel1.Size = size;
			p2_total_label.TabIndex=3;
			p2_total_label.Text = "99";
			p2_total_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_name_label.BorderStyle = BorderStyle.Fixed3D;
			p2_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p2NameLabel = p2_name_label;
			point = new Point(184, 72);
			p2NameLabel.Location = point;
			p2_name_label.Name = "p2_name_label";
			Label p2NameLabel1 = p2_name_label;
			size = new Size(120, 23);
			p2NameLabel1.Size = size;
			p2_name_label.TabIndex=2;
			p2_name_label.Text = "Player2";
			p2_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_total_label.BorderStyle = BorderStyle.Fixed3D;
			p3_total_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p3TotalLabel = p3_total_label;
			point = new Point(312, 104);
			p3TotalLabel.Location = point;
			p3_total_label.Name = "p3_total_label";
			Label p3TotalLabel1 = p3_total_label;
			size = new Size(32, 23);
			p3TotalLabel1.Size = size;
			p3_total_label.TabIndex=5;
			p3_total_label.Text = "99";
			p3_total_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_name_label.BorderStyle = BorderStyle.Fixed3D;
			p3_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p3NameLabel = p3_name_label;
			point = new Point(184, 104);
			p3NameLabel.Location = point;
			p3_name_label.Name = "p3_name_label";
			Label p3NameLabel1 = p3_name_label;
			size = new Size(120, 23);
			p3NameLabel1.Size = size;
			p3_name_label.TabIndex=4;
			p3_name_label.Text = "Player3";
			p3_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_total_label.BorderStyle = BorderStyle.Fixed3D;
			p4_total_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p4TotalLabel = p4_total_label;
			point = new Point(312, 136);
			p4TotalLabel.Location = point;
			p4_total_label.Name = "p4_total_label";
			Label p4TotalLabel1 = p4_total_label;
			size = new Size(32, 23);
			p4TotalLabel1.Size = size;
			p4_total_label.TabIndex=7;
			p4_total_label.Text = "99";
			p4_total_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_name_label.BorderStyle = BorderStyle.Fixed3D;
			p4_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p4NameLabel = p4_name_label;
			point = new Point(184, 136);
			p4NameLabel.Location = point;
			p4_name_label.Name = "p4_name_label";
			Label p4NameLabel1 = p4_name_label;
			size = new Size(120, 23);
			p4NameLabel1.Size = size;
			p4_name_label.TabIndex=6;
			p4_name_label.Text = "Player4";
			p4_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p5_total_label.BorderStyle = BorderStyle.Fixed3D;
			p5_total_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p5TotalLabel = p5_total_label;
			point = new Point(312, 168);
			p5TotalLabel.Location = point;
			p5_total_label.Name = "p5_total_label";
			Label p5TotalLabel1 = p5_total_label;
			size = new Size(32, 23);
			p5TotalLabel1.Size = size;
			p5_total_label.TabIndex=9;
			p5_total_label.Text = "99";
			p5_total_label.TextAlign = ContentAlignment.MiddleCenter;
			p5_name_label.BorderStyle = BorderStyle.Fixed3D;
			p5_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p5NameLabel = p5_name_label;
			point = new Point(184, 168);
			p5NameLabel.Location = point;
			p5_name_label.Name = "p5_name_label";
			Label p5NameLabel1 = p5_name_label;
			size = new Size(120, 23);
			p5NameLabel1.Size = size;
			p5_name_label.TabIndex=8;
			p5_name_label.Text = "Player5";
			p5_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p5_mayor_label.BorderStyle = BorderStyle.Fixed3D;
			p5_mayor_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p5MayorLabel = p5_mayor_label;
			point = new Point(112, 168);
			p5MayorLabel.Location = point;
			p5_mayor_label.Name = "p5_mayor_label";
			Label p5MayorLabel1 = p5_mayor_label;
			size = new Size(64, 23);
			p5MayorLabel1.Size = size;
			p5_mayor_label.TabIndex = 10;
			p5_mayor_label.Text = "Mayor";
			p5_mayor_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_mayor_label.BorderStyle = BorderStyle.Fixed3D;
			p4_mayor_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p4MayorLabel = p4_mayor_label;
			point = new Point(112, 136);
			p4MayorLabel.Location = point;
			p4_mayor_label.Name = "p4_mayor_label";
			Label p4MayorLabel1 = p4_mayor_label;
			size = new Size(64, 23);
			p4MayorLabel1.Size = size;
			p4_mayor_label.TabIndex = 11;
			p4_mayor_label.Text = "Mayor";
			p4_mayor_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_mayor_label.BorderStyle = BorderStyle.Fixed3D;
			p2_mayor_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p2MayorLabel = p2_mayor_label;
			point = new Point(112, 72);
			p2MayorLabel.Location = point;
			p2_mayor_label.Name = "p2_mayor_label";
			Label p2MayorLabel1 = p2_mayor_label;
			size = new Size(64, 23);
			p2MayorLabel1.Size = size;
			p2_mayor_label.TabIndex = 13;
			p2_mayor_label.Text = "Mayor";
			p2_mayor_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_mayor_label.BorderStyle = BorderStyle.Fixed3D;
			p3_mayor_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p3MayorLabel = p3_mayor_label;
			point = new Point(112, 104);
			p3MayorLabel.Location = point;
			p3_mayor_label.Name = "p3_mayor_label";
			Label p3MayorLabel1 = p3_mayor_label;
			size = new Size(64, 23);
			p3MayorLabel1.Size = size;
			p3_mayor_label.TabIndex = 12;
			p3_mayor_label.Text = "Mayor";
			p3_mayor_label.TextAlign = ContentAlignment.MiddleCenter;
			p1_mayor_label.BorderStyle = BorderStyle.Fixed3D;
			p1_mayor_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p1MayorLabel = p1_mayor_label;
			point = new Point(112, 40);
			p1MayorLabel.Location = point;
			p1_mayor_label.Name = "p1_mayor_label";
			Label p1MayorLabel1 = p1_mayor_label;
			size = new Size(64, 23);
			p1MayorLabel1.Size = size;
			p1_mayor_label.TabIndex = 14;
			p1_mayor_label.Text = "Mayor";
			p1_mayor_label.TextAlign = ContentAlignment.MiddleCenter;
			PictureBox1.Image = (Image)resourceManager.GetObject("PictureBox1.Image");
			PictureBox pictureBox1 = PictureBox1;
			point = new Point(24, 64);
			pictureBox1.Location = point;
			PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = PictureBox1;
			size = new Size(72, 104);
			pictureBox.Size = size;
			PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox1.TabIndex = 15;
			PictureBox1.TabStop = false;
			Button button1 = Button1;
			point = new Point(152, 216);
			button1.Location = point;
			Button1.Name = "Button1";
			Button1.TabIndex = 16;
			Button1.Text = "OK";
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(368, 258);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(Button1);
			Controls.Add(PictureBox1);
			Controls.Add(p1_mayor_label);
			Controls.Add(p2_mayor_label);
			Controls.Add(p3_mayor_label);
			Controls.Add(p4_mayor_label);
			Controls.Add(p5_mayor_label);
			Controls.Add(p5_total_label);
			Controls.Add(p5_name_label);
			Controls.Add(p4_total_label);
			Controls.Add(p4_name_label);
			Controls.Add(p3_total_label);
			Controls.Add(p3_name_label);
			Controls.Add(p2_total_label);
			Controls.Add(p2_name_label);
			Controls.Add(p1_total_label);
			Controls.Add(p1_name_label);
			size = new Size(376, 296);
			MaximumSize = size;
			size = new Size(376, 296);
			MinimumSize = size;
			Name = "Mayor1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Where the Colonists went";
			ResumeLayout(false);
		}
	}
}
