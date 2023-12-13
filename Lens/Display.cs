	public class Display {
		public static int Width = 320;
		public static int Height = 180;
		public static float Viewport = (float) Width / Height;
		public static float InvertedViewport = (float) Height / Width;
		public const float UiScale = 1.5f;
		public static int UiWidth = (int) (Width * UiScale);
		public static int UiHeight = (int) (Height * UiScale);
	}