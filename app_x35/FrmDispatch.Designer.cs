
using System.Drawing;
using System.Windows.Forms;

namespace Cps_x35
{
    partial class FrmDispatch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            listView1 = new WinFormsLibrary.PrintableListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            ListViewContextMenuStrip = new ContextMenuStrip(components);
            toolStripMenuItem31 = new ToolStripMenuItem();
            panel6 = new Panel();
            expListView = new ListView();
            btnCsv = new Button();
            btnPrint = new Button();
            splitter1 = new Splitter();
            panel3 = new Panel();
            treeView1 = new TreeView();
            panel4 = new Panel();
            infoLabel = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            contextMenuStrip2 = new ContextMenuStrip(components);
            abandonedToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem2 = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem3 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ListViewContextMenuStrip.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(379, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "数据处理中心";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(splitter1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 410);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(listView1);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(227, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(573, 410);
            panel5.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            listView1.ContextMenuStrip = ListViewContextMenuStrip;
            listView1.Dock = DockStyle.Fill;
            listView1.FitToPage = false;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(573, 321);
            listView1.TabIndex = 1;
            listView1.Title = "";
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "辆序";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "总重";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "净重";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "车型";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "车号";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "载重";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "自重";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "盈亏";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "煤种";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "到站";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "日期";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "时间";
            // 
            // ListViewContextMenuStrip
            // 
            ListViewContextMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem31 });
            ListViewContextMenuStrip.Name = "ListViewContextMenuStrip";
            ListViewContextMenuStrip.Size = new Size(227, 26);
            // 
            // toolStripMenuItem31
            // 
            toolStripMenuItem31.Name = "toolStripMenuItem31";
            toolStripMenuItem31.Size = new Size(226, 22);
            toolStripMenuItem31.Text = "Remove vehicle from consist";
            toolStripMenuItem31.Click += removeVehicle_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(expListView);
            panel6.Controls.Add(btnCsv);
            panel6.Controls.Add(btnPrint);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 321);
            panel6.Name = "panel6";
            panel6.Size = new Size(573, 89);
            panel6.TabIndex = 0;
            // 
            // expListView
            // 
            expListView.Location = new Point(16, 11);
            expListView.Name = "expListView";
            expListView.Size = new Size(182, 37);
            expListView.TabIndex = 2;
            expListView.UseCompatibleStateImageBehavior = false;
            expListView.View = View.Details;
            expListView.Visible = false;
            // 
            // btnCsv
            // 
            btnCsv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCsv.Location = new Point(477, 25);
            btnCsv.Name = "btnCsv";
            btnCsv.Size = new Size(75, 23);
            btnCsv.TabIndex = 1;
            btnCsv.Text = "数据上报";
            btnCsv.UseVisualStyleBackColor = true;
            btnCsv.Click += btnCsv_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.Location = new Point(381, 25);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "数据打印";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(224, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 410);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(treeView1);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 410);
            panel3.TabIndex = 0;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(224, 227);
            treeView1.TabIndex = 1;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            treeView1.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(infoLabel);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 227);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 183);
            panel4.TabIndex = 0;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(13, 17);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(31, 15);
            infoLabel.TabIndex = 0;
            infoLabel.Text = "Info:";
            // 
            // statusStrip1
            // 
            statusStrip1.GripStyle = ToolStripGripStyle.Visible;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            statusStrip1.Location = new Point(0, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 24);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel1.BorderSides = ToolStripStatusLabelBorderSides.Right;
            toolStripStatusLabel1.BorderStyle = Border3DStyle.Etched;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(224, 19);
            toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Right;
            toolStripStatusLabel2.BorderStyle = Border3DStyle.Etched;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(4, 19);
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(0, 19);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { abandonedToolStripMenuItem, toolStripSeparator1, toolStripMenuItem2 });
            contextMenuStrip2.Name = "contextMenuStrip1";
            contextMenuStrip2.Size = new Size(137, 54);
            // 
            // abandonedToolStripMenuItem
            // 
            abandonedToolStripMenuItem.Name = "abandonedToolStripMenuItem";
            abandonedToolStripMenuItem.Size = new Size(136, 22);
            abandonedToolStripMenuItem.Text = "废弃";
            abandonedToolStripMenuItem.Click += abandonedToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(133, 6);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(136, 22);
            toolStripMenuItem2.Text = "添加新编组";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            contextMenuStrip1.Name = "contextMenuStrip2";
            contextMenuStrip1.Size = new Size(123, 26);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(122, 22);
            toolStripMenuItem3.Text = "更改到站";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // FrmDispatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmDispatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Shown += FrmDispatch_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ListViewContextMenuStrip.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCsv;
        private WinFormsLibrary.PrintableListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abandonedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ContextMenuStrip ListViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem31;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ListView expListView;
    }
}

