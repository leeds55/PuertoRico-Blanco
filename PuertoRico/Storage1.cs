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
				return this._coffee_label;
			}
			set
			{
				this._coffee_label  = null;
				this._coffee_label = value;
				this._coffee_label  = null;
			}
		}

		internal virtual RadioButton coffee1
		{
			get
			{
				return this._coffee1;
			}
			set
			{
				if (this._coffee1 != null)
				{
					Storage1 storage1 = this;
					this._coffee1.CheckedChanged -= new EventHandler(storage1.coffee1_CheckedChanged);
				}
				this._coffee1 = value;
				if (this._coffee1 != null)
				{
					Storage1 storage11 = this;
					this._coffee1.CheckedChanged += new EventHandler(storage11.coffee1_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton coffee2
		{
			get
			{
				return this._coffee2;
			}
			set
			{
				if (this._coffee2 != null)
				{
					Storage1 storage1 = this;
					this._coffee2.CheckedChanged -= new EventHandler(storage1.coffee2_CheckedChanged);
				}
				this._coffee2 = value;
				if (this._coffee2 != null)
				{
					Storage1 storage11 = this;
					this._coffee2.CheckedChanged += new EventHandler(storage11.coffee2_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton coffee3
		{
			get
			{
				return this._coffee3;
			}
			set
			{
				if (this._coffee3 != null)
				{
					Storage1 storage1 = this;
					this._coffee3.CheckedChanged -= new EventHandler(storage1.coffee3_CheckedChanged);
				}
				this._coffee3 = value;
				if (this._coffee3 != null)
				{
					Storage1 storage11 = this;
					this._coffee3.CheckedChanged += new EventHandler(storage11.coffee3_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton coffee4
		{
			get
			{
				return this._coffee4;
			}
			set
			{
				if (this._coffee4 != null)
				{
					Storage1 storage1 = this;
					this._coffee4.CheckedChanged -= new EventHandler(storage1.coffee4_CheckedChanged);
				}
				this._coffee4 = value;
				if (this._coffee4 != null)
				{
					Storage1 storage11 = this;
					this._coffee4.CheckedChanged += new EventHandler(storage11.coffee4_CheckedChanged);
				}
			}
		}

		internal virtual Label corn_label
		{
			get
			{
				return this._corn_label;
			}
			set
			{
				this._corn_label  = null;
				this._corn_label = value;
				this._corn_label  = null;
			}
		}

		internal virtual RadioButton corn1
		{
			get
			{
				return this._corn1;
			}
			set
			{
				if (this._corn1 != null)
				{
					Storage1 storage1 = this;
					this._corn1.CheckedChanged -= new EventHandler(storage1.corn1_CheckedChanged);
				}
				this._corn1 = value;
				if (this._corn1 != null)
				{
					Storage1 storage11 = this;
					this._corn1.CheckedChanged += new EventHandler(storage11.corn1_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton corn2
		{
			get
			{
				return this._corn2;
			}
			set
			{
				if (this._corn2 != null)
				{
					Storage1 storage1 = this;
					this._corn2.CheckedChanged -= new EventHandler(storage1.corn2_CheckedChanged);
				}
				this._corn2 = value;
				if (this._corn2 != null)
				{
					Storage1 storage11 = this;
					this._corn2.CheckedChanged += new EventHandler(storage11.corn2_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton corn3
		{
			get
			{
				return this._corn3;
			}
			set
			{
				if (this._corn3 != null)
				{
					Storage1 storage1 = this;
					this._corn3.CheckedChanged -= new EventHandler(storage1.corn3_CheckedChanged);
				}
				this._corn3 = value;
				if (this._corn3 != null)
				{
					Storage1 storage11 = this;
					this._corn3.CheckedChanged += new EventHandler(storage11.corn3_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton corn4
		{
			get
			{
				return this._corn4;
			}
			set
			{
				if (this._corn4 != null)
				{
					Storage1 storage1 = this;
					this._corn4.CheckedChanged -= new EventHandler(storage1.corn4_CheckedChanged);
				}
				this._corn4 = value;
				if (this._corn4 != null)
				{
					Storage1 storage11 = this;
					this._corn4.CheckedChanged += new EventHandler(storage11.corn4_CheckedChanged);
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
				this._GroupBox1  = null;
				this._GroupBox1 = value;
				this._GroupBox1  = null;
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
				this._GroupBox2  = null;
				this._GroupBox2 = value;
				this._GroupBox2  = null;
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
				this._GroupBox3  = null;
				this._GroupBox3 = value;
				this._GroupBox3  = null;
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
				this._GroupBox4  = null;
				this._GroupBox4 = value;
				this._GroupBox4  = null;
			}
		}

		internal virtual Label indigo_label
		{
			get
			{
				return this._indigo_label;
			}
			set
			{
				this._indigo_label  = null;
				this._indigo_label = value;
				this._indigo_label  = null;
			}
		}

		internal virtual RadioButton indigo1
		{
			get
			{
				return this._indigo1;
			}
			set
			{
				if (this._indigo1 != null)
				{
					Storage1 storage1 = this;
					this._indigo1.CheckedChanged -= new EventHandler(storage1.indigo1_CheckedChanged);
				}
				this._indigo1 = value;
				if (this._indigo1 != null)
				{
					Storage1 storage11 = this;
					this._indigo1.CheckedChanged += new EventHandler(storage11.indigo1_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton indigo2
		{
			get
			{
				return this._indigo2;
			}
			set
			{
				if (this._indigo2 != null)
				{
					Storage1 storage1 = this;
					this._indigo2.CheckedChanged -= new EventHandler(storage1.indigo2_CheckedChanged);
				}
				this._indigo2 = value;
				if (this._indigo2 != null)
				{
					Storage1 storage11 = this;
					this._indigo2.CheckedChanged += new EventHandler(storage11.indigo2_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton indigo3
		{
			get
			{
				return this._indigo3;
			}
			set
			{
				if (this._indigo3 != null)
				{
					Storage1 storage1 = this;
					this._indigo3.CheckedChanged -= new EventHandler(storage1.indigo3_CheckedChanged);
				}
				this._indigo3 = value;
				if (this._indigo3 != null)
				{
					Storage1 storage11 = this;
					this._indigo3.CheckedChanged += new EventHandler(storage11.indigo3_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton indigo4
		{
			get
			{
				return this._indigo4;
			}
			set
			{
				if (this._indigo4 != null)
				{
					Storage1 storage1 = this;
					this._indigo4.CheckedChanged -= new EventHandler(storage1.indigo4_CheckedChanged);
				}
				this._indigo4 = value;
				if (this._indigo4 != null)
				{
					Storage1 storage11 = this;
					this._indigo4.CheckedChanged += new EventHandler(storage11.indigo4_CheckedChanged);
				}
			}
		}

		internal virtual Button storage_close_button
		{
			get
			{
				return this._storage_close_button;
			}
			set
			{
				if (this._storage_close_button != null)
				{
					Storage1 storage1 = this;
					this._storage_close_button.Click -=new EventHandler(storage1.storage_close_button_Click);
				}
				this._storage_close_button = value;
				if (this._storage_close_button != null)
				{
					Storage1 storage11 = this;
					this._storage_close_button.Click +=new EventHandler(storage11.storage_close_button_Click);
				}
			}
		}

		internal virtual Label sugar_label
		{
			get
			{
				return this._sugar_label;
			}
			set
			{
				this._sugar_label  = null;
				this._sugar_label = value;
				this._sugar_label  = null;
			}
		}

		internal virtual RadioButton sugar1
		{
			get
			{
				return this._sugar1;
			}
			set
			{
				if (this._sugar1 != null)
				{
					Storage1 storage1 = this;
					this._sugar1.CheckedChanged -= new EventHandler(storage1.sugar1_CheckedChanged);
				}
				this._sugar1 = value;
				if (this._sugar1 != null)
				{
					Storage1 storage11 = this;
					this._sugar1.CheckedChanged += new EventHandler(storage11.sugar1_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton sugar2
		{
			get
			{
				return this._sugar2;
			}
			set
			{
				if (this._sugar2 != null)
				{
					Storage1 storage1 = this;
					this._sugar2.CheckedChanged -= new EventHandler(storage1.sugar2_CheckedChanged);
				}
				this._sugar2 = value;
				if (this._sugar2 != null)
				{
					Storage1 storage11 = this;
					this._sugar2.CheckedChanged += new EventHandler(storage11.sugar2_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton sugar3
		{
			get
			{
				return this._sugar3;
			}
			set
			{
				if (this._sugar3 != null)
				{
					Storage1 storage1 = this;
					this._sugar3.CheckedChanged -= new EventHandler(storage1.sugar3_CheckedChanged);
				}
				this._sugar3 = value;
				if (this._sugar3 != null)
				{
					Storage1 storage11 = this;
					this._sugar3.CheckedChanged += new EventHandler(storage11.sugar3_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton sugar4
		{
			get
			{
				return this._sugar4;
			}
			set
			{
				if (this._sugar4 != null)
				{
					Storage1 storage1 = this;
					this._sugar4.CheckedChanged -= new EventHandler(storage1.sugar4_CheckedChanged);
				}
				this._sugar4 = value;
				if (this._sugar4 != null)
				{
					Storage1 storage11 = this;
					this._sugar4.CheckedChanged += new EventHandler(storage11.sugar4_CheckedChanged);
				}
			}
		}

		internal virtual Label tobacco_label
		{
			get
			{
				return this._tobacco_label;
			}
			set
			{
				this._tobacco_label  = null;
				this._tobacco_label = value;
				this._tobacco_label  = null;
			}
		}

		internal virtual RadioButton tobacco1
		{
			get
			{
				return this._tobacco1;
			}
			set
			{
				if (this._tobacco1 != null)
				{
					Storage1 storage1 = this;
					this._tobacco1.CheckedChanged -= new EventHandler(storage1.tobacco1_CheckedChanged);
				}
				this._tobacco1 = value;
				if (this._tobacco1 != null)
				{
					Storage1 storage11 = this;
					this._tobacco1.CheckedChanged += new EventHandler(storage11.tobacco1_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton tobacco2
		{
			get
			{
				return this._tobacco2;
			}
			set
			{
				if (this._tobacco2 != null)
				{
					Storage1 storage1 = this;
					this._tobacco2.CheckedChanged -= new EventHandler(storage1.tobacco2_CheckedChanged);
				}
				this._tobacco2 = value;
				if (this._tobacco2 != null)
				{
					Storage1 storage11 = this;
					this._tobacco2.CheckedChanged += new EventHandler(storage11.tobacco2_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton tobacco3
		{
			get
			{
				return this._tobacco3;
			}
			set
			{
				if (this._tobacco3 != null)
				{
					Storage1 storage1 = this;
					this._tobacco3.CheckedChanged -= new EventHandler(storage1.tobacco3_CheckedChanged);
				}
				this._tobacco3 = value;
				if (this._tobacco3 != null)
				{
					Storage1 storage11 = this;
					this._tobacco3.CheckedChanged += new EventHandler(storage11.tobacco3_CheckedChanged);
				}
			}
		}

		internal virtual RadioButton tobacco4
		{
			get
			{
				return this._tobacco4;
			}
			set
			{
				if (this._tobacco4 != null)
				{
					Storage1 storage1 = this;
					this._tobacco4.CheckedChanged -=new EventHandler(storage1.tobacco4_CheckedChanged);
				}
				this._tobacco4 = value;
				if (this._tobacco4 != null)
				{
					Storage1 storage11 = this;
					this._tobacco4.CheckedChanged += new EventHandler(storage11.tobacco4_CheckedChanged);
				}
			}
		}

		public Storage1()
		{
			this.InitializeComponent();
		}

		public void check_for_close_button()
		{
			if (!this.storage_close_button.Visible)
			{
				this.storage_close_button.Enabled = true;
				this.storage_close_button.Visible = true;
			}
		}

		private void coffee1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.coffee1.Checked)
			{
				this.coffee2.Checked = false;
				this.coffee3.Checked = false;
				this.coffee4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void coffee2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.coffee2.Checked)
			{
				this.coffee1.Checked = false;
				this.coffee3.Checked = false;
				this.coffee4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void coffee3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.coffee3.Checked)
			{
				this.coffee1.Checked = false;
				this.coffee2.Checked = false;
				this.coffee4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void coffee4_CheckedChanged(object sender, EventArgs e)
		{
			if (this.coffee4.Checked)
			{
				this.coffee1.Checked = false;
				this.coffee2.Checked = false;
				this.coffee3.Checked = false;
			}
			this.check_for_close_button();
		}

		private void corn1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.corn1.Checked)
			{
				this.corn2.Checked = false;
				this.corn3.Checked = false;
				this.corn4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void corn2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.corn2.Checked)
			{
				this.corn1.Checked = false;
				this.corn3.Checked = false;
				this.corn4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void corn3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.corn3.Checked)
			{
				this.corn1.Checked = false;
				this.corn2.Checked = false;
				this.corn4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void corn4_CheckedChanged(object sender, EventArgs e)
		{
			if (this.corn4.Checked)
			{
				this.corn1.Checked = false;
				this.corn2.Checked = false;
				this.corn3.Checked = false;
			}
			this.check_for_close_button();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void indigo1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.indigo1.Checked)
			{
				this.indigo2.Checked = false;
				this.indigo3.Checked = false;
				this.indigo4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void indigo2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.indigo2.Checked)
			{
				this.indigo1.Checked = false;
				this.indigo3.Checked = false;
				this.indigo4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void indigo3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.indigo3.Checked)
			{
				this.indigo1.Checked = false;
				this.indigo2.Checked = false;
				this.indigo4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void indigo4_CheckedChanged(object sender, EventArgs e)
		{
			if (this.indigo4.Checked)
			{
				this.indigo1.Checked = false;
				this.indigo2.Checked = false;
				this.indigo3.Checked = false;
			}
			this.check_for_close_button();
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.coffee_label = new Label();
			this.tobacco_label = new Label();
			this.corn_label = new Label();
			this.sugar_label = new Label();
			this.indigo_label = new Label();
			this.GroupBox1 = new GroupBox();
			this.coffee1 = new RadioButton();
			this.corn1 = new RadioButton();
			this.tobacco1 = new RadioButton();
			this.sugar1 = new RadioButton();
			this.indigo1 = new RadioButton();
			this.GroupBox2 = new GroupBox();
			this.indigo2 = new RadioButton();
			this.sugar2 = new RadioButton();
			this.tobacco2 = new RadioButton();
			this.corn2 = new RadioButton();
			this.coffee2 = new RadioButton();
			this.GroupBox3 = new GroupBox();
			this.sugar3 = new RadioButton();
			this.tobacco3 = new RadioButton();
			this.coffee3 = new RadioButton();
			this.corn3 = new RadioButton();
			this.indigo3 = new RadioButton();
			this.GroupBox4 = new GroupBox();
			this.sugar4 = new RadioButton();
			this.tobacco4 = new RadioButton();
			this.coffee4 = new RadioButton();
			this.corn4 = new RadioButton();
			this.indigo4 = new RadioButton();
			this.storage_close_button = new Button();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.SuspendLayout();
			this.coffee_label.BackColor = Color.SaddleBrown;
			this.coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label coffeeLabel = this.coffee_label;
			Point point = new Point(24, 248);
			coffeeLabel.Location = point;
			this.coffee_label.Name = "coffee_label";
			Label label = this.coffee_label;
			Size size = new Size(36, 32);
			label.Size = size;
			this.coffee_label.TabIndex = 53;
			this.coffee_label.Text = "99";
			this.coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			this.tobacco_label.BackColor=Color.Goldenrod;
			this.tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label tobaccoLabel = this.tobacco_label;
			point = new Point(24, 200);
			tobaccoLabel.Location = point;
			this.tobacco_label.Name = "tobacco_label";
			Label tobaccoLabel1 = this.tobacco_label;
			size = new Size(36, 32);
			tobaccoLabel1.Size = size;
			this.tobacco_label.TabIndex = 52;
			this.tobacco_label.Text = "99";
			this.tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			this.corn_label.BackColor = Color.Yellow;
			this.corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label cornLabel = this.corn_label;
			point = new Point(24, 152);
			cornLabel.Location = point;
			this.corn_label.Name = "corn_label";
			Label cornLabel1 = this.corn_label;
			size = new Size(36, 32);
			cornLabel1.Size = size;
			this.corn_label.TabIndex = 51;
			this.corn_label.Text = "99";
			this.corn_label.TextAlign = ContentAlignment.MiddleCenter;
			this.sugar_label.BackColor = Color.White;
			this.sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label sugarLabel = this.sugar_label;
			point = new Point(24, 104);
			sugarLabel.Location = point;
			this.sugar_label.Name = "sugar_label";
			Label sugarLabel1 = this.sugar_label;
			size = new Size(36, 32);
			sugarLabel1.Size = size;
			this.sugar_label.TabIndex = 50;
			this.sugar_label.Text = "99";
			this.sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			this.indigo_label.BackColor = Color.Blue;
			this.indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label indigoLabel = this.indigo_label;
			point = new Point(24, 56);
			indigoLabel.Location = point;
			this.indigo_label.Name = "indigo_label";
			Label indigoLabel1 = this.indigo_label;
			size = new Size(36, 32);
			indigoLabel1.Size = size;
			this.indigo_label.TabIndex = 49;
			this.indigo_label.Text = "99";
			this.indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			this.GroupBox1.Controls.Add(this.coffee1);
			this.GroupBox1.Controls.Add(this.corn1);
			this.GroupBox1.Controls.Add(this.tobacco1);
			this.GroupBox1.Controls.Add(this.sugar1);
			this.GroupBox1.Controls.Add(this.indigo1);
			GroupBox groupBox1 = this.GroupBox1;
			point = new Point(88, 24);
			groupBox1.Location = point;
			this.GroupBox1.Name = "GroupBox1";
			GroupBox groupBox = this.GroupBox1;
			size = new Size(80, 272);
			groupBox.Size = size;
			this.GroupBox1.TabIndex = 54;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Store 1 Good";
			RadioButton radioButton = this.coffee1;
			point = new Point(32, 232);
			radioButton.Location = point;
			this.coffee1.Name = "coffee1";
			RadioButton radioButton1 = this.coffee1;
			size = new Size(24, 16);
			radioButton1.Size = size;
			this.coffee1.TabIndex=4;
			RadioButton radioButton2 = this.corn1;
			point = new Point(32, 136);
			radioButton2.Location = point;
			this.corn1.Name = "corn1";
			RadioButton radioButton3 = this.corn1;
			size = new Size(24, 16);
			radioButton3.Size = size;
			this.corn1.TabIndex=3;
			RadioButton radioButton4 = this.tobacco1;
			point = new Point(32, 184);
			radioButton4.Location = point;
			this.tobacco1.Name = "tobacco1";
			RadioButton radioButton5 = this.tobacco1;
			size = new Size(24, 16);
			radioButton5.Size = size;
			this.tobacco1.TabIndex=2;
			RadioButton radioButton6 = this.sugar1;
			point = new Point(32, 88);
			radioButton6.Location = point;
			this.sugar1.Name = "sugar1";
			RadioButton radioButton7 = this.sugar1;
			size = new Size(28, 16);
			radioButton7.Size = size;
			this.sugar1.TabIndex=1;
			RadioButton radioButton8 = this.indigo1;
			point = new Point(32, 40);
			radioButton8.Location = point;
			this.indigo1.Name = "indigo1";
			RadioButton radioButton9 = this.indigo1;
			size = new Size(24, 16);
			radioButton9.Size = size;
			this.indigo1.TabIndex=0;
			this.GroupBox2.Controls.Add(this.indigo2);
			this.GroupBox2.Controls.Add(this.sugar2);
			this.GroupBox2.Controls.Add(this.tobacco2);
			this.GroupBox2.Controls.Add(this.corn2);
			this.GroupBox2.Controls.Add(this.coffee2);
			GroupBox groupBox2 = this.GroupBox2;
			point = new Point(168, 24);
			groupBox2.Location = point;
			this.GroupBox2.Name = "GroupBox2";
			GroupBox groupBox21 = this.GroupBox2;
			size = new Size(80, 272);
			groupBox21.Size = size;
			this.GroupBox2.TabIndex = 55;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Small Warehouse";
			RadioButton radioButton10 = this.indigo2;
			point = new Point(32, 40);
			radioButton10.Location = point;
			this.indigo2.Name = "indigo2";
			RadioButton radioButton11 = this.indigo2;
			size = new Size(24, 16);
			radioButton11.Size = size;
			this.indigo2.TabIndex=5;
			RadioButton radioButton12 = this.sugar2;
			point = new Point(32, 88);
			radioButton12.Location = point;
			this.sugar2.Name = "sugar2";
			RadioButton radioButton13 = this.sugar2;
			size = new Size(28, 16);
			radioButton13.Size = size;
			this.sugar2.TabIndex=6;
			RadioButton radioButton14 = this.tobacco2;
			point = new Point(32, 184);
			radioButton14.Location = point;
			this.tobacco2.Name = "tobacco2";
			RadioButton radioButton15 = this.tobacco2;
			size = new Size(24, 16);
			radioButton15.Size = size;
			this.tobacco2.TabIndex=7;
			RadioButton radioButton16 = this.corn2;
			point = new Point(32, 136);
			radioButton16.Location = point;
			this.corn2.Name = "corn2";
			RadioButton radioButton17 = this.corn2;
			size = new Size(24, 16);
			radioButton17.Size = size;
			this.corn2.TabIndex=8;
			RadioButton radioButton18 = this.coffee2;
			point = new Point(32, 232);
			radioButton18.Location = point;
			this.coffee2.Name = "coffee2";
			RadioButton radioButton19 = this.coffee2;
			size = new Size(24, 16);
			radioButton19.Size = size;
			this.coffee2.TabIndex=9;
			this.GroupBox3.Controls.Add(this.sugar3);
			this.GroupBox3.Controls.Add(this.tobacco3);
			this.GroupBox3.Controls.Add(this.coffee3);
			this.GroupBox3.Controls.Add(this.corn3);
			this.GroupBox3.Controls.Add(this.indigo3);
			GroupBox groupBox3 = this.GroupBox3;
			point = new Point(248, 24);
			groupBox3.Location = point;
			this.GroupBox3.Name = "GroupBox3";
			GroupBox groupBox31 = this.GroupBox3;
			size = new Size(80, 272);
			groupBox31.Size = size;
			this.GroupBox3.TabIndex = 56;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Large Warehouse";
			RadioButton radioButton20 = this.sugar3;
			point = new Point(32, 88);
			radioButton20.Location = point;
			this.sugar3.Name = "sugar3";
			RadioButton radioButton21 = this.sugar3;
			size = new Size(28, 16);
			radioButton21.Size = size;
			this.sugar3.TabIndex = 11;
			RadioButton radioButton22 = this.tobacco3;
			point = new Point(32, 184);
			radioButton22.Location = point;
			this.tobacco3.Name = "tobacco3";
			RadioButton radioButton23 = this.tobacco3;
			size = new Size(24, 16);
			radioButton23.Size = size;
			this.tobacco3.TabIndex = 12;
			RadioButton radioButton24 = this.coffee3;
			point = new Point(32, 232);
			radioButton24.Location = point;
			this.coffee3.Name = "coffee3";
			RadioButton radioButton25 = this.coffee3;
			size = new Size(24, 16);
			radioButton25.Size = size;
			this.coffee3.TabIndex = 14;
			RadioButton radioButton26 = this.corn3;
			point = new Point(32, 136);
			radioButton26.Location = point;
			this.corn3.Name = "corn3";
			RadioButton radioButton27 = this.corn3;
			size = new Size(24, 16);
			radioButton27.Size = size;
			this.corn3.TabIndex = 13;
			RadioButton radioButton28 = this.indigo3;
			point = new Point(32, 40);
			radioButton28.Location = point;
			this.indigo3.Name = "indigo3";
			RadioButton radioButton29 = this.indigo3;
			size = new Size(24, 16);
			radioButton29.Size = size;
			this.indigo3.TabIndex = 10;
			this.GroupBox4.Controls.Add(this.sugar4);
			this.GroupBox4.Controls.Add(this.tobacco4);
			this.GroupBox4.Controls.Add(this.coffee4);
			this.GroupBox4.Controls.Add(this.corn4);
			this.GroupBox4.Controls.Add(this.indigo4);
			GroupBox groupBox4 = this.GroupBox4;
			point = new Point(328, 24);
			groupBox4.Location = point;
			this.GroupBox4.Name = "GroupBox4";
			GroupBox groupBox41 = this.GroupBox4;
			size = new Size(80, 272);
			groupBox41.Size = size;
			this.GroupBox4.TabIndex = 57;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Large Warehouse";
			RadioButton radioButton30 = this.sugar4;
			point = new Point(32, 88);
			radioButton30.Location = point;
			this.sugar4.Name = "sugar4";
			RadioButton radioButton31 = this.sugar4;
			size = new Size(28, 16);
			radioButton31.Size = size;
			this.sugar4.TabIndex = 11;
			RadioButton radioButton32 = this.tobacco4;
			point = new Point(32, 184);
			radioButton32.Location = point;
			this.tobacco4.Name = "tobacco4";
			RadioButton radioButton33 = this.tobacco4;
			size = new Size(24, 16);
			radioButton33.Size = size;
			this.tobacco4.TabIndex = 12;
			RadioButton radioButton34 = this.coffee4;
			point = new Point(32, 232);
			radioButton34.Location = point;
			this.coffee4.Name = "coffee4";
			RadioButton radioButton35 = this.coffee4;
			size = new Size(24, 16);
			radioButton35.Size = size;
			this.coffee4.TabIndex = 14;
			RadioButton radioButton36 = this.corn4;
			point = new Point(32, 136);
			radioButton36.Location = point;
			this.corn4.Name = "corn4";
			RadioButton radioButton37 = this.corn4;
			size = new Size(24, 16);
			radioButton37.Size = size;
			this.corn4.TabIndex = 13;
			RadioButton radioButton38 = this.indigo4;
			point = new Point(32, 40);
			radioButton38.Location = point;
			this.indigo4.Name = "indigo4";
			RadioButton radioButton39 = this.indigo4;
			size = new Size(24, 16);
			radioButton39.Size = size;
			this.indigo4.TabIndex = 10;
			this.storage_close_button.Enabled=false;
			Button storageCloseButton = this.storage_close_button;
			point = new Point(184, 320);
			storageCloseButton.Location = point;
			this.storage_close_button.Name = "storage_close_button";
			this.storage_close_button.TabIndex = 58;
			this.storage_close_button.Text = "OK";
			this.storage_close_button.Visible = false;
			size = new Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new Size(432, 400);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.storage_close_button);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.coffee_label);
			this.Controls.Add(this.tobacco_label);
			this.Controls.Add(this.corn_label);
			this.Controls.Add(this.sugar_label);
			this.Controls.Add(this.indigo_label);
			this.Controls.Add(this.GroupBox4);
			size = new Size(440, 408);
			this.MaximumSize = size;
			size = new Size(440, 408);
			this.MinimumSize = size;
			this.Name = "Storage1";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "What Goods Will You Store?";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox4.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void storage_close_button_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void sugar1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.sugar1.Checked)
			{
				this.sugar2.Checked = false;
				this.sugar3.Checked = false;
				this.sugar4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void sugar2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.sugar2.Checked)
			{
				this.sugar1.Checked = false;
				this.sugar3.Checked = false;
				this.sugar4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void sugar3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.sugar3.Checked)
			{
				this.sugar1.Checked = false;
				this.sugar2.Checked = false;
				this.sugar4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void sugar4_CheckedChanged(object sender, EventArgs e)
		{
			if (this.sugar4.Checked)
			{
				this.sugar1.Checked = false;
				this.sugar2.Checked = false;
				this.sugar3.Checked = false;
			}
			this.check_for_close_button();
		}

		private void tobacco1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.tobacco1.Checked)
			{
				this.tobacco2.Checked = false;
				this.tobacco3.Checked = false;
				this.tobacco4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void tobacco2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.tobacco2.Checked)
			{
				this.tobacco1.Checked = false;
				this.tobacco3.Checked = false;
				this.tobacco4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void tobacco3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.tobacco3.Checked)
			{
				this.tobacco1.Checked = false;
				this.tobacco2.Checked = false;
				this.tobacco4.Checked = false;
			}
			this.check_for_close_button();
		}

		private void tobacco4_CheckedChanged(object sender, EventArgs e)
		{
			if (this.tobacco4.Checked)
			{
				this.tobacco1.Checked = false;
				this.tobacco2.Checked = false;
				this.tobacco3.Checked = false;
			}
			this.check_for_close_button();
		}
	}
}
