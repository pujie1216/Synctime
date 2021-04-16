
namespace Synctime
{
    partial class SynctimeForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.syncunitimebt = new System.Windows.Forms.Button();
            this.localtimetlb = new System.Windows.Forms.Label();
            this.localtimeflb = new System.Windows.Forms.Label();
            this.unitimetlb = new System.Windows.Forms.Label();
            this.unitimeflb = new System.Windows.Forms.Label();
            this.localtimebgwk = new System.ComponentModel.BackgroundWorker();
            this.unitimebgwk = new System.ComponentModel.BackgroundWorker();
            this.jdtimetlb = new System.Windows.Forms.Label();
            this.jdtimeflb = new System.Windows.Forms.Label();
            this.syncjdtimebt = new System.Windows.Forms.Button();
            this.jdtimebgwk = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // syncunitimebt
            // 
            this.syncunitimebt.Location = new System.Drawing.Point(12, 64);
            this.syncunitimebt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.syncunitimebt.Name = "syncunitimebt";
            this.syncunitimebt.Size = new System.Drawing.Size(112, 25);
            this.syncunitimebt.TabIndex = 0;
            this.syncunitimebt.Text = "点击同步联通时间";
            this.syncunitimebt.UseVisualStyleBackColor = true;
            this.syncunitimebt.Click += new System.EventHandler(this.Syncunitimebt_Click);
            // 
            // localtimetlb
            // 
            this.localtimetlb.AutoSize = true;
            this.localtimetlb.Location = new System.Drawing.Point(12, 9);
            this.localtimetlb.Name = "localtimetlb";
            this.localtimetlb.Size = new System.Drawing.Size(59, 17);
            this.localtimetlb.TabIndex = 1;
            this.localtimetlb.Text = "本地时间:";
            // 
            // localtimeflb
            // 
            this.localtimeflb.AutoSize = true;
            this.localtimeflb.Location = new System.Drawing.Point(77, 10);
            this.localtimeflb.Name = "localtimeflb";
            this.localtimeflb.Size = new System.Drawing.Size(0, 17);
            this.localtimeflb.TabIndex = 2;
            // 
            // unitimetlb
            // 
            this.unitimetlb.AutoSize = true;
            this.unitimetlb.Location = new System.Drawing.Point(12, 26);
            this.unitimetlb.Name = "unitimetlb";
            this.unitimetlb.Size = new System.Drawing.Size(59, 17);
            this.unitimetlb.TabIndex = 3;
            this.unitimetlb.Text = "联通时间:";
            // 
            // unitimeflb
            // 
            this.unitimeflb.AutoSize = true;
            this.unitimeflb.Location = new System.Drawing.Point(77, 26);
            this.unitimeflb.Name = "unitimeflb";
            this.unitimeflb.Size = new System.Drawing.Size(0, 17);
            this.unitimeflb.TabIndex = 4;
            // 
            // localtimebgwk
            // 
            this.localtimebgwk.WorkerSupportsCancellation = true;
            this.localtimebgwk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Localtimebgwk_DoWork);
            // 
            // unitimebgwk
            // 
            this.unitimebgwk.WorkerSupportsCancellation = true;
            this.unitimebgwk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Unitimebgwk_DoWork);
            // 
            // jdtimetlb
            // 
            this.jdtimetlb.AutoSize = true;
            this.jdtimetlb.Location = new System.Drawing.Point(12, 43);
            this.jdtimetlb.Name = "jdtimetlb";
            this.jdtimetlb.Size = new System.Drawing.Size(59, 17);
            this.jdtimetlb.TabIndex = 5;
            this.jdtimetlb.Text = "京东时间:";
            // 
            // jdtimeflb
            // 
            this.jdtimeflb.AutoSize = true;
            this.jdtimeflb.Location = new System.Drawing.Point(77, 43);
            this.jdtimeflb.Name = "jdtimeflb";
            this.jdtimeflb.Size = new System.Drawing.Size(0, 17);
            this.jdtimeflb.TabIndex = 6;
            // 
            // syncjdtimebt
            // 
            this.syncjdtimebt.Location = new System.Drawing.Point(130, 64);
            this.syncjdtimebt.Name = "syncjdtimebt";
            this.syncjdtimebt.Size = new System.Drawing.Size(112, 25);
            this.syncjdtimebt.TabIndex = 7;
            this.syncjdtimebt.Text = "点击同步京东时间";
            this.syncjdtimebt.UseVisualStyleBackColor = true;
            this.syncjdtimebt.Click += new System.EventHandler(this.Syncjdtimebt_Click);
            // 
            // jdtimebgwk
            // 
            this.jdtimebgwk.WorkerSupportsCancellation = true;
            this.jdtimebgwk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.JDtimebgwk_DoWork);
            // 
            // SynctimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 99);
            this.Controls.Add(this.syncjdtimebt);
            this.Controls.Add(this.jdtimeflb);
            this.Controls.Add(this.jdtimetlb);
            this.Controls.Add(this.unitimeflb);
            this.Controls.Add(this.unitimetlb);
            this.Controls.Add(this.localtimeflb);
            this.Controls.Add(this.localtimetlb);
            this.Controls.Add(this.syncunitimebt);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SynctimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "同步时间";
            this.Load += new System.EventHandler(this.SynctimeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button syncunitimebt;
        private System.Windows.Forms.Label localtimetlb;
        private System.Windows.Forms.Label localtimeflb;
        private System.Windows.Forms.Label unitimetlb;
        private System.Windows.Forms.Label unitimeflb;
        private System.ComponentModel.BackgroundWorker localtimebgwk;
        private System.ComponentModel.BackgroundWorker unitimebgwk;
        private System.Windows.Forms.Label jdtimetlb;
        private System.Windows.Forms.Label jdtimeflb;
        private System.Windows.Forms.Button syncjdtimebt;
        private System.ComponentModel.BackgroundWorker jdtimebgwk;
    }
}

