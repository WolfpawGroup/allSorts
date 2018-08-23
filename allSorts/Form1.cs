using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allSorts
{
	public partial class Form1 : Form
	{
		int arrayType = 0;
		int[] intArray = new int[] { 0 };
		int arrayLength = 20;
		int from = 0;
		int to = 0;
		int len = -1;
		item[] lst2;
		int comparisons = 0;
		int arrayAccesses = 0;
		StringFormat sf = new StringFormat() { Alignment = StringAlignment.Center };

		public Form1()
		{
			InitializeComponent();
			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 0;

			DoubleBuffered = true;

			this.SetStyle(
				ControlStyles.AllPaintingInWmPaint |
				ControlStyles.UserPaint |
				ControlStyles.OptimizedDoubleBuffer,
				true);
			

			/*
			typeof(Form).InvokeMember("DoubleBuffered",
			   BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
			   null, this, new object[] { true });
			  */ 
		}

		protected override void OnPaint(PaintEventArgs e) { }

		public void bubbleSort(int[] inp)
		{
			bool run = true;
			int i = 0;
			int tmp = 0;
			myDelegate md = new myDelegate(writeToScreen);
			int end = -1;
			len = inp.Length;

			while (run)
			{
				if (len > i + 1)
				{
					from = inp[i];
					to = inp[i + 1];
					comparisons++;
					if (inp[i] > inp[i + 1])
					{
						arrayAccesses++;
						end = i;
						tmp = inp[i];
						inp[i] = inp[i + 1];
						inp[i + 1] = tmp;

					}

					Thread.Sleep(100);
					this.Invoke(md);
					i++;
					if(arrayType == 1)
					{
						if (i + 1 == len) { len--; }
					}
				}
				else
				{
					if (end == 0)
					{
						run = false; MessageBox.Show("OK");
					}
					else
					{
						end = 0;
					}
					i = 0;
				}
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			arrayAccesses = comparisons = 0;
			Random r0 = new Random();
			List<item> lst = new List<item>();
			
			int min = 0;
			for (int i = 0; i < 20; i++)
			{
				min = new Random(((int)((float)Environment.TickCount / Math.PI) * r0.Next())).Next(min, min + 255);
				lst.Add(new item() { key = i + 1, number = min });
				Thread.Sleep(10);
			}
			lst2 = lst.ToArray();
			shuffle(lst2);
			intArray = lst2.Select(x => x.number).ToArray();

			arrayType = comboBox1.SelectedIndex;

			Thread t = new Thread(
				() => bubbleSort(intArray)
			);
			t.Start();

		}

		public void shuffle(item[] arr)
		{
			Random r0 = new Random();
			int i = arr.Length - 1;
			while (i > 1)
			{
				int r = new Random(((int)((float)Environment.TickCount / Math.PI) * r0.Next())).Next(0, i);
				var v1 = arr[i];
				arr[i] = arr[r];
				arr[r] = v1;
				i--;
			}
		}

		public delegate void myDelegate();
		public void writeToScreen()
		{
			int ii = 0;
			using (Graphics g = CreateGraphics())
			{
				g.Clear(Color.AliceBlue);
				

				Color c = Color.Black;
				foreach (int i in intArray)
				{
					c = Color.Black;

					if (i == from)
					{
						c = Color.Red;
					}
					else if (i == to || ii >= len)
					{
						c = Color.Green;
					}
					item it = lst2.Where(x => x.number == i).ToArray()[0];
					g.DrawString(it.number.ToString(), this.Font, new SolidBrush(c), new Point(30 + (ii * 30), 30), sf);
					g.DrawString(it.key.ToString(), this.Font, new SolidBrush(c), new Point(30 + (ii * 30), 50), sf);

					g.FillRectangle(Brushes.ForestGreen, new Rectangle(new Point(30 + (ii * 30) - 6, 65), new Size(13, it.key * 10)));

					g.DrawString("Array accesses: " +	arrayAccesses,	this.Font, Brushes.Black, new Point(50, 300));
					g.DrawString("Comparisons: " +		comparisons,	this.Font, Brushes.Black, new Point(50, 330));

					g.Flush();

					ii++;
				}
			}
		}

		private void tb_End_ValueChanged(object sender, EventArgs e)
		{
			arrayLength = tb_End.Value;
			label2.Text = arrayLength + "";
		}
	}

	public struct item
	{
		public int key;
		public int number;
	}

	public class myPanel : Panel
	{
		public myPanel()
		{
			DoubleBuffered = true;
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			UpdateStyles();
		}
		
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
				return cp;
			}
		}
		

	}

}
