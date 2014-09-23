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
				return _Button1;
			}
			set
			{
				if (_Button1 != null)
				{
					Craftsman1 craftsman1 = this;
					_Button1.Click -=new EventHandler(craftsman1.Button1_Click);
				}
				_Button1 = value;
				if (_Button1 != null)
				{
					Craftsman1 craftsman11 = this;
					_Button1.Click +=new EventHandler(craftsman11.Button1_Click);
				}
			}
		}

		internal virtual Label Label1
		{
			get
			{
				return _Label1;
			}
			set
			{
				_Label1 = value;
			}
		}

		internal virtual Label p1_coffee_label
		{
			get
			{
				return _p1_coffee_label;
			}
			set
			{
				_p1_coffee_label = value;
			}
		}

		internal virtual Label p1_corn_label
		{
			get
			{
				return _p1_corn_label;
			}
			set
			{
				_p1_corn_label = value;
			}
		}

		internal virtual Label p1_craftsman_label
		{
			get
			{
				return _p1_craftsman_label;
			}
			set
			{
				_p1_craftsman_label = value;
			}
		}

		internal virtual Label p1_indigo_label
		{
			get
			{
				return _p1_indigo_label;
			}
			set
			{
				_p1_indigo_label = value;
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

		internal virtual Label p1_sugar_label
		{
			get
			{
				return _p1_sugar_label;
			}
			set
			{
				_p1_sugar_label = value;
			}
		}

		internal virtual Label p1_tobacco_label
		{
			get
			{
				return _p1_tobacco_label;
			}
			set
			{
				_p1_tobacco_label = value;
			}
		}

		internal virtual Label p2_coffee_label
		{
			get
			{
				return _p2_coffee_label;
			}
			set
			{
				_p2_coffee_label = value;
			}
		}

		internal virtual Label p2_corn_label
		{
			get
			{
				return _p2_corn_label;
			}
			set
			{
				_p2_corn_label = value;
			}
		}

		internal virtual Label p2_craftsman_label
		{
			get
			{
				return _p2_craftsman_label;
			}
			set
			{
				_p2_craftsman_label = value;
			}
		}

		internal virtual Label p2_indigo_label
		{
			get
			{
				return _p2_indigo_label;
			}
			set
			{
				_p2_indigo_label = value;
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

		internal virtual Label p2_sugar_label
		{
			get
			{
				return _p2_sugar_label;
			}
			set
			{
				_p2_sugar_label = value;
			}
		}

		internal virtual Label p2_tobacco_label
		{
			get
			{
				return _p2_tobacco_label;
			}
			set
			{
				_p2_tobacco_label = value;
			}
		}

		internal virtual Label p3_coffee_label
		{
			get
			{
				return _p3_coffee_label;
			}
			set
			{
				_p3_coffee_label = value;
			}
		}

		internal virtual Label p3_corn_label
		{
			get
			{
				return _p3_corn_label;
			}
			set
			{
				_p3_corn_label = value;
			}
		}

		internal virtual Label p3_craftsman_label
		{
			get
			{
				return _p3_craftsman_label;
			}
			set
			{
				_p3_craftsman_label = value;
			}
		}

		internal virtual Label p3_indigo_label
		{
			get
			{
				return _p3_indigo_label;
			}
			set
			{
				_p3_indigo_label = value;
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

		internal virtual Label p3_sugar_label
		{
			get
			{
				return _p3_sugar_label;
			}
			set
			{
				_p3_sugar_label = value;
			}
		}

		internal virtual Label p3_tobacco_label
		{
			get
			{
				return _p3_tobacco_label;
			}
			set
			{
				_p3_tobacco_label = value;
			}
		}

		internal virtual Label p4_coffee_label
		{
			get
			{
				return _p4_coffee_label;
			}
			set
			{
				_p4_coffee_label = value;
			}
		}

		internal virtual Label p4_corn_label
		{
			get
			{
				return _p4_corn_label;
			}
			set
			{
				_p4_corn_label = value;
			}
		}

		internal virtual Label p4_craftsman_label
		{
			get
			{
				return _p4_craftsman_label;
			}
			set
			{
				_p4_craftsman_label = value;
			}
		}

		internal virtual Label p4_indigo_label
		{
			get
			{
				return _p4_indigo_label;
			}
			set
			{
				_p4_indigo_label = value;
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

		internal virtual Label p4_sugar_label
		{
			get
			{
				return _p4_sugar_label;
			}
			set
			{
				_p4_sugar_label = value;
			}
		}

		internal virtual Label p4_tobacco_label
		{
			get
			{
				return _p4_tobacco_label;
			}
			set
			{
				_p4_tobacco_label = value;
			}
		}

		internal virtual Label p5_coffee_label
		{
			get
			{
				return _p5_coffee_label;
			}
			set
			{
				_p5_coffee_label = value;
			}
		}

		internal virtual Label p5_corn_label
		{
			get
			{
				return _p5_corn_label;
			}
			set
			{
				_p5_corn_label = value;
			}
		}

		internal virtual Label p5_craftsman_label
		{
			get
			{
				return _p5_craftsman_label;
			}
			set
			{
				_p5_craftsman_label = value;
			}
		}

		internal virtual Label p5_indigo_label
		{
			get
			{
				return _p5_indigo_label;
			}
			set
			{
				_p5_indigo_label = value;
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

		internal virtual Label p5_sugar_label
		{
			get
			{
				return _p5_sugar_label;
			}
			set
			{
				_p5_sugar_label = value;
			}
		}

		internal virtual Label p5_tobacco_label
		{
			get
			{
				return _p5_tobacco_label;
			}
			set
			{
				_p5_tobacco_label = value;
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

		internal virtual PictureBox PictureBox2
		{
			get
			{
				return _PictureBox2;
			}
			set
			{
				_PictureBox2 = value;
			}
		}

		public Craftsman1()
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
			p5_name_label = new Label();
			p4_name_label = new Label();
			p3_name_label = new Label();
			p2_name_label = new Label();
			p1_name_label = new Label();
			p1_craftsman_label = new Label();
			p2_craftsman_label = new Label();
			p3_craftsman_label = new Label();
			p4_craftsman_label = new Label();
			p5_craftsman_label = new Label();
			p1_coffee_label = new Label();
			p1_tobacco_label = new Label();
			p1_corn_label = new Label();
			p1_sugar_label = new Label();
			p1_indigo_label = new Label();
			p2_coffee_label = new Label();
			p2_tobacco_label = new Label();
			p2_corn_label = new Label();
			p2_sugar_label = new Label();
			p2_indigo_label = new Label();
			p3_coffee_label = new Label();
			p3_tobacco_label = new Label();
			p3_corn_label = new Label();
			p3_sugar_label = new Label();
			p3_indigo_label = new Label();
			p5_coffee_label = new Label();
			p5_tobacco_label = new Label();
			p5_corn_label = new Label();
			p5_sugar_label = new Label();
			p5_indigo_label = new Label();
			p4_coffee_label = new Label();
			p4_tobacco_label = new Label();
			p4_corn_label = new Label();
			p4_sugar_label = new Label();
			p4_indigo_label = new Label();
			Label1 = new Label();
			Button1 = new Button();
			PictureBox1 = new PictureBox();
			PictureBox2 = new PictureBox();
			SuspendLayout();
			p5_name_label.BorderStyle = BorderStyle.Fixed3D;
			p5_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p5NameLabel = p5_name_label;
			Point point = new Point(136, 256);
			p5NameLabel.Location = point;
			p5_name_label.Name = "p5_name_label";
			Label label = p5_name_label;
			Size size = new Size(120, 32);
			label.Size = size;
			p5_name_label.TabIndex = 13;
			p5_name_label.Text = "Player5";
			p5_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_name_label.BorderStyle = BorderStyle.Fixed3D;
			p4_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p4NameLabel = p4_name_label;
			point = new Point(136, 216);
			p4NameLabel.Location = point;
			p4_name_label.Name = "p4_name_label";
			Label p4NameLabel1 = p4_name_label;
			size = new Size(120, 32);
			p4NameLabel1.Size = size;
			p4_name_label.TabIndex = 12;
			p4_name_label.Text = "Player4";
			p4_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_name_label.BorderStyle = BorderStyle.Fixed3D;
			p3_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p3NameLabel = p3_name_label;
			point = new Point(136, 176);
			p3NameLabel.Location = point;
			p3_name_label.Name = "p3_name_label";
			Label p3NameLabel1 = p3_name_label;
			size = new Size(120, 32);
			p3NameLabel1.Size = size;
			p3_name_label.TabIndex = 11;
			p3_name_label.Text = "Player3";
			p3_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_name_label.BorderStyle = BorderStyle.Fixed3D;
			p2_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p2NameLabel = p2_name_label;
			point = new Point(136, 136);
			p2NameLabel.Location = point;
			p2_name_label.Name = "p2_name_label";
			Label p2NameLabel1 = p2_name_label;
			size = new Size(120, 32);
			p2NameLabel1.Size = size;
			p2_name_label.TabIndex = 10;
			p2_name_label.Text = "Player2";
			p2_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p1_name_label.BorderStyle = BorderStyle.Fixed3D;
			p1_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p1NameLabel = p1_name_label;
			point = new Point(136, 96);
			p1NameLabel.Location = point;
			p1_name_label.Name = "p1_name_label";
			Label p1NameLabel1 = p1_name_label;
			size = new Size(120, 32);
			p1NameLabel1.Size = size;
			p1_name_label.TabIndex=9;
			p1_name_label.Text = "Player1";
			p1_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p1_craftsman_label.BorderStyle = BorderStyle.Fixed3D;
			p1_craftsman_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p1CraftsmanLabel = p1_craftsman_label;
			point = new Point(32, 96);
			p1CraftsmanLabel.Location = point;
			p1_craftsman_label.Name = "p1_craftsman_label";
			Label p1CraftsmanLabel1 = p1_craftsman_label;
			size = new Size(88, 32);
			p1CraftsmanLabel1.Size = size;
			p1_craftsman_label.TabIndex = 19;
			p1_craftsman_label.Text = "Craftsman";
			p1_craftsman_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_craftsman_label.BorderStyle = BorderStyle.Fixed3D;
			p2_craftsman_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p2CraftsmanLabel = p2_craftsman_label;
			point = new Point(32, 136);
			p2CraftsmanLabel.Location = point;
			p2_craftsman_label.Name = "p2_craftsman_label";
			Label p2CraftsmanLabel1 = p2_craftsman_label;
			size = new Size(88, 32);
			p2CraftsmanLabel1.Size = size;
			p2_craftsman_label.TabIndex = 18;
			p2_craftsman_label.Text = "Craftsman";
			p2_craftsman_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_craftsman_label.BorderStyle = BorderStyle.Fixed3D;
			p3_craftsman_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p3CraftsmanLabel = p3_craftsman_label;
			point = new Point(32, 176);
			p3CraftsmanLabel.Location = point;
			p3_craftsman_label.Name = "p3_craftsman_label";
			Label p3CraftsmanLabel1 = p3_craftsman_label;
			size = new Size(88, 32);
			p3CraftsmanLabel1.Size = size;
			p3_craftsman_label.TabIndex = 17;
			p3_craftsman_label.Text = "Craftsman";
			p3_craftsman_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_craftsman_label.BorderStyle = BorderStyle.Fixed3D;
			p4_craftsman_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p4CraftsmanLabel = p4_craftsman_label;
			point = new Point(32, 216);
			p4CraftsmanLabel.Location = point;
			p4_craftsman_label.Name = "p4_craftsman_label";
			Label p4CraftsmanLabel1 = p4_craftsman_label;
			size = new Size(88, 32);
			p4CraftsmanLabel1.Size = size;
			p4_craftsman_label.TabIndex = 16;
			p4_craftsman_label.Text = "Craftsman";
			p4_craftsman_label.TextAlign = ContentAlignment.MiddleCenter;
			p5_craftsman_label.BorderStyle = BorderStyle.Fixed3D;
			p5_craftsman_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p5CraftsmanLabel = p5_craftsman_label;
			point = new Point(32, 256);
			p5CraftsmanLabel.Location = point;
			p5_craftsman_label.Name = "p5_craftsman_label";
			Label p5CraftsmanLabel1 = p5_craftsman_label;
			size = new Size(88, 32);
			p5CraftsmanLabel1.Size = size;
			p5_craftsman_label.TabIndex = 15;
			p5_craftsman_label.Text = "Craftsman";
			p5_craftsman_label.TextAlign = ContentAlignment.MiddleCenter;
			p1_coffee_label.BackColor = Color.SaddleBrown;
			p1_coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			p1_coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p1CoffeeLabel = p1_coffee_label;
			point = new Point(504, 96);
			p1CoffeeLabel.Location = point;
			p1_coffee_label.Name = "p1_coffee_label";
			Label p1CoffeeLabel1 = p1_coffee_label;
			size = new Size(36, 32);
			p1CoffeeLabel1.Size = size;
			p1_coffee_label.TabIndex = 33;
			p1_coffee_label.Text = "99";
			p1_coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			p1_tobacco_label.BackColor=Color.Goldenrod;
			p1_tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p1TobaccoLabel = p1_tobacco_label;
			point = new Point(448, 96);
			p1TobaccoLabel.Location = point;
			p1_tobacco_label.Name = "p1_tobacco_label";
			Label p1TobaccoLabel1 = p1_tobacco_label;
			size = new Size(36, 32);
			p1TobaccoLabel1.Size = size;
			p1_tobacco_label.TabIndex = 32;
			p1_tobacco_label.Text = "99";
			p1_tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			p1_corn_label.BackColor = Color.Yellow;
			p1_corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p1CornLabel = p1_corn_label;
			point = new Point(392, 96);
			p1CornLabel.Location = point;
			p1_corn_label.Name = "p1_corn_label";
			Label p1CornLabel1 = p1_corn_label;
			size = new Size(36, 32);
			p1CornLabel1.Size = size;
			p1_corn_label.TabIndex = 31;
			p1_corn_label.Text = "99";
			p1_corn_label.TextAlign = ContentAlignment.MiddleCenter;
			p1_sugar_label.BackColor = Color.White;
			p1_sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p1SugarLabel = p1_sugar_label;
			point = new Point(336, 96);
			p1SugarLabel.Location = point;
			p1_sugar_label.Name = "p1_sugar_label";
			Label p1SugarLabel1 = p1_sugar_label;
			size = new Size(36, 32);
			p1SugarLabel1.Size = size;
			p1_sugar_label.TabIndex = 30;
			p1_sugar_label.Text = "99";
			p1_sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			p1_indigo_label.BackColor = Color.Blue;
			p1_indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			p1_indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p1IndigoLabel = p1_indigo_label;
			point = new Point(280, 96);
			p1IndigoLabel.Location = point;
			p1_indigo_label.Name = "p1_indigo_label";
			Label p1IndigoLabel1 = p1_indigo_label;
			size = new Size(36, 32);
			p1IndigoLabel1.Size = size;
			p1_indigo_label.TabIndex = 29;
			p1_indigo_label.Text = "99";
			p1_indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_coffee_label.BackColor = Color.SaddleBrown;
			p2_coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			p2_coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p2CoffeeLabel = p2_coffee_label;
			point = new Point(504, 136);
			p2CoffeeLabel.Location = point;
			p2_coffee_label.Name = "p2_coffee_label";
			Label p2CoffeeLabel1 = p2_coffee_label;
			size = new Size(36, 32);
			p2CoffeeLabel1.Size = size;
			p2_coffee_label.TabIndex = 38;
			p2_coffee_label.Text = "99";
			p2_coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_tobacco_label.BackColor=Color.Goldenrod;
			p2_tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p2TobaccoLabel = p2_tobacco_label;
			point = new Point(448, 136);
			p2TobaccoLabel.Location = point;
			p2_tobacco_label.Name = "p2_tobacco_label";
			Label p2TobaccoLabel1 = p2_tobacco_label;
			size = new Size(36, 32);
			p2TobaccoLabel1.Size = size;
			p2_tobacco_label.TabIndex = 37;
			p2_tobacco_label.Text = "99";
			p2_tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_corn_label.BackColor = Color.Yellow;
			p2_corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p2CornLabel = p2_corn_label;
			point = new Point(392, 136);
			p2CornLabel.Location = point;
			p2_corn_label.Name = "p2_corn_label";
			Label p2CornLabel1 = p2_corn_label;
			size = new Size(36, 32);
			p2CornLabel1.Size = size;
			p2_corn_label.TabIndex = 36;
			p2_corn_label.Text = "99";
			p2_corn_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_sugar_label.BackColor = Color.White;
			p2_sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p2SugarLabel = p2_sugar_label;
			point = new Point(336, 136);
			p2SugarLabel.Location = point;
			p2_sugar_label.Name = "p2_sugar_label";
			Label p2SugarLabel1 = p2_sugar_label;
			size = new Size(36, 32);
			p2SugarLabel1.Size = size;
			p2_sugar_label.TabIndex = 35;
			p2_sugar_label.Text = "99";
			p2_sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_indigo_label.BackColor = Color.Blue;
			p2_indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			p2_indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p2IndigoLabel = p2_indigo_label;
			point = new Point(280, 136);
			p2IndigoLabel.Location = point;
			p2_indigo_label.Name = "p2_indigo_label";
			Label p2IndigoLabel1 = p2_indigo_label;
			size = new Size(36, 32);
			p2IndigoLabel1.Size = size;
			p2_indigo_label.TabIndex = 34;
			p2_indigo_label.Text = "99";
			p2_indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_coffee_label.BackColor = Color.SaddleBrown;
			p3_coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			p3_coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p3CoffeeLabel = p3_coffee_label;
			point = new Point(504, 176);
			p3CoffeeLabel.Location = point;
			p3_coffee_label.Name = "p3_coffee_label";
			Label p3CoffeeLabel1 = p3_coffee_label;
			size = new Size(36, 32);
			p3CoffeeLabel1.Size = size;
			p3_coffee_label.TabIndex = 43;
			p3_coffee_label.Text = "99";
			p3_coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_tobacco_label.BackColor=Color.Goldenrod;
			p3_tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p3TobaccoLabel = p3_tobacco_label;
			point = new Point(448, 176);
			p3TobaccoLabel.Location = point;
			p3_tobacco_label.Name = "p3_tobacco_label";
			Label p3TobaccoLabel1 = p3_tobacco_label;
			size = new Size(36, 32);
			p3TobaccoLabel1.Size = size;
			p3_tobacco_label.TabIndex = 42;
			p3_tobacco_label.Text = "99";
			p3_tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_corn_label.BackColor = Color.Yellow;
			p3_corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p3CornLabel = p3_corn_label;
			point = new Point(392, 176);
			p3CornLabel.Location = point;
			p3_corn_label.Name = "p3_corn_label";
			Label p3CornLabel1 = p3_corn_label;
			size = new Size(36, 32);
			p3CornLabel1.Size = size;
			p3_corn_label.TabIndex = 41;
			p3_corn_label.Text = "99";
			p3_corn_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_sugar_label.BackColor = Color.White;
			p3_sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p3SugarLabel = p3_sugar_label;
			point = new Point(336, 176);
			p3SugarLabel.Location = point;
			p3_sugar_label.Name = "p3_sugar_label";
			Label p3SugarLabel1 = p3_sugar_label;
			size = new Size(36, 32);
			p3SugarLabel1.Size = size;
			p3_sugar_label.TabIndex = 40;
			p3_sugar_label.Text = "99";
			p3_sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_indigo_label.BackColor = Color.Blue;
			p3_indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			p3_indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p3IndigoLabel = p3_indigo_label;
			point = new Point(280, 176);
			p3IndigoLabel.Location = point;
			p3_indigo_label.Name = "p3_indigo_label";
			Label p3IndigoLabel1 = p3_indigo_label;
			size = new Size(36, 32);
			p3IndigoLabel1.Size = size;
			p3_indigo_label.TabIndex = 39;
			p3_indigo_label.Text = "99";
			p3_indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			p5_coffee_label.BackColor = Color.SaddleBrown;
			p5_coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			p5_coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p5CoffeeLabel = p5_coffee_label;
			point = new Point(504, 256);
			p5CoffeeLabel.Location = point;
			p5_coffee_label.Name = "p5_coffee_label";
			Label p5CoffeeLabel1 = p5_coffee_label;
			size = new Size(36, 32);
			p5CoffeeLabel1.Size = size;
			p5_coffee_label.TabIndex = 53;
			p5_coffee_label.Text = "99";
			p5_coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			p5_tobacco_label.BackColor=Color.Goldenrod;
			p5_tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p5TobaccoLabel = p5_tobacco_label;
			point = new Point(448, 256);
			p5TobaccoLabel.Location = point;
			p5_tobacco_label.Name = "p5_tobacco_label";
			Label p5TobaccoLabel1 = p5_tobacco_label;
			size = new Size(36, 32);
			p5TobaccoLabel1.Size = size;
			p5_tobacco_label.TabIndex = 52;
			p5_tobacco_label.Text = "99";
			p5_tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			p5_corn_label.BackColor = Color.Yellow;
			p5_corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p5CornLabel = p5_corn_label;
			point = new Point(392, 256);
			p5CornLabel.Location = point;
			p5_corn_label.Name = "p5_corn_label";
			Label p5CornLabel1 = p5_corn_label;
			size = new Size(36, 32);
			p5CornLabel1.Size = size;
			p5_corn_label.TabIndex = 51;
			p5_corn_label.Text = "99";
			p5_corn_label.TextAlign = ContentAlignment.MiddleCenter;
			p5_sugar_label.BackColor = Color.White;
			p5_sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p5SugarLabel = p5_sugar_label;
			point = new Point(336, 256);
			p5SugarLabel.Location = point;
			p5_sugar_label.Name = "p5_sugar_label";
			Label p5SugarLabel1 = p5_sugar_label;
			size = new Size(36, 32);
			p5SugarLabel1.Size = size;
			p5_sugar_label.TabIndex = 50;
			p5_sugar_label.Text = "99";
			p5_sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			p5_indigo_label.BackColor = Color.Blue;
			p5_indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			p5_indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p5IndigoLabel = p5_indigo_label;
			point = new Point(280, 256);
			p5IndigoLabel.Location = point;
			p5_indigo_label.Name = "p5_indigo_label";
			Label p5IndigoLabel1 = p5_indigo_label;
			size = new Size(36, 32);
			p5IndigoLabel1.Size = size;
			p5_indigo_label.TabIndex = 49;
			p5_indigo_label.Text = "99";
			p5_indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_coffee_label.BackColor = Color.SaddleBrown;
			p4_coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			p4_coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p4CoffeeLabel = p4_coffee_label;
			point = new Point(504, 216);
			p4CoffeeLabel.Location = point;
			p4_coffee_label.Name = "p4_coffee_label";
			Label p4CoffeeLabel1 = p4_coffee_label;
			size = new Size(36, 32);
			p4CoffeeLabel1.Size = size;
			p4_coffee_label.TabIndex = 48;
			p4_coffee_label.Text = "99";
			p4_coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_tobacco_label.BackColor=Color.Goldenrod;
			p4_tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p4TobaccoLabel = p4_tobacco_label;
			point = new Point(448, 216);
			p4TobaccoLabel.Location = point;
			p4_tobacco_label.Name = "p4_tobacco_label";
			Label p4TobaccoLabel1 = p4_tobacco_label;
			size = new Size(36, 32);
			p4TobaccoLabel1.Size = size;
			p4_tobacco_label.TabIndex = 47;
			p4_tobacco_label.Text = "99";
			p4_tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_corn_label.BackColor = Color.Yellow;
			p4_corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p4CornLabel = p4_corn_label;
			point = new Point(392, 216);
			p4CornLabel.Location = point;
			p4_corn_label.Name = "p4_corn_label";
			Label p4CornLabel1 = p4_corn_label;
			size = new Size(36, 32);
			p4CornLabel1.Size = size;
			p4_corn_label.TabIndex = 46;
			p4_corn_label.Text = "99";
			p4_corn_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_sugar_label.BackColor = Color.White;
			p4_sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p4SugarLabel = p4_sugar_label;
			point = new Point(336, 216);
			p4SugarLabel.Location = point;
			p4_sugar_label.Name = "p4_sugar_label";
			Label p4SugarLabel1 = p4_sugar_label;
			size = new Size(36, 32);
			p4SugarLabel1.Size = size;
			p4_sugar_label.TabIndex = 45;
			p4_sugar_label.Text = "99";
			p4_sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_indigo_label.BackColor = Color.Blue;
			p4_indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			p4_indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label p4IndigoLabel = p4_indigo_label;
			point = new Point(280, 216);
			p4IndigoLabel.Location = point;
			p4_indigo_label.Name = "p4_indigo_label";
			Label p4IndigoLabel1 = p4_indigo_label;
			size = new Size(36, 32);
			p4IndigoLabel1.Size = size;
			p4_indigo_label.TabIndex = 44;
			p4_indigo_label.Text = "99";
			p4_indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			Label1.BorderStyle = BorderStyle.Fixed3D;
			Label1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = Label1;
			point = new Point(144, 32);
			label1.Location = point;
			Label1.Name = "Label1";
			Label label11 = Label1;
			size = new Size(296, 32);
			label11.Size = size;
			Label1.TabIndex = 54;
			Label1.Text = "Goods Produced this Turn";
			Label1.TextAlign = ContentAlignment.MiddleCenter;
			Button button1 = Button1;
			point = new Point(256, 304);
			button1.Location = point;
			Button1.Name = "Button1";
			Button1.TabIndex = 55;
			Button1.Text = "OK";
			PictureBox pictureBox1 = PictureBox1;
			point = new Point(24, 216);
			pictureBox1.Location = point;
			PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = PictureBox1;
			size = new Size(528, 32);
			pictureBox.Size = size;
			PictureBox1.TabIndex = 56;
			PictureBox1.TabStop = false;
			PictureBox pictureBox2 = PictureBox2;
			point = new Point(24, 256);
			pictureBox2.Location = point;
			PictureBox2.Name = "PictureBox2";
			PictureBox pictureBox21 = PictureBox2;
			size = new Size(528, 32);
			pictureBox21.Size = size;
			PictureBox2.TabIndex = 57;
			PictureBox2.TabStop = false;
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(576, 338);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(PictureBox2);
			Controls.Add(PictureBox1);
			Controls.Add(Button1);
			Controls.Add(Label1);
			Controls.Add(p5_coffee_label);
			Controls.Add(p5_tobacco_label);
			Controls.Add(p5_corn_label);
			Controls.Add(p5_sugar_label);
			Controls.Add(p5_indigo_label);
			Controls.Add(p4_coffee_label);
			Controls.Add(p4_tobacco_label);
			Controls.Add(p4_corn_label);
			Controls.Add(p4_sugar_label);
			Controls.Add(p4_indigo_label);
			Controls.Add(p3_coffee_label);
			Controls.Add(p3_tobacco_label);
			Controls.Add(p3_corn_label);
			Controls.Add(p3_sugar_label);
			Controls.Add(p3_indigo_label);
			Controls.Add(p2_coffee_label);
			Controls.Add(p2_tobacco_label);
			Controls.Add(p2_corn_label);
			Controls.Add(p2_sugar_label);
			Controls.Add(p2_indigo_label);
			Controls.Add(p1_coffee_label);
			Controls.Add(p1_tobacco_label);
			Controls.Add(p1_corn_label);
			Controls.Add(p1_sugar_label);
			Controls.Add(p1_indigo_label);
			Controls.Add(p1_craftsman_label);
			Controls.Add(p2_craftsman_label);
			Controls.Add(p3_craftsman_label);
			Controls.Add(p4_craftsman_label);
			Controls.Add(p5_craftsman_label);
			Controls.Add(p5_name_label);
			Controls.Add(p4_name_label);
			Controls.Add(p3_name_label);
			Controls.Add(p2_name_label);
			Controls.Add(p1_name_label);
			size = new Size(584, 376);
			MaximumSize = size;
			size = new Size(584, 376);
			MinimumSize = size;
			Name = "Craftsman1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Craftsman Phase - Goods Production";
			ResumeLayout(false);
		}
	}
}
