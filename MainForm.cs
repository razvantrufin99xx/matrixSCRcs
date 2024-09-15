/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/15/2024
 * Time: 2:07 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace drawLinesFallDown
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Graphics g;
		public Font f;
		public Brush b = new SolidBrush(Color.Lime);
		public Pen p = new Pen(Color.Black);
		public Pen pf = new Pen(Color.FromArgb(200,50,50,50));
		private Random r = new Random();
		private Random rr = new Random();
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		public bool drawALineOfCharsFallingDown()
		{
			
			string xs = "";
			
					
					
			int k =  r.Next(1,80);
			 
			    int ky = rr.Next(1,40)-k/2;
			  
			 
			    int i = 0;
				for(i = k; i < k+10 ;i++)
				{
				     
					 int ks = rr.Next(1,127);
					 xs = ((char)ks).ToString();
						 Text = k.ToString() + " , " + ky.ToString() + " , " + ks.ToString();
						 g.DrawString(xs,f,b,k*20,(ky*20)+(i*10));
						g.DrawLine(pf,0,k*20,1920,k*20);
						g.DrawLine(pf,k*20,0,k*20,1080);
						//g.DrawLine(p,0,ky,1920,ky);
						//g.DrawLine(p,ky,0,ky,1080);
						//g.DrawLine(p,0,ks,1920,ks);
						//g.DrawLine(p,ks,0,ks,1080);
						Thread.Sleep(1);
				}
				return false;
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			drawALineOfCharsFallingDown();
		}
		void MainFormShown(object sender, EventArgs e)
		{
			g = panel1.CreateGraphics();
			f = this.Font;
		}
		
		
	}
}
