using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Player4 : Form
	{
		[AccessedThroughProperty("build_p4_slot6")]
		private PictureBox _build_p4_slot6;

		[AccessedThroughProperty("build_p4_slot9")]
		private PictureBox _build_p4_slot9;

		[AccessedThroughProperty("build_p4_slot12")]
		private PictureBox _build_p4_slot12;

		[AccessedThroughProperty("build_p4_slot1")]
		private PictureBox _build_p4_slot1;

		[AccessedThroughProperty("build_p4_slot2")]
		private PictureBox _build_p4_slot2;

		[AccessedThroughProperty("build_p4_slot4")]
		private PictureBox _build_p4_slot4;

		[AccessedThroughProperty("build_p4_slot5")]
		private PictureBox _build_p4_slot5;

		[AccessedThroughProperty("build_p4_slot7")]
		private PictureBox _build_p4_slot7;

		[AccessedThroughProperty("player_board_pic")]
		private PictureBox _player_board_pic;

		[AccessedThroughProperty("build_p4_slot8")]
		private PictureBox _build_p4_slot8;

		[AccessedThroughProperty("build_p4_slot10")]
		private PictureBox _build_p4_slot10;

		[AccessedThroughProperty("build_p4_slot11")]
		private PictureBox _build_p4_slot11;

		[AccessedThroughProperty("p4_close_button")]
		private Button _p4_close_button;

		[AccessedThroughProperty("plant_p4_slot1")]
		private PictureBox _plant_p4_slot1;

		[AccessedThroughProperty("plant_p4_slot2")]
		private PictureBox _plant_p4_slot2;

		[AccessedThroughProperty("plant_p4_slot3")]
		private PictureBox _plant_p4_slot3;

		[AccessedThroughProperty("gold_label")]
		private Label _gold_label;

		[AccessedThroughProperty("num_indigo_label")]
		private Label _num_indigo_label;

		[AccessedThroughProperty("build_p4_slot14")]
		private PictureBox _build_p4_slot14;

		[AccessedThroughProperty("build_p4_slot16")]
		private PictureBox _build_p4_slot16;

		[AccessedThroughProperty("build_p4_slot18")]
		private PictureBox _build_p4_slot18;

		[AccessedThroughProperty("build_p4_slot20")]
		private PictureBox _build_p4_slot20;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("build_p4_slot13")]
		private PictureBox _build_p4_slot13;

		[AccessedThroughProperty("build_p4_slot15")]
		private PictureBox _build_p4_slot15;

		[AccessedThroughProperty("build_p4_slot17")]
		private PictureBox _build_p4_slot17;

		[AccessedThroughProperty("plant_p4_slot4")]
		private PictureBox _plant_p4_slot4;

		[AccessedThroughProperty("build_p4_slot19")]
		private PictureBox _build_p4_slot19;

		[AccessedThroughProperty("governor_pic")]
		private PictureBox _governor_pic;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("build_p4_slot3")]
		private PictureBox _build_p4_slot3;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("num_sugar_label")]
		private Label _num_sugar_label;

		[AccessedThroughProperty("plant_p4_slot12")]
		private PictureBox _plant_p4_slot12;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("plant_p4_slot11")]
		private PictureBox _plant_p4_slot11;

		[AccessedThroughProperty("vp_chips_label")]
		private Label _vp_chips_label;

		[AccessedThroughProperty("plant_p4_slot5")]
		private PictureBox _plant_p4_slot5;

		[AccessedThroughProperty("plant_p4_slot10")]
		private PictureBox _plant_p4_slot10;

		[AccessedThroughProperty("vp_total_label")]
		private Label _vp_total_label;

		[AccessedThroughProperty("plant_p4_slot9")]
		private PictureBox _plant_p4_slot9;

		[AccessedThroughProperty("idle_colonists_label")]
		private Label _idle_colonists_label;

		[AccessedThroughProperty("plant_p4_slot8")]
		private PictureBox _plant_p4_slot8;

		[AccessedThroughProperty("num_coffee_label")]
		private Label _num_coffee_label;

		[AccessedThroughProperty("plant_p4_slot7")]
		private PictureBox _plant_p4_slot7;

		[AccessedThroughProperty("num_tobacco_label")]
		private Label _num_tobacco_label;

		[AccessedThroughProperty("num_corn_label")]
		private Label _num_corn_label;

		[AccessedThroughProperty("plant_p4_slot6")]
		private PictureBox _plant_p4_slot6;

		private IContainer components;

		internal virtual PictureBox build_p4_slot1
		{
			get
			{
				return _build_p4_slot1;
			}
			set
			{
				_build_p4_slot1 = value;
			}
		}

		internal virtual PictureBox build_p4_slot10
		{
			get
			{
				return _build_p4_slot10;
			}
			set
			{
				_build_p4_slot10 = value;
			}
		}

		internal virtual PictureBox build_p4_slot11
		{
			get
			{
				return _build_p4_slot11;
			}
			set
			{
				_build_p4_slot11 = value;
			}
		}

		internal virtual PictureBox build_p4_slot12
		{
			get
			{
				return _build_p4_slot12;
			}
			set
			{
				_build_p4_slot12 = value;
			}
		}

		internal virtual PictureBox build_p4_slot13
		{
			get
			{
				return _build_p4_slot13;
			}
			set
			{
				_build_p4_slot13 = value;
			}
		}

		internal virtual PictureBox build_p4_slot14
		{
			get
			{
				return _build_p4_slot14;
			}
			set
			{
				_build_p4_slot14 = value;
			}
		}

		internal virtual PictureBox build_p4_slot15
		{
			get
			{
				return _build_p4_slot15;
			}
			set
			{
				_build_p4_slot15 = value;
			}
		}

		internal virtual PictureBox build_p4_slot16
		{
			get
			{
				return _build_p4_slot16;
			}
			set
			{
				_build_p4_slot16 = value;
			}
		}

		internal virtual PictureBox build_p4_slot17
		{
			get
			{
				return _build_p4_slot17;
			}
			set
			{
				_build_p4_slot17 = value;
			}
		}

		internal virtual PictureBox build_p4_slot18
		{
			get
			{
				return _build_p4_slot18;
			}
			set
			{
				_build_p4_slot18 = value;
			}
		}

		internal virtual PictureBox build_p4_slot19
		{
			get
			{
				return _build_p4_slot19;
			}
			set
			{
				_build_p4_slot19 = value;
			}
		}

		internal virtual PictureBox build_p4_slot2
		{
			get
			{
				return _build_p4_slot2;
			}
			set
			{
				_build_p4_slot2 = value;
			}
		}

		internal virtual PictureBox build_p4_slot20
		{
			get
			{
				return _build_p4_slot20;
			}
			set
			{
				_build_p4_slot20 = value;
			}
		}

		internal virtual PictureBox build_p4_slot3
		{
			get
			{
				return _build_p4_slot3;
			}
			set
			{
				_build_p4_slot3 = value;
			}
		}

		internal virtual PictureBox build_p4_slot4
		{
			get
			{
				return _build_p4_slot4;
			}
			set
			{
				_build_p4_slot4 = value;
			}
		}

		internal virtual PictureBox build_p4_slot5
		{
			get
			{
				return _build_p4_slot5;
			}
			set
			{
				_build_p4_slot5 = value;
			}
		}

		internal virtual PictureBox build_p4_slot6
		{
			get
			{
				return _build_p4_slot6;
			}
			set
			{
				_build_p4_slot6 = value;
			}
		}

		internal virtual PictureBox build_p4_slot7
		{
			get
			{
				return _build_p4_slot7;
			}
			set
			{
				_build_p4_slot7 = value;
			}
		}

		internal virtual PictureBox build_p4_slot8
		{
			get
			{
				return _build_p4_slot8;
			}
			set
			{
				_build_p4_slot8 = value;
			}
		}

		internal virtual PictureBox build_p4_slot9
		{
			get
			{
				return _build_p4_slot9;
			}
			set
			{
				_build_p4_slot9 = value;
			}
		}

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
					Player4 player4 = this;
					_Button1.Click -=new EventHandler(player4.Button1_Click);
				}
				_Button1 = value;
				if (_Button1 != null)
				{
					Player4 player41 = this;
					_Button1.Click +=new EventHandler(player41.Button1_Click);
				}
			}
		}

		internal virtual Label gold_label
		{
			get
			{
				return _gold_label;
			}
			set
			{
				_gold_label = value;
			}
		}

		internal virtual PictureBox governor_pic
		{
			get
			{
				return _governor_pic;
			}
			set
			{
				_governor_pic = value;
			}
		}

		internal virtual Label idle_colonists_label
		{
			get
			{
				return _idle_colonists_label;
			}
			set
			{
				_idle_colonists_label = value;
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

		internal virtual Label Label4
		{
			get
			{
				return _Label4;
			}
			set
			{
				_Label4 = value;
			}
		}

		internal virtual Label Label5
		{
			get
			{
				return _Label5;
			}
			set
			{
				_Label5 = value;
			}
		}

		internal virtual Label num_coffee_label
		{
			get
			{
				return _num_coffee_label;
			}
			set
			{
				_num_coffee_label = value;
			}
		}

		internal virtual Label num_corn_label
		{
			get
			{
				return _num_corn_label;
			}
			set
			{
				_num_corn_label = value;
			}
		}

		internal virtual Label num_indigo_label
		{
			get
			{
				return _num_indigo_label;
			}
			set
			{
				_num_indigo_label = value;
			}
		}

		internal virtual Label num_sugar_label
		{
			get
			{
				return _num_sugar_label;
			}
			set
			{
				_num_sugar_label = value;
			}
		}

		internal virtual Label num_tobacco_label
		{
			get
			{
				return _num_tobacco_label;
			}
			set
			{
				_num_tobacco_label = value;
			}
		}

		internal virtual Button p4_close_button
		{
			get
			{
				return _p4_close_button;
			}
			set
			{
				if (_p4_close_button != null)
				{
					Player4 player4 = this;
					_p4_close_button.Click -=new EventHandler(player4.p4_close_button_Click);
				}
				_p4_close_button = value;
				if (_p4_close_button != null)
				{
					Player4 player41 = this;
					_p4_close_button.Click +=new EventHandler(player41.p4_close_button_Click);
				}
			}
		}

		internal virtual PictureBox plant_p4_slot1
		{
			get
			{
				return _plant_p4_slot1;
			}
			set
			{
				_plant_p4_slot1 = value;
			}
		}

		internal virtual PictureBox plant_p4_slot10
		{
			get
			{
				return _plant_p4_slot10;
			}
			set
			{
				_plant_p4_slot10 = value;
			}
		}

		internal virtual PictureBox plant_p4_slot11
		{
			get
			{
				return _plant_p4_slot11;
			}
			set
			{
				_plant_p4_slot11 = value;
			}
		}

		internal virtual PictureBox plant_p4_slot12
		{
			get
			{
				return _plant_p4_slot12;
			}
			set
			{
				_plant_p4_slot12 = value;
			}
		}

		internal virtual PictureBox plant_p4_slot2
		{
			get
			{
				return _plant_p4_slot2;
			}
			set
			{
				_plant_p4_slot2 = value;
			}
		}

		internal virtual PictureBox plant_p4_slot3
		{
			get
			{
				return _plant_p4_slot3;
			}
			set
			{
				_plant_p4_slot3 = value;
			}
		}

		internal virtual PictureBox plant_p4_slot4
		{
			get
			{
				return _plant_p4_slot4;
			}
			set
			{
				_plant_p4_slot4 = value;
			}
		}

		internal virtual PictureBox plant_p4_slot5
		{
			get
			{
				return _plant_p4_slot5;
			}
			set
			{
				_plant_p4_slot5 = value;
			}
		}

		internal virtual PictureBox plant_p4_slot6
		{
			get
			{
				return _plant_p4_slot6;
			}
			set
			{
				_plant_p4_slot6 = value;
			}
		}

		internal virtual PictureBox plant_p4_slot7
		{
			get
			{
				return _plant_p4_slot7;
			}
			set
			{
				_plant_p4_slot7 = value;
			}
		}

		internal virtual PictureBox plant_p4_slot8
		{
			get
			{
				return _plant_p4_slot8;
			}
			set
			{
				_plant_p4_slot8 = value;
			}
		}

		internal virtual PictureBox plant_p4_slot9
		{
			get
			{
				return _plant_p4_slot9;
			}
			set
			{
				_plant_p4_slot9 = value;
			}
		}

		internal virtual PictureBox player_board_pic
		{
			get
			{
				return _player_board_pic;
			}
			set
			{
				_player_board_pic = value;
			}
		}

		internal virtual Label vp_chips_label
		{
			get
			{
				return _vp_chips_label;
			}
			set
			{
				_vp_chips_label = value;
			}
		}

		internal virtual Label vp_total_label
		{
			get
			{
				return _vp_total_label;
			}
			set
			{
				_vp_total_label = value;
			}
		}

		public Player4()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (!vp_chips_label.Visible)
			{
				vp_chips_label.Visible = true;
				vp_total_label.Visible = true;
				Label4.Visible = true;
				Label5.Visible = true;
			}
			else
			{
				vp_chips_label.Visible = false;
				vp_total_label.Visible = false;
				Label4.Visible = false;
				Label5.Visible = false;
			}
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
			ResourceManager resourceManager = new ResourceManager(typeof(Player4));
			player_board_pic = new PictureBox();
			plant_p4_slot12 = new PictureBox();
			plant_p4_slot11 = new PictureBox();
			plant_p4_slot10 = new PictureBox();
			plant_p4_slot9 = new PictureBox();
			plant_p4_slot8 = new PictureBox();
			plant_p4_slot7 = new PictureBox();
			plant_p4_slot6 = new PictureBox();
			plant_p4_slot5 = new PictureBox();
			plant_p4_slot4 = new PictureBox();
			plant_p4_slot3 = new PictureBox();
			plant_p4_slot2 = new PictureBox();
			plant_p4_slot1 = new PictureBox();
			governor_pic = new PictureBox();
			Label5 = new Label();
			Label4 = new Label();
			vp_chips_label = new Label();
			vp_total_label = new Label();
			Label1 = new Label();
			gold_label = new Label();
			idle_colonists_label = new Label();
			num_coffee_label = new Label();
			num_tobacco_label = new Label();
			num_corn_label = new Label();
			num_sugar_label = new Label();
			num_indigo_label = new Label();
			p4_close_button = new Button();
			build_p4_slot11 = new PictureBox();
			build_p4_slot10 = new PictureBox();
			build_p4_slot8 = new PictureBox();
			build_p4_slot7 = new PictureBox();
			build_p4_slot5 = new PictureBox();
			build_p4_slot4 = new PictureBox();
			build_p4_slot2 = new PictureBox();
			build_p4_slot1 = new PictureBox();
			build_p4_slot12 = new PictureBox();
			build_p4_slot9 = new PictureBox();
			build_p4_slot6 = new PictureBox();
			build_p4_slot3 = new PictureBox();
			build_p4_slot14 = new PictureBox();
			build_p4_slot16 = new PictureBox();
			build_p4_slot18 = new PictureBox();
			build_p4_slot20 = new PictureBox();
			build_p4_slot13 = new PictureBox();
			build_p4_slot15 = new PictureBox();
			build_p4_slot17 = new PictureBox();
			build_p4_slot19 = new PictureBox();
			Button1 = new Button();
			SuspendLayout();
			player_board_pic.Image = (Image)resourceManager.GetObject("player_board_pic.Image");
			PictureBox playerBoardPic = player_board_pic;
			Point point = new Point(0, 0);
			playerBoardPic.Location = point;
			player_board_pic.Name = "player_board_pic";
			PictureBox pictureBox = player_board_pic;
			Size size = new Size(824, 624);
			pictureBox.Size = size;
			player_board_pic.SizeMode = PictureBoxSizeMode.CenterImage;
			player_board_pic.TabIndex=3;
			player_board_pic.TabStop = false;
			plant_p4_slot12.BackColor=SystemColors.ActiveCaption;
			plant_p4_slot12.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP4Slot12 = plant_p4_slot12;
			point = new Point(410, 404);
			plantP4Slot12.Location = point;
			plant_p4_slot12.Name = "plant_p4_slot12";
			PictureBox plantP4Slot121 = plant_p4_slot12;
			size = new Size(72, 74);
			plantP4Slot121.Size = size;
			plant_p4_slot12.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p4_slot12.TabIndex = 148;
			plant_p4_slot12.TabStop = false;
			plant_p4_slot12.Visible = false;
			plant_p4_slot11.BackColor=SystemColors.ActiveCaption;
			plant_p4_slot11.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP4Slot11 = plant_p4_slot11;
			point = new Point(334, 446);
			plantP4Slot11.Location = point;
			plant_p4_slot11.Name = "plant_p4_slot11";
			PictureBox plantP4Slot111 = plant_p4_slot11;
			size = new Size(72, 74);
			plantP4Slot111.Size = size;
			plant_p4_slot11.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p4_slot11.TabIndex = 147;
			plant_p4_slot11.TabStop = false;
			plant_p4_slot11.Visible = false;
			plant_p4_slot10.BackColor=SystemColors.ActiveCaption;
			plant_p4_slot10.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP4Slot10 = plant_p4_slot10;
			point = new Point(334, 370);
			plantP4Slot10.Location = point;
			plant_p4_slot10.Name = "plant_p4_slot10";
			PictureBox plantP4Slot101 = plant_p4_slot10;
			size = new Size(72, 74);
			plantP4Slot101.Size = size;
			plant_p4_slot10.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p4_slot10.TabIndex = 146;
			plant_p4_slot10.TabStop = false;
			plant_p4_slot10.Visible = false;
			plant_p4_slot9.BackColor=SystemColors.ActiveCaption;
			plant_p4_slot9.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP4Slot9 = plant_p4_slot9;
			point = new Point(258, 486);
			plantP4Slot9.Location = point;
			plant_p4_slot9.Name = "plant_p4_slot9";
			PictureBox plantP4Slot91 = plant_p4_slot9;
			size = new Size(72, 74);
			plantP4Slot91.Size = size;
			plant_p4_slot9.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p4_slot9.TabIndex = 145;
			plant_p4_slot9.TabStop = false;
			plant_p4_slot9.Visible = false;
			plant_p4_slot8.BackColor=SystemColors.ActiveCaption;
			plant_p4_slot8.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP4Slot8 = plant_p4_slot8;
			point = new Point(258, 410);
			plantP4Slot8.Location = point;
			plant_p4_slot8.Name = "plant_p4_slot8";
			PictureBox plantP4Slot81 = plant_p4_slot8;
			size = new Size(72, 74);
			plantP4Slot81.Size = size;
			plant_p4_slot8.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p4_slot8.TabIndex = 144;
			plant_p4_slot8.TabStop = false;
			plant_p4_slot8.Visible = false;
			plant_p4_slot7.BackColor=SystemColors.ActiveCaption;
			plant_p4_slot7.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP4Slot7 = plant_p4_slot7;
			point = new Point(258, 332);
			plantP4Slot7.Location = point;
			plant_p4_slot7.Name = "plant_p4_slot7";
			PictureBox plantP4Slot71 = plant_p4_slot7;
			size = new Size(72, 74);
			plantP4Slot71.Size = size;
			plant_p4_slot7.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p4_slot7.TabIndex = 143;
			plant_p4_slot7.TabStop = false;
			plant_p4_slot7.Visible = false;
			plant_p4_slot6.BackColor=SystemColors.ActiveCaption;
			plant_p4_slot6.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP4Slot6 = plant_p4_slot6;
			point = new Point(182, 462);
			plantP4Slot6.Location = point;
			plant_p4_slot6.Name = "plant_p4_slot6";
			PictureBox plantP4Slot61 = plant_p4_slot6;
			size = new Size(72, 74);
			plantP4Slot61.Size = size;
			plant_p4_slot6.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p4_slot6.TabIndex = 142;
			plant_p4_slot6.TabStop = false;
			plant_p4_slot6.Visible = false;
			plant_p4_slot5.BackColor=SystemColors.ActiveCaption;
			plant_p4_slot5.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP4Slot5 = plant_p4_slot5;
			point = new Point(182, 386);
			plantP4Slot5.Location = point;
			plant_p4_slot5.Name = "plant_p4_slot5";
			PictureBox plantP4Slot51 = plant_p4_slot5;
			size = new Size(72, 74);
			plantP4Slot51.Size = size;
			plant_p4_slot5.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p4_slot5.TabIndex = 141;
			plant_p4_slot5.TabStop = false;
			plant_p4_slot5.Visible = false;
			plant_p4_slot4.BackColor=SystemColors.ActiveCaption;
			plant_p4_slot4.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP4Slot4 = plant_p4_slot4;
			point = new Point(182, 308);
			plantP4Slot4.Location = point;
			plant_p4_slot4.Name = "plant_p4_slot4";
			PictureBox plantP4Slot41 = plant_p4_slot4;
			size = new Size(72, 74);
			plantP4Slot41.Size = size;
			plant_p4_slot4.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p4_slot4.TabIndex = 140;
			plant_p4_slot4.TabStop = false;
			plant_p4_slot4.Visible = false;
			plant_p4_slot3.BackColor=SystemColors.ActiveCaption;
			plant_p4_slot3.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP4Slot3 = plant_p4_slot3;
			point = new Point(106, 496);
			plantP4Slot3.Location = point;
			plant_p4_slot3.Name = "plant_p4_slot3";
			PictureBox plantP4Slot31 = plant_p4_slot3;
			size = new Size(72, 74);
			plantP4Slot31.Size = size;
			plant_p4_slot3.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p4_slot3.TabIndex = 139;
			plant_p4_slot3.TabStop = false;
			plant_p4_slot3.Visible = false;
			plant_p4_slot2.BackColor=SystemColors.ActiveCaption;
			plant_p4_slot2.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP4Slot2 = plant_p4_slot2;
			point = new Point(106, 420);
			plantP4Slot2.Location = point;
			plant_p4_slot2.Name = "plant_p4_slot2";
			PictureBox plantP4Slot21 = plant_p4_slot2;
			size = new Size(72, 74);
			plantP4Slot21.Size = size;
			plant_p4_slot2.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p4_slot2.TabIndex = 138;
			plant_p4_slot2.TabStop = false;
			plant_p4_slot2.Visible = false;
			plant_p4_slot1.BackColor=SystemColors.ActiveCaption;
			plant_p4_slot1.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP4Slot1 = plant_p4_slot1;
			point = new Point(106, 342);
			plantP4Slot1.Location = point;
			plant_p4_slot1.Name = "plant_p4_slot1";
			PictureBox pictureBox1 = plant_p4_slot1;
			size = new Size(72, 74);
			pictureBox1.Size = size;
			plant_p4_slot1.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p4_slot1.TabIndex = 137;
			plant_p4_slot1.TabStop = false;
			plant_p4_slot1.Visible = false;
			governor_pic.Image = (Image)resourceManager.GetObject("governor_pic.Image");
			PictureBox governorPic = governor_pic;
			point = new Point(424, 512);
			governorPic.Location = point;
			governor_pic.Name = "governor_pic";
			PictureBox governorPic1 = governor_pic;
			size = new Size(52, 72);
			governorPic1.Size = size;
			governor_pic.SizeMode=PictureBoxSizeMode.AutoSize;
			governor_pic.TabIndex = 180;
			governor_pic.TabStop = false;
			Label5.Font = new Font("Comic Sans MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label5 = Label5;
			point = new Point(20, 564);
			label5.Location = point;
			Label5.Name = "Label5";
			Label label = Label5;
			size = new Size(72, 16);
			label.Size = size;
			Label5.TabIndex = 179;
			Label5.Text = "VP Total";
			Label5.TextAlign = ContentAlignment.MiddleCenter;
			Label5.Visible = false;
			Label4.Font = new Font("Comic Sans MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label4 = Label4;
			point = new Point(20, 492);
			label4.Location = point;
			Label4.Name = "Label4";
			Label label41 = Label4;
			size = new Size(72, 16);
			label41.Size = size;
			Label4.TabIndex = 178;
			Label4.Text = "VP Chips";
			Label4.TextAlign = ContentAlignment.MiddleCenter;
			Label4.Visible = false;
			vp_chips_label.BackColor = SystemColors.ActiveBorder;
			vp_chips_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label vpChipsLabel = vp_chips_label;
			point = new Point(36, 460);
			vpChipsLabel.Location = point;
			vp_chips_label.Name = "vp_chips_label";
			Label vpChipsLabel1 = vp_chips_label;
			size = new Size(36, 32);
			vpChipsLabel1.Size = size;
			vp_chips_label.TabIndex = 177;
			vp_chips_label.Text = "99";
			vp_chips_label.TextAlign = ContentAlignment.MiddleCenter;
			vp_chips_label.Visible = false;
			vp_total_label.BackColor = SystemColors.ActiveBorder;
			vp_total_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label vpTotalLabel = vp_total_label;
			point = new Point(36, 532);
			vpTotalLabel.Location = point;
			vp_total_label.Name = "vp_total_label";
			Label vpTotalLabel1 = vp_total_label;
			size = new Size(36, 32);
			vpTotalLabel1.Size = size;
			vp_total_label.TabIndex = 176;
			vp_total_label.Text = "99";
			vp_total_label.TextAlign = ContentAlignment.MiddleCenter;
			vp_total_label.Visible = false;
			Label1.Font = new Font("Comic Sans MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = Label1;
			point = new Point(20, 428);
			label1.Location = point;
			Label1.Name = "Label1";
			Label label11 = Label1;
			size = new Size(72, 16);
			label11.Size = size;
			Label1.TabIndex = 175;
			Label1.Text = "Doubloons";
			Label1.TextAlign = ContentAlignment.MiddleCenter;
			gold_label.BackColor = SystemColors.ActiveBorder;
			gold_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label goldLabel = gold_label;
			point = new Point(36, 396);
			goldLabel.Location = point;
			gold_label.Name = "gold_label";
			Label goldLabel1 = gold_label;
			size = new Size(36, 32);
			goldLabel1.Size = size;
			gold_label.TabIndex = 174;
			gold_label.Text = "99";
			gold_label.TextAlign = ContentAlignment.MiddleCenter;
			idle_colonists_label.BackColor = SystemColors.ActiveBorder;
			idle_colonists_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label idleColonistsLabel = idle_colonists_label;
			point = new Point(52, 284);
			idleColonistsLabel.Location = point;
			idle_colonists_label.Name = "idle_colonists_label";
			Label idleColonistsLabel1 = idle_colonists_label;
			size = new Size(36, 32);
			idleColonistsLabel1.Size = size;
			idle_colonists_label.TabIndex = 173;
			idle_colonists_label.Text = "99";
			idle_colonists_label.TextAlign = ContentAlignment.MiddleCenter;
			num_coffee_label.BackColor = Color.SaddleBrown;
			num_coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			num_coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label numCoffeeLabel = num_coffee_label;
			point = new Point(406, 264);
			numCoffeeLabel.Location = point;
			num_coffee_label.Name = "num_coffee_label";
			Label numCoffeeLabel1 = num_coffee_label;
			size = new Size(36, 32);
			numCoffeeLabel1.Size = size;
			num_coffee_label.TabIndex = 172;
			num_coffee_label.Text = "99";
			num_coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			num_tobacco_label.BackColor=Color.Goldenrod;
			num_tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label numTobaccoLabel = num_tobacco_label;
			point = new Point(350, 264);
			numTobaccoLabel.Location = point;
			num_tobacco_label.Name = "num_tobacco_label";
			Label numTobaccoLabel1 = num_tobacco_label;
			size = new Size(36, 32);
			numTobaccoLabel1.Size = size;
			num_tobacco_label.TabIndex = 171;
			num_tobacco_label.Text = "99";
			num_tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			num_corn_label.BackColor = Color.Yellow;
			num_corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label numCornLabel = num_corn_label;
			point = new Point(294, 264);
			numCornLabel.Location = point;
			num_corn_label.Name = "num_corn_label";
			Label numCornLabel1 = num_corn_label;
			size = new Size(36, 32);
			numCornLabel1.Size = size;
			num_corn_label.TabIndex = 170;
			num_corn_label.Text = "99";
			num_corn_label.TextAlign = ContentAlignment.MiddleCenter;
			num_sugar_label.BackColor = Color.White;
			num_sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label numSugarLabel = num_sugar_label;
			point = new Point(238, 264);
			numSugarLabel.Location = point;
			num_sugar_label.Name = "num_sugar_label";
			Label numSugarLabel1 = num_sugar_label;
			size = new Size(36, 32);
			numSugarLabel1.Size = size;
			num_sugar_label.TabIndex = 169;
			num_sugar_label.Text = "99";
			num_sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			num_indigo_label.BackColor = Color.Blue;
			num_indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			num_indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label numIndigoLabel = num_indigo_label;
			point = new Point(182, 264);
			numIndigoLabel.Location = point;
			num_indigo_label.Name = "num_indigo_label";
			Label numIndigoLabel1 = num_indigo_label;
			size = new Size(36, 32);
			numIndigoLabel1.Size = size;
			num_indigo_label.TabIndex = 168;
			num_indigo_label.Text = "99";
			num_indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			Button p4CloseButton = p4_close_button;
			point = new Point(210, 570);
			p4CloseButton.Location = point;
			p4_close_button.Name = "p4_close_button";
			p4_close_button.TabIndex = 167;
			p4_close_button.Text = "Close";
			build_p4_slot11.BackColor=SystemColors.ActiveCaption;
			build_p4_slot11.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot11 = build_p4_slot11;
			point = new Point(376, 118);
			buildP4Slot11.Location = point;
			build_p4_slot11.Name = "build_p4_slot11";
			PictureBox buildP4Slot111 = build_p4_slot11;
			size = new Size(114, 64);
			buildP4Slot111.Size = size;
			build_p4_slot11.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot11.TabIndex = 192;
			build_p4_slot11.TabStop = false;
			build_p4_slot11.Visible = false;
			build_p4_slot10.BackColor=SystemColors.ActiveCaption;
			build_p4_slot10.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot10 = build_p4_slot10;
			point = new Point(376, 50);
			buildP4Slot10.Location = point;
			build_p4_slot10.Name = "build_p4_slot10";
			PictureBox buildP4Slot101 = build_p4_slot10;
			size = new Size(114, 64);
			buildP4Slot101.Size = size;
			build_p4_slot10.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot10.TabIndex = 191;
			build_p4_slot10.TabStop = false;
			build_p4_slot10.Visible = false;
			build_p4_slot8.BackColor=SystemColors.ActiveCaption;
			build_p4_slot8.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot8 = build_p4_slot8;
			point = new Point(260, 118);
			buildP4Slot8.Location = point;
			build_p4_slot8.Name = "build_p4_slot8";
			PictureBox buildP4Slot81 = build_p4_slot8;
			size = new Size(114, 64);
			buildP4Slot81.Size = size;
			build_p4_slot8.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot8.TabIndex = 190;
			build_p4_slot8.TabStop = false;
			build_p4_slot8.Visible = false;
			build_p4_slot7.BackColor=SystemColors.ActiveCaption;
			build_p4_slot7.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot7 = build_p4_slot7;
			point = new Point(260, 50);
			buildP4Slot7.Location = point;
			build_p4_slot7.Name = "build_p4_slot7";
			PictureBox buildP4Slot71 = build_p4_slot7;
			size = new Size(114, 64);
			buildP4Slot71.Size = size;
			build_p4_slot7.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot7.TabIndex = 189;
			build_p4_slot7.TabStop = false;
			build_p4_slot7.Visible = false;
			build_p4_slot5.BackColor=SystemColors.ActiveCaption;
			build_p4_slot5.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot5 = build_p4_slot5;
			point = new Point(144, 118);
			buildP4Slot5.Location = point;
			build_p4_slot5.Name = "build_p4_slot5";
			PictureBox buildP4Slot51 = build_p4_slot5;
			size = new Size(114, 64);
			buildP4Slot51.Size = size;
			build_p4_slot5.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot5.TabIndex = 188;
			build_p4_slot5.TabStop = false;
			build_p4_slot5.Visible = false;
			build_p4_slot4.BackColor=SystemColors.ActiveCaption;
			build_p4_slot4.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot4 = build_p4_slot4;
			point = new Point(144, 50);
			buildP4Slot4.Location = point;
			build_p4_slot4.Name = "build_p4_slot4";
			PictureBox buildP4Slot41 = build_p4_slot4;
			size = new Size(114, 64);
			buildP4Slot41.Size = size;
			build_p4_slot4.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot4.TabIndex = 187;
			build_p4_slot4.TabStop = false;
			build_p4_slot4.Visible = false;
			build_p4_slot2.BackColor=SystemColors.ActiveCaption;
			build_p4_slot2.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot2 = build_p4_slot2;
			point = new Point(28, 118);
			buildP4Slot2.Location = point;
			build_p4_slot2.Name = "build_p4_slot2";
			PictureBox buildP4Slot21 = build_p4_slot2;
			size = new Size(114, 64);
			buildP4Slot21.Size = size;
			build_p4_slot2.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot2.TabIndex = 186;
			build_p4_slot2.TabStop = false;
			build_p4_slot2.Visible = false;
			build_p4_slot1.BackColor=SystemColors.ActiveCaption;
			build_p4_slot1.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot1 = build_p4_slot1;
			point = new Point(28, 50);
			buildP4Slot1.Location = point;
			build_p4_slot1.Name = "build_p4_slot1";
			PictureBox buildP4Slot12 = build_p4_slot1;
			size = new Size(114, 64);
			buildP4Slot12.Size = size;
			build_p4_slot1.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot1.TabIndex = 185;
			build_p4_slot1.TabStop = false;
			build_p4_slot1.Visible = false;
			build_p4_slot12.BackColor=SystemColors.ActiveCaption;
			build_p4_slot12.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot121 = build_p4_slot12;
			point = new Point(376, 186);
			buildP4Slot121.Location = point;
			build_p4_slot12.Name = "build_p4_slot12";
			PictureBox buildP4Slot122 = build_p4_slot12;
			size = new Size(114, 64);
			buildP4Slot122.Size = size;
			build_p4_slot12.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot12.TabIndex = 184;
			build_p4_slot12.TabStop = false;
			build_p4_slot12.Visible = false;
			build_p4_slot9.BackColor=SystemColors.ActiveCaption;
			build_p4_slot9.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot9 = build_p4_slot9;
			point = new Point(260, 186);
			buildP4Slot9.Location = point;
			build_p4_slot9.Name = "build_p4_slot9";
			PictureBox buildP4Slot91 = build_p4_slot9;
			size = new Size(114, 64);
			buildP4Slot91.Size = size;
			build_p4_slot9.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot9.TabIndex = 183;
			build_p4_slot9.TabStop = false;
			build_p4_slot9.Visible = false;
			build_p4_slot6.BackColor=SystemColors.ActiveCaption;
			build_p4_slot6.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot6 = build_p4_slot6;
			point = new Point(144, 186);
			buildP4Slot6.Location = point;
			build_p4_slot6.Name = "build_p4_slot6";
			PictureBox buildP4Slot61 = build_p4_slot6;
			size = new Size(114, 64);
			buildP4Slot61.Size = size;
			build_p4_slot6.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot6.TabIndex = 182;
			build_p4_slot6.TabStop = false;
			build_p4_slot6.Visible = false;
			build_p4_slot3.BackColor=SystemColors.ActiveCaption;
			build_p4_slot3.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot3 = build_p4_slot3;
			point = new Point(28, 186);
			buildP4Slot3.Location = point;
			build_p4_slot3.Name = "build_p4_slot3";
			PictureBox buildP4Slot31 = build_p4_slot3;
			size = new Size(114, 64);
			buildP4Slot31.Size = size;
			build_p4_slot3.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot3.TabIndex = 181;
			build_p4_slot3.TabStop = false;
			build_p4_slot3.Visible = false;
			build_p4_slot14.BackColor=SystemColors.ActiveCaption;
			build_p4_slot14.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot14 = build_p4_slot14;
			point = new Point(28, 118);
			buildP4Slot14.Location = point;
			build_p4_slot14.Name = "build_p4_slot14";
			PictureBox buildP4Slot141 = build_p4_slot14;
			size = new Size(114, 132);
			buildP4Slot141.Size = size;
			build_p4_slot14.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot14.TabIndex = 204;
			build_p4_slot14.TabStop = false;
			build_p4_slot14.Visible = false;
			build_p4_slot16.BackColor=SystemColors.ActiveCaption;
			build_p4_slot16.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot16 = build_p4_slot16;
			point = new Point(144, 118);
			buildP4Slot16.Location = point;
			build_p4_slot16.Name = "build_p4_slot16";
			PictureBox buildP4Slot161 = build_p4_slot16;
			size = new Size(114, 132);
			buildP4Slot161.Size = size;
			build_p4_slot16.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot16.TabIndex = 203;
			build_p4_slot16.TabStop = false;
			build_p4_slot16.Visible = false;
			build_p4_slot18.BackColor=SystemColors.ActiveCaption;
			build_p4_slot18.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot18 = build_p4_slot18;
			point = new Point(260, 118);
			buildP4Slot18.Location = point;
			build_p4_slot18.Name = "build_p4_slot18";
			PictureBox buildP4Slot181 = build_p4_slot18;
			size = new Size(114, 132);
			buildP4Slot181.Size = size;
			build_p4_slot18.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot18.TabIndex = 202;
			build_p4_slot18.TabStop = false;
			build_p4_slot18.Visible = false;
			build_p4_slot20.BackColor=SystemColors.ActiveCaption;
			build_p4_slot20.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot20 = build_p4_slot20;
			point = new Point(376, 118);
			buildP4Slot20.Location = point;
			build_p4_slot20.Name = "build_p4_slot20";
			PictureBox buildP4Slot201 = build_p4_slot20;
			size = new Size(114, 132);
			buildP4Slot201.Size = size;
			build_p4_slot20.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot20.TabIndex = 201;
			build_p4_slot20.TabStop = false;
			build_p4_slot20.Visible = false;
			build_p4_slot13.BackColor=SystemColors.ActiveCaption;
			build_p4_slot13.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot13 = build_p4_slot13;
			point = new Point(28, 50);
			buildP4Slot13.Location = point;
			build_p4_slot13.Name = "build_p4_slot13";
			PictureBox buildP4Slot131 = build_p4_slot13;
			size = new Size(114, 132);
			buildP4Slot131.Size = size;
			build_p4_slot13.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot13.TabIndex = 200;
			build_p4_slot13.TabStop = false;
			build_p4_slot13.Visible = false;
			build_p4_slot15.BackColor=SystemColors.ActiveCaption;
			build_p4_slot15.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot15 = build_p4_slot15;
			point = new Point(144, 50);
			buildP4Slot15.Location = point;
			build_p4_slot15.Name = "build_p4_slot15";
			PictureBox buildP4Slot151 = build_p4_slot15;
			size = new Size(114, 132);
			buildP4Slot151.Size = size;
			build_p4_slot15.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot15.TabIndex = 199;
			build_p4_slot15.TabStop = false;
			build_p4_slot15.Visible = false;
			build_p4_slot17.BackColor=SystemColors.ActiveCaption;
			build_p4_slot17.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot17 = build_p4_slot17;
			point = new Point(260, 50);
			buildP4Slot17.Location = point;
			build_p4_slot17.Name = "build_p4_slot17";
			PictureBox buildP4Slot171 = build_p4_slot17;
			size = new Size(114, 132);
			buildP4Slot171.Size = size;
			build_p4_slot17.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot17.TabIndex = 198;
			build_p4_slot17.TabStop = false;
			build_p4_slot17.Visible = false;
			build_p4_slot19.BackColor=SystemColors.ActiveCaption;
			build_p4_slot19.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP4Slot19 = build_p4_slot19;
			point = new Point(376, 50);
			buildP4Slot19.Location = point;
			build_p4_slot19.Name = "build_p4_slot19";
			PictureBox buildP4Slot191 = build_p4_slot19;
			size = new Size(114, 132);
			buildP4Slot191.Size = size;
			build_p4_slot19.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p4_slot19.TabIndex = 197;
			build_p4_slot19.TabStop = false;
			build_p4_slot19.Visible = false;
			Button button1 = Button1;
			point = new Point(20, 586);
			button1.Location = point;
			Button1.Name = "Button1";
			Button1.TabIndex = 205;
			Button1.Text = "Points";
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(512, 610);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(Button1);
			Controls.Add(build_p4_slot14);
			Controls.Add(build_p4_slot16);
			Controls.Add(build_p4_slot18);
			Controls.Add(build_p4_slot20);
			Controls.Add(build_p4_slot13);
			Controls.Add(build_p4_slot15);
			Controls.Add(build_p4_slot17);
			Controls.Add(build_p4_slot19);
			Controls.Add(build_p4_slot11);
			Controls.Add(build_p4_slot10);
			Controls.Add(build_p4_slot8);
			Controls.Add(build_p4_slot7);
			Controls.Add(build_p4_slot5);
			Controls.Add(build_p4_slot4);
			Controls.Add(build_p4_slot2);
			Controls.Add(build_p4_slot1);
			Controls.Add(build_p4_slot12);
			Controls.Add(build_p4_slot9);
			Controls.Add(build_p4_slot6);
			Controls.Add(build_p4_slot3);
			Controls.Add(governor_pic);
			Controls.Add(Label5);
			Controls.Add(Label4);
			Controls.Add(vp_chips_label);
			Controls.Add(vp_total_label);
			Controls.Add(Label1);
			Controls.Add(gold_label);
			Controls.Add(idle_colonists_label);
			Controls.Add(num_coffee_label);
			Controls.Add(num_tobacco_label);
			Controls.Add(num_corn_label);
			Controls.Add(num_sugar_label);
			Controls.Add(num_indigo_label);
			Controls.Add(p4_close_button);
			Controls.Add(plant_p4_slot12);
			Controls.Add(plant_p4_slot11);
			Controls.Add(plant_p4_slot10);
			Controls.Add(plant_p4_slot9);
			Controls.Add(plant_p4_slot8);
			Controls.Add(plant_p4_slot7);
			Controls.Add(plant_p4_slot6);
			Controls.Add(plant_p4_slot5);
			Controls.Add(plant_p4_slot4);
			Controls.Add(plant_p4_slot3);
			Controls.Add(plant_p4_slot2);
			Controls.Add(plant_p4_slot1);
			Controls.Add(player_board_pic);
			size = new Size(520, 648);
			MaximumSize = size;
			size = new Size(520, 648);
			MinimumSize = size;
			Name = "Player4";
			Text = "Player4";
			ResumeLayout(false);
		}

		private void p4_close_button_Click(object sender, EventArgs e)
		{
			Visible = false;
		}
	}
}
