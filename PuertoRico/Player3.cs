using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Player3 : Form
	{
		[AccessedThroughProperty("gold_label")]
		private Label _gold_label;

		[AccessedThroughProperty("plant_p3_slot2")]
		private PictureBox _plant_p3_slot2;

		[AccessedThroughProperty("p3_close_button")]
		private Button _p3_close_button;

		[AccessedThroughProperty("plant_p3_slot12")]
		private PictureBox _plant_p3_slot12;

		[AccessedThroughProperty("governor_pic")]
		private PictureBox _governor_pic;

		[AccessedThroughProperty("build_p3_slot19")]
		private PictureBox _build_p3_slot19;

		[AccessedThroughProperty("build_p3_slot17")]
		private PictureBox _build_p3_slot17;

		[AccessedThroughProperty("player_board_pic")]
		private PictureBox _player_board_pic;

		[AccessedThroughProperty("build_p3_slot15")]
		private PictureBox _build_p3_slot15;

		[AccessedThroughProperty("build_p3_slot13")]
		private PictureBox _build_p3_slot13;

		[AccessedThroughProperty("plant_p3_slot3")]
		private PictureBox _plant_p3_slot3;

		[AccessedThroughProperty("plant_p3_slot4")]
		private PictureBox _plant_p3_slot4;

		[AccessedThroughProperty("plant_p3_slot5")]
		private PictureBox _plant_p3_slot5;

		[AccessedThroughProperty("plant_p3_slot6")]
		private PictureBox _plant_p3_slot6;

		[AccessedThroughProperty("plant_p3_slot7")]
		private PictureBox _plant_p3_slot7;

		[AccessedThroughProperty("build_p3_slot20")]
		private PictureBox _build_p3_slot20;

		[AccessedThroughProperty("build_p3_slot11")]
		private PictureBox _build_p3_slot11;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("plant_p3_slot8")]
		private PictureBox _plant_p3_slot8;

		[AccessedThroughProperty("plant_p3_slot9")]
		private PictureBox _plant_p3_slot9;

		[AccessedThroughProperty("build_p3_slot10")]
		private PictureBox _build_p3_slot10;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("build_p3_slot8")]
		private PictureBox _build_p3_slot8;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("build_p3_slot7")]
		private PictureBox _build_p3_slot7;

		[AccessedThroughProperty("vp_chips_label")]
		private Label _vp_chips_label;

		[AccessedThroughProperty("build_p3_slot5")]
		private PictureBox _build_p3_slot5;

		[AccessedThroughProperty("plant_p3_slot10")]
		private PictureBox _plant_p3_slot10;

		[AccessedThroughProperty("build_p3_slot18")]
		private PictureBox _build_p3_slot18;

		[AccessedThroughProperty("plant_p3_slot11")]
		private PictureBox _plant_p3_slot11;

		[AccessedThroughProperty("vp_total_label")]
		private Label _vp_total_label;

		[AccessedThroughProperty("build_p3_slot4")]
		private PictureBox _build_p3_slot4;

		[AccessedThroughProperty("idle_colonists_label")]
		private Label _idle_colonists_label;

		[AccessedThroughProperty("build_p3_slot2")]
		private PictureBox _build_p3_slot2;

		[AccessedThroughProperty("num_coffee_label")]
		private Label _num_coffee_label;

		[AccessedThroughProperty("build_p3_slot1")]
		private PictureBox _build_p3_slot1;

		[AccessedThroughProperty("num_tobacco_label")]
		private Label _num_tobacco_label;

		[AccessedThroughProperty("build_p3_slot12")]
		private PictureBox _build_p3_slot12;

		[AccessedThroughProperty("num_corn_label")]
		private Label _num_corn_label;

		[AccessedThroughProperty("build_p3_slot9")]
		private PictureBox _build_p3_slot9;

		[AccessedThroughProperty("num_sugar_label")]
		private Label _num_sugar_label;

		[AccessedThroughProperty("build_p3_slot16")]
		private PictureBox _build_p3_slot16;

		[AccessedThroughProperty("build_p3_slot6")]
		private PictureBox _build_p3_slot6;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("num_indigo_label")]
		private Label _num_indigo_label;

		[AccessedThroughProperty("build_p3_slot3")]
		private PictureBox _build_p3_slot3;

		[AccessedThroughProperty("plant_p3_slot1")]
		private PictureBox _plant_p3_slot1;

		[AccessedThroughProperty("build_p3_slot14")]
		private PictureBox _build_p3_slot14;

		private IContainer components;

		internal virtual PictureBox build_p3_slot1
		{
			get
			{
				return this._build_p3_slot1;
			}
			set
			{
				this._build_p3_slot1 = null;
				this._build_p3_slot1 = value;
				this._build_p3_slot1 = null;
			}
		}

		internal virtual PictureBox build_p3_slot10
		{
			get
			{
				return this._build_p3_slot10;
			}
			set
			{
				this._build_p3_slot10 = null;
				this._build_p3_slot10 = value;
				this._build_p3_slot10 = null;
			}
		}

		internal virtual PictureBox build_p3_slot11
		{
			get
			{
				return this._build_p3_slot11;
			}
			set
			{
				this._build_p3_slot11 = null;
				this._build_p3_slot11 = value;
				this._build_p3_slot11 = null;
			}
		}

		internal virtual PictureBox build_p3_slot12
		{
			get
			{
				return this._build_p3_slot12;
			}
			set
			{
				this._build_p3_slot12 = null;
				this._build_p3_slot12 = value;
				this._build_p3_slot12 = null;
			}
		}

		internal virtual PictureBox build_p3_slot13
		{
			get
			{
				return this._build_p3_slot13;
			}
			set
			{
				this._build_p3_slot13 = null;
				this._build_p3_slot13 = value;
				this._build_p3_slot13 = null;
			}
		}

		internal virtual PictureBox build_p3_slot14
		{
			get
			{
				return this._build_p3_slot14;
			}
			set
			{
				this._build_p3_slot14 = null;
				this._build_p3_slot14 = value;
				this._build_p3_slot14 = null;
			}
		}

		internal virtual PictureBox build_p3_slot15
		{
			get
			{
				return this._build_p3_slot15;
			}
			set
			{
				this._build_p3_slot15 = null;
				this._build_p3_slot15 = value;
				this._build_p3_slot15 = null;
			}
		}

		internal virtual PictureBox build_p3_slot16
		{
			get
			{
				return this._build_p3_slot16;
			}
			set
			{
				this._build_p3_slot16 = null;
				this._build_p3_slot16 = value;
				this._build_p3_slot16 = null;
			}
		}

		internal virtual PictureBox build_p3_slot17
		{
			get
			{
				return this._build_p3_slot17;
			}
			set
			{
				this._build_p3_slot17 = null;
				this._build_p3_slot17 = value;
				this._build_p3_slot17 = null;
			}
		}

		internal virtual PictureBox build_p3_slot18
		{
			get
			{
				return this._build_p3_slot18;
			}
			set
			{
				this._build_p3_slot18 = null;
				this._build_p3_slot18 = value;
				this._build_p3_slot18 = null;
			}
		}

		internal virtual PictureBox build_p3_slot19
		{
			get
			{
				return this._build_p3_slot19;
			}
			set
			{
				this._build_p3_slot19 = null;
				this._build_p3_slot19 = value;
				this._build_p3_slot19 = null;
			}
		}

		internal virtual PictureBox build_p3_slot2
		{
			get
			{
				return this._build_p3_slot2;
			}
			set
			{
				this._build_p3_slot2 = null;
				this._build_p3_slot2 = value;
				this._build_p3_slot2 = null;
			}
		}

		internal virtual PictureBox build_p3_slot20
		{
			get
			{
				return this._build_p3_slot20;
			}
			set
			{
				this._build_p3_slot20 = null;
				this._build_p3_slot20 = value;
				this._build_p3_slot20 = null;
			}
		}

		internal virtual PictureBox build_p3_slot3
		{
			get
			{
				return this._build_p3_slot3;
			}
			set
			{
				this._build_p3_slot3 = null;
				this._build_p3_slot3 = value;
				this._build_p3_slot3 = null;
			}
		}

		internal virtual PictureBox build_p3_slot4
		{
			get
			{
				return this._build_p3_slot4;
			}
			set
			{
				this._build_p3_slot4 = null;
				this._build_p3_slot4 = value;
				this._build_p3_slot4 = null;
			}
		}

		internal virtual PictureBox build_p3_slot5
		{
			get
			{
				return this._build_p3_slot5;
			}
			set
			{
				this._build_p3_slot5 = null;
				this._build_p3_slot5 = value;
				this._build_p3_slot5 = null;
			}
		}

		internal virtual PictureBox build_p3_slot6
		{
			get
			{
				return this._build_p3_slot6;
			}
			set
			{
				this._build_p3_slot6 = null;
				this._build_p3_slot6 = value;
				this._build_p3_slot6 = null;
			}
		}

		internal virtual PictureBox build_p3_slot7
		{
			get
			{
				return this._build_p3_slot7;
			}
			set
			{
				this._build_p3_slot7 = null;
				this._build_p3_slot7 = value;
				this._build_p3_slot7 = null;
			}
		}

		internal virtual PictureBox build_p3_slot8
		{
			get
			{
				return this._build_p3_slot8;
			}
			set
			{
				this._build_p3_slot8 = null;
				this._build_p3_slot8 = value;
				this._build_p3_slot8 = null;
			}
		}

		internal virtual PictureBox build_p3_slot9
		{
			get
			{
				return this._build_p3_slot9;
			}
			set
			{
				this._build_p3_slot9 = null;
				this._build_p3_slot9 = value;
				this._build_p3_slot9 = null;
			}
		}

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
					Player3 player3 = this;
					this._Button1.Click -=new EventHandler(player3.Button1_Click);
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					Player3 player31 = this;
					this._Button1.Click +=new EventHandler(player31.Button1_Click);
				}
			}
		}

		internal virtual Label gold_label
		{
			get
			{
				return this._gold_label;
			}
			set
			{
				this._gold_label = null;
				this._gold_label = value;
				this._gold_label = null;
			}
		}

		internal virtual PictureBox governor_pic
		{
			get
			{
				return this._governor_pic;
			}
			set
			{
				this._governor_pic = null;
				this._governor_pic = value;
				this._governor_pic = null;
			}
		}

		internal virtual Label idle_colonists_label
		{
			get
			{
				return this._idle_colonists_label;
			}
			set
			{
				this._idle_colonists_label = null;
				this._idle_colonists_label = value;
				this._idle_colonists_label = null;
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

		internal virtual Label num_coffee_label
		{
			get
			{
				return this._num_coffee_label;
			}
			set
			{
				this._num_coffee_label = null;
				this._num_coffee_label = value;
				this._num_coffee_label = null;
			}
		}

		internal virtual Label num_corn_label
		{
			get
			{
				return this._num_corn_label;
			}
			set
			{
				this._num_corn_label = null;
				this._num_corn_label = value;
				this._num_corn_label = null;
			}
		}

		internal virtual Label num_indigo_label
		{
			get
			{
				return this._num_indigo_label;
			}
			set
			{
				this._num_indigo_label = null;
				this._num_indigo_label = value;
				this._num_indigo_label = null;
			}
		}

		internal virtual Label num_sugar_label
		{
			get
			{
				return this._num_sugar_label;
			}
			set
			{
				this._num_sugar_label = null;
				this._num_sugar_label = value;
				this._num_sugar_label = null;
			}
		}

		internal virtual Label num_tobacco_label
		{
			get
			{
				return this._num_tobacco_label;
			}
			set
			{
				this._num_tobacco_label = null;
				this._num_tobacco_label = value;
				this._num_tobacco_label = null;
			}
		}

		internal virtual Button p3_close_button
		{
			get
			{
				return this._p3_close_button;
			}
			set
			{
				if (this._p3_close_button != null)
				{
					Player3 player3 = this;
					this._p3_close_button.Click -=new EventHandler(player3.p3_close_button_Click);
				}
				this._p3_close_button = value;
				if (this._p3_close_button != null)
				{
					Player3 player31 = this;
					this._p3_close_button.Click +=new EventHandler(player31.p3_close_button_Click);
				}
			}
		}

		internal virtual PictureBox plant_p3_slot1
		{
			get
			{
				return this._plant_p3_slot1;
			}
			set
			{
				this._plant_p3_slot1 = null;
				this._plant_p3_slot1 = value;
				this._plant_p3_slot1 = null;
			}
		}

		internal virtual PictureBox plant_p3_slot10
		{
			get
			{
				return this._plant_p3_slot10;
			}
			set
			{
				this._plant_p3_slot10 = null;
				this._plant_p3_slot10 = value;
				this._plant_p3_slot10 = null;
			}
		}

		internal virtual PictureBox plant_p3_slot11
		{
			get
			{
				return this._plant_p3_slot11;
			}
			set
			{
				this._plant_p3_slot11 = null;
				this._plant_p3_slot11 = value;
				this._plant_p3_slot11 = null;
			}
		}

		internal virtual PictureBox plant_p3_slot12
		{
			get
			{
				return this._plant_p3_slot12;
			}
			set
			{
				this._plant_p3_slot12 = null;
				this._plant_p3_slot12 = value;
				this._plant_p3_slot12 = null;
			}
		}

		internal virtual PictureBox plant_p3_slot2
		{
			get
			{
				return this._plant_p3_slot2;
			}
			set
			{
				this._plant_p3_slot2 = null;
				this._plant_p3_slot2 = value;
				this._plant_p3_slot2 = null;
			}
		}

		internal virtual PictureBox plant_p3_slot3
		{
			get
			{
				return this._plant_p3_slot3;
			}
			set
			{
				this._plant_p3_slot3 = null;
				this._plant_p3_slot3 = value;
				this._plant_p3_slot3 = null;
			}
		}

		internal virtual PictureBox plant_p3_slot4
		{
			get
			{
				return this._plant_p3_slot4;
			}
			set
			{
				this._plant_p3_slot4 = null;
				this._plant_p3_slot4 = value;
				this._plant_p3_slot4 = null;
			}
		}

		internal virtual PictureBox plant_p3_slot5
		{
			get
			{
				return this._plant_p3_slot5;
			}
			set
			{
				this._plant_p3_slot5 = null;
				this._plant_p3_slot5 = value;
				this._plant_p3_slot5 = null;
			}
		}

		internal virtual PictureBox plant_p3_slot6
		{
			get
			{
				return this._plant_p3_slot6;
			}
			set
			{
				this._plant_p3_slot6 = null;
				this._plant_p3_slot6 = value;
				this._plant_p3_slot6 = null;
			}
		}

		internal virtual PictureBox plant_p3_slot7
		{
			get
			{
				return this._plant_p3_slot7;
			}
			set
			{
				this._plant_p3_slot7 = null;
				this._plant_p3_slot7 = value;
				this._plant_p3_slot7 = null;
			}
		}

		internal virtual PictureBox plant_p3_slot8
		{
			get
			{
				return this._plant_p3_slot8;
			}
			set
			{
				this._plant_p3_slot8 = null;
				this._plant_p3_slot8 = value;
				this._plant_p3_slot8 = null;
			}
		}

		internal virtual PictureBox plant_p3_slot9
		{
			get
			{
				return this._plant_p3_slot9;
			}
			set
			{
				this._plant_p3_slot9 = null;
				this._plant_p3_slot9 = value;
				this._plant_p3_slot9 = null;
			}
		}

		internal virtual PictureBox player_board_pic
		{
			get
			{
				return this._player_board_pic;
			}
			set
			{
				this._player_board_pic = null;
				this._player_board_pic = value;
				this._player_board_pic = null;
			}
		}

		internal virtual Label vp_chips_label
		{
			get
			{
				return this._vp_chips_label;
			}
			set
			{
				this._vp_chips_label = null;
				this._vp_chips_label = value;
				this._vp_chips_label = null;
			}
		}

		internal virtual Label vp_total_label
		{
			get
			{
				return this._vp_total_label;
			}
			set
			{
				this._vp_total_label = null;
				this._vp_total_label = value;
				this._vp_total_label = null;
			}
		}

		public Player3()
		{
			this.InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (!this.vp_chips_label.Visible)
			{
				this.vp_chips_label.Visible = true;
				this.vp_total_label.Visible = true;
				this.Label4.Visible = true;
				this.Label5.Visible = true;
			}
			else
			{
				this.vp_chips_label.Visible = false;
				this.vp_total_label.Visible = false;
				this.Label4.Visible = false;
				this.Label5.Visible = false;
			}
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
			ResourceManager resourceManager = new ResourceManager(typeof(Player3));
			this.player_board_pic = new PictureBox();
			this.plant_p3_slot12 = new PictureBox();
			this.plant_p3_slot11 = new PictureBox();
			this.plant_p3_slot10 = new PictureBox();
			this.plant_p3_slot9 = new PictureBox();
			this.plant_p3_slot8 = new PictureBox();
			this.plant_p3_slot7 = new PictureBox();
			this.plant_p3_slot6 = new PictureBox();
			this.plant_p3_slot5 = new PictureBox();
			this.plant_p3_slot4 = new PictureBox();
			this.plant_p3_slot3 = new PictureBox();
			this.plant_p3_slot2 = new PictureBox();
			this.plant_p3_slot1 = new PictureBox();
			this.governor_pic = new PictureBox();
			this.Label5 = new Label();
			this.Label4 = new Label();
			this.vp_chips_label = new Label();
			this.vp_total_label = new Label();
			this.Label1 = new Label();
			this.gold_label = new Label();
			this.idle_colonists_label = new Label();
			this.num_coffee_label = new Label();
			this.num_tobacco_label = new Label();
			this.num_corn_label = new Label();
			this.num_sugar_label = new Label();
			this.num_indigo_label = new Label();
			this.p3_close_button = new Button();
			this.build_p3_slot11 = new PictureBox();
			this.build_p3_slot10 = new PictureBox();
			this.build_p3_slot8 = new PictureBox();
			this.build_p3_slot7 = new PictureBox();
			this.build_p3_slot5 = new PictureBox();
			this.build_p3_slot4 = new PictureBox();
			this.build_p3_slot2 = new PictureBox();
			this.build_p3_slot1 = new PictureBox();
			this.build_p3_slot12 = new PictureBox();
			this.build_p3_slot9 = new PictureBox();
			this.build_p3_slot6 = new PictureBox();
			this.build_p3_slot3 = new PictureBox();
			this.build_p3_slot14 = new PictureBox();
			this.build_p3_slot16 = new PictureBox();
			this.build_p3_slot18 = new PictureBox();
			this.build_p3_slot20 = new PictureBox();
			this.build_p3_slot13 = new PictureBox();
			this.build_p3_slot15 = new PictureBox();
			this.build_p3_slot17 = new PictureBox();
			this.build_p3_slot19 = new PictureBox();
			this.Button1 = new Button();
			this.SuspendLayout();
			this.player_board_pic.Image = (Image)resourceManager.GetObject("player_board_pic.Image");
			PictureBox playerBoardPic = this.player_board_pic;
			Point point = new Point(0, 0);
			playerBoardPic.Location = point;
			this.player_board_pic.Name = "player_board_pic";
			PictureBox pictureBox = this.player_board_pic;
			Size size = new Size(824, 624);
			pictureBox.Size = size;
			this.player_board_pic.SizeMode = PictureBoxSizeMode.CenterImage;
			this.player_board_pic.TabIndex=3;
			this.player_board_pic.TabStop = false;
			this.plant_p3_slot12.BackColor=SystemColors.ActiveCaption;
			this.plant_p3_slot12.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot12 = this.plant_p3_slot12;
			point = new Point(410, 404);
			plantP3Slot12.Location = point;
			this.plant_p3_slot12.Name = "plant_p3_slot12";
			PictureBox plantP3Slot121 = this.plant_p3_slot12;
			size = new Size(72, 74);
			plantP3Slot121.Size = size;
			this.plant_p3_slot12.SizeMode=PictureBoxSizeMode.AutoSize;
			this.plant_p3_slot12.TabIndex = 148;
			this.plant_p3_slot12.TabStop = false;
			this.plant_p3_slot12.Visible = false;
			this.plant_p3_slot11.BackColor=SystemColors.ActiveCaption;
			this.plant_p3_slot11.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot11 = this.plant_p3_slot11;
			point = new Point(334, 446);
			plantP3Slot11.Location = point;
			this.plant_p3_slot11.Name = "plant_p3_slot11";
			PictureBox plantP3Slot111 = this.plant_p3_slot11;
			size = new Size(72, 74);
			plantP3Slot111.Size = size;
			this.plant_p3_slot11.SizeMode=PictureBoxSizeMode.AutoSize;
			this.plant_p3_slot11.TabIndex = 147;
			this.plant_p3_slot11.TabStop = false;
			this.plant_p3_slot11.Visible = false;
			this.plant_p3_slot10.BackColor=SystemColors.ActiveCaption;
			this.plant_p3_slot10.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot10 = this.plant_p3_slot10;
			point = new Point(334, 370);
			plantP3Slot10.Location = point;
			this.plant_p3_slot10.Name = "plant_p3_slot10";
			PictureBox plantP3Slot101 = this.plant_p3_slot10;
			size = new Size(72, 74);
			plantP3Slot101.Size = size;
			this.plant_p3_slot10.SizeMode=PictureBoxSizeMode.AutoSize;
			this.plant_p3_slot10.TabIndex = 146;
			this.plant_p3_slot10.TabStop = false;
			this.plant_p3_slot10.Visible = false;
			this.plant_p3_slot9.BackColor=SystemColors.ActiveCaption;
			this.plant_p3_slot9.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot9 = this.plant_p3_slot9;
			point = new Point(258, 486);
			plantP3Slot9.Location = point;
			this.plant_p3_slot9.Name = "plant_p3_slot9";
			PictureBox plantP3Slot91 = this.plant_p3_slot9;
			size = new Size(72, 74);
			plantP3Slot91.Size = size;
			this.plant_p3_slot9.SizeMode=PictureBoxSizeMode.AutoSize;
			this.plant_p3_slot9.TabIndex = 145;
			this.plant_p3_slot9.TabStop = false;
			this.plant_p3_slot9.Visible = false;
			this.plant_p3_slot8.BackColor=SystemColors.ActiveCaption;
			this.plant_p3_slot8.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot8 = this.plant_p3_slot8;
			point = new Point(258, 410);
			plantP3Slot8.Location = point;
			this.plant_p3_slot8.Name = "plant_p3_slot8";
			PictureBox plantP3Slot81 = this.plant_p3_slot8;
			size = new Size(72, 74);
			plantP3Slot81.Size = size;
			this.plant_p3_slot8.SizeMode=PictureBoxSizeMode.AutoSize;
			this.plant_p3_slot8.TabIndex = 144;
			this.plant_p3_slot8.TabStop = false;
			this.plant_p3_slot8.Visible = false;
			this.plant_p3_slot7.BackColor=SystemColors.ActiveCaption;
			this.plant_p3_slot7.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot7 = this.plant_p3_slot7;
			point = new Point(258, 332);
			plantP3Slot7.Location = point;
			this.plant_p3_slot7.Name = "plant_p3_slot7";
			PictureBox plantP3Slot71 = this.plant_p3_slot7;
			size = new Size(72, 74);
			plantP3Slot71.Size = size;
			this.plant_p3_slot7.SizeMode=PictureBoxSizeMode.AutoSize;
			this.plant_p3_slot7.TabIndex = 143;
			this.plant_p3_slot7.TabStop = false;
			this.plant_p3_slot7.Visible = false;
			this.plant_p3_slot6.BackColor=SystemColors.ActiveCaption;
			this.plant_p3_slot6.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot6 = this.plant_p3_slot6;
			point = new Point(182, 462);
			plantP3Slot6.Location = point;
			this.plant_p3_slot6.Name = "plant_p3_slot6";
			PictureBox plantP3Slot61 = this.plant_p3_slot6;
			size = new Size(72, 74);
			plantP3Slot61.Size = size;
			this.plant_p3_slot6.SizeMode=PictureBoxSizeMode.AutoSize;
			this.plant_p3_slot6.TabIndex = 142;
			this.plant_p3_slot6.TabStop = false;
			this.plant_p3_slot6.Visible = false;
			this.plant_p3_slot5.BackColor=SystemColors.ActiveCaption;
			this.plant_p3_slot5.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot5 = this.plant_p3_slot5;
			point = new Point(182, 386);
			plantP3Slot5.Location = point;
			this.plant_p3_slot5.Name = "plant_p3_slot5";
			PictureBox plantP3Slot51 = this.plant_p3_slot5;
			size = new Size(72, 74);
			plantP3Slot51.Size = size;
			this.plant_p3_slot5.SizeMode=PictureBoxSizeMode.AutoSize;
			this.plant_p3_slot5.TabIndex = 141;
			this.plant_p3_slot5.TabStop = false;
			this.plant_p3_slot5.Visible = false;
			this.plant_p3_slot4.BackColor=SystemColors.ActiveCaption;
			this.plant_p3_slot4.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot4 = this.plant_p3_slot4;
			point = new Point(182, 308);
			plantP3Slot4.Location = point;
			this.plant_p3_slot4.Name = "plant_p3_slot4";
			PictureBox plantP3Slot41 = this.plant_p3_slot4;
			size = new Size(72, 74);
			plantP3Slot41.Size = size;
			this.plant_p3_slot4.SizeMode=PictureBoxSizeMode.AutoSize;
			this.plant_p3_slot4.TabIndex = 140;
			this.plant_p3_slot4.TabStop = false;
			this.plant_p3_slot4.Visible = false;
			this.plant_p3_slot3.BackColor=SystemColors.ActiveCaption;
			this.plant_p3_slot3.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot3 = this.plant_p3_slot3;
			point = new Point(106, 496);
			plantP3Slot3.Location = point;
			this.plant_p3_slot3.Name = "plant_p3_slot3";
			PictureBox plantP3Slot31 = this.plant_p3_slot3;
			size = new Size(72, 74);
			plantP3Slot31.Size = size;
			this.plant_p3_slot3.SizeMode=PictureBoxSizeMode.AutoSize;
			this.plant_p3_slot3.TabIndex = 139;
			this.plant_p3_slot3.TabStop = false;
			this.plant_p3_slot3.Visible = false;
			this.plant_p3_slot2.BackColor=SystemColors.ActiveCaption;
			this.plant_p3_slot2.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot2 = this.plant_p3_slot2;
			point = new Point(106, 420);
			plantP3Slot2.Location = point;
			this.plant_p3_slot2.Name = "plant_p3_slot2";
			PictureBox plantP3Slot21 = this.plant_p3_slot2;
			size = new Size(72, 74);
			plantP3Slot21.Size = size;
			this.plant_p3_slot2.SizeMode=PictureBoxSizeMode.AutoSize;
			this.plant_p3_slot2.TabIndex = 138;
			this.plant_p3_slot2.TabStop = false;
			this.plant_p3_slot2.Visible = false;
			this.plant_p3_slot1.BackColor=SystemColors.ActiveCaption;
			this.plant_p3_slot1.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot1 = this.plant_p3_slot1;
			point = new Point(106, 342);
			plantP3Slot1.Location = point;
			this.plant_p3_slot1.Name = "plant_p3_slot1";
			PictureBox pictureBox1 = this.plant_p3_slot1;
			size = new Size(72, 74);
			pictureBox1.Size = size;
			this.plant_p3_slot1.SizeMode=PictureBoxSizeMode.AutoSize;
			this.plant_p3_slot1.TabIndex = 137;
			this.plant_p3_slot1.TabStop = false;
			this.plant_p3_slot1.Visible = false;
			this.governor_pic.Image = (Image)resourceManager.GetObject("governor_pic.Image");
			PictureBox governorPic = this.governor_pic;
			point = new Point(424, 512);
			governorPic.Location = point;
			this.governor_pic.Name = "governor_pic";
			PictureBox governorPic1 = this.governor_pic;
			size = new Size(52, 72);
			governorPic1.Size = size;
			this.governor_pic.SizeMode=PictureBoxSizeMode.AutoSize;
			this.governor_pic.TabIndex = 180;
			this.governor_pic.TabStop = false;
			this.Label5.Font = new Font("Comic Sans MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label5 = this.Label5;
			point = new Point(20, 564);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label = this.Label5;
			size = new Size(72, 16);
			label.Size = size;
			this.Label5.TabIndex = 179;
			this.Label5.Text = "VP Total";
			this.Label5.TextAlign = ContentAlignment.MiddleCenter;
			this.Label5.Visible = false;
			this.Label4.Font = new Font("Comic Sans MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label4 = this.Label4;
			point = new Point(20, 492);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label41 = this.Label4;
			size = new Size(72, 16);
			label41.Size = size;
			this.Label4.TabIndex = 178;
			this.Label4.Text = "VP Chips";
			this.Label4.TextAlign = ContentAlignment.MiddleCenter;
			this.Label4.Visible = false;
			this.vp_chips_label.BackColor = SystemColors.ActiveBorder;
			this.vp_chips_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label vpChipsLabel = this.vp_chips_label;
			point = new Point(36, 460);
			vpChipsLabel.Location = point;
			this.vp_chips_label.Name = "vp_chips_label";
			Label vpChipsLabel1 = this.vp_chips_label;
			size = new Size(36, 32);
			vpChipsLabel1.Size = size;
			this.vp_chips_label.TabIndex = 177;
			this.vp_chips_label.Text = "99";
			this.vp_chips_label.TextAlign = ContentAlignment.MiddleCenter;
			this.vp_chips_label.Visible = false;
			this.vp_total_label.BackColor = SystemColors.ActiveBorder;
			this.vp_total_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label vpTotalLabel = this.vp_total_label;
			point = new Point(36, 532);
			vpTotalLabel.Location = point;
			this.vp_total_label.Name = "vp_total_label";
			Label vpTotalLabel1 = this.vp_total_label;
			size = new Size(36, 32);
			vpTotalLabel1.Size = size;
			this.vp_total_label.TabIndex = 176;
			this.vp_total_label.Text = "99";
			this.vp_total_label.TextAlign = ContentAlignment.MiddleCenter;
			this.vp_total_label.Visible = false;
			this.Label1.Font = new Font("Comic Sans MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = this.Label1;
			point = new Point(20, 428);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label11 = this.Label1;
			size = new Size(72, 16);
			label11.Size = size;
			this.Label1.TabIndex = 175;
			this.Label1.Text = "Doubloons";
			this.Label1.TextAlign = ContentAlignment.MiddleCenter;
			this.gold_label.BackColor = SystemColors.ActiveBorder;
			this.gold_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label goldLabel = this.gold_label;
			point = new Point(36, 396);
			goldLabel.Location = point;
			this.gold_label.Name = "gold_label";
			Label goldLabel1 = this.gold_label;
			size = new Size(36, 32);
			goldLabel1.Size = size;
			this.gold_label.TabIndex = 174;
			this.gold_label.Text = "99";
			this.gold_label.TextAlign = ContentAlignment.MiddleCenter;
			this.idle_colonists_label.BackColor = SystemColors.ActiveBorder;
			this.idle_colonists_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label idleColonistsLabel = this.idle_colonists_label;
			point = new Point(52, 284);
			idleColonistsLabel.Location = point;
			this.idle_colonists_label.Name = "idle_colonists_label";
			Label idleColonistsLabel1 = this.idle_colonists_label;
			size = new Size(36, 32);
			idleColonistsLabel1.Size = size;
			this.idle_colonists_label.TabIndex = 173;
			this.idle_colonists_label.Text = "99";
			this.idle_colonists_label.TextAlign = ContentAlignment.MiddleCenter;
			this.num_coffee_label.BackColor = Color.SaddleBrown;
			this.num_coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.num_coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label numCoffeeLabel = this.num_coffee_label;
			point = new Point(406, 264);
			numCoffeeLabel.Location = point;
			this.num_coffee_label.Name = "num_coffee_label";
			Label numCoffeeLabel1 = this.num_coffee_label;
			size = new Size(36, 32);
			numCoffeeLabel1.Size = size;
			this.num_coffee_label.TabIndex = 172;
			this.num_coffee_label.Text = "99";
			this.num_coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			this.num_tobacco_label.BackColor=Color.Goldenrod;
			this.num_tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label numTobaccoLabel = this.num_tobacco_label;
			point = new Point(350, 264);
			numTobaccoLabel.Location = point;
			this.num_tobacco_label.Name = "num_tobacco_label";
			Label numTobaccoLabel1 = this.num_tobacco_label;
			size = new Size(36, 32);
			numTobaccoLabel1.Size = size;
			this.num_tobacco_label.TabIndex = 171;
			this.num_tobacco_label.Text = "99";
			this.num_tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			this.num_corn_label.BackColor = Color.Yellow;
			this.num_corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label numCornLabel = this.num_corn_label;
			point = new Point(294, 264);
			numCornLabel.Location = point;
			this.num_corn_label.Name = "num_corn_label";
			Label numCornLabel1 = this.num_corn_label;
			size = new Size(36, 32);
			numCornLabel1.Size = size;
			this.num_corn_label.TabIndex = 170;
			this.num_corn_label.Text = "99";
			this.num_corn_label.TextAlign = ContentAlignment.MiddleCenter;
			this.num_sugar_label.BackColor = Color.White;
			this.num_sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label numSugarLabel = this.num_sugar_label;
			point = new Point(238, 264);
			numSugarLabel.Location = point;
			this.num_sugar_label.Name = "num_sugar_label";
			Label numSugarLabel1 = this.num_sugar_label;
			size = new Size(36, 32);
			numSugarLabel1.Size = size;
			this.num_sugar_label.TabIndex = 169;
			this.num_sugar_label.Text = "99";
			this.num_sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			this.num_indigo_label.BackColor = Color.Blue;
			this.num_indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.num_indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label numIndigoLabel = this.num_indigo_label;
			point = new Point(182, 264);
			numIndigoLabel.Location = point;
			this.num_indigo_label.Name = "num_indigo_label";
			Label numIndigoLabel1 = this.num_indigo_label;
			size = new Size(36, 32);
			numIndigoLabel1.Size = size;
			this.num_indigo_label.TabIndex = 168;
			this.num_indigo_label.Text = "99";
			this.num_indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			Button p3CloseButton = this.p3_close_button;
			point = new Point(210, 570);
			p3CloseButton.Location = point;
			this.p3_close_button.Name = "p3_close_button";
			this.p3_close_button.TabIndex = 167;
			this.p3_close_button.Text = "Close";
			this.build_p3_slot11.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot11.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot11 = this.build_p3_slot11;
			point = new Point(376, 118);
			buildP3Slot11.Location = point;
			this.build_p3_slot11.Name = "build_p3_slot11";
			PictureBox buildP3Slot111 = this.build_p3_slot11;
			size = new Size(114, 64);
			buildP3Slot111.Size = size;
			this.build_p3_slot11.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot11.TabIndex = 192;
			this.build_p3_slot11.TabStop = false;
			this.build_p3_slot11.Visible = false;
			this.build_p3_slot10.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot10.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot10 = this.build_p3_slot10;
			point = new Point(376, 50);
			buildP3Slot10.Location = point;
			this.build_p3_slot10.Name = "build_p3_slot10";
			PictureBox buildP3Slot101 = this.build_p3_slot10;
			size = new Size(114, 64);
			buildP3Slot101.Size = size;
			this.build_p3_slot10.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot10.TabIndex = 191;
			this.build_p3_slot10.TabStop = false;
			this.build_p3_slot10.Visible = false;
			this.build_p3_slot8.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot8.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot8 = this.build_p3_slot8;
			point = new Point(260, 118);
			buildP3Slot8.Location = point;
			this.build_p3_slot8.Name = "build_p3_slot8";
			PictureBox buildP3Slot81 = this.build_p3_slot8;
			size = new Size(114, 64);
			buildP3Slot81.Size = size;
			this.build_p3_slot8.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot8.TabIndex = 190;
			this.build_p3_slot8.TabStop = false;
			this.build_p3_slot8.Visible = false;
			this.build_p3_slot7.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot7.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot7 = this.build_p3_slot7;
			point = new Point(260, 50);
			buildP3Slot7.Location = point;
			this.build_p3_slot7.Name = "build_p3_slot7";
			PictureBox buildP3Slot71 = this.build_p3_slot7;
			size = new Size(114, 64);
			buildP3Slot71.Size = size;
			this.build_p3_slot7.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot7.TabIndex = 189;
			this.build_p3_slot7.TabStop = false;
			this.build_p3_slot7.Visible = false;
			this.build_p3_slot5.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot5.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot5 = this.build_p3_slot5;
			point = new Point(144, 118);
			buildP3Slot5.Location = point;
			this.build_p3_slot5.Name = "build_p3_slot5";
			PictureBox buildP3Slot51 = this.build_p3_slot5;
			size = new Size(114, 64);
			buildP3Slot51.Size = size;
			this.build_p3_slot5.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot5.TabIndex = 188;
			this.build_p3_slot5.TabStop = false;
			this.build_p3_slot5.Visible = false;
			this.build_p3_slot4.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot4.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot4 = this.build_p3_slot4;
			point = new Point(144, 50);
			buildP3Slot4.Location = point;
			this.build_p3_slot4.Name = "build_p3_slot4";
			PictureBox buildP3Slot41 = this.build_p3_slot4;
			size = new Size(114, 64);
			buildP3Slot41.Size = size;
			this.build_p3_slot4.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot4.TabIndex = 187;
			this.build_p3_slot4.TabStop = false;
			this.build_p3_slot4.Visible = false;
			this.build_p3_slot2.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot2.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot2 = this.build_p3_slot2;
			point = new Point(28, 118);
			buildP3Slot2.Location = point;
			this.build_p3_slot2.Name = "build_p3_slot2";
			PictureBox buildP3Slot21 = this.build_p3_slot2;
			size = new Size(114, 64);
			buildP3Slot21.Size = size;
			this.build_p3_slot2.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot2.TabIndex = 186;
			this.build_p3_slot2.TabStop = false;
			this.build_p3_slot2.Visible = false;
			this.build_p3_slot1.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot1.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot1 = this.build_p3_slot1;
			point = new Point(28, 50);
			buildP3Slot1.Location = point;
			this.build_p3_slot1.Name = "build_p3_slot1";
			PictureBox buildP3Slot12 = this.build_p3_slot1;
			size = new Size(114, 64);
			buildP3Slot12.Size = size;
			this.build_p3_slot1.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot1.TabIndex = 185;
			this.build_p3_slot1.TabStop = false;
			this.build_p3_slot1.Visible = false;
			this.build_p3_slot12.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot12.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot121 = this.build_p3_slot12;
			point = new Point(376, 186);
			buildP3Slot121.Location = point;
			this.build_p3_slot12.Name = "build_p3_slot12";
			PictureBox buildP3Slot122 = this.build_p3_slot12;
			size = new Size(114, 64);
			buildP3Slot122.Size = size;
			this.build_p3_slot12.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot12.TabIndex = 184;
			this.build_p3_slot12.TabStop = false;
			this.build_p3_slot12.Visible = false;
			this.build_p3_slot9.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot9.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot9 = this.build_p3_slot9;
			point = new Point(260, 186);
			buildP3Slot9.Location = point;
			this.build_p3_slot9.Name = "build_p3_slot9";
			PictureBox buildP3Slot91 = this.build_p3_slot9;
			size = new Size(114, 64);
			buildP3Slot91.Size = size;
			this.build_p3_slot9.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot9.TabIndex = 183;
			this.build_p3_slot9.TabStop = false;
			this.build_p3_slot9.Visible = false;
			this.build_p3_slot6.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot6.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot6 = this.build_p3_slot6;
			point = new Point(144, 186);
			buildP3Slot6.Location = point;
			this.build_p3_slot6.Name = "build_p3_slot6";
			PictureBox buildP3Slot61 = this.build_p3_slot6;
			size = new Size(114, 64);
			buildP3Slot61.Size = size;
			this.build_p3_slot6.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot6.TabIndex = 182;
			this.build_p3_slot6.TabStop = false;
			this.build_p3_slot6.Visible = false;
			this.build_p3_slot3.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot3.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot3 = this.build_p3_slot3;
			point = new Point(28, 186);
			buildP3Slot3.Location = point;
			this.build_p3_slot3.Name = "build_p3_slot3";
			PictureBox buildP3Slot31 = this.build_p3_slot3;
			size = new Size(114, 64);
			buildP3Slot31.Size = size;
			this.build_p3_slot3.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot3.TabIndex = 181;
			this.build_p3_slot3.TabStop = false;
			this.build_p3_slot3.Visible = false;
			this.build_p3_slot14.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot14.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot14 = this.build_p3_slot14;
			point = new Point(28, 118);
			buildP3Slot14.Location = point;
			this.build_p3_slot14.Name = "build_p3_slot14";
			PictureBox buildP3Slot141 = this.build_p3_slot14;
			size = new Size(114, 132);
			buildP3Slot141.Size = size;
			this.build_p3_slot14.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot14.TabIndex = 200;
			this.build_p3_slot14.TabStop = false;
			this.build_p3_slot14.Visible = false;
			this.build_p3_slot16.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot16.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot16 = this.build_p3_slot16;
			point = new Point(144, 118);
			buildP3Slot16.Location = point;
			this.build_p3_slot16.Name = "build_p3_slot16";
			PictureBox buildP3Slot161 = this.build_p3_slot16;
			size = new Size(114, 132);
			buildP3Slot161.Size = size;
			this.build_p3_slot16.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot16.TabIndex = 199;
			this.build_p3_slot16.TabStop = false;
			this.build_p3_slot16.Visible = false;
			this.build_p3_slot18.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot18.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot18 = this.build_p3_slot18;
			point = new Point(260, 118);
			buildP3Slot18.Location = point;
			this.build_p3_slot18.Name = "build_p3_slot18";
			PictureBox buildP3Slot181 = this.build_p3_slot18;
			size = new Size(114, 132);
			buildP3Slot181.Size = size;
			this.build_p3_slot18.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot18.TabIndex = 198;
			this.build_p3_slot18.TabStop = false;
			this.build_p3_slot18.Visible = false;
			this.build_p3_slot20.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot20.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot20 = this.build_p3_slot20;
			point = new Point(376, 118);
			buildP3Slot20.Location = point;
			this.build_p3_slot20.Name = "build_p3_slot20";
			PictureBox buildP3Slot201 = this.build_p3_slot20;
			size = new Size(114, 132);
			buildP3Slot201.Size = size;
			this.build_p3_slot20.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot20.TabIndex = 197;
			this.build_p3_slot20.TabStop = false;
			this.build_p3_slot20.Visible = false;
			this.build_p3_slot13.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot13.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot13 = this.build_p3_slot13;
			point = new Point(28, 50);
			buildP3Slot13.Location = point;
			this.build_p3_slot13.Name = "build_p3_slot13";
			PictureBox buildP3Slot131 = this.build_p3_slot13;
			size = new Size(114, 132);
			buildP3Slot131.Size = size;
			this.build_p3_slot13.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot13.TabIndex = 196;
			this.build_p3_slot13.TabStop = false;
			this.build_p3_slot13.Visible = false;
			this.build_p3_slot15.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot15.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot15 = this.build_p3_slot15;
			point = new Point(144, 50);
			buildP3Slot15.Location = point;
			this.build_p3_slot15.Name = "build_p3_slot15";
			PictureBox buildP3Slot151 = this.build_p3_slot15;
			size = new Size(114, 132);
			buildP3Slot151.Size = size;
			this.build_p3_slot15.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot15.TabIndex = 195;
			this.build_p3_slot15.TabStop = false;
			this.build_p3_slot15.Visible = false;
			this.build_p3_slot17.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot17.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot17 = this.build_p3_slot17;
			point = new Point(260, 50);
			buildP3Slot17.Location = point;
			this.build_p3_slot17.Name = "build_p3_slot17";
			PictureBox buildP3Slot171 = this.build_p3_slot17;
			size = new Size(114, 132);
			buildP3Slot171.Size = size;
			this.build_p3_slot17.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot17.TabIndex = 194;
			this.build_p3_slot17.TabStop = false;
			this.build_p3_slot17.Visible = false;
			this.build_p3_slot19.BackColor=SystemColors.ActiveCaption;
			this.build_p3_slot19.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot19 = this.build_p3_slot19;
			point = new Point(376, 50);
			buildP3Slot19.Location = point;
			this.build_p3_slot19.Name = "build_p3_slot19";
			PictureBox buildP3Slot191 = this.build_p3_slot19;
			size = new Size(114, 132);
			buildP3Slot191.Size = size;
			this.build_p3_slot19.SizeMode=PictureBoxSizeMode.AutoSize;
			this.build_p3_slot19.TabIndex = 193;
			this.build_p3_slot19.TabStop = false;
			this.build_p3_slot19.Visible = false;
			Button button1 = this.Button1;
			point = new Point(20, 586);
			button1.Location = point;
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 201;
			this.Button1.Text = "Points";
			size = new Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new Size(512, 610);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.build_p3_slot14);
			this.Controls.Add(this.build_p3_slot16);
			this.Controls.Add(this.build_p3_slot18);
			this.Controls.Add(this.build_p3_slot20);
			this.Controls.Add(this.build_p3_slot13);
			this.Controls.Add(this.build_p3_slot15);
			this.Controls.Add(this.build_p3_slot17);
			this.Controls.Add(this.build_p3_slot19);
			this.Controls.Add(this.build_p3_slot11);
			this.Controls.Add(this.build_p3_slot10);
			this.Controls.Add(this.build_p3_slot8);
			this.Controls.Add(this.build_p3_slot7);
			this.Controls.Add(this.build_p3_slot5);
			this.Controls.Add(this.build_p3_slot4);
			this.Controls.Add(this.build_p3_slot2);
			this.Controls.Add(this.build_p3_slot1);
			this.Controls.Add(this.build_p3_slot12);
			this.Controls.Add(this.build_p3_slot9);
			this.Controls.Add(this.build_p3_slot6);
			this.Controls.Add(this.build_p3_slot3);
			this.Controls.Add(this.governor_pic);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.vp_chips_label);
			this.Controls.Add(this.vp_total_label);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.gold_label);
			this.Controls.Add(this.idle_colonists_label);
			this.Controls.Add(this.num_coffee_label);
			this.Controls.Add(this.num_tobacco_label);
			this.Controls.Add(this.num_corn_label);
			this.Controls.Add(this.num_sugar_label);
			this.Controls.Add(this.num_indigo_label);
			this.Controls.Add(this.p3_close_button);
			this.Controls.Add(this.plant_p3_slot12);
			this.Controls.Add(this.plant_p3_slot11);
			this.Controls.Add(this.plant_p3_slot10);
			this.Controls.Add(this.plant_p3_slot9);
			this.Controls.Add(this.plant_p3_slot8);
			this.Controls.Add(this.plant_p3_slot7);
			this.Controls.Add(this.plant_p3_slot6);
			this.Controls.Add(this.plant_p3_slot5);
			this.Controls.Add(this.plant_p3_slot4);
			this.Controls.Add(this.plant_p3_slot3);
			this.Controls.Add(this.plant_p3_slot2);
			this.Controls.Add(this.plant_p3_slot1);
			this.Controls.Add(this.player_board_pic);
			size = new Size(520, 648);
			this.MaximumSize = size;
			size = new Size(520, 648);
			this.MinimumSize = size;
			this.Name = "Player3";
			this.Text = "Player3";
			this.ResumeLayout(false);
		}

		private void p3_close_button_Click(object sender, EventArgs e)
		{
			this.Visible = false;
		}
	}
}