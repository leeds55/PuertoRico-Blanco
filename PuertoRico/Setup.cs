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
				return _GroupBox1;
			}
			set
			{
				_GroupBox1 = value;
			}
		}

		internal virtual GroupBox GroupBox2
		{
			get
			{
				return _GroupBox2;
			}
			set
			{
				_GroupBox2 = value;
			}
		}

		internal virtual GroupBox GroupBox3
		{
			get
			{
				return _GroupBox3;
			}
			set
			{
				_GroupBox3 = value;
			}
		}

		internal virtual GroupBox GroupBox4
		{
			get
			{
				return _GroupBox4;
			}
			set
			{
				_GroupBox4 = value;
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

		internal virtual Label Label2
		{
			get
			{
				return _Label2;
			}
			set
			{
				_Label2 = value;
			}
		}

		internal virtual Label Label3
		{
			get
			{
				return _Label3;
			}
			set
			{
				_Label3 = value;
			}
		}

		internal virtual TextBox name_ai1
		{
			get
			{
				return _name_ai1;
			}
			set
			{
				_name_ai1 = value;
			}
		}

		internal virtual TextBox name_ai2
		{
			get
			{
				return _name_ai2;
			}
			set
			{
				_name_ai2 = value;
			}
		}

		internal virtual TextBox name_ai3
		{
			get
			{
				return _name_ai3;
			}
			set
			{
				_name_ai3 = value;
			}
		}

		internal virtual Label name_ai3_setup_label
		{
			get
			{
				return _name_ai3_setup_label;
			}
			set
			{
				_name_ai3_setup_label = value;
			}
		}

		internal virtual TextBox name_ai4
		{
			get
			{
				return _name_ai4;
			}
			set
			{
				_name_ai4 = value;
			}
		}

		internal virtual Label name_ai4_setup_label
		{
			get
			{
				return _name_ai4_setup_label;
			}
			set
			{
				_name_ai4_setup_label = value;
			}
		}

		internal virtual TextBox name_human
		{
			get
			{
				return _name_human;
			}
			set
			{
				_name_human = value;
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

		internal virtual PictureBox PictureBox3
		{
			get
			{
				return _PictureBox3;
			}
			set
			{
				_PictureBox3 = value;
			}
		}

		internal virtual PictureBox PictureBox4
		{
			get
			{
				return _PictureBox4;
			}
			set
			{
				_PictureBox4 = value;
			}
		}

		internal virtual PictureBox PictureBox7
		{
			get
			{
				return _PictureBox7;
			}
			set
			{
				_PictureBox7 = value;
			}
		}

		internal virtual PictureBox PictureBox8
		{
			get
			{
				return _PictureBox8;
			}
			set
			{
				_PictureBox8 = value;
			}
		}

		internal virtual RadioButton players3_radio
		{
			get
			{
				return _players3_radio;
			}
			set
			{
				if (_players3_radio != null)
				{
					Setup setup = this;
					_players3_radio.CheckedChanged -= new EventHandler(setup.players3_radio_CheckedChanged);
				}
				_players3_radio = value;
				if (_players3_radio != null)
				{
					Setup setup1 = this;
					_players3_radio.CheckedChanged += new EventHandler(setup1.players3_radio_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton players4_Radio
		{
			get
			{
				return _players4_Radio;
			}
			set
			{
				if (_players4_Radio != null)
				{
					Setup setup = this;
					_players4_Radio.CheckedChanged -= new EventHandler(setup.players4_Radio_CheckedChanged);
				}
				_players4_Radio = value;
				if (_players4_Radio != null)
				{
					Setup setup1 = this;
					_players4_Radio.CheckedChanged += new EventHandler(setup1.players4_Radio_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton players5_radio
		{
			get
			{
				return _players5_radio;
			}
			set
			{
				if (_players5_radio != null)
				{
					Setup setup = this;
					_players5_radio.CheckedChanged -= new EventHandler(setup.players5_radio_CheckedChanged);
				}
				_players5_radio = value;
				if (_players5_radio != null)
				{
					Setup setup1 = this;
					_players5_radio.CheckedChanged += new EventHandler(setup1.players5_radio_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton playersx_radio
		{
			get
			{
				return _playersx_radio;
			}
			set
			{
				if (_playersx_radio != null)
				{
					Setup setup = this;
					_playersx_radio.CheckedChanged -= new EventHandler(setup.playersx_radio_CheckedChanged);
				}
				_playersx_radio = value;
				if (_playersx_radio != null)
				{
					Setup setup1 = this;
					_playersx_radio.CheckedChanged += new EventHandler(setup1.playersx_radio_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton seat1_radio
		{
			get
			{
				return _seat1_radio;
			}
			set
			{
				_seat1_radio = value;
			}
		}

		internal virtual RadioButton seat2_radio
		{
			get
			{
				return _seat2_radio;
			}
			set
			{
				_seat2_radio = value;
			}
		}

		internal virtual RadioButton seat3_radio
		{
			get
			{
				return _seat3_radio;
			}
			set
			{
				_seat3_radio = value;
			}
		}

		internal virtual RadioButton seat4_radio
		{
			get
			{
				return _seat4_radio;
			}
			set
			{
				_seat4_radio = value;
			}
		}

		internal virtual RadioButton seat5_radio
		{
			get
			{
				return _seat5_radio;
			}
			set
			{
				_seat5_radio = value;
			}
		}

		internal virtual RadioButton seatx_radio
		{
			get
			{
				return _seatx_radio;
			}
			set
			{
				_seatx_radio = value;
			}
		}

		internal virtual Button setup_confirm_button
		{
			get
			{
				return _setup_confirm_button;
			}
			set
			{
				if (_setup_confirm_button != null)
				{
					Setup setup = this;
					_setup_confirm_button.Click -=new EventHandler(setup.setup_confirm_button_Click);
				}
				_setup_confirm_button = value;
				if (_setup_confirm_button != null)
				{
					Setup setup1 = this;
					_setup_confirm_button.Click +=new EventHandler(setup1.setup_confirm_button_Click);
				}
			}
		}

		internal virtual PictureBox setup_role1_pic
		{
			get
			{
				return _setup_role1_pic;
			}
			set
			{
				_setup_role1_pic = value;
			}
		}

		internal virtual PictureBox setup_role2_pic
		{
			get
			{
				return _setup_role2_pic;
			}
			set
			{
				_setup_role2_pic = value;
			}
		}

		public Setup()
		{
			setup_random1 = 0;
			setup_rand_finished = true;
			setup_low_rand = 0;
			setup_high_rand = 0;
			setup_num_players = 3;
			setup_seat = 1;
			InitializeComponent();
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
			ResourceManager resourceManager = new ResourceManager(typeof(Setup));
			players3_radio = new RadioButton();
			players4_Radio = new RadioButton();
			players5_radio = new RadioButton();
			setup_confirm_button = new Button();
			GroupBox1 = new GroupBox();
			playersx_radio = new RadioButton();
			GroupBox2 = new GroupBox();
			seatx_radio = new RadioButton();
			seat5_radio = new RadioButton();
			seat4_radio = new RadioButton();
			seat3_radio = new RadioButton();
			seat2_radio = new RadioButton();
			seat1_radio = new RadioButton();
			PictureBox1 = new PictureBox();
			PictureBox2 = new PictureBox();
			PictureBox3 = new PictureBox();
			PictureBox4 = new PictureBox();
			setup_role2_pic = new PictureBox();
			setup_role1_pic = new PictureBox();
			PictureBox7 = new PictureBox();
			PictureBox8 = new PictureBox();
			GroupBox3 = new GroupBox();
			GroupBox4 = new GroupBox();
			name_ai4 = new TextBox();
			name_ai3 = new TextBox();
			name_ai2 = new TextBox();
			name_ai1 = new TextBox();
			name_ai4_setup_label = new Label();
			name_ai3_setup_label = new Label();
			Label3 = new Label();
			Label2 = new Label();
			Label1 = new Label();
			name_human = new TextBox();
			GroupBox1.SuspendLayout();
			GroupBox2.SuspendLayout();
			GroupBox3.SuspendLayout();
			GroupBox4.SuspendLayout();
			SuspendLayout();
			players3_radio.Checked = true;
			RadioButton players3Radio = players3_radio;
			Point point = new Point(24, 40);
			players3Radio.Location = point;
			players3_radio.Name = "players3_radio";
			players3_radio.TabIndex=0;
			players3_radio.TabStop = true;
			players3_radio.Text = "3 Players";
			RadioButton players4Radio = players4_Radio;
			point = new Point(24, 72);
			players4Radio.Location = point;
			players4_Radio.Name = "players4_Radio";
			players4_Radio.TabIndex=1;
			players4_Radio.Text = "4 Players";
			RadioButton players5Radio = players5_radio;
			point = new Point(24, 104);
			players5Radio.Location = point;
			players5_radio.Name = "players5_radio";
			players5_radio.TabIndex=2;
			players5_radio.Text = "5 Players";
			Button setupConfirmButton = setup_confirm_button;
			point = new Point(24, 496);
			setupConfirmButton.Location = point;
			setup_confirm_button.Name = "setup_confirm_button";
			setup_confirm_button.TabIndex=3;
			setup_confirm_button.Text = "OK";
			GroupBox1.Controls.Add(players4_Radio);
			GroupBox1.Controls.Add(players5_radio);
			GroupBox1.Controls.Add(players3_radio);
			GroupBox1.Controls.Add(playersx_radio);
			GroupBox groupBox1 = GroupBox1;
			point = new Point(24, 40);
			groupBox1.Location = point;
			GroupBox1.Name = "GroupBox1";
			GroupBox groupBox = GroupBox1;
			Size size = new Size(144, 184);
			groupBox.Size = size;
			GroupBox1.TabIndex=4;
			GroupBox1.TabStop = false;
			GroupBox1.Text = "Number of Players";
			RadioButton playersxRadio = playersx_radio;
			point = new Point(24, 136);
			playersxRadio.Location = point;
			playersx_radio.Name = "playersx_radio";
			playersx_radio.TabIndex=6;
			playersx_radio.Text = "Random";
			GroupBox2.Controls.Add(seatx_radio);
			GroupBox2.Controls.Add(seat5_radio);
			GroupBox2.Controls.Add(seat4_radio);
			GroupBox2.Controls.Add(seat3_radio);
			GroupBox2.Controls.Add(seat2_radio);
			GroupBox2.Controls.Add(seat1_radio);
			GroupBox groupBox2 = GroupBox2;
			point = new Point(192, 40);
			groupBox2.Location = point;
			GroupBox2.Name = "GroupBox2";
			GroupBox groupBox21 = GroupBox2;
			size = new Size(144, 232);
			groupBox21.Size = size;
			GroupBox2.TabIndex=5;
			GroupBox2.TabStop = false;
			GroupBox2.Text = "Choice of Seat";
			RadioButton seatxRadio = seatx_radio;
			point = new Point(32, 192);
			seatxRadio.Location = point;
			seatx_radio.Name = "seatx_radio";
			seatx_radio.TabIndex=5;
			seatx_radio.Text = "Random";
			RadioButton seat5Radio = seat5_radio;
			point = new Point(32, 160);
			seat5Radio.Location = point;
			seat5_radio.Name = "seat5_radio";
			seat5_radio.TabIndex=4;
			seat5_radio.Text = "5th";
			seat5_radio.Visible = false;
			RadioButton seat4Radio = seat4_radio;
			point = new Point(32, 128);
			seat4Radio.Location = point;
			seat4_radio.Name = "seat4_radio";
			seat4_radio.TabIndex=3;
			seat4_radio.Text = "4th";
			seat4_radio.Visible = false;
			RadioButton seat3Radio = seat3_radio;
			point = new Point(32, 96);
			seat3Radio.Location = point;
			seat3_radio.Name = "seat3_radio";
			seat3_radio.TabIndex=2;
			seat3_radio.Text = "3rd";
			RadioButton seat2Radio = seat2_radio;
			point = new Point(32, 64);
			seat2Radio.Location = point;
			seat2_radio.Name = "seat2_radio";
			seat2_radio.TabIndex=1;
			seat2_radio.Text = "2nd";
			seat1_radio.Checked = true;
			RadioButton seat1Radio = seat1_radio;
			point = new Point(32, 32);
			seat1Radio.Location = point;
			seat1_radio.Name = "seat1_radio";
			seat1_radio.TabIndex=0;
			seat1_radio.TabStop = true;
			seat1_radio.Text = "1st";
			PictureBox1.Image = (Image)resourceManager.GetObject("PictureBox1.Image");
			PictureBox pictureBox1 = PictureBox1;
			point = new Point(48, 24);
			pictureBox1.Location = point;
			PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = PictureBox1;
			size = new Size(72, 104);
			pictureBox.Size = size;
			PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox1.TabIndex=6;
			PictureBox1.TabStop = false;
			PictureBox2.Image = (Image)resourceManager.GetObject("PictureBox2.Image");
			PictureBox pictureBox2 = PictureBox2;
			point = new Point(136, 24);
			pictureBox2.Location = point;
			PictureBox2.Name = "PictureBox2";
			PictureBox pictureBox21 = PictureBox2;
			size = new Size(72, 104);
			pictureBox21.Size = size;
			PictureBox2.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox2.TabIndex=7;
			PictureBox2.TabStop = false;
			PictureBox3.Image = (Image)resourceManager.GetObject("PictureBox3.Image");
			PictureBox pictureBox3 = PictureBox3;
			point = new Point(136, 144);
			pictureBox3.Location = point;
			PictureBox3.Name = "PictureBox3";
			PictureBox pictureBox31 = PictureBox3;
			size = new Size(72, 104);
			pictureBox31.Size = size;
			PictureBox3.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox3.TabIndex=9;
			PictureBox3.TabStop = false;
			PictureBox4.Image = (Image)resourceManager.GetObject("PictureBox4.Image");
			PictureBox pictureBox4 = PictureBox4;
			point = new Point(48, 144);
			pictureBox4.Location = point;
			PictureBox4.Name = "PictureBox4";
			PictureBox pictureBox41 = PictureBox4;
			size = new Size(72, 104);
			pictureBox41.Size = size;
			PictureBox4.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox4.TabIndex=8;
			PictureBox4.TabStop = false;
			setup_role2_pic.Image = (Image)resourceManager.GetObject("setup_role2_pic.Image");
			PictureBox setupRole2Pic = setup_role2_pic;
			point = new Point(136, 384);
			setupRole2Pic.Location = point;
			setup_role2_pic.Name = "setup_role2_pic";
			PictureBox setupRole2Pic1 = setup_role2_pic;
			size = new Size(72, 104);
			setupRole2Pic1.Size = size;
			setup_role2_pic.SizeMode=PictureBoxSizeMode.AutoSize;
			setup_role2_pic.TabIndex = 13;
			setup_role2_pic.TabStop = false;
			setup_role2_pic.Visible = false;
			setup_role1_pic.Image = (Image)resourceManager.GetObject("setup_role1_pic.Image");
			PictureBox setupRole1Pic = setup_role1_pic;
			point = new Point(48, 384);
			setupRole1Pic.Location = point;
			setup_role1_pic.Name = "setup_role1_pic";
			PictureBox setupRole1Pic1 = setup_role1_pic;
			size = new Size(72, 104);
			setupRole1Pic1.Size = size;
			setup_role1_pic.SizeMode=PictureBoxSizeMode.AutoSize;
			setup_role1_pic.TabIndex = 12;
			setup_role1_pic.TabStop = false;
			setup_role1_pic.Visible = false;
			PictureBox7.Image = (Image)resourceManager.GetObject("PictureBox7.Image");
			PictureBox pictureBox7 = PictureBox7;
			point = new Point(136, 264);
			pictureBox7.Location = point;
			PictureBox7.Name = "PictureBox7";
			PictureBox pictureBox71 = PictureBox7;
			size = new Size(72, 104);
			pictureBox71.Size = size;
			PictureBox7.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox7.TabIndex = 11;
			PictureBox7.TabStop = false;
			PictureBox8.Image = (Image)resourceManager.GetObject("PictureBox8.Image");
			PictureBox pictureBox8 = PictureBox8;
			point = new Point(48, 264);
			pictureBox8.Location = point;
			PictureBox8.Name = "PictureBox8";
			PictureBox pictureBox81 = PictureBox8;
			size = new Size(72, 104);
			pictureBox81.Size = size;
			PictureBox8.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox8.TabIndex = 10;
			PictureBox8.TabStop = false;
			GroupBox3.Controls.Add(PictureBox7);
			GroupBox3.Controls.Add(PictureBox8);
			GroupBox3.Controls.Add(PictureBox3);
			GroupBox3.Controls.Add(PictureBox4);
			GroupBox3.Controls.Add(PictureBox2);
			GroupBox3.Controls.Add(PictureBox1);
			GroupBox3.Controls.Add(setup_role2_pic);
			GroupBox3.Controls.Add(setup_role1_pic);
			GroupBox groupBox3 = GroupBox3;
			point = new Point(360, 16);
			groupBox3.Location = point;
			GroupBox3.Name = "GroupBox3";
			GroupBox groupBox31 = GroupBox3;
			size = new Size(256, 504);
			groupBox31.Size = size;
			GroupBox3.TabIndex = 14;
			GroupBox3.TabStop = false;
			GroupBox3.Text = "Available Roles";
			GroupBox4.Controls.Add(name_ai4);
			GroupBox4.Controls.Add(name_ai3);
			GroupBox4.Controls.Add(name_ai2);
			GroupBox4.Controls.Add(name_ai1);
			GroupBox4.Controls.Add(name_ai4_setup_label);
			GroupBox4.Controls.Add(name_ai3_setup_label);
			GroupBox4.Controls.Add(Label3);
			GroupBox4.Controls.Add(Label2);
			GroupBox4.Controls.Add(Label1);
			GroupBox4.Controls.Add(name_human);
			GroupBox groupBox4 = GroupBox4;
			point = new Point(104, 296);
			groupBox4.Location = point;
			GroupBox4.Name = "GroupBox4";
			GroupBox groupBox41 = GroupBox4;
			size = new Size(240, 224);
			groupBox41.Size = size;
			GroupBox4.TabIndex = 15;
			GroupBox4.TabStop = false;
			GroupBox4.Text = "Player Names";
			TextBox nameAi4 = name_ai4;
			point = new Point(136, 176);
			nameAi4.Location = point;
			name_ai4.Name = "name_ai4";
			TextBox textBox = name_ai4;
			size = new Size(88, 20);
			textBox.Size = size;
			name_ai4.TabIndex=9;
			name_ai4.Text = "Player5";
			TextBox nameAi3 = name_ai3;
			point = new Point(136, 144);
			nameAi3.Location = point;
			name_ai3.Name = "name_ai3";
			TextBox nameAi31 = name_ai3;
			size = new Size(88, 20);
			nameAi31.Size = size;
			name_ai3.TabIndex=8;
			name_ai3.Text = "Player4";
			TextBox nameAi2 = name_ai2;
			point = new Point(136, 112);
			nameAi2.Location = point;
			name_ai2.Name = "name_ai2";
			TextBox nameAi21 = name_ai2;
			size = new Size(88, 20);
			nameAi21.Size = size;
			name_ai2.TabIndex=7;
			name_ai2.Text = "Player3";
			TextBox nameAi1 = name_ai1;
			point = new Point(136, 80);
			nameAi1.Location = point;
			name_ai1.Name = "name_ai1";
			TextBox nameAi11 = name_ai1;
			size = new Size(88, 20);
			nameAi11.Size = size;
			name_ai1.TabIndex=6;
			name_ai1.Text = "Player2";
			Label nameAi4SetupLabel = name_ai4_setup_label;
			point = new Point(16, 176);
			nameAi4SetupLabel.Location = point;
			name_ai4_setup_label.Name = "name_ai4_setup_label";
			Label label = name_ai4_setup_label;
			size = new Size(100, 16);
			label.Size = size;
			name_ai4_setup_label.TabIndex=5;
			name_ai4_setup_label.Text = "AI PLayer";
			Label nameAi3SetupLabel = name_ai3_setup_label;
			point = new Point(16, 144);
			nameAi3SetupLabel.Location = point;
			name_ai3_setup_label.Name = "name_ai3_setup_label";
			Label nameAi3SetupLabel1 = name_ai3_setup_label;
			size = new Size(100, 16);
			nameAi3SetupLabel1.Size = size;
			name_ai3_setup_label.TabIndex=4;
			name_ai3_setup_label.Text = "AI Player";
			Label label3 = Label3;
			point = new Point(16, 112);
			label3.Location = point;
			Label3.Name = "Label3";
			Label label31 = Label3;
			size = new Size(100, 16);
			label31.Size = size;
			Label3.TabIndex=3;
			Label3.Text = "AI Player";
			Label label2 = Label2;
			point = new Point(16, 80);
			label2.Location = point;
			Label2.Name = "Label2";
			Label label21 = Label2;
			size = new Size(100, 16);
			label21.Size = size;
			Label2.TabIndex=2;
			Label2.Text = "AI Player";
			Label label1 = Label1;
			point = new Point(16, 48);
			label1.Location = point;
			Label1.Name = "Label1";
			Label label11 = Label1;
			size = new Size(100, 16);
			label11.Size = size;
			Label1.TabIndex=1;
			Label1.Text = "Human Player";
			TextBox nameHuman = name_human;
			point = new Point(136, 48);
			nameHuman.Location = point;
			name_human.Name = "name_human";
			TextBox nameHuman1 = name_human;
			size = new Size(88, 20);
			nameHuman1.Size = size;
			name_human.TabIndex=0;
			name_human.Text = "Player1";
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(640, 546);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(GroupBox4);
			Controls.Add(GroupBox3);
			Controls.Add(GroupBox2);
			Controls.Add(GroupBox1);
			Controls.Add(setup_confirm_button);
			MaximizeBox = false;
			size = new Size(648, 584);
			MaximumSize = size;
			MinimizeBox = false;
			size = new Size(648, 584);
			MinimumSize = size;
			Name = "Setup";
			SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Setup";
			GroupBox1.ResumeLayout(false);
			GroupBox2.ResumeLayout(false);
			GroupBox3.ResumeLayout(false);
			GroupBox4.ResumeLayout(false);
			ResumeLayout(false);
		}

		private void players3_radio_CheckedChanged(object sender, EventArgs e)
		{
			GroupBox2.Visible = true;
			if (!(seat4_radio.Checked | seat5_radio.Checked))
			{
				seat4_radio.Visible = false;
				seat5_radio.Visible = false;
			}
			else
			{
				seat4_radio.Checked = false;
				seat4_radio.Visible = false;
				seat5_radio.Checked = false;
				seat5_radio.Visible = false;
				seat1_radio.Checked = true;
			}
			setup_role1_pic.Visible = false;
			setup_role2_pic.Visible = false;
			name_ai3_setup_label.Visible = false;
			name_ai4_setup_label.Visible = false;
			name_ai3.Visible = false;
			name_ai4.Visible = false;
		}

		private void players4_Radio_CheckedChanged(object sender, EventArgs e)
		{
			GroupBox2.Visible = true;
			if (!seat5_radio.Checked)
			{
				seat4_radio.Visible = true;
				seat5_radio.Visible = false;
			}
			else
			{
				seat4_radio.Checked = false;
				seat4_radio.Visible = true;
				seat5_radio.Checked = false;
				seat5_radio.Visible = false;
				seat1_radio.Checked = true;
			}
			setup_role1_pic.Visible = true;
			setup_role2_pic.Visible = false;
			name_ai3_setup_label.Visible = true;
			name_ai4_setup_label.Visible = false;
			name_ai3.Visible = true;
			name_ai4.Visible = false;
		}

		private void players5_radio_CheckedChanged(object sender, EventArgs e)
		{
			GroupBox2.Visible = true;
			seat4_radio.Visible = true;
			seat5_radio.Visible = true;
			setup_role1_pic.Visible = true;
			setup_role2_pic.Visible = true;
			name_ai3_setup_label.Visible = true;
			name_ai4_setup_label.Visible = true;
			name_ai3.Visible = true;
			name_ai4.Visible = true;
		}

		private void playersx_radio_CheckedChanged(object sender, EventArgs e)
		{
			GroupBox2.Visible = false;
		}

		private void setup_confirm_button_Click(object sender, EventArgs e)
		{
			bool flag = true;
			if (flag == players3_radio.Checked)
			{
				setup_num_players = 3;
			}
			else if (flag == players4_Radio.Checked)
			{
				setup_num_players = 4;
			}
			else if (flag == players5_radio.Checked)
			{
				setup_num_players = 5;
			}
			else if (flag == playersx_radio.Checked)
			{
				setup_generate_random1(3, 5);
				setup_num_players = setup_random1;
				setup_generate_random1(1, setup_num_players);
				setup_seat = setup_random1;
			}
			if (!playersx_radio.Checked)
			{
				bool flag1 = true;
				if (flag1 == seat1_radio.Checked)
				{
					setup_seat = 1;
				}
				else if (flag1 == seat2_radio.Checked)
				{
					setup_seat = 2;
				}
				else if (flag1 == seat3_radio.Checked)
				{
					setup_seat = 3;
				}
				else if (flag1 == seat4_radio.Checked)
				{
					setup_seat = 4;
				}
				else if (flag1 == seat5_radio.Checked)
				{
					setup_seat = 5;
				}
				else if (flag1 == seatx_radio.Checked)
				{
					setup_generate_random1(1, setup_num_players);
					setup_seat = setup_random1;
				}
			}
			Close();
		}

		public void setup_generate_random1(object setup_low_rand, object setup_high_rand)
		{
			setup_rand_finished = false;
			while (!setup_rand_finished)
			{
				VBMath.Randomize();
				setup_random1 = IntegerType.FromObject(Conversion.Int(ObjectType.AddObj(ObjectType.MulObj(ObjectType.AddObj(setup_high_rand, 1), VBMath.Rnd()), 0)));
				if (!BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(setup_random1, setup_low_rand, false) >= 0, ObjectType.ObjTst(setup_random1, setup_high_rand, false) <= 0)))
				{
					continue;
				}
				setup_rand_finished = true;
			}
		}
	}
}
