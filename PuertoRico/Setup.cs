using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Setup : Form
	{
		[AccessedThroughProperty("name_ai4_setup_label")]
		private Label _name_ai4_setup_label;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("PictureBox3")]
		private PictureBox _PictureBox3;

		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		[AccessedThroughProperty("setup_confirm_button")]
		private Button _setup_confirm_button;

		[AccessedThroughProperty("players3_radio")]
		private RadioButton _players3_radio;

		[AccessedThroughProperty("players4_Radio")]
		private RadioButton _players4_Radio;

		[AccessedThroughProperty("players5_radio")]
		private RadioButton _players5_radio;

		[AccessedThroughProperty("name_human")]
		private TextBox _name_human;

		[AccessedThroughProperty("seat1_radio")]
		private RadioButton _seat1_radio;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("seat2_radio")]
		private RadioButton _seat2_radio;

		[AccessedThroughProperty("seat3_radio")]
		private RadioButton _seat3_radio;

		[AccessedThroughProperty("seat4_radio")]
		private RadioButton _seat4_radio;

		[AccessedThroughProperty("seat5_radio")]
		private RadioButton _seat5_radio;

		[AccessedThroughProperty("seatx_radio")]
		private RadioButton _seatx_radio;

		[AccessedThroughProperty("playersx_radio")]
		private RadioButton _playersx_radio;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("PictureBox4")]
		private PictureBox _PictureBox4;

		[AccessedThroughProperty("setup_role2_pic")]
		private PictureBox _setup_role2_pic;

		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[AccessedThroughProperty("name_ai1")]
		private TextBox _name_ai1;

		[AccessedThroughProperty("name_ai2")]
		private TextBox _name_ai2;

		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		[AccessedThroughProperty("name_ai3")]
		private TextBox _name_ai3;

		[AccessedThroughProperty("name_ai4")]
		private TextBox _name_ai4;

		[AccessedThroughProperty("PictureBox8")]
		private PictureBox _PictureBox8;

		[AccessedThroughProperty("PictureBox7")]
		private PictureBox _PictureBox7;

		[AccessedThroughProperty("setup_role1_pic")]
		private PictureBox _setup_role1_pic;

		[AccessedThroughProperty("name_ai3_setup_label")]
		private Label _name_ai3_setup_label;

		private IContainer components;

		public int setup_random1;

		public bool setup_rand_finished;

		public int setup_low_rand;

		public int setup_high_rand;

		public int setup_num_players;

		public int setup_seat;

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

		internal virtual GroupBox GroupBox2
		{
			get
			{
				return this._GroupBox2;
			}
			set
			{
				this._GroupBox2 = null;
				this._GroupBox2 = value;
				this._GroupBox2 = null;
			}
		}

		internal virtual GroupBox GroupBox3
		{
			get
			{
				return this._GroupBox3;
			}
			set
			{
				this._GroupBox3 = null;
				this._GroupBox3 = value;
				this._GroupBox3 = null;
			}
		}

		internal virtual GroupBox GroupBox4
		{
			get
			{
				return this._GroupBox4;
			}
			set
			{
				this._GroupBox4 = null;
				this._GroupBox4 = value;
				this._GroupBox4 = null;
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

		internal virtual TextBox name_ai1
		{
			get
			{
				return this._name_ai1;
			}
			set
			{
				this._name_ai1 = null;
				this._name_ai1 = value;
				this._name_ai1 = null;
			}
		}

		internal virtual TextBox name_ai2
		{
			get
			{
				return this._name_ai2;
			}
			set
			{
				this._name_ai2 = null;
				this._name_ai2 = value;
				this._name_ai2 = null;
			}
		}

		internal virtual TextBox name_ai3
		{
			get
			{
				return this._name_ai3;
			}
			set
			{
				this._name_ai3 = null;
				this._name_ai3 = value;
				this._name_ai3 = null;
			}
		}

		internal virtual Label name_ai3_setup_label
		{
			get
			{
				return this._name_ai3_setup_label;
			}
			set
			{
				this._name_ai3_setup_label = null;
				this._name_ai3_setup_label = value;
				this._name_ai3_setup_label = null;
			}
		}

		internal virtual TextBox name_ai4
		{
			get
			{
				return this._name_ai4;
			}
			set
			{
				this._name_ai4 = null;
				this._name_ai4 = value;
				this._name_ai4 = null;
			}
		}

		internal virtual Label name_ai4_setup_label
		{
			get
			{
				return this._name_ai4_setup_label;
			}
			set
			{
				this._name_ai4_setup_label = null;
				this._name_ai4_setup_label = value;
				this._name_ai4_setup_label = null;
			}
		}

		internal virtual TextBox name_human
		{
			get
			{
				return this._name_human;
			}
			set
			{
				this._name_human = null;
				this._name_human = value;
				this._name_human = null;
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

		internal virtual PictureBox PictureBox3
		{
			get
			{
				return this._PictureBox3;
			}
			set
			{
				this._PictureBox3 = null;
				this._PictureBox3 = value;
				this._PictureBox3 = null;
			}
		}

		internal virtual PictureBox PictureBox4
		{
			get
			{
				return this._PictureBox4;
			}
			set
			{
				this._PictureBox4 = null;
				this._PictureBox4 = value;
				this._PictureBox4 = null;
			}
		}

		internal virtual PictureBox PictureBox7
		{
			get
			{
				return this._PictureBox7;
			}
			set
			{
				this._PictureBox7 = null;
				this._PictureBox7 = value;
				this._PictureBox7 = null;
			}
		}

		internal virtual PictureBox PictureBox8
		{
			get
			{
				return this._PictureBox8;
			}
			set
			{
				this._PictureBox8 = null;
				this._PictureBox8 = value;
				this._PictureBox8 = null;
			}
		}

		internal virtual RadioButton players3_radio
		{
			get
			{
				return this._players3_radio;
			}
			set
			{
				if (this._players3_radio != null)
				{
					Setup setup = this;
					this._players3_radio.CheckedChanged -= new EventHandler(setup.players3_radio_CheckedChanged);
				}
				this._players3_radio = value;
				if (this._players3_radio != null)
				{
					Setup setup1 = this;
					this._players3_radio.CheckedChanged += new EventHandler(setup1.players3_radio_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton players4_Radio
		{
			get
			{
				return this._players4_Radio;
			}
			set
			{
				if (this._players4_Radio != null)
				{
					Setup setup = this;
					this._players4_Radio.CheckedChanged -= new EventHandler(setup.players4_Radio_CheckedChanged);
				}
				this._players4_Radio = value;
				if (this._players4_Radio != null)
				{
					Setup setup1 = this;
					this._players4_Radio.CheckedChanged += new EventHandler(setup1.players4_Radio_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton players5_radio
		{
			get
			{
				return this._players5_radio;
			}
			set
			{
				if (this._players5_radio != null)
				{
					Setup setup = this;
					this._players5_radio.CheckedChanged -= new EventHandler(setup.players5_radio_CheckedChanged);
				}
				this._players5_radio = value;
				if (this._players5_radio != null)
				{
					Setup setup1 = this;
					this._players5_radio.CheckedChanged += new EventHandler(setup1.players5_radio_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton playersx_radio
		{
			get
			{
				return this._playersx_radio;
			}
			set
			{
				if (this._playersx_radio != null)
				{
					Setup setup = this;
					this._playersx_radio.CheckedChanged -= new EventHandler(setup.playersx_radio_CheckedChanged);
				}
				this._playersx_radio = value;
				if (this._playersx_radio != null)
				{
					Setup setup1 = this;
					this._playersx_radio.CheckedChanged += new EventHandler(setup1.playersx_radio_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton seat1_radio
		{
			get
			{
				return this._seat1_radio;
			}
			set
			{
				this._seat1_radio = null;
				this._seat1_radio = value;
				this._seat1_radio = null;
			}
		}

		internal virtual RadioButton seat2_radio
		{
			get
			{
				return this._seat2_radio;
			}
			set
			{
				this._seat2_radio = null;
				this._seat2_radio = value;
				this._seat2_radio = null;
			}
		}

		internal virtual RadioButton seat3_radio
		{
			get
			{
				return this._seat3_radio;
			}
			set
			{
				this._seat3_radio = null;
				this._seat3_radio = value;
				this._seat3_radio = null;
			}
		}

		internal virtual RadioButton seat4_radio
		{
			get
			{
				return this._seat4_radio;
			}
			set
			{
				this._seat4_radio = null;
				this._seat4_radio = value;
				this._seat4_radio = null;
			}
		}

		internal virtual RadioButton seat5_radio
		{
			get
			{
				return this._seat5_radio;
			}
			set
			{
				this._seat5_radio = null;
				this._seat5_radio = value;
				this._seat5_radio = null;
			}
		}

		internal virtual RadioButton seatx_radio
		{
			get
			{
				return this._seatx_radio;
			}
			set
			{
				this._seatx_radio = null;
				this._seatx_radio = value;
				this._seatx_radio = null;
			}
		}

		internal virtual Button setup_confirm_button
		{
			get
			{
				return this._setup_confirm_button;
			}
			set
			{
				if (this._setup_confirm_button != null)
				{
					Setup setup = this;
					this._setup_confirm_button.Click -=new EventHandler(setup.setup_confirm_button_Click);
				}
				this._setup_confirm_button = value;
				if (this._setup_confirm_button != null)
				{
					Setup setup1 = this;
					this._setup_confirm_button.Click +=new EventHandler(setup1.setup_confirm_button_Click);
				}
			}
		}

		internal virtual PictureBox setup_role1_pic
		{
			get
			{
				return this._setup_role1_pic;
			}
			set
			{
				this._setup_role1_pic = null;
				this._setup_role1_pic = value;
				this._setup_role1_pic = null;
			}
		}

		internal virtual PictureBox setup_role2_pic
		{
			get
			{
				return this._setup_role2_pic;
			}
			set
			{
				this._setup_role2_pic = null;
				this._setup_role2_pic = value;
				this._setup_role2_pic = null;
			}
		}

		public Setup()
		{
			this.setup_random1 = 0;
			this.setup_rand_finished = true;
			this.setup_low_rand = 0;
			this.setup_high_rand = 0;
			this.setup_num_players = 3;
			this.setup_seat = 1;
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
			ResourceManager resourceManager = new ResourceManager(typeof(Setup));
			this.players3_radio = new RadioButton();
			this.players4_Radio = new RadioButton();
			this.players5_radio = new RadioButton();
			this.setup_confirm_button = new Button();
			this.GroupBox1 = new GroupBox();
			this.playersx_radio = new RadioButton();
			this.GroupBox2 = new GroupBox();
			this.seatx_radio = new RadioButton();
			this.seat5_radio = new RadioButton();
			this.seat4_radio = new RadioButton();
			this.seat3_radio = new RadioButton();
			this.seat2_radio = new RadioButton();
			this.seat1_radio = new RadioButton();
			this.PictureBox1 = new PictureBox();
			this.PictureBox2 = new PictureBox();
			this.PictureBox3 = new PictureBox();
			this.PictureBox4 = new PictureBox();
			this.setup_role2_pic = new PictureBox();
			this.setup_role1_pic = new PictureBox();
			this.PictureBox7 = new PictureBox();
			this.PictureBox8 = new PictureBox();
			this.GroupBox3 = new GroupBox();
			this.GroupBox4 = new GroupBox();
			this.name_ai4 = new TextBox();
			this.name_ai3 = new TextBox();
			this.name_ai2 = new TextBox();
			this.name_ai1 = new TextBox();
			this.name_ai4_setup_label = new Label();
			this.name_ai3_setup_label = new Label();
			this.Label3 = new Label();
			this.Label2 = new Label();
			this.Label1 = new Label();
			this.name_human = new TextBox();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.SuspendLayout();
			this.players3_radio.Checked = true;
			RadioButton players3Radio = this.players3_radio;
			Point point = new Point(24, 40);
			players3Radio.Location = point;
			this.players3_radio.Name = "players3_radio";
			this.players3_radio.TabIndex=0;
			this.players3_radio.TabStop = true;
			this.players3_radio.Text = "3 Players";
			RadioButton players4Radio = this.players4_Radio;
			point = new Point(24, 72);
			players4Radio.Location = point;
			this.players4_Radio.Name = "players4_Radio";
			this.players4_Radio.TabIndex=1;
			this.players4_Radio.Text = "4 Players";
			RadioButton players5Radio = this.players5_radio;
			point = new Point(24, 104);
			players5Radio.Location = point;
			this.players5_radio.Name = "players5_radio";
			this.players5_radio.TabIndex=2;
			this.players5_radio.Text = "5 Players";
			Button setupConfirmButton = this.setup_confirm_button;
			point = new Point(24, 496);
			setupConfirmButton.Location = point;
			this.setup_confirm_button.Name = "setup_confirm_button";
			this.setup_confirm_button.TabIndex=3;
			this.setup_confirm_button.Text = "OK";
			this.GroupBox1.Controls.Add(this.players4_Radio);
			this.GroupBox1.Controls.Add(this.players5_radio);
			this.GroupBox1.Controls.Add(this.players3_radio);
			this.GroupBox1.Controls.Add(this.playersx_radio);
			GroupBox groupBox1 = this.GroupBox1;
			point = new Point(24, 40);
			groupBox1.Location = point;
			this.GroupBox1.Name = "GroupBox1";
			GroupBox groupBox = this.GroupBox1;
			Size size = new Size(144, 184);
			groupBox.Size = size;
			this.GroupBox1.TabIndex=4;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Number of Players";
			RadioButton playersxRadio = this.playersx_radio;
			point = new Point(24, 136);
			playersxRadio.Location = point;
			this.playersx_radio.Name = "playersx_radio";
			this.playersx_radio.TabIndex=6;
			this.playersx_radio.Text = "Random";
			this.GroupBox2.Controls.Add(this.seatx_radio);
			this.GroupBox2.Controls.Add(this.seat5_radio);
			this.GroupBox2.Controls.Add(this.seat4_radio);
			this.GroupBox2.Controls.Add(this.seat3_radio);
			this.GroupBox2.Controls.Add(this.seat2_radio);
			this.GroupBox2.Controls.Add(this.seat1_radio);
			GroupBox groupBox2 = this.GroupBox2;
			point = new Point(192, 40);
			groupBox2.Location = point;
			this.GroupBox2.Name = "GroupBox2";
			GroupBox groupBox21 = this.GroupBox2;
			size = new Size(144, 232);
			groupBox21.Size = size;
			this.GroupBox2.TabIndex=5;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Choice of Seat";
			RadioButton seatxRadio = this.seatx_radio;
			point = new Point(32, 192);
			seatxRadio.Location = point;
			this.seatx_radio.Name = "seatx_radio";
			this.seatx_radio.TabIndex=5;
			this.seatx_radio.Text = "Random";
			RadioButton seat5Radio = this.seat5_radio;
			point = new Point(32, 160);
			seat5Radio.Location = point;
			this.seat5_radio.Name = "seat5_radio";
			this.seat5_radio.TabIndex=4;
			this.seat5_radio.Text = "5th";
			this.seat5_radio.Visible = false;
			RadioButton seat4Radio = this.seat4_radio;
			point = new Point(32, 128);
			seat4Radio.Location = point;
			this.seat4_radio.Name = "seat4_radio";
			this.seat4_radio.TabIndex=3;
			this.seat4_radio.Text = "4th";
			this.seat4_radio.Visible = false;
			RadioButton seat3Radio = this.seat3_radio;
			point = new Point(32, 96);
			seat3Radio.Location = point;
			this.seat3_radio.Name = "seat3_radio";
			this.seat3_radio.TabIndex=2;
			this.seat3_radio.Text = "3rd";
			RadioButton seat2Radio = this.seat2_radio;
			point = new Point(32, 64);
			seat2Radio.Location = point;
			this.seat2_radio.Name = "seat2_radio";
			this.seat2_radio.TabIndex=1;
			this.seat2_radio.Text = "2nd";
			this.seat1_radio.Checked = true;
			RadioButton seat1Radio = this.seat1_radio;
			point = new Point(32, 32);
			seat1Radio.Location = point;
			this.seat1_radio.Name = "seat1_radio";
			this.seat1_radio.TabIndex=0;
			this.seat1_radio.TabStop = true;
			this.seat1_radio.Text = "1st";
			this.PictureBox1.Image = (Image)resourceManager.GetObject("PictureBox1.Image");
			PictureBox pictureBox1 = this.PictureBox1;
			point = new Point(48, 24);
			pictureBox1.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = this.PictureBox1;
			size = new Size(72, 104);
			pictureBox.Size = size;
			this.PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex=6;
			this.PictureBox1.TabStop = false;
			this.PictureBox2.Image = (Image)resourceManager.GetObject("PictureBox2.Image");
			PictureBox pictureBox2 = this.PictureBox2;
			point = new Point(136, 24);
			pictureBox2.Location = point;
			this.PictureBox2.Name = "PictureBox2";
			PictureBox pictureBox21 = this.PictureBox2;
			size = new Size(72, 104);
			pictureBox21.Size = size;
			this.PictureBox2.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox2.TabIndex=7;
			this.PictureBox2.TabStop = false;
			this.PictureBox3.Image = (Image)resourceManager.GetObject("PictureBox3.Image");
			PictureBox pictureBox3 = this.PictureBox3;
			point = new Point(136, 144);
			pictureBox3.Location = point;
			this.PictureBox3.Name = "PictureBox3";
			PictureBox pictureBox31 = this.PictureBox3;
			size = new Size(72, 104);
			pictureBox31.Size = size;
			this.PictureBox3.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox3.TabIndex=9;
			this.PictureBox3.TabStop = false;
			this.PictureBox4.Image = (Image)resourceManager.GetObject("PictureBox4.Image");
			PictureBox pictureBox4 = this.PictureBox4;
			point = new Point(48, 144);
			pictureBox4.Location = point;
			this.PictureBox4.Name = "PictureBox4";
			PictureBox pictureBox41 = this.PictureBox4;
			size = new Size(72, 104);
			pictureBox41.Size = size;
			this.PictureBox4.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox4.TabIndex=8;
			this.PictureBox4.TabStop = false;
			this.setup_role2_pic.Image = (Image)resourceManager.GetObject("setup_role2_pic.Image");
			PictureBox setupRole2Pic = this.setup_role2_pic;
			point = new Point(136, 384);
			setupRole2Pic.Location = point;
			this.setup_role2_pic.Name = "setup_role2_pic";
			PictureBox setupRole2Pic1 = this.setup_role2_pic;
			size = new Size(72, 104);
			setupRole2Pic1.Size = size;
			this.setup_role2_pic.SizeMode=PictureBoxSizeMode.AutoSize;
			this.setup_role2_pic.TabIndex = 13;
			this.setup_role2_pic.TabStop = false;
			this.setup_role2_pic.Visible = false;
			this.setup_role1_pic.Image = (Image)resourceManager.GetObject("setup_role1_pic.Image");
			PictureBox setupRole1Pic = this.setup_role1_pic;
			point = new Point(48, 384);
			setupRole1Pic.Location = point;
			this.setup_role1_pic.Name = "setup_role1_pic";
			PictureBox setupRole1Pic1 = this.setup_role1_pic;
			size = new Size(72, 104);
			setupRole1Pic1.Size = size;
			this.setup_role1_pic.SizeMode=PictureBoxSizeMode.AutoSize;
			this.setup_role1_pic.TabIndex = 12;
			this.setup_role1_pic.TabStop = false;
			this.setup_role1_pic.Visible = false;
			this.PictureBox7.Image = (Image)resourceManager.GetObject("PictureBox7.Image");
			PictureBox pictureBox7 = this.PictureBox7;
			point = new Point(136, 264);
			pictureBox7.Location = point;
			this.PictureBox7.Name = "PictureBox7";
			PictureBox pictureBox71 = this.PictureBox7;
			size = new Size(72, 104);
			pictureBox71.Size = size;
			this.PictureBox7.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox7.TabIndex = 11;
			this.PictureBox7.TabStop = false;
			this.PictureBox8.Image = (Image)resourceManager.GetObject("PictureBox8.Image");
			PictureBox pictureBox8 = this.PictureBox8;
			point = new Point(48, 264);
			pictureBox8.Location = point;
			this.PictureBox8.Name = "PictureBox8";
			PictureBox pictureBox81 = this.PictureBox8;
			size = new Size(72, 104);
			pictureBox81.Size = size;
			this.PictureBox8.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox8.TabIndex = 10;
			this.PictureBox8.TabStop = false;
			this.GroupBox3.Controls.Add(this.PictureBox7);
			this.GroupBox3.Controls.Add(this.PictureBox8);
			this.GroupBox3.Controls.Add(this.PictureBox3);
			this.GroupBox3.Controls.Add(this.PictureBox4);
			this.GroupBox3.Controls.Add(this.PictureBox2);
			this.GroupBox3.Controls.Add(this.PictureBox1);
			this.GroupBox3.Controls.Add(this.setup_role2_pic);
			this.GroupBox3.Controls.Add(this.setup_role1_pic);
			GroupBox groupBox3 = this.GroupBox3;
			point = new Point(360, 16);
			groupBox3.Location = point;
			this.GroupBox3.Name = "GroupBox3";
			GroupBox groupBox31 = this.GroupBox3;
			size = new Size(256, 504);
			groupBox31.Size = size;
			this.GroupBox3.TabIndex = 14;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Available Roles";
			this.GroupBox4.Controls.Add(this.name_ai4);
			this.GroupBox4.Controls.Add(this.name_ai3);
			this.GroupBox4.Controls.Add(this.name_ai2);
			this.GroupBox4.Controls.Add(this.name_ai1);
			this.GroupBox4.Controls.Add(this.name_ai4_setup_label);
			this.GroupBox4.Controls.Add(this.name_ai3_setup_label);
			this.GroupBox4.Controls.Add(this.Label3);
			this.GroupBox4.Controls.Add(this.Label2);
			this.GroupBox4.Controls.Add(this.Label1);
			this.GroupBox4.Controls.Add(this.name_human);
			GroupBox groupBox4 = this.GroupBox4;
			point = new Point(104, 296);
			groupBox4.Location = point;
			this.GroupBox4.Name = "GroupBox4";
			GroupBox groupBox41 = this.GroupBox4;
			size = new Size(240, 224);
			groupBox41.Size = size;
			this.GroupBox4.TabIndex = 15;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Player Names";
			TextBox nameAi4 = this.name_ai4;
			point = new Point(136, 176);
			nameAi4.Location = point;
			this.name_ai4.Name = "name_ai4";
			TextBox textBox = this.name_ai4;
			size = new Size(88, 20);
			textBox.Size = size;
			this.name_ai4.TabIndex=9;
			this.name_ai4.Text = "Player5";
			TextBox nameAi3 = this.name_ai3;
			point = new Point(136, 144);
			nameAi3.Location = point;
			this.name_ai3.Name = "name_ai3";
			TextBox nameAi31 = this.name_ai3;
			size = new Size(88, 20);
			nameAi31.Size = size;
			this.name_ai3.TabIndex=8;
			this.name_ai3.Text = "Player4";
			TextBox nameAi2 = this.name_ai2;
			point = new Point(136, 112);
			nameAi2.Location = point;
			this.name_ai2.Name = "name_ai2";
			TextBox nameAi21 = this.name_ai2;
			size = new Size(88, 20);
			nameAi21.Size = size;
			this.name_ai2.TabIndex=7;
			this.name_ai2.Text = "Player3";
			TextBox nameAi1 = this.name_ai1;
			point = new Point(136, 80);
			nameAi1.Location = point;
			this.name_ai1.Name = "name_ai1";
			TextBox nameAi11 = this.name_ai1;
			size = new Size(88, 20);
			nameAi11.Size = size;
			this.name_ai1.TabIndex=6;
			this.name_ai1.Text = "Player2";
			Label nameAi4SetupLabel = this.name_ai4_setup_label;
			point = new Point(16, 176);
			nameAi4SetupLabel.Location = point;
			this.name_ai4_setup_label.Name = "name_ai4_setup_label";
			Label label = this.name_ai4_setup_label;
			size = new Size(100, 16);
			label.Size = size;
			this.name_ai4_setup_label.TabIndex=5;
			this.name_ai4_setup_label.Text = "AI PLayer";
			Label nameAi3SetupLabel = this.name_ai3_setup_label;
			point = new Point(16, 144);
			nameAi3SetupLabel.Location = point;
			this.name_ai3_setup_label.Name = "name_ai3_setup_label";
			Label nameAi3SetupLabel1 = this.name_ai3_setup_label;
			size = new Size(100, 16);
			nameAi3SetupLabel1.Size = size;
			this.name_ai3_setup_label.TabIndex=4;
			this.name_ai3_setup_label.Text = "AI Player";
			Label label3 = this.Label3;
			point = new Point(16, 112);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new Size(100, 16);
			label31.Size = size;
			this.Label3.TabIndex=3;
			this.Label3.Text = "AI Player";
			Label label2 = this.Label2;
			point = new Point(16, 80);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new Size(100, 16);
			label21.Size = size;
			this.Label2.TabIndex=2;
			this.Label2.Text = "AI Player";
			Label label1 = this.Label1;
			point = new Point(16, 48);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label11 = this.Label1;
			size = new Size(100, 16);
			label11.Size = size;
			this.Label1.TabIndex=1;
			this.Label1.Text = "Human Player";
			TextBox nameHuman = this.name_human;
			point = new Point(136, 48);
			nameHuman.Location = point;
			this.name_human.Name = "name_human";
			TextBox nameHuman1 = this.name_human;
			size = new Size(88, 20);
			nameHuman1.Size = size;
			this.name_human.TabIndex=0;
			this.name_human.Text = "Player1";
			size = new Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new Size(640, 546);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.setup_confirm_button);
			this.MaximizeBox = false;
			size = new Size(648, 584);
			this.MaximumSize = size;
			this.MinimizeBox = false;
			size = new Size(648, 584);
			this.MinimumSize = size;
			this.Name = "Setup";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Setup";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox4.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void players3_radio_CheckedChanged(object sender, EventArgs e)
		{
			this.GroupBox2.Visible = true;
			if (!(this.seat4_radio.Checked | this.seat5_radio.Checked))
			{
				this.seat4_radio.Visible = false;
				this.seat5_radio.Visible = false;
			}
			else
			{
				this.seat4_radio.Checked = false;
				this.seat4_radio.Visible = false;
				this.seat5_radio.Checked = false;
				this.seat5_radio.Visible = false;
				this.seat1_radio.Checked = true;
			}
			this.setup_role1_pic.Visible = false;
			this.setup_role2_pic.Visible = false;
			this.name_ai3_setup_label.Visible = false;
			this.name_ai4_setup_label.Visible = false;
			this.name_ai3.Visible = false;
			this.name_ai4.Visible = false;
		}

		private void players4_Radio_CheckedChanged(object sender, EventArgs e)
		{
			this.GroupBox2.Visible = true;
			if (!this.seat5_radio.Checked)
			{
				this.seat4_radio.Visible = true;
				this.seat5_radio.Visible = false;
			}
			else
			{
				this.seat4_radio.Checked = false;
				this.seat4_radio.Visible = true;
				this.seat5_radio.Checked = false;
				this.seat5_radio.Visible = false;
				this.seat1_radio.Checked = true;
			}
			this.setup_role1_pic.Visible = true;
			this.setup_role2_pic.Visible = false;
			this.name_ai3_setup_label.Visible = true;
			this.name_ai4_setup_label.Visible = false;
			this.name_ai3.Visible = true;
			this.name_ai4.Visible = false;
		}

		private void players5_radio_CheckedChanged(object sender, EventArgs e)
		{
			this.GroupBox2.Visible = true;
			this.seat4_radio.Visible = true;
			this.seat5_radio.Visible = true;
			this.setup_role1_pic.Visible = true;
			this.setup_role2_pic.Visible = true;
			this.name_ai3_setup_label.Visible = true;
			this.name_ai4_setup_label.Visible = true;
			this.name_ai3.Visible = true;
			this.name_ai4.Visible = true;
		}

		private void playersx_radio_CheckedChanged(object sender, EventArgs e)
		{
			this.GroupBox2.Visible = false;
		}

		private void setup_confirm_button_Click(object sender, EventArgs e)
		{
			bool flag = true;
			if (flag == this.players3_radio.Checked)
			{
				this.setup_num_players = 3;
			}
			else if (flag == this.players4_Radio.Checked)
			{
				this.setup_num_players = 4;
			}
			else if (flag == this.players5_radio.Checked)
			{
				this.setup_num_players = 5;
			}
			else if (flag == this.playersx_radio.Checked)
			{
				this.setup_generate_random1(3, 5);
				this.setup_num_players = this.setup_random1;
				this.setup_generate_random1(1, this.setup_num_players);
				this.setup_seat = this.setup_random1;
			}
			if (!this.playersx_radio.Checked)
			{
				bool flag1 = true;
				if (flag1 == this.seat1_radio.Checked)
				{
					this.setup_seat = 1;
				}
				else if (flag1 == this.seat2_radio.Checked)
				{
					this.setup_seat = 2;
				}
				else if (flag1 == this.seat3_radio.Checked)
				{
					this.setup_seat = 3;
				}
				else if (flag1 == this.seat4_radio.Checked)
				{
					this.setup_seat = 4;
				}
				else if (flag1 == this.seat5_radio.Checked)
				{
					this.setup_seat = 5;
				}
				else if (flag1 == this.seatx_radio.Checked)
				{
					this.setup_generate_random1(1, this.setup_num_players);
					this.setup_seat = this.setup_random1;
				}
			}
			this.Close();
		}

		public void setup_generate_random1(object setup_low_rand, object setup_high_rand)
		{
			this.setup_rand_finished = false;
			while (!this.setup_rand_finished)
			{
				VBMath.Randomize();
				this.setup_random1 = IntegerType.FromObject(Conversion.Int(ObjectType.AddObj(ObjectType.MulObj(ObjectType.AddObj(setup_high_rand, 1), VBMath.Rnd()), 0)));
				if (!BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(this.setup_random1, setup_low_rand, false) >= 0, ObjectType.ObjTst(this.setup_random1, setup_high_rand, false) <= 0)))
				{
					continue;
				}
				this.setup_rand_finished = true;
			}
		}
	}
}
