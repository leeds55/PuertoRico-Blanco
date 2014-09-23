using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Craftsman1 : Form
	{
		[AccessedThroughProperty("p2_corn_label")]
		private Label _p2_corn_label;

		[AccessedThroughProperty("p2_indigo_label")]
		private Label _p2_indigo_label;

		[AccessedThroughProperty("p2_tobacco_label")]
		private Label _p2_tobacco_label;

		[AccessedThroughProperty("p3_coffee_label")]
		private Label _p3_coffee_label;

		[AccessedThroughProperty("p3_tobacco_label")]
		private Label _p3_tobacco_label;

		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		[AccessedThroughProperty("p3_corn_label")]
		private Label _p3_corn_label;

		[AccessedThroughProperty("p3_sugar_label")]
		private Label _p3_sugar_label;

		[AccessedThroughProperty("p2_coffee_label")]
		private Label _p2_coffee_label;

		[AccessedThroughProperty("p1_indigo_label")]
		private Label _p1_indigo_label;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("p1_sugar_label")]
		private Label _p1_sugar_label;

		[AccessedThroughProperty("p1_corn_label")]
		private Label _p1_corn_label;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("p1_tobacco_label")]
		private Label _p1_tobacco_label;

		[AccessedThroughProperty("p3_indigo_label")]
		private Label _p3_indigo_label;

		[AccessedThroughProperty("p5_coffee_label")]
		private Label _p5_coffee_label;

		[AccessedThroughProperty("p1_coffee_label")]
		private Label _p1_coffee_label;

		[AccessedThroughProperty("p5_tobacco_label")]
		private Label _p5_tobacco_label;

		[AccessedThroughProperty("p5_corn_label")]
		private Label _p5_corn_label;

		[AccessedThroughProperty("p5_sugar_label")]
		private Label _p5_sugar_label;

		[AccessedThroughProperty("p5_indigo_label")]
		private Label _p5_indigo_label;

		[AccessedThroughProperty("p4_coffee_label")]
		private Label _p4_coffee_label;

		[AccessedThroughProperty("p4_tobacco_label")]
		private Label _p4_tobacco_label;

		[AccessedThroughProperty("p4_corn_label")]
		private Label _p4_corn_label;

		[AccessedThroughProperty("p4_sugar_label")]
		private Label _p4_sugar_label;

		[AccessedThroughProperty("p4_indigo_label")]
		private Label _p4_indigo_label;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("p5_name_label")]
		private Label _p5_name_label;

		[AccessedThroughProperty("p4_name_label")]
		private Label _p4_name_label;

		[AccessedThroughProperty("p3_name_label")]
		private Label _p3_name_label;

		[AccessedThroughProperty("p2_name_label")]
		private Label _p2_name_label;

		[AccessedThroughProperty("p1_name_label")]
		private Label _p1_name_label;

		[AccessedThroughProperty("p2_sugar_label")]
		private Label _p2_sugar_label;

		[AccessedThroughProperty("p5_craftsman_label")]
		private Label _p5_craftsman_label;

		[AccessedThroughProperty("p1_craftsman_label")]
		private Label _p1_craftsman_label;

		[AccessedThroughProperty("p2_craftsman_label")]
		private Label _p2_craftsman_label;

		[AccessedThroughProperty("p3_craftsman_label")]
		private Label _p3_craftsman_label;

		[AccessedThroughProperty("p4_craftsman_label")]
		private Label _p4_craftsman_label;

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
					Craftsman1 craftsman1 = this;
					this._Button1.Click -=new EventHandler(craftsman1.Button1_Click);
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					Craftsman1 craftsman11 = this;
					this._Button1.Click +=new EventHandler(craftsman11.Button1_Click);
				}
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

		internal virtual Label p1_coffee_label
		{
			get
			{
				return this._p1_coffee_label;
			}
			set
			{
				this._p1_coffee_label = null;
				this._p1_coffee_label = value;
				this._p1_coffee_label = null;
			}
		}

		internal virtual Label p1_corn_label
		{
			get
			{
				return this._p1_corn_label;
			}
			set
			{
				this._p1_corn_label = null;
				this._p1_corn_label = value;
				this._p1_corn_label = null;
			}
		}

		internal virtual Label p1_craftsman_label
		{
			get
			{
				return this._p1_craftsman_label;
			}
			set
			{
				this._p1_craftsman_label = null;
				this._p1_craftsman_label = value;
				this._p1_craftsman_label = null;
			}
		}

		internal virtual Label p1_indigo_label
		{
			get
			{
				return this._p1_indigo_label;
			}
			set
			{
				this._p1_indigo_label = null;
				this._p1_indigo_label = value;
				this._p1_indigo_label = null;
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

		internal virtual Label p1_sugar_label
		{
			get
			{
				return this._p1_sugar_label;
			}
			set
			{
				this._p1_sugar_label = null;
				this._p1_sugar_label = value;
				this._p1_sugar_label = null;
			}
		}

		internal virtual Label p1_tobacco_label
		{
			get
			{
				return this._p1_tobacco_label;
			}
			set
			{
				this._p1_tobacco_label = null;
				this._p1_tobacco_label = value;
				this._p1_tobacco_label = null;
			}
		}

		internal virtual Label p2_coffee_label
		{
			get
			{
				return this._p2_coffee_label;
			}
			set
			{
				this._p2_coffee_label = null;
				this._p2_coffee_label = value;
				this._p2_coffee_label = null;
			}
		}

		internal virtual Label p2_corn_label
		{
			get
			{
				return this._p2_corn_label;
			}
			set
			{
				this._p2_corn_label = null;
				this._p2_corn_label = value;
				this._p2_corn_label = null;
			}
		}

		internal virtual Label p2_craftsman_label
		{
			get
			{
				return this._p2_craftsman_label;
			}
			set
			{
				this._p2_craftsman_label = null;
				this._p2_craftsman_label = value;
				this._p2_craftsman_label = null;
			}
		}

		internal virtual Label p2_indigo_label
		{
			get
			{
				return this._p2_indigo_label;
			}
			set
			{
				this._p2_indigo_label = null;
				this._p2_indigo_label = value;
				this._p2_indigo_label = null;
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

		internal virtual Label p2_sugar_label
		{
			get
			{
				return this._p2_sugar_label;
			}
			set
			{
				this._p2_sugar_label = null;
				this._p2_sugar_label = value;
				this._p2_sugar_label = null;
			}
		}

		internal virtual Label p2_tobacco_label
		{
			get
			{
				return this._p2_tobacco_label;
			}
			set
			{
				this._p2_tobacco_label = null;
				this._p2_tobacco_label = value;
				this._p2_tobacco_label = null;
			}
		}

		internal virtual Label p3_coffee_label
		{
			get
			{
				return this._p3_coffee_label;
			}
			set
			{
				this._p3_coffee_label = null;
				this._p3_coffee_label = value;
				this._p3_coffee_label = null;
			}
		}

		internal virtual Label p3_corn_label
		{
			get
			{
				return this._p3_corn_label;
			}
			set
			{
				this._p3_corn_label = null;
				this._p3_corn_label = value;
				this._p3_corn_label = null;
			}
		}

		internal virtual Label p3_craftsman_label
		{
			get
			{
				return this._p3_craftsman_label;
			}
			set
			{
				this._p3_craftsman_label = null;
				this._p3_craftsman_label = value;
				this._p3_craftsman_label = null;
			}
		}

		internal virtual Label p3_indigo_label
		{
			get
			{
				return this._p3_indigo_label;
			}
			set
			{
				this._p3_indigo_label = null;
				this._p3_indigo_label = value;
				this._p3_indigo_label = null;
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

		internal virtual Label p3_sugar_label
		{
			get
			{
				return this._p3_sugar_label;
			}
			set
			{
				this._p3_sugar_label = null;
				this._p3_sugar_label = value;
				this._p3_sugar_label = null;
			}
		}

		internal virtual Label p3_tobacco_label
		{
			get
			{
				return this._p3_tobacco_label;
			}
			set
			{
				this._p3_tobacco_label = null;
				this._p3_tobacco_label = value;
				this._p3_tobacco_label = null;
			}
		}

		internal virtual Label p4_coffee_label
		{
			get
			{
				return this._p4_coffee_label;
			}
			set
			{
				this._p4_coffee_label = null;
				this._p4_coffee_label = value;
				this._p4_coffee_label = null;
			}
		}

		internal virtual Label p4_corn_label
		{
			get
			{
				return this._p4_corn_label;
			}
			set
			{
				this._p4_corn_label = null;
				this._p4_corn_label = value;
				this._p4_corn_label = null;
			}
		}

		internal virtual Label p4_craftsman_label
		{
			get
			{
				return this._p4_craftsman_label;
			}
			set
			{
				this._p4_craftsman_label = null;
				this._p4_craftsman_label = value;
				this._p4_craftsman_label = null;
			}
		}

		internal virtual Label p4_indigo_label
		{
			get
			{
				return this._p4_indigo_label;
			}
			set
			{
				this._p4_indigo_label = null;
				this._p4_indigo_label = value;
				this._p4_indigo_label = null;
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

		internal virtual Label p4_sugar_label
		{
			get
			{
				return this._p4_sugar_label;
			}
			set
			{
				this._p4_sugar_label = null;
				this._p4_sugar_label = value;
				this._p4_sugar_label = null;
			}
		}

		internal virtual Label p4_tobacco_label
		{
			get
			{
				return this._p4_tobacco_label;
			}
			set
			{
				this._p4_tobacco_label = null;
				this._p4_tobacco_label = value;
				this._p4_tobacco_label = null;
			}
		}

		internal virtual Label p5_coffee_label
		{
			get
			{
				return this._p5_coffee_label;
			}
			set
			{
				this._p5_coffee_label = null;
				this._p5_coffee_label = value;
				this._p5_coffee_label = null;
			}
		}

		internal virtual Label p5_corn_label
		{
			get
			{
				return this._p5_corn_label;
			}
			set
			{
				this._p5_corn_label = null;
				this._p5_corn_label = value;
				this._p5_corn_label = null;
			}
		}

		internal virtual Label p5_craftsman_label
		{
			get
			{
				return this._p5_craftsman_label;
			}
			set
			{
				this._p5_craftsman_label = null;
				this._p5_craftsman_label = value;
				this._p5_craftsman_label = null;
			}
		}

		internal virtual Label p5_indigo_label
		{
			get
			{
				return this._p5_indigo_label;
			}
			set
			{
				this._p5_indigo_label = null;
				this._p5_indigo_label = value;
				this._p5_indigo_label = null;
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

		internal virtual Label p5_sugar_label
		{
			get
			{
				return this._p5_sugar_label;
			}
			set
			{
				this._p5_sugar_label = null;
				this._p5_sugar_label = value;
				this._p5_sugar_label = null;
			}
		}

		internal virtual Label p5_tobacco_label
		{
			get
			{
				return this._p5_tobacco_label;
			}
			set
			{
				this._p5_tobacco_label = null;
				this._p5_tobacco_label = value;
				this._p5_tobacco_label = null;
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

		internal virtual PictureBox PictureBox2
		{
			get
			{
				return this._PictureBox2;
			}
			set
			{
				this._PictureBox2 = null;
				this._PictureBox2 = value;
				this._PictureBox2 = null;
			}
		}

		public Craftsman1()
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
			this.p5_name_label = new Label();
			this.p4_name_label = new Label();
			this.p3_name_label = new Label();
			this.p2_name_label = new Label();
			this.p1_name_label = new Label();
			this.p1_craftsman_label = new Label();
			this.p2_craftsman_label = new Label();
			this.p3_craftsman_label = new Label();
			this.p4_craftsman_label = new Label();
			this.p5_craftsman_label = new Label();
			this.p1_coffee_label = new Label();
			this.p1_tobacco_label = new Label();
			this.p1_corn_label = new Label();
			this.p1_sugar_label = new Label();
			this.p1_indigo_label = new Label();
			this.p2_coffee_label = new Label();
			this.p2_tobacco_label = new Label();
			this.p2_corn_label = new Label();
			this.p2_sugar_label = new Label();
			this.p2_indigo_label = new Label();
			this.p3_coffee_label = new Label();
			this.p3_tobacco_label = new Label();
			this.p3_corn_label = new Label();
			this.p3_sugar_label = new Label();
			this.p3_indigo_label = new Label();
			this.p5_coffee_label = new Label();
			this.p5_tobacco_label = new Label();
			this.p5_corn_label = new Label();
			this.p5_sugar_label = new Label();
			this.p5_indigo_label = new Label();
			this.p4_coffee_label = new Label();
			this.p4_tobacco_label = new Label();
			this.p4_corn_label = new Label();
			this.p4_sugar_label = new Label();
			this.p4_indigo_label = new Label();
			this.Label1 = new Label();
			this.Button1 = new Button();
			this.PictureBox1 = new PictureBox();
			this.PictureBox2 = new PictureBox();
			this.SuspendLayout();
			this.p5_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p5_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p5NameLabel = this.p5_name_label;
			Point point = new Point(136, 256);
			p5NameLabel.Location = point;
			this.p5_name_label.Name = "p5_name_label";
			Label label = this.p5_name_label;
			Size size = new Size(120, 32);
			label.Size = size;
			this.p5_name_label.TabIndex = 13;
			this.p5_name_label.Text = "Player5";
			this.p5_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p4_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p4NameLabel = this.p4_name_label;
			point = new Point(136, 216);
			p4NameLabel.Location = point;
			this.p4_name_label.Name = "p4_name_label";
			Label p4NameLabel1 = this.p4_name_label;
			size = new Size(120, 32);
			p4NameLabel1.Size = size;
			this.p4_name_label.TabIndex = 12;
			this.p4_name_label.Text = "Player4";
			this.p4_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p3_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p3NameLabel = this.p3_name_label;
			point = new Point(136, 176);
			p3NameLabel.Location = point;
			this.p3_name_label.Name = "p3_name_label";
			Label p3NameLabel1 = this.p3_name_label;
			size = new Size(120, 32);
			p3NameLabel1.Size = size;
			this.p3_name_label.TabIndex = 11;
			this.p3_name_label.Text = "Player3";
			this.p3_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p2_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p2NameLabel = this.p2_name_label;
			point = new Point(136, 136);
			p2NameLabel.Location = point;
			this.p2_name_label.Name = "p2_name_label";
			Label p2NameLabel1 = this.p2_name_label;
			size = new Size(120, 32);
			p2NameLabel1.Size = size;
			this.p2_name_label.TabIndex = 10;
			this.p2_name_label.Text = "Player2";
			this.p2_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p1_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p1NameLabel = this.p1_name_label;
			point = new Point(136, 96);
			p1NameLabel.Location = point;
			this.p1_name_label.Name = "p1_name_label";
			Label p1NameLabel1 = this.p1_name_label;
			size = new Size(120, 32);
			p1NameLabel1.Size = size;
			this.p1_name_label.TabIndex=9;
			this.p1_name_label.Text = "Player1";
			this.p1_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_craftsman_label.BorderStyle = BorderStyle.Fixed3D;
			this.p1_craftsman_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p1CraftsmanLabel = this.p1_craftsman_label;
			point = new Point(32, 96);
			p1CraftsmanLabel.Location = point;
			this.p1_craftsman_label.Name = "p1_craftsman_label";
			Label p1CraftsmanLabel1 = this.p1_craftsman_label;
			size = new Size(88, 32);
			p1CraftsmanLabel1.Size = size;
			this.p1_craftsman_label.TabIndex = 19;
			this.p1_craftsman_label.Text = "Craftsman";
			this.p1_craftsman_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_craftsman_label.BorderStyle = BorderStyle.Fixed3D;
			this.p2_craftsman_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p2CraftsmanLabel = this.p2_craftsman_label;
			point = new Point(32, 136);
			p2CraftsmanLabel.Location = point;
			this.p2_craftsman_label.Name = "p2_craftsman_label";
			Label p2CraftsmanLabel1 = this.p2_craftsman_label;
			size = new Size(88, 32);
			p2CraftsmanLabel1.Size = size;
			this.p2_craftsman_label.TabIndex = 18;
			this.p2_craftsman_label.Text = "Craftsman";
			this.p2_craftsman_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_craftsman_label.BorderStyle = BorderStyle.Fixed3D;
			this.p3_craftsman_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p3CraftsmanLabel = this.p3_craftsman_label;
			point = new Point(32, 176);
			p3CraftsmanLabel.Location = point;
			this.p3_craftsman_label.Name = "p3_craftsman_label";
			Label p3CraftsmanLabel1 = this.p3_craftsman_label;
			size = new Size(88, 32);
			p3CraftsmanLabel1.Size = size;
			this.p3_craftsman_label.TabIndex = 17;
			this.p3_craftsman_label.Text = "Craftsman";
			this.p3_craftsman_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_craftsman_label.BorderStyle = BorderStyle.Fixed3D;
			this.p4_craftsman_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p4CraftsmanLabel = this.p4_craftsman_label;
			point = new Point(32, 216);
			p4CraftsmanLabel.Location = point;
			this.p4_craftsman_label.Name = "p4_craftsman_label";
			Label p4CraftsmanLabel1 = this.p4_craftsman_label;
			size = new Size(88, 32);
			p4CraftsmanLabel1.Size = size;
			this.p4_craftsman_label.TabIndex = 16;
			this.p4_craftsman_label.Text = "Craftsman";
			this.p4_craftsman_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p5_craftsman_label.BorderStyle = BorderStyle.Fixed3D;
			this.p5_craftsman_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p5CraftsmanLabel = this.p5_craftsman_label;
			point = new Point(32, 256);
			p5CraftsmanLabel.Location = point;
			this.p5_craftsman_label.Name = "p5_craftsman_label";
			Label p5CraftsmanLabel1 = this.p5_craftsman_label;
			size = new Size(88, 32);
			p5CraftsmanLabel1.Size = size;
			this.p5_craftsman_label.TabIndex = 15;
			this.p5_craftsman_label.Text = "Craftsman";
			this.p5_craftsman_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_coffee_label.BackColor = Color.SaddleBrown;
			this.p1_coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p1_coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p1CoffeeLabel = this.p1_coffee_label;
			point = new Point(504, 96);
			p1CoffeeLabel.Location = point;
			this.p1_coffee_label.Name = "p1_coffee_label";
			Label p1CoffeeLabel1 = this.p1_coffee_label;
			size = new Size(36, 32);
			p1CoffeeLabel1.Size = size;
			this.p1_coffee_label.TabIndex = 33;
			this.p1_coffee_label.Text = "99";
			this.p1_coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_tobacco_label.BackColor=Color.Goldenrod;
			this.p1_tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p1TobaccoLabel = this.p1_tobacco_label;
			point = new Point(448, 96);
			p1TobaccoLabel.Location = point;
			this.p1_tobacco_label.Name = "p1_tobacco_label";
			Label p1TobaccoLabel1 = this.p1_tobacco_label;
			size = new Size(36, 32);
			p1TobaccoLabel1.Size = size;
			this.p1_tobacco_label.TabIndex = 32;
			this.p1_tobacco_label.Text = "99";
			this.p1_tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_corn_label.BackColor = Color.Yellow;
			this.p1_corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p1CornLabel = this.p1_corn_label;
			point = new Point(392, 96);
			p1CornLabel.Location = point;
			this.p1_corn_label.Name = "p1_corn_label";
			Label p1CornLabel1 = this.p1_corn_label;
			size = new Size(36, 32);
			p1CornLabel1.Size = size;
			this.p1_corn_label.TabIndex = 31;
			this.p1_corn_label.Text = "99";
			this.p1_corn_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_sugar_label.BackColor = Color.White;
			this.p1_sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p1SugarLabel = this.p1_sugar_label;
			point = new Point(336, 96);
			p1SugarLabel.Location = point;
			this.p1_sugar_label.Name = "p1_sugar_label";
			Label p1SugarLabel1 = this.p1_sugar_label;
			size = new Size(36, 32);
			p1SugarLabel1.Size = size;
			this.p1_sugar_label.TabIndex = 30;
			this.p1_sugar_label.Text = "99";
			this.p1_sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_indigo_label.BackColor = Color.Blue;
			this.p1_indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p1_indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p1IndigoLabel = this.p1_indigo_label;
			point = new Point(280, 96);
			p1IndigoLabel.Location = point;
			this.p1_indigo_label.Name = "p1_indigo_label";
			Label p1IndigoLabel1 = this.p1_indigo_label;
			size = new Size(36, 32);
			p1IndigoLabel1.Size = size;
			this.p1_indigo_label.TabIndex = 29;
			this.p1_indigo_label.Text = "99";
			this.p1_indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_coffee_label.BackColor = Color.SaddleBrown;
			this.p2_coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p2_coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p2CoffeeLabel = this.p2_coffee_label;
			point = new Point(504, 136);
			p2CoffeeLabel.Location = point;
			this.p2_coffee_label.Name = "p2_coffee_label";
			Label p2CoffeeLabel1 = this.p2_coffee_label;
			size = new Size(36, 32);
			p2CoffeeLabel1.Size = size;
			this.p2_coffee_label.TabIndex = 38;
			this.p2_coffee_label.Text = "99";
			this.p2_coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_tobacco_label.BackColor=Color.Goldenrod;
			this.p2_tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p2TobaccoLabel = this.p2_tobacco_label;
			point = new Point(448, 136);
			p2TobaccoLabel.Location = point;
			this.p2_tobacco_label.Name = "p2_tobacco_label";
			Label p2TobaccoLabel1 = this.p2_tobacco_label;
			size = new Size(36, 32);
			p2TobaccoLabel1.Size = size;
			this.p2_tobacco_label.TabIndex = 37;
			this.p2_tobacco_label.Text = "99";
			this.p2_tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_corn_label.BackColor = Color.Yellow;
			this.p2_corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p2CornLabel = this.p2_corn_label;
			point = new Point(392, 136);
			p2CornLabel.Location = point;
			this.p2_corn_label.Name = "p2_corn_label";
			Label p2CornLabel1 = this.p2_corn_label;
			size = new Size(36, 32);
			p2CornLabel1.Size = size;
			this.p2_corn_label.TabIndex = 36;
			this.p2_corn_label.Text = "99";
			this.p2_corn_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_sugar_label.BackColor = Color.White;
			this.p2_sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p2SugarLabel = this.p2_sugar_label;
			point = new Point(336, 136);
			p2SugarLabel.Location = point;
			this.p2_sugar_label.Name = "p2_sugar_label";
			Label p2SugarLabel1 = this.p2_sugar_label;
			size = new Size(36, 32);
			p2SugarLabel1.Size = size;
			this.p2_sugar_label.TabIndex = 35;
			this.p2_sugar_label.Text = "99";
			this.p2_sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_indigo_label.BackColor = Color.Blue;
			this.p2_indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p2_indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p2IndigoLabel = this.p2_indigo_label;
			point = new Point(280, 136);
			p2IndigoLabel.Location = point;
			this.p2_indigo_label.Name = "p2_indigo_label";
			Label p2IndigoLabel1 = this.p2_indigo_label;
			size = new Size(36, 32);
			p2IndigoLabel1.Size = size;
			this.p2_indigo_label.TabIndex = 34;
			this.p2_indigo_label.Text = "99";
			this.p2_indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_coffee_label.BackColor = Color.SaddleBrown;
			this.p3_coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p3_coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p3CoffeeLabel = this.p3_coffee_label;
			point = new Point(504, 176);
			p3CoffeeLabel.Location = point;
			this.p3_coffee_label.Name = "p3_coffee_label";
			Label p3CoffeeLabel1 = this.p3_coffee_label;
			size = new Size(36, 32);
			p3CoffeeLabel1.Size = size;
			this.p3_coffee_label.TabIndex = 43;
			this.p3_coffee_label.Text = "99";
			this.p3_coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_tobacco_label.BackColor=Color.Goldenrod;
			this.p3_tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p3TobaccoLabel = this.p3_tobacco_label;
			point = new Point(448, 176);
			p3TobaccoLabel.Location = point;
			this.p3_tobacco_label.Name = "p3_tobacco_label";
			Label p3TobaccoLabel1 = this.p3_tobacco_label;
			size = new Size(36, 32);
			p3TobaccoLabel1.Size = size;
			this.p3_tobacco_label.TabIndex = 42;
			this.p3_tobacco_label.Text = "99";
			this.p3_tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_corn_label.BackColor = Color.Yellow;
			this.p3_corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p3CornLabel = this.p3_corn_label;
			point = new Point(392, 176);
			p3CornLabel.Location = point;
			this.p3_corn_label.Name = "p3_corn_label";
			Label p3CornLabel1 = this.p3_corn_label;
			size = new Size(36, 32);
			p3CornLabel1.Size = size;
			this.p3_corn_label.TabIndex = 41;
			this.p3_corn_label.Text = "99";
			this.p3_corn_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_sugar_label.BackColor = Color.White;
			this.p3_sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p3SugarLabel = this.p3_sugar_label;
			point = new Point(336, 176);
			p3SugarLabel.Location = point;
			this.p3_sugar_label.Name = "p3_sugar_label";
			Label p3SugarLabel1 = this.p3_sugar_label;
			size = new Size(36, 32);
			p3SugarLabel1.Size = size;
			this.p3_sugar_label.TabIndex = 40;
			this.p3_sugar_label.Text = "99";
			this.p3_sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_indigo_label.BackColor = Color.Blue;
			this.p3_indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p3_indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p3IndigoLabel = this.p3_indigo_label;
			point = new Point(280, 176);
			p3IndigoLabel.Location = point;
			this.p3_indigo_label.Name = "p3_indigo_label";
			Label p3IndigoLabel1 = this.p3_indigo_label;
			size = new Size(36, 32);
			p3IndigoLabel1.Size = size;
			this.p3_indigo_label.TabIndex = 39;
			this.p3_indigo_label.Text = "99";
			this.p3_indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p5_coffee_label.BackColor = Color.SaddleBrown;
			this.p5_coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p5_coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p5CoffeeLabel = this.p5_coffee_label;
			point = new Point(504, 256);
			p5CoffeeLabel.Location = point;
			this.p5_coffee_label.Name = "p5_coffee_label";
			Label p5CoffeeLabel1 = this.p5_coffee_label;
			size = new Size(36, 32);
			p5CoffeeLabel1.Size = size;
			this.p5_coffee_label.TabIndex = 53;
			this.p5_coffee_label.Text = "99";
			this.p5_coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p5_tobacco_label.BackColor=Color.Goldenrod;
			this.p5_tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p5TobaccoLabel = this.p5_tobacco_label;
			point = new Point(448, 256);
			p5TobaccoLabel.Location = point;
			this.p5_tobacco_label.Name = "p5_tobacco_label";
			Label p5TobaccoLabel1 = this.p5_tobacco_label;
			size = new Size(36, 32);
			p5TobaccoLabel1.Size = size;
			this.p5_tobacco_label.TabIndex = 52;
			this.p5_tobacco_label.Text = "99";
			this.p5_tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p5_corn_label.BackColor = Color.Yellow;
			this.p5_corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p5CornLabel = this.p5_corn_label;
			point = new Point(392, 256);
			p5CornLabel.Location = point;
			this.p5_corn_label.Name = "p5_corn_label";
			Label p5CornLabel1 = this.p5_corn_label;
			size = new Size(36, 32);
			p5CornLabel1.Size = size;
			this.p5_corn_label.TabIndex = 51;
			this.p5_corn_label.Text = "99";
			this.p5_corn_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p5_sugar_label.BackColor = Color.White;
			this.p5_sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p5SugarLabel = this.p5_sugar_label;
			point = new Point(336, 256);
			p5SugarLabel.Location = point;
			this.p5_sugar_label.Name = "p5_sugar_label";
			Label p5SugarLabel1 = this.p5_sugar_label;
			size = new Size(36, 32);
			p5SugarLabel1.Size = size;
			this.p5_sugar_label.TabIndex = 50;
			this.p5_sugar_label.Text = "99";
			this.p5_sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p5_indigo_label.BackColor = Color.Blue;
			this.p5_indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p5_indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p5IndigoLabel = this.p5_indigo_label;
			point = new Point(280, 256);
			p5IndigoLabel.Location = point;
			this.p5_indigo_label.Name = "p5_indigo_label";
			Label p5IndigoLabel1 = this.p5_indigo_label;
			size = new Size(36, 32);
			p5IndigoLabel1.Size = size;
			this.p5_indigo_label.TabIndex = 49;
			this.p5_indigo_label.Text = "99";
			this.p5_indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_coffee_label.BackColor = Color.SaddleBrown;
			this.p4_coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p4_coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p4CoffeeLabel = this.p4_coffee_label;
			point = new Point(504, 216);
			p4CoffeeLabel.Location = point;
			this.p4_coffee_label.Name = "p4_coffee_label";
			Label p4CoffeeLabel1 = this.p4_coffee_label;
			size = new Size(36, 32);
			p4CoffeeLabel1.Size = size;
			this.p4_coffee_label.TabIndex = 48;
			this.p4_coffee_label.Text = "99";
			this.p4_coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_tobacco_label.BackColor=Color.Goldenrod;
			this.p4_tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p4TobaccoLabel = this.p4_tobacco_label;
			point = new Point(448, 216);
			p4TobaccoLabel.Location = point;
			this.p4_tobacco_label.Name = "p4_tobacco_label";
			Label p4TobaccoLabel1 = this.p4_tobacco_label;
			size = new Size(36, 32);
			p4TobaccoLabel1.Size = size;
			this.p4_tobacco_label.TabIndex = 47;
			this.p4_tobacco_label.Text = "99";
			this.p4_tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_corn_label.BackColor = Color.Yellow;
			this.p4_corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p4CornLabel = this.p4_corn_label;
			point = new Point(392, 216);
			p4CornLabel.Location = point;
			this.p4_corn_label.Name = "p4_corn_label";
			Label p4CornLabel1 = this.p4_corn_label;
			size = new Size(36, 32);
			p4CornLabel1.Size = size;
			this.p4_corn_label.TabIndex = 46;
			this.p4_corn_label.Text = "99";
			this.p4_corn_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_sugar_label.BackColor = Color.White;
			this.p4_sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p4SugarLabel = this.p4_sugar_label;
			point = new Point(336, 216);
			p4SugarLabel.Location = point;
			this.p4_sugar_label.Name = "p4_sugar_label";
			Label p4SugarLabel1 = this.p4_sugar_label;
			size = new Size(36, 32);
			p4SugarLabel1.Size = size;
			this.p4_sugar_label.TabIndex = 45;
			this.p4_sugar_label.Text = "99";
			this.p4_sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_indigo_label.BackColor = Color.Blue;
			this.p4_indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p4_indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p4IndigoLabel = this.p4_indigo_label;
			point = new Point(280, 216);
			p4IndigoLabel.Location = point;
			this.p4_indigo_label.Name = "p4_indigo_label";
			Label p4IndigoLabel1 = this.p4_indigo_label;
			size = new Size(36, 32);
			p4IndigoLabel1.Size = size;
			this.p4_indigo_label.TabIndex = 44;
			this.p4_indigo_label.Text = "99";
			this.p4_indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			this.Label1.BorderStyle = BorderStyle.Fixed3D;
			this.Label1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = this.Label1;
			point = new Point(144, 32);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label11 = this.Label1;
			size = new Size(296, 32);
			label11.Size = size;
			this.Label1.TabIndex = 54;
			this.Label1.Text = "Goods Produced this Turn";
			this.Label1.TextAlign = ContentAlignment.MiddleCenter;
			Button button1 = this.Button1;
			point = new Point(256, 304);
			button1.Location = point;
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 55;
			this.Button1.Text = "OK";
			PictureBox pictureBox1 = this.PictureBox1;
			point = new Point(24, 216);
			pictureBox1.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = this.PictureBox1;
			size = new Size(528, 32);
			pictureBox.Size = size;
			this.PictureBox1.TabIndex = 56;
			this.PictureBox1.TabStop = false;
			PictureBox pictureBox2 = this.PictureBox2;
			point = new Point(24, 256);
			pictureBox2.Location = point;
			this.PictureBox2.Name = "PictureBox2";
			PictureBox pictureBox21 = this.PictureBox2;
			size = new Size(528, 32);
			pictureBox21.Size = size;
			this.PictureBox2.TabIndex = 57;
			this.PictureBox2.TabStop = false;
			size = new Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new Size(576, 338);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.PictureBox2);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.p5_coffee_label);
			this.Controls.Add(this.p5_tobacco_label);
			this.Controls.Add(this.p5_corn_label);
			this.Controls.Add(this.p5_sugar_label);
			this.Controls.Add(this.p5_indigo_label);
			this.Controls.Add(this.p4_coffee_label);
			this.Controls.Add(this.p4_tobacco_label);
			this.Controls.Add(this.p4_corn_label);
			this.Controls.Add(this.p4_sugar_label);
			this.Controls.Add(this.p4_indigo_label);
			this.Controls.Add(this.p3_coffee_label);
			this.Controls.Add(this.p3_tobacco_label);
			this.Controls.Add(this.p3_corn_label);
			this.Controls.Add(this.p3_sugar_label);
			this.Controls.Add(this.p3_indigo_label);
			this.Controls.Add(this.p2_coffee_label);
			this.Controls.Add(this.p2_tobacco_label);
			this.Controls.Add(this.p2_corn_label);
			this.Controls.Add(this.p2_sugar_label);
			this.Controls.Add(this.p2_indigo_label);
			this.Controls.Add(this.p1_coffee_label);
			this.Controls.Add(this.p1_tobacco_label);
			this.Controls.Add(this.p1_corn_label);
			this.Controls.Add(this.p1_sugar_label);
			this.Controls.Add(this.p1_indigo_label);
			this.Controls.Add(this.p1_craftsman_label);
			this.Controls.Add(this.p2_craftsman_label);
			this.Controls.Add(this.p3_craftsman_label);
			this.Controls.Add(this.p4_craftsman_label);
			this.Controls.Add(this.p5_craftsman_label);
			this.Controls.Add(this.p5_name_label);
			this.Controls.Add(this.p4_name_label);
			this.Controls.Add(this.p3_name_label);
			this.Controls.Add(this.p2_name_label);
			this.Controls.Add(this.p1_name_label);
			size = new Size(584, 376);
			this.MaximumSize = size;
			size = new Size(584, 376);
			this.MinimumSize = size;
			this.Name = "Craftsman1";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Craftsman Phase - Goods Production";
			this.ResumeLayout(false);
		}
	}
}
