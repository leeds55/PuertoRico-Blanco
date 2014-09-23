using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Storage1 : Form
	{
		[AccessedThroughProperty("sugar4")]
		private RadioButton _sugar4;

		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[AccessedThroughProperty("tobacco4")]
		private RadioButton _tobacco4;

		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		[AccessedThroughProperty("indigo1")]
		private RadioButton _indigo1;

		[AccessedThroughProperty("corn2")]
		private RadioButton _corn2;

		[AccessedThroughProperty("coffee4")]
		private RadioButton _coffee4;

		[AccessedThroughProperty("coffee2")]
		private RadioButton _coffee2;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("coffee1")]
		private RadioButton _coffee1;

		[AccessedThroughProperty("corn4")]
		private RadioButton _corn4;

		[AccessedThroughProperty("indigo4")]
		private RadioButton _indigo4;

		[AccessedThroughProperty("corn1")]
		private RadioButton _corn1;

		[AccessedThroughProperty("storage_close_button")]
		private Button _storage_close_button;

		[AccessedThroughProperty("tobacco1")]
		private RadioButton _tobacco1;

		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		[AccessedThroughProperty("sugar2")]
		private RadioButton _sugar2;

		[AccessedThroughProperty("indigo2")]
		private RadioButton _indigo2;

		[AccessedThroughProperty("indigo3")]
		private RadioButton _indigo3;

		[AccessedThroughProperty("sugar3")]
		private RadioButton _sugar3;

		[AccessedThroughProperty("indigo_label")]
		private Label _indigo_label;

		[AccessedThroughProperty("tobacco3")]
		private RadioButton _tobacco3;

		[AccessedThroughProperty("corn3")]
		private RadioButton _corn3;

		[AccessedThroughProperty("coffee3")]
		private RadioButton _coffee3;

		[AccessedThroughProperty("coffee_label")]
		private Label _coffee_label;

		[AccessedThroughProperty("tobacco_label")]
		private Label _tobacco_label;

		[AccessedThroughProperty("sugar1")]
		private RadioButton _sugar1;

		[AccessedThroughProperty("tobacco2")]
		private RadioButton _tobacco2;

		[AccessedThroughProperty("corn_label")]
		private Label _corn_label;

		[AccessedThroughProperty("sugar_label")]
		private Label _sugar_label;

		private IContainer components;

		internal virtual Label coffee_label
		{
			get
			{
				return _coffee_label;
			}
			set
			{
				_coffee_label = value;
			}
		}

		internal virtual RadioButton coffee1
		{
			get
			{
				return _coffee1;
			}
			set
			{
				if (_coffee1 != null)
				{
					Storage1 storage1 = this;
					_coffee1.CheckedChanged -= new EventHandler(storage1.coffee1_CheckedChanged);
				}
				_coffee1 = value;
				if (_coffee1 != null)
				{
					Storage1 storage11 = this;
					_coffee1.CheckedChanged += new EventHandler(storage11.coffee1_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton coffee2
		{
			get
			{
				return _coffee2;
			}
			set
			{
				if (_coffee2 != null)
				{
					Storage1 storage1 = this;
					_coffee2.CheckedChanged -= new EventHandler(storage1.coffee2_CheckedChanged);
				}
				_coffee2 = value;
				if (_coffee2 != null)
				{
					Storage1 storage11 = this;
					_coffee2.CheckedChanged += new EventHandler(storage11.coffee2_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton coffee3
		{
			get
			{
				return _coffee3;
			}
			set
			{
				if (_coffee3 != null)
				{
					Storage1 storage1 = this;
					_coffee3.CheckedChanged -= new EventHandler(storage1.coffee3_CheckedChanged);
				}
				_coffee3 = value;
				if (_coffee3 != null)
				{
					Storage1 storage11 = this;
					_coffee3.CheckedChanged += new EventHandler(storage11.coffee3_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton coffee4
		{
			get
			{
				return _coffee4;
			}
			set
			{
				if (_coffee4 != null)
				{
					Storage1 storage1 = this;
					_coffee4.CheckedChanged -= new EventHandler(storage1.coffee4_CheckedChanged);
				}
				_coffee4 = value;
				if (_coffee4 != null)
				{
					Storage1 storage11 = this;
					_coffee4.CheckedChanged += new EventHandler(storage11.coffee4_CheckedChanged);
				}
			}
		}

		internal virtual Label corn_label
		{
			get
			{
				return _corn_label;
			}
			set
			{
				_corn_label = value;
			}
		}

		internal virtual RadioButton corn1
		{
			get
			{
				return _corn1;
			}
			set
			{
				if (_corn1 != null)
				{
					Storage1 storage1 = this;
					_corn1.CheckedChanged -= new EventHandler(storage1.corn1_CheckedChanged);
				}
				_corn1 = value;
				if (_corn1 != null)
				{
					Storage1 storage11 = this;
					_corn1.CheckedChanged += new EventHandler(storage11.corn1_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton corn2
		{
			get
			{
				return _corn2;
			}
			set
			{
				if (_corn2 != null)
				{
					Storage1 storage1 = this;
					_corn2.CheckedChanged -= new EventHandler(storage1.corn2_CheckedChanged);
				}
				_corn2 = value;
				if (_corn2 != null)
				{
					Storage1 storage11 = this;
					_corn2.CheckedChanged += new EventHandler(storage11.corn2_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton corn3
		{
			get
			{
				return _corn3;
			}
			set
			{
				if (_corn3 != null)
				{
					Storage1 storage1 = this;
					_corn3.CheckedChanged -= new EventHandler(storage1.corn3_CheckedChanged);
				}
				_corn3 = value;
				if (_corn3 != null)
				{
					Storage1 storage11 = this;
					_corn3.CheckedChanged += new EventHandler(storage11.corn3_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton corn4
		{
			get
			{
				return _corn4;
			}
			set
			{
				if (_corn4 != null)
				{
					Storage1 storage1 = this;
					_corn4.CheckedChanged -= new EventHandler(storage1.corn4_CheckedChanged);
				}
				_corn4 = value;
				if (_corn4 != null)
				{
					Storage1 storage11 = this;
					_corn4.CheckedChanged += new EventHandler(storage11.corn4_CheckedChanged);
				}
			}
		}

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

		internal virtual Label indigo_label
		{
			get
			{
				return _indigo_label;
			}
			set
			{
				_indigo_label = value;
			}
		}

		internal virtual RadioButton indigo1
		{
			get
			{
				return _indigo1;
			}
			set
			{
				if (_indigo1 != null)
				{
					Storage1 storage1 = this;
					_indigo1.CheckedChanged -= new EventHandler(storage1.indigo1_CheckedChanged);
				}
				_indigo1 = value;
				if (_indigo1 != null)
				{
					Storage1 storage11 = this;
					_indigo1.CheckedChanged += new EventHandler(storage11.indigo1_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton indigo2
		{
			get
			{
				return _indigo2;
			}
			set
			{
				if (_indigo2 != null)
				{
					Storage1 storage1 = this;
					_indigo2.CheckedChanged -= new EventHandler(storage1.indigo2_CheckedChanged);
				}
				_indigo2 = value;
				if (_indigo2 != null)
				{
					Storage1 storage11 = this;
					_indigo2.CheckedChanged += new EventHandler(storage11.indigo2_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton indigo3
		{
			get
			{
				return _indigo3;
			}
			set
			{
				if (_indigo3 != null)
				{
					Storage1 storage1 = this;
					_indigo3.CheckedChanged -= new EventHandler(storage1.indigo3_CheckedChanged);
				}
				_indigo3 = value;
				if (_indigo3 != null)
				{
					Storage1 storage11 = this;
					_indigo3.CheckedChanged += new EventHandler(storage11.indigo3_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton indigo4
		{
			get
			{
				return _indigo4;
			}
			set
			{
				if (_indigo4 != null)
				{
					Storage1 storage1 = this;
					_indigo4.CheckedChanged -= new EventHandler(storage1.indigo4_CheckedChanged);
				}
				_indigo4 = value;
				if (_indigo4 != null)
				{
					Storage1 storage11 = this;
					_indigo4.CheckedChanged += new EventHandler(storage11.indigo4_CheckedChanged);
				}
			}
		}

		internal virtual Button storage_close_button
		{
			get
			{
				return _storage_close_button;
			}
			set
			{
				if (_storage_close_button != null)
				{
					Storage1 storage1 = this;
					_storage_close_button.Click -=new EventHandler(storage1.storage_close_button_Click);
				}
				_storage_close_button = value;
				if (_storage_close_button != null)
				{
					Storage1 storage11 = this;
					_storage_close_button.Click +=new EventHandler(storage11.storage_close_button_Click);
				}
			}
		}

		internal virtual Label sugar_label
		{
			get
			{
				return _sugar_label;
			}
			set
			{
				_sugar_label = value;
			}
		}

		internal virtual RadioButton sugar1
		{
			get
			{
				return _sugar1;
			}
			set
			{
				if (_sugar1 != null)
				{
					Storage1 storage1 = this;
					_sugar1.CheckedChanged -= new EventHandler(storage1.sugar1_CheckedChanged);
				}
				_sugar1 = value;
				if (_sugar1 != null)
				{
					Storage1 storage11 = this;
					_sugar1.CheckedChanged += new EventHandler(storage11.sugar1_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton sugar2
		{
			get
			{
				return _sugar2;
			}
			set
			{
				if (_sugar2 != null)
				{
					Storage1 storage1 = this;
					_sugar2.CheckedChanged -= new EventHandler(storage1.sugar2_CheckedChanged);
				}
				_sugar2 = value;
				if (_sugar2 != null)
				{
					Storage1 storage11 = this;
					_sugar2.CheckedChanged += new EventHandler(storage11.sugar2_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton sugar3
		{
			get
			{
				return _sugar3;
			}
			set
			{
				if (_sugar3 != null)
				{
					Storage1 storage1 = this;
					_sugar3.CheckedChanged -= new EventHandler(storage1.sugar3_CheckedChanged);
				}
				_sugar3 = value;
				if (_sugar3 != null)
				{
					Storage1 storage11 = this;
					_sugar3.CheckedChanged += new EventHandler(storage11.sugar3_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton sugar4
		{
			get
			{
				return _sugar4;
			}
			set
			{
				if (_sugar4 != null)
				{
					Storage1 storage1 = this;
					_sugar4.CheckedChanged -= new EventHandler(storage1.sugar4_CheckedChanged);
				}
				_sugar4 = value;
				if (_sugar4 != null)
				{
					Storage1 storage11 = this;
					_sugar4.CheckedChanged += new EventHandler(storage11.sugar4_CheckedChanged);
				}
			}
		}

		internal virtual Label tobacco_label
		{
			get
			{
				return _tobacco_label;
			}
			set
			{
				_tobacco_label = value;
			}
		}

		internal virtual RadioButton tobacco1
		{
			get
			{
				return _tobacco1;
			}
			set
			{
				if (_tobacco1 != null)
				{
					Storage1 storage1 = this;
					_tobacco1.CheckedChanged -= new EventHandler(storage1.tobacco1_CheckedChanged);
				}
				_tobacco1 = value;
				if (_tobacco1 != null)
				{
					Storage1 storage11 = this;
					_tobacco1.CheckedChanged += new EventHandler(storage11.tobacco1_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton tobacco2
		{
			get
			{
				return _tobacco2;
			}
			set
			{
				if (_tobacco2 != null)
				{
					Storage1 storage1 = this;
					_tobacco2.CheckedChanged -= new EventHandler(storage1.tobacco2_CheckedChanged);
				}
				_tobacco2 = value;
				if (_tobacco2 != null)
				{
					Storage1 storage11 = this;
					_tobacco2.CheckedChanged += new EventHandler(storage11.tobacco2_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton tobacco3
		{
			get
			{
				return _tobacco3;
			}
			set
			{
				if (_tobacco3 != null)
				{
					Storage1 storage1 = this;
					_tobacco3.CheckedChanged -= new EventHandler(storage1.tobacco3_CheckedChanged);
				}
				_tobacco3 = value;
				if (_tobacco3 != null)
				{
					Storage1 storage11 = this;
					_tobacco3.CheckedChanged += new EventHandler(storage11.tobacco3_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton tobacco4
		{
			get
			{
				return _tobacco4;
			}
			set
			{
				if (_tobacco4 != null)
				{
					Storage1 storage1 = this;
					_tobacco4.CheckedChanged -=new EventHandler(storage1.tobacco4_CheckedChanged);
				}
				_tobacco4 = value;
				if (_tobacco4 != null)
				{
					Storage1 storage11 = this;
					_tobacco4.CheckedChanged += new EventHandler(storage11.tobacco4_CheckedChanged);
				}
			}
		}

		public Storage1()
		{
			InitializeComponent();
		}

		public void check_for_close_button()
		{
			if (!storage_close_button.Visible)
			{
				storage_close_button.Enabled = true;
				storage_close_button.Visible = true;
			}
		}

		private void coffee1_CheckedChanged(object sender, EventArgs e)
		{
			if (coffee1.Checked)
			{
				coffee2.Checked = false;
				coffee3.Checked = false;
				coffee4.Checked = false;
			}
			check_for_close_button();
		}

		private void coffee2_CheckedChanged(object sender, EventArgs e)
		{
			if (coffee2.Checked)
			{
				coffee1.Checked = false;
				coffee3.Checked = false;
				coffee4.Checked = false;
			}
			check_for_close_button();
		}

		private void coffee3_CheckedChanged(object sender, EventArgs e)
		{
			if (coffee3.Checked)
			{
				coffee1.Checked = false;
				coffee2.Checked = false;
				coffee4.Checked = false;
			}
			check_for_close_button();
		}

		private void coffee4_CheckedChanged(object sender, EventArgs e)
		{
			if (coffee4.Checked)
			{
				coffee1.Checked = false;
				coffee2.Checked = false;
				coffee3.Checked = false;
			}
			check_for_close_button();
		}

		private void corn1_CheckedChanged(object sender, EventArgs e)
		{
			if (corn1.Checked)
			{
				corn2.Checked = false;
				corn3.Checked = false;
				corn4.Checked = false;
			}
			check_for_close_button();
		}

		private void corn2_CheckedChanged(object sender, EventArgs e)
		{
			if (corn2.Checked)
			{
				corn1.Checked = false;
				corn3.Checked = false;
				corn4.Checked = false;
			}
			check_for_close_button();
		}

		private void corn3_CheckedChanged(object sender, EventArgs e)
		{
			if (corn3.Checked)
			{
				corn1.Checked = false;
				corn2.Checked = false;
				corn4.Checked = false;
			}
			check_for_close_button();
		}

		private void corn4_CheckedChanged(object sender, EventArgs e)
		{
			if (corn4.Checked)
			{
				corn1.Checked = false;
				corn2.Checked = false;
				corn3.Checked = false;
			}
			check_for_close_button();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void indigo1_CheckedChanged(object sender, EventArgs e)
		{
			if (indigo1.Checked)
			{
				indigo2.Checked = false;
				indigo3.Checked = false;
				indigo4.Checked = false;
			}
			check_for_close_button();
		}

		private void indigo2_CheckedChanged(object sender, EventArgs e)
		{
			if (indigo2.Checked)
			{
				indigo1.Checked = false;
				indigo3.Checked = false;
				indigo4.Checked = false;
			}
			check_for_close_button();
		}

		private void indigo3_CheckedChanged(object sender, EventArgs e)
		{
			if (indigo3.Checked)
			{
				indigo1.Checked = false;
				indigo2.Checked = false;
				indigo4.Checked = false;
			}
			check_for_close_button();
		}

		private void indigo4_CheckedChanged(object sender, EventArgs e)
		{
			if (indigo4.Checked)
			{
				indigo1.Checked = false;
				indigo2.Checked = false;
				indigo3.Checked = false;
			}
			check_for_close_button();
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			coffee_label = new Label();
			tobacco_label = new Label();
			corn_label = new Label();
			sugar_label = new Label();
			indigo_label = new Label();
			GroupBox1 = new GroupBox();
			coffee1 = new RadioButton();
			corn1 = new RadioButton();
			tobacco1 = new RadioButton();
			sugar1 = new RadioButton();
			indigo1 = new RadioButton();
			GroupBox2 = new GroupBox();
			indigo2 = new RadioButton();
			sugar2 = new RadioButton();
			tobacco2 = new RadioButton();
			corn2 = new RadioButton();
			coffee2 = new RadioButton();
			GroupBox3 = new GroupBox();
			sugar3 = new RadioButton();
			tobacco3 = new RadioButton();
			coffee3 = new RadioButton();
			corn3 = new RadioButton();
			indigo3 = new RadioButton();
			GroupBox4 = new GroupBox();
			sugar4 = new RadioButton();
			tobacco4 = new RadioButton();
			coffee4 = new RadioButton();
			corn4 = new RadioButton();
			indigo4 = new RadioButton();
			storage_close_button = new Button();
			GroupBox1.SuspendLayout();
			GroupBox2.SuspendLayout();
			GroupBox3.SuspendLayout();
			GroupBox4.SuspendLayout();
			SuspendLayout();
			coffee_label.BackColor = Color.SaddleBrown;
			coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label coffeeLabel = coffee_label;
			Point point = new Point(24, 248);
			coffeeLabel.Location = point;
			coffee_label.Name = "coffee_label";
			Label label = coffee_label;
			Size size = new Size(36, 32);
			label.Size = size;
			coffee_label.TabIndex = 53;
			coffee_label.Text = "99";
			coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			tobacco_label.BackColor=Color.Goldenrod;
			tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label tobaccoLabel = tobacco_label;
			point = new Point(24, 200);
			tobaccoLabel.Location = point;
			tobacco_label.Name = "tobacco_label";
			Label tobaccoLabel1 = tobacco_label;
			size = new Size(36, 32);
			tobaccoLabel1.Size = size;
			tobacco_label.TabIndex = 52;
			tobacco_label.Text = "99";
			tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			corn_label.BackColor = Color.Yellow;
			corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label cornLabel = corn_label;
			point = new Point(24, 152);
			cornLabel.Location = point;
			corn_label.Name = "corn_label";
			Label cornLabel1 = corn_label;
			size = new Size(36, 32);
			cornLabel1.Size = size;
			corn_label.TabIndex = 51;
			corn_label.Text = "99";
			corn_label.TextAlign = ContentAlignment.MiddleCenter;
			sugar_label.BackColor = Color.White;
			sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label sugarLabel = sugar_label;
			point = new Point(24, 104);
			sugarLabel.Location = point;
			sugar_label.Name = "sugar_label";
			Label sugarLabel1 = sugar_label;
			size = new Size(36, 32);
			sugarLabel1.Size = size;
			sugar_label.TabIndex = 50;
			sugar_label.Text = "99";
			sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			indigo_label.BackColor = Color.Blue;
			indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label indigoLabel = indigo_label;
			point = new Point(24, 56);
			indigoLabel.Location = point;
			indigo_label.Name = "indigo_label";
			Label indigoLabel1 = indigo_label;
			size = new Size(36, 32);
			indigoLabel1.Size = size;
			indigo_label.TabIndex = 49;
			indigo_label.Text = "99";
			indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			GroupBox1.Controls.Add(coffee1);
			GroupBox1.Controls.Add(corn1);
			GroupBox1.Controls.Add(tobacco1);
			GroupBox1.Controls.Add(sugar1);
			GroupBox1.Controls.Add(indigo1);
			GroupBox groupBox1 = GroupBox1;
			point = new Point(88, 24);
			groupBox1.Location = point;
			GroupBox1.Name = "GroupBox1";
			GroupBox groupBox = GroupBox1;
			size = new Size(80, 272);
			groupBox.Size = size;
			GroupBox1.TabIndex = 54;
			GroupBox1.TabStop = false;
			GroupBox1.Text = "Store 1 Good";
			RadioButton radioButton = coffee1;
			point = new Point(32, 232);
			radioButton.Location = point;
			coffee1.Name = "coffee1";
			RadioButton radioButton1 = coffee1;
			size = new Size(24, 16);
			radioButton1.Size = size;
			coffee1.TabIndex=4;
			RadioButton radioButton2 = corn1;
			point = new Point(32, 136);
			radioButton2.Location = point;
			corn1.Name = "corn1";
			RadioButton radioButton3 = corn1;
			size = new Size(24, 16);
			radioButton3.Size = size;
			corn1.TabIndex=3;
			RadioButton radioButton4 = tobacco1;
			point = new Point(32, 184);
			radioButton4.Location = point;
			tobacco1.Name = "tobacco1";
			RadioButton radioButton5 = tobacco1;
			size = new Size(24, 16);
			radioButton5.Size = size;
			tobacco1.TabIndex=2;
			RadioButton radioButton6 = sugar1;
			point = new Point(32, 88);
			radioButton6.Location = point;
			sugar1.Name = "sugar1";
			RadioButton radioButton7 = sugar1;
			size = new Size(28, 16);
			radioButton7.Size = size;
			sugar1.TabIndex=1;
			RadioButton radioButton8 = indigo1;
			point = new Point(32, 40);
			radioButton8.Location = point;
			indigo1.Name = "indigo1";
			RadioButton radioButton9 = indigo1;
			size = new Size(24, 16);
			radioButton9.Size = size;
			indigo1.TabIndex=0;
			GroupBox2.Controls.Add(indigo2);
			GroupBox2.Controls.Add(sugar2);
			GroupBox2.Controls.Add(tobacco2);
			GroupBox2.Controls.Add(corn2);
			GroupBox2.Controls.Add(coffee2);
			GroupBox groupBox2 = GroupBox2;
			point = new Point(168, 24);
			groupBox2.Location = point;
			GroupBox2.Name = "GroupBox2";
			GroupBox groupBox21 = GroupBox2;
			size = new Size(80, 272);
			groupBox21.Size = size;
			GroupBox2.TabIndex = 55;
			GroupBox2.TabStop = false;
			GroupBox2.Text = "Small Warehouse";
			RadioButton radioButton10 = indigo2;
			point = new Point(32, 40);
			radioButton10.Location = point;
			indigo2.Name = "indigo2";
			RadioButton radioButton11 = indigo2;
			size = new Size(24, 16);
			radioButton11.Size = size;
			indigo2.TabIndex=5;
			RadioButton radioButton12 = sugar2;
			point = new Point(32, 88);
			radioButton12.Location = point;
			sugar2.Name = "sugar2";
			RadioButton radioButton13 = sugar2;
			size = new Size(28, 16);
			radioButton13.Size = size;
			sugar2.TabIndex=6;
			RadioButton radioButton14 = tobacco2;
			point = new Point(32, 184);
			radioButton14.Location = point;
			tobacco2.Name = "tobacco2";
			RadioButton radioButton15 = tobacco2;
			size = new Size(24, 16);
			radioButton15.Size = size;
			tobacco2.TabIndex=7;
			RadioButton radioButton16 = corn2;
			point = new Point(32, 136);
			radioButton16.Location = point;
			corn2.Name = "corn2";
			RadioButton radioButton17 = corn2;
			size = new Size(24, 16);
			radioButton17.Size = size;
			corn2.TabIndex=8;
			RadioButton radioButton18 = coffee2;
			point = new Point(32, 232);
			radioButton18.Location = point;
			coffee2.Name = "coffee2";
			RadioButton radioButton19 = coffee2;
			size = new Size(24, 16);
			radioButton19.Size = size;
			coffee2.TabIndex=9;
			GroupBox3.Controls.Add(sugar3);
			GroupBox3.Controls.Add(tobacco3);
			GroupBox3.Controls.Add(coffee3);
			GroupBox3.Controls.Add(corn3);
			GroupBox3.Controls.Add(indigo3);
			GroupBox groupBox3 = GroupBox3;
			point = new Point(248, 24);
			groupBox3.Location = point;
			GroupBox3.Name = "GroupBox3";
			GroupBox groupBox31 = GroupBox3;
			size = new Size(80, 272);
			groupBox31.Size = size;
			GroupBox3.TabIndex = 56;
			GroupBox3.TabStop = false;
			GroupBox3.Text = "Large Warehouse";
			RadioButton radioButton20 = sugar3;
			point = new Point(32, 88);
			radioButton20.Location = point;
			sugar3.Name = "sugar3";
			RadioButton radioButton21 = sugar3;
			size = new Size(28, 16);
			radioButton21.Size = size;
			sugar3.TabIndex = 11;
			RadioButton radioButton22 = tobacco3;
			point = new Point(32, 184);
			radioButton22.Location = point;
			tobacco3.Name = "tobacco3";
			RadioButton radioButton23 = tobacco3;
			size = new Size(24, 16);
			radioButton23.Size = size;
			tobacco3.TabIndex = 12;
			RadioButton radioButton24 = coffee3;
			point = new Point(32, 232);
			radioButton24.Location = point;
			coffee3.Name = "coffee3";
			RadioButton radioButton25 = coffee3;
			size = new Size(24, 16);
			radioButton25.Size = size;
			coffee3.TabIndex = 14;
			RadioButton radioButton26 = corn3;
			point = new Point(32, 136);
			radioButton26.Location = point;
			corn3.Name = "corn3";
			RadioButton radioButton27 = corn3;
			size = new Size(24, 16);
			radioButton27.Size = size;
			corn3.TabIndex = 13;
			RadioButton radioButton28 = indigo3;
			point = new Point(32, 40);
			radioButton28.Location = point;
			indigo3.Name = "indigo3";
			RadioButton radioButton29 = indigo3;
			size = new Size(24, 16);
			radioButton29.Size = size;
			indigo3.TabIndex = 10;
			GroupBox4.Controls.Add(sugar4);
			GroupBox4.Controls.Add(tobacco4);
			GroupBox4.Controls.Add(coffee4);
			GroupBox4.Controls.Add(corn4);
			GroupBox4.Controls.Add(indigo4);
			GroupBox groupBox4 = GroupBox4;
			point = new Point(328, 24);
			groupBox4.Location = point;
			GroupBox4.Name = "GroupBox4";
			GroupBox groupBox41 = GroupBox4;
			size = new Size(80, 272);
			groupBox41.Size = size;
			GroupBox4.TabIndex = 57;
			GroupBox4.TabStop = false;
			GroupBox4.Text = "Large Warehouse";
			RadioButton radioButton30 = sugar4;
			point = new Point(32, 88);
			radioButton30.Location = point;
			sugar4.Name = "sugar4";
			RadioButton radioButton31 = sugar4;
			size = new Size(28, 16);
			radioButton31.Size = size;
			sugar4.TabIndex = 11;
			RadioButton radioButton32 = tobacco4;
			point = new Point(32, 184);
			radioButton32.Location = point;
			tobacco4.Name = "tobacco4";
			RadioButton radioButton33 = tobacco4;
			size = new Size(24, 16);
			radioButton33.Size = size;
			tobacco4.TabIndex = 12;
			RadioButton radioButton34 = coffee4;
			point = new Point(32, 232);
			radioButton34.Location = point;
			coffee4.Name = "coffee4";
			RadioButton radioButton35 = coffee4;
			size = new Size(24, 16);
			radioButton35.Size = size;
			coffee4.TabIndex = 14;
			RadioButton radioButton36 = corn4;
			point = new Point(32, 136);
			radioButton36.Location = point;
			corn4.Name = "corn4";
			RadioButton radioButton37 = corn4;
			size = new Size(24, 16);
			radioButton37.Size = size;
			corn4.TabIndex = 13;
			RadioButton radioButton38 = indigo4;
			point = new Point(32, 40);
			radioButton38.Location = point;
			indigo4.Name = "indigo4";
			RadioButton radioButton39 = indigo4;
			size = new Size(24, 16);
			radioButton39.Size = size;
			indigo4.TabIndex = 10;
			storage_close_button.Enabled=false;
			Button storageCloseButton = storage_close_button;
			point = new Point(184, 320);
			storageCloseButton.Location = point;
			storage_close_button.Name = "storage_close_button";
			storage_close_button.TabIndex = 58;
			storage_close_button.Text = "OK";
			storage_close_button.Visible = false;
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(432, 400);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(storage_close_button);
			Controls.Add(GroupBox3);
			Controls.Add(GroupBox2);
			Controls.Add(GroupBox1);
			Controls.Add(coffee_label);
			Controls.Add(tobacco_label);
			Controls.Add(corn_label);
			Controls.Add(sugar_label);
			Controls.Add(indigo_label);
			Controls.Add(GroupBox4);
			size = new Size(440, 408);
			MaximumSize = size;
			size = new Size(440, 408);
			MinimumSize = size;
			Name = "Storage1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "What Goods Will You Store?";
			GroupBox1.ResumeLayout(false);
			GroupBox2.ResumeLayout(false);
			GroupBox3.ResumeLayout(false);
			GroupBox4.ResumeLayout(false);
			ResumeLayout(false);
		}

		private void storage_close_button_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void sugar1_CheckedChanged(object sender, EventArgs e)
		{
			if (sugar1.Checked)
			{
				sugar2.Checked = false;
				sugar3.Checked = false;
				sugar4.Checked = false;
			}
			check_for_close_button();
		}

		private void sugar2_CheckedChanged(object sender, EventArgs e)
		{
			if (sugar2.Checked)
			{
				sugar1.Checked = false;
				sugar3.Checked = false;
				sugar4.Checked = false;
			}
			check_for_close_button();
		}

		private void sugar3_CheckedChanged(object sender, EventArgs e)
		{
			if (sugar3.Checked)
			{
				sugar1.Checked = false;
				sugar2.Checked = false;
				sugar4.Checked = false;
			}
			check_for_close_button();
		}

		private void sugar4_CheckedChanged(object sender, EventArgs e)
		{
			if (sugar4.Checked)
			{
				sugar1.Checked = false;
				sugar2.Checked = false;
				sugar3.Checked = false;
			}
			check_for_close_button();
		}

		private void tobacco1_CheckedChanged(object sender, EventArgs e)
		{
			if (tobacco1.Checked)
			{
				tobacco2.Checked = false;
				tobacco3.Checked = false;
				tobacco4.Checked = false;
			}
			check_for_close_button();
		}

		private void tobacco2_CheckedChanged(object sender, EventArgs e)
		{
			if (tobacco2.Checked)
			{
				tobacco1.Checked = false;
				tobacco3.Checked = false;
				tobacco4.Checked = false;
			}
			check_for_close_button();
		}

		private void tobacco3_CheckedChanged(object sender, EventArgs e)
		{
			if (tobacco3.Checked)
			{
				tobacco1.Checked = false;
				tobacco2.Checked = false;
				tobacco4.Checked = false;
			}
			check_for_close_button();
		}

		private void tobacco4_CheckedChanged(object sender, EventArgs e)
		{
			if (tobacco4.Checked)
			{
				tobacco1.Checked = false;
				tobacco2.Checked = false;
				tobacco3.Checked = false;
			}
			check_for_close_button();
		}
	}
}
