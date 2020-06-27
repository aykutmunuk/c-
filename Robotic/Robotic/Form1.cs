using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Robotic.Data;
using static Robotic.Data.Constants;

namespace Robotic
{
	public partial class frmRobotic : Form
	{
		private AreaEntity areaEntity = null;
		private RobotEntity robotEntity = null;
		public frmRobotic()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cbxDirection.DataSource = Enum.GetValues(typeof(Constants.Directions));
		}

		private void btnArea_Click(object sender, EventArgs e)
		{
            int xSize = int.Parse(txtX.Text);
            int ySize = int.Parse(txtY.Text);

			if (xSize <= 0 || ySize <= 0)
            {
                MessageBox.Show("Alan ölçüleri 0 dan büyük bir değer olmalıdır.");
                return;
            }
			areaEntity = null;
			robotEntity = null;
			areaEntity = AreaEntity.CreateInstance(xSize, ySize);
            areaEntity.DrawArea(this.grpArea);
            
        }

		private void place_click(object sender, EventArgs e)
		{
			if (areaEntity != null)
			{
				areaEntity.DrawArea(this.grpArea);
				RobotEntity.Clear();
				int robotXCoor = int.Parse(txtRobotXCoor.Text);
				int robotYCoor = areaEntity.ySize - int.Parse(txtRobotYCoor.Text);
				if (robotXCoor < 0 || robotYCoor < 0)
				{
					MessageBox.Show("Alan ölçüleri 0 dan büyük bir değer olmalıdır.");
					return;
				}
				else if (robotXCoor > areaEntity.xSize || robotYCoor > areaEntity.ySize)
				{
					MessageBox.Show("Robot koordinatı alan içerisinde olmalıdır.");
					return;
				}
                else
                {
					Directions direction = (Directions)Enum.Parse(typeof(Directions), cbxDirection.SelectedItem.ToString());
					robotEntity = RobotEntity.CreateInstance(robotXCoor, robotYCoor, direction);
				}
			}
            else
            {
				MessageBox.Show("Alanı oluşturun.");
            }
		}
		private void acceptDigit(KeyPressEventArgs e)
        {
			if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
			{
				return;
			}
			e.Handled = true;
		}
		private void txtX_KeyPress(object sender, KeyPressEventArgs e)
		{
			acceptDigit(e);
		}
		private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
			acceptDigit(e);
		}
        private void txtRobotXCoor_KeyPress(object sender, KeyPressEventArgs e)
        {
			acceptDigit(e);
		}
        private void txtRobotYCoor_KeyPress(object sender, KeyPressEventArgs e)
        {
			acceptDigit(e);
		}

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
			
			if (!Enum.IsDefined(typeof(RotationKeys), e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
			if (robotEntity != null)
			{
				areaEntity.DrawArea(this.grpArea);
				if (!String.IsNullOrEmpty(txtRotations.Text))
				{
                    Business.RobotMapping.Run(txtRotations.Text);
					MessageBox.Show("X: " + robotEntity.X + ", Y: " + (areaEntity.ySize - robotEntity.Y) + ", Yön: " + robotEntity.Direction.ToString());

				}
				else
				{
					MessageBox.Show("Robot için yön komutlarını giriniz.");
				}
            }
            else
            {
				MessageBox.Show("Robotun konumu belirleyin.");
			}
        }
    }
}