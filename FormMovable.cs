// Token: 0x06000001 RID: 1
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000002 RID: 2
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		private void FormMoveable_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				Form1.ReleaseCapture();
				Form1.SendMessage(base.Handle, 161, 2, 0);
			}
		}
