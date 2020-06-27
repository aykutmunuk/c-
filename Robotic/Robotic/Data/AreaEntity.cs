using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Robotic.Data
{
	public class AreaEntity
	{
        private static AreaEntity instance = null;
        public Button[][] buttons { get; set; }
        public int xSize { get; set; }
        public int ySize { get; set; }
        public static AreaEntity CreateInstance(int xSize, int ySize)
        {
            if (instance == null)
            {
                instance = new AreaEntity(xSize, ySize);
            }
            return instance;
        }
        public static AreaEntity getInstance()
        {
            return instance;
        }
        private AreaEntity(int xSize, int ySize)
		{
			this.xSize = xSize;
			this.ySize = ySize;
		}
        public void DrawArea(GroupBox grpArea)
        {
            grpArea.Controls.Clear();
            buttons = new Button[xSize+1][];
            int distance = 15;
            int yOffset = 5;
            int xOffset = 5;
            int buttonSize = 30;
            for (int yCoor = 0; yCoor <= ySize; yCoor++)
            {
                yOffset = distance + buttonSize * yCoor;
                xOffset = 5;
                for (int xCoor = 0; xCoor <= xSize; xCoor++)
                {
                    if (buttons[xCoor] == null)
                    {
                        buttons[xCoor] = new Button[ySize+1];
                    }
                    xOffset = distance + buttonSize * xCoor;
                    var button = new Button();
                    button.Size = new Size(buttonSize, buttonSize);
                    button.Location = new Point(xOffset, yOffset);
                    button.Name = "btnArea_" + xCoor + "," + yCoor;
                    button.Text = "";
                    buttons[xCoor][yCoor] = button;
                    grpArea.Controls.Add(button);
                }
            }
            grpArea.Size = new Size(xOffset + buttonSize + distance, yOffset + buttonSize + distance);
        }

	}
}
