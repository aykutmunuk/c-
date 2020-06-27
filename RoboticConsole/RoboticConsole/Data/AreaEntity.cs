namespace Robotic.Data
{
	public class AreaEntity
	{
        private static AreaEntity instance = null;
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
        
	}
}
