using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimizationNumber1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private List<Lines> OriginalLines = new List<Lines>();
        private List<Point> OriginalPoint = new List<Point>();
        private void BRefresh_Click(object sender, EventArgs e)
        {
            Lines cl;Point ls;
            for (int i = 0; i < gvTable.Rows.Count; i++)
            {
                int k = 0;
                for (int j = 0; j < ddFinish.Items.Count - 1; j++)
                {
                    if (ddFinish.Items[j] == gvTable.Rows[i].Cells[0].Value)
                    {
                        k = 1;
                        break;
                    }
                }
                if (k == 0)
                {
                    ddFinish.Items.Add(gvTable.Rows[i].Cells[0].Value.ToString());
                }
                int k1 = 1;
                for (int j = 0; j < ddStart.Items.Count - 1; j++)
                {
                    if (ddStart.Items[j] == gvTable.Rows[i].Cells[0].Value)
                    {
                        k1 = 1;
                        break;
                    }
                }
                if (k1 == 0)
                {
                    ddStart.Items.Add(gvTable.Rows[i].Cells[0].Value.ToString());
                }
                cl = new Lines();
                cl.Name = i + 1;
                cl.NameOut = Convert.ToInt32(gvTable.Rows[i].Cells[0].Value);
                cl.Time = Convert.ToInt32(gvTable.Rows[i].Cells[1].Value);
                cl.NameIn = Convert.ToInt32(gvTable.Rows[i].Cells[2].Value);
                OriginalLines.Add(cl);
                
                
            }
            List<int> no = new List<int> { };
            List<int> ni = new List<int> { };
            List<int> namePoint = new List<int> { };
            for (int i=0;i<OriginalLines.Count;i++)
            {
                if(!no.Contains(OriginalLines[i].NameOut))
                {
                    no.Add(OriginalLines[i].NameOut);
                }
                if(!ni.Contains(OriginalLines[i].NameIn))
                {
                    ni.Add(OriginalLines[i].NameIn);
                }

            }
            namePoint = ni;
            for(int i =0;i<no.Count;i++)
            {
                if(!namePoint.Contains(no[i]))
                {
                    namePoint.Add(no[i]);
                }
            }
            Point op;
            for(int i=0;i<namePoint.Count;i++)
            {
                op = new Point();
                op.Name = namePoint[i];
                op.Min = 0;
                OriginalPoint.Add(op);
            }
            StartSolv();
            for(int i=0;i<OriginalPoint.Count;i++)
            {
                radGridView1.Rows.AddNew();
                radGridView1.Rows[i].Cells[0].Value = OriginalPoint[i].Name;
                radGridView1.Rows[i].Cells[1].Value = OriginalPoint[i].Max;
            }
        }

        private void DdStart_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            for (int i = 0; i < gvTable.Rows.Count; i++)
            {
                if(OriginalLines[i].NameOut== Convert.ToInt32(gvTable.Rows[i].Cells[0].Value))
                {
                    OriginalLines[i].IsStart = true;
                }
            }
        }

        private void DdFinish_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            for (int i = 0; i < gvTable.Rows.Count; i++)
            {
                if (OriginalLines[i].NameIn == Convert.ToInt32(gvTable.Rows[i].Cells[2].Value))
                {
                    OriginalLines[i].IsFinish = true;
                }
            }
        }
        private void StartSolv()
        {
            int n = 0;
            while(n<=1000)
            {
                int k = 0;
                for(int i=0;i< OriginalLines.Count;i++)
                {
                    for(int j=0;j<OriginalPoint.Count;j++)
                    {
                        if(OriginalLines[i].NameIn==OriginalPoint[j].Name)
                        {
                            for(int p=0;p<OriginalPoint.Count;p++)
                            {
                                if(OriginalLines[i].NameOut == OriginalPoint[p].Name)
                                {
                                    if(OriginalLines[i].Time+ OriginalPoint[p].Min> OriginalPoint[j].Min)
                                    {
                                        OriginalPoint[j].Min = OriginalLines[i].Time + OriginalPoint[p].Min;
                                        k = 1;
                                    }
                                }
                            }
                        }
                    }
                }
                if(k==0)
                {
                    break;
                }
            }
            int max = OriginalPoint[0].Min;
            for(int v=0;v<OriginalPoint.Count;v++)
            {
                if(OriginalPoint[v].Min>max)
                {
                    max = OriginalPoint[v].Min;
                }
            }
            for (int v = 0; v < OriginalPoint.Count; v++)
            {
                OriginalPoint[v].Max = max;
            }
            n = 0;
            while (n <= 1000)
            {
                int k = 0;
                for (int i = 0; i < OriginalLines.Count; i++)
                {
                    for (int j = 0; j < OriginalPoint.Count; j++)
                    {
                        if (OriginalLines[i].NameOut == OriginalPoint[j].Name)
                        {
                            for (int p = 0; p < OriginalPoint.Count; p++)
                            {
                                if (OriginalLines[i].NameIn == OriginalPoint[p].Name)
                                {
                                    if (OriginalPoint[p].Max-OriginalLines[i].Time < OriginalPoint[j].Max)
                                    {
                                        OriginalPoint[j].Max = OriginalPoint[p].Max - OriginalLines[i].Time;
                                        k = 1;
                                    }
                                }
                            }
                        }
                    }
                }
                if (k == 0)
                {
                    break;
                }
            }
        }

        private void GvTable_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TableInput(0,1,2,2);
            TableInput(1, 1, 1, 3);
            TableInput(2, 1, 11, 4);
            TableInput(3, 2, 9, 5);
            TableInput(4, 2, 15, 6);
            TableInput(5, 6, 2, 5);
            TableInput(6, 5, 10, 9);
            TableInput(7, 3, 5, 6);
            TableInput(8, 3, 3, 9);
            TableInput(9, 4, 2, 7);
            TableInput(10, 7, 1, 8);
            TableInput(11, 4, 5, 8);
            TableInput(12, 8, 10, 9);
            
        }
        private void TableInput(int i,int p1,int p2,int p3)
        {
            gvTable.Rows.AddNew();
            gvTable.Rows[i].Cells[0].Value = p1;
            gvTable.Rows[i].Cells[1].Value = p2;
            gvTable.Rows[i].Cells[2].Value = p3;
        }
    }
}
